﻿/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 13/11/2019
 * Time: 12:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;  
using System.Data.SQLite;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace WBNT
{
	/// <summary>
	/// Description of frmNotes.
	/// </summary>
	public partial class frmNotes : Form
	{
		private Database DB;
		private string IDnote;
		private int totalRecord = 0;
		
		public frmNotes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			//Thread t = new Thread(startSplash); //new ThreadStart(startSplash));
			//t.SetApartmentState(ApartmentState.STA);
			//t.IsBackground = true;
			//t.Start();
			//Thread.Sleep(2000);   
			InitializeComponent();
			//t.Abort();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			dgvNotes.AllowUserToAddRows = false;
		}
		
		public void startSplash()
		{
			Application.Run(new frmLogo());
		}
		
		void FrmNotesLoad(object sender, EventArgs e)
		{
			resetForm();
			loadDataGridView();
			this.Activate();
		}
		
		void BtnResetClick(object sender, EventArgs e)
		{
			resetForm();
		}
		
		void DgvNotesCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			IDnote = dgvNotes.CurrentRow.Cells[3].Value.ToString();
			txtTitle.Text = dgvNotes.CurrentRow.Cells[1].Value.ToString();
			txtNote.Text = dgvNotes.CurrentRow.Cells[2].Value.ToString();
			btnSave.Text = "&Update";
			btnDelete.Enabled = true;
		}
		
		void BtnSearchClick(object sender, EventArgs e)
		{
			searchText();
		}
		
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			DialogResult confirm = MessageBox.Show("Are you sure to permanently DELETE this note.","Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if ( confirm == DialogResult.Yes)
			{
				SQLiteCommand insertSQL = new SQLiteCommand("DELETE FROM notes WHERE id=$id", DB.sqlCon);
				//insertSQL.Parameters.Add("$id", System.Data.DbType.String).Value = IDPerson;
				insertSQL.Parameters.AddWithValue("$id",IDnote.ToString());
				insertSQL.ExecuteNonQuery();
				resetForm();
				loadDataGridView();	
			}
		}
		
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			saveNote();
		}

		void BtnRefreshClick(object sender, EventArgs e)
		{
			loadDataGridView();
		}
		
		void TxtNoteKeyDown(object sender, KeyEventArgs e)
		{
			 if(e.KeyCode==Keys.Enter)
			 {
			 	//saveNote();
			 }
		
		}
		

		void TxtSearchKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			 {
				searchText();
			 }
		}
		
		
		/************** Private Function ************/
		
		private void searchText()
		{
			if (txtSearch.Text.Trim() != "") {
				loadDataGridView(txtSearch.Text.Trim());
				Debug.WriteLine(txtSearch.Text.Trim());
			} else {
				MessageBox.Show("Please enter text to search.","Search",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txtSearch.Focus();
			}
		}
		
		private void loadDataGridView(string searchSQL="")
		{
			int countRow = 1;
			string sqlQuery = "";
			DB =  new Database();
			DB.openConnection();			
			
			dgvNotes.Rows.Clear();
			dgvNotes.Refresh();
			
			if (searchSQL.Trim() == "")
				sqlQuery = "SELECT * FROM notes ORDER BY id ASC";
			else
				sqlQuery = "SELECT * FROM notes WHERE title LIKE '%" + searchSQL + "%' OR note LIKE '%" + searchSQL + "%' ORDER BY id ASC";
			
			Debug.WriteLine(sqlQuery);
			
			SQLiteCommand cmdSQL = new SQLiteCommand(sqlQuery, DB.sqlCon);
			
			using( SQLiteDataReader readData =  cmdSQL.ExecuteReader())
			{
				while (readData.Read())
				{
					dgvNotes.Rows.Add(
						new object[] {
							countRow++,  // using column index
							readData.GetValue(readData.GetOrdinal("title")), // using column name
							readData.GetValue(readData.GetOrdinal("note")), // using column name
						    readData.GetValue(0), 
						}
					);
				}
				
			} //End Using
			totalRecord = countRow;
			statusBar1.Text = "Total Records : " + (totalRecord-1);
		} //end load grid view
		
		private void resetForm()
		{
			txtTitle.Text = "";
			txtNote.Text = "";
			btnDelete.Enabled = false;
			btnSave.Text = "&Save";
			txtTitle.Select();
			txtTitle.Focus();
		}
		
		private void saveNote()
		{
			if (btnSave.Text == "&Save")
			{
				SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO notes (title, note) VALUES ($title, $note)", DB.sqlCon);
				insertSQL.Parameters.Add("$title", System.Data.DbType.String).Value = txtTitle.Text.Trim();
				insertSQL.Parameters.Add("$note", System.Data.DbType.String).Value =txtNote.Text.Trim();
	
			    try {
			        insertSQL.ExecuteNonQuery();
			    }
			    catch (Exception ex) {
			        throw new Exception(ex.Message);
			    }
				
			    resetForm();
			    loadDataGridView();
			}
			
			if (btnSave.Text == "&Update")
			{
				SQLiteCommand insertSQL = new SQLiteCommand("UPDATE notes Set title=$title, note=$note WHERE id=$id", DB.sqlCon);
				insertSQL.Parameters.Add("$title", System.Data.DbType.String).Value = txtTitle.Text.Trim();
				insertSQL.Parameters.Add("$note", System.Data.DbType.String).Value =txtNote.Text.Trim();
				insertSQL.Parameters.Add("$id", System.Data.DbType.String).Value = IDnote;
				insertSQL.ExecuteNonQuery();
				resetForm();
				loadDataGridView();
			}
		}
		void DgvNotesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvNotes.Rows[e.RowIndex].Selected = true;
		}
		
		
		/**************** END ************/
	}
}
