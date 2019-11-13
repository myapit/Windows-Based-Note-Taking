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

namespace WBNT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	 //[STAThread]
	public partial class MainForm : Form
	{
		 
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
		}
		
		public void startSplash()
		{
			Application.Run(new frmLogo());
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Activate();
		}
	}
}
