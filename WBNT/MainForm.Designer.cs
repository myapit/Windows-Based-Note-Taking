/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 13/11/2019
 * Time: 11:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WBNT
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuBar;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem subMenuFileConfigDB;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel statusDB;
		private System.Windows.Forms.ToolStripMenuItem subMenuFileOpenNote;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripStatusLabel statusTimeDate;
		private System.Windows.Forms.ToolStripStatusLabel space;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuBar = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.subMenuFileOpenNote = new System.Windows.Forms.ToolStripMenuItem();
			this.subMenuFileConfigDB = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.statusDB = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusTimeDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.space = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuBar.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuBar
			// 
			this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuBar.Location = new System.Drawing.Point(0, 0);
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new System.Drawing.Size(830, 24);
			this.menuBar.TabIndex = 0;
			this.menuBar.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.subMenuFileOpenNote,
			this.subMenuFileConfigDB,
			this.toolStripSeparator2,
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// subMenuFileOpenNote
			// 
			this.subMenuFileOpenNote.Name = "subMenuFileOpenNote";
			this.subMenuFileOpenNote.Size = new System.Drawing.Size(161, 22);
			this.subMenuFileOpenNote.Text = "Open &Note";
			// 
			// subMenuFileConfigDB
			// 
			this.subMenuFileConfigDB.Image = ((System.Drawing.Image)(resources.GetObject("subMenuFileConfigDB.Image")));
			this.subMenuFileConfigDB.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.subMenuFileConfigDB.Name = "subMenuFileConfigDB";
			this.subMenuFileConfigDB.Size = new System.Drawing.Size(161, 22);
			this.subMenuFileConfigDB.Text = "Config &Database";
			this.subMenuFileConfigDB.Click += new System.EventHandler(this.SubMenuFileConfigDBClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.contentsToolStripMenuItem,
			this.toolStripSeparator5,
			this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.contentsToolStripMenuItem.Text = "&Contents";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.space,
			this.statusDB,
			this.statusTimeDate});
			this.statusBar.Location = new System.Drawing.Point(0, 300);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(830, 24);
			this.statusBar.TabIndex = 2;
			this.statusBar.Text = "statusStrip1";
			// 
			// statusDB
			// 
			this.statusDB.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.statusDB.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.statusDB.Name = "statusDB";
			this.statusDB.Size = new System.Drawing.Size(74, 19);
			this.statusDB.Text = "statusBarDB";
			// 
			// statusTimeDate
			// 
			this.statusTimeDate.Name = "statusTimeDate";
			this.statusTimeDate.Size = new System.Drawing.Size(31, 19);
			this.statusTimeDate.Text = "time";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// space
			// 
			this.space.Name = "space";
			this.space.Size = new System.Drawing.Size(679, 19);
			this.space.Spring = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 324);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.menuBar);
			this.Icon = global::WBNT.ResourceAssets.Narrator;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuBar;
			this.Name = "MainForm";
			this.Text = "Windows Based Note Taking";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuBar.ResumeLayout(false);
			this.menuBar.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
