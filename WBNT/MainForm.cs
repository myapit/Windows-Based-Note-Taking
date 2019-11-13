/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 13/11/2019
 * Time: 11:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;

namespace WBNT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	 //[STAThread]
	public partial class MainForm : Form
	{
		/************************************ BEGIN *********************/
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			Thread t = new Thread(startSplash); //new ThreadStart(startSplash));
			//t.SetApartmentState(ApartmentState.STA);
			t.IsBackground = true;
			t.Start();
			Thread.Sleep(2000);   
			InitializeComponent();
			t.Abort();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			Database DB =  new Database();
			if (DB.dbExist == true) {
				statusDB.Text = "DB loaded";
			} else {
				statusDB.Text = "DB NOT loaded";
			}
		}
		
		public void startSplash()
		{
			Application.Run(new frmLogo());
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Activate();
		}
		
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if( MessageBox.Show("Are you sure to close this application ?", "Close",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
		
		
		void SubMenuFileConfigDBClick(object sender, EventArgs e)
		{
			bool isOpenForm = false;
			
			foreach( Form f in Application.OpenForms)
			{
				if (f.Name == "frmDBConfig") 
				{
					isOpenForm = true;
					f.BringToFront();
					break;
				}
			}
			
			if (isOpenForm == false)
			{
				Form frm1 = new frmDBConfig();
				frm1.MdiParent = this;
				frm1.Show();
			}
		}
		
		
		void Timer1Tick(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			String currentTime = dt.Day.ToString() + "/" + dt.Month.ToString() + "/" + dt.Year.ToString() + "  " +  dt.ToLongTimeString();
			statusTimeDate.Text = currentTime.ToString();
		}
		
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		/************************** END ****************************/	
	}
}
