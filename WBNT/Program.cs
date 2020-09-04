/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 13/11/2019
 * Time: 11:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Threading; // to use mutex

namespace WBNT
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		/// 
		
		static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");

		[STAThread]
		private static void Main(string[] args)
		{
				
			if(mutex.WaitOne(TimeSpan.Zero, true)) 
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				//Application.Run(new MainForm()); // temporary disabled splash and mdiform
				Application.Run(new frmNotes());
				mutex.ReleaseMutex();
	        } else {
				MessageBox.Show("only one instance at a time");
	        }
			
		}
		
	}
}
