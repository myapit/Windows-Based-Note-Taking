/*
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

namespace WBNT
{
	/// <summary>
	/// Description of frmLogo.
	/// </summary>
	public partial class frmLogo : Form
	{
		public frmLogo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
string title = @"
			
				██╗    ██╗    ██████╗     ███╗   ██╗    ████████╗
				██║    ██║    ██╔══██╗    ████╗  ██║    ╚══██╔══╝
				██║ █╗ ██║    ██████╔╝    ██╔██╗ ██║       ██║   
				██║███╗██║    ██╔══██╗    ██║╚██╗██║       ██║   
				╚███╔███╔╝    ██████╔╝    ██║ ╚████║       ██║   
				 ╚══╝╚══╝     ╚═════╝     ╚═╝  ╚═══╝       ╚═╝   
                                                 
";
			txtLoad.Text = title;
			//label1.Text = title;

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmLogoLoad(object sender, EventArgs e)
		{
			string teks = "My Note\n Version: 0.1\nAuthor: Myapit\n URL: myapit.github.io";
			txtLoad.Text = teks;
		}
	}
}
