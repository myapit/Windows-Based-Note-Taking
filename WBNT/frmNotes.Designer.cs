/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 13/11/2019
 * Time: 12:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WBNT
{
	partial class frmNotes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvNotes;
		private System.Windows.Forms.DataGridViewTextBoxColumn num;
		private System.Windows.Forms.DataGridViewTextBoxColumn title;
		private System.Windows.Forms.DataGridViewTextBoxColumn note;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvNotes = new System.Windows.Forms.DataGridView();
			this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvNotes
			// 
			this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.num,
			this.title,
			this.note,
			this.id});
			this.dgvNotes.Location = new System.Drawing.Point(370, 65);
			this.dgvNotes.Name = "dgvNotes";
			this.dgvNotes.RowHeadersVisible = false;
			this.dgvNotes.Size = new System.Drawing.Size(439, 261);
			this.dgvNotes.TabIndex = 0;
			this.dgvNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNotesCellDoubleClick);
			// 
			// num
			// 
			this.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.num.HeaderText = "#";
			this.num.Name = "num";
			this.num.ReadOnly = true;
			this.num.Width = 50;
			// 
			// title
			// 
			this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.title.HeaderText = "Title";
			this.title.Name = "title";
			this.title.ReadOnly = true;
			// 
			// note
			// 
			this.note.HeaderText = "Note";
			this.note.Name = "note";
			this.note.ReadOnly = true;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitle.Location = new System.Drawing.Point(12, 65);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(336, 22);
			this.txtTitle.TabIndex = 1;
			// 
			// txtNote
			// 
			this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNote.Location = new System.Drawing.Point(12, 116);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(336, 156);
			this.txtNote.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Title :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Note :";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnSave.Location = new System.Drawing.Point(13, 286);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 40);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(132, 286);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 40);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.Violet;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(245, 286);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(100, 40);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
			this.btnSearch.Location = new System.Drawing.Point(720, 26);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(88, 31);
			this.btnSearch.TabIndex = 7;
			this.btnSearch.Text = "S&earch";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(370, 32);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(317, 22);
			this.txtSearch.TabIndex = 6;
			// 
			// frmNotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(918, 383);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.dgvNotes);
			this.Name = "frmNotes";
			this.Text = "My Note";
			this.Load += new System.EventHandler(this.FrmNotesLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
