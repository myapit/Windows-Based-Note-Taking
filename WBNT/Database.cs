/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 13/11/2019
 * Time: 2:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

namespace WBNT
{
	/// <summary>
	/// Description of Database.
	/// </summary>
	public class Database
	{
/************************************ BEGIN *********************/		
		public SQLiteConnection sqlCon;
		public SQLiteCommand sqlCmd;
		public SQLiteDataAdapter sqlDA;
		public bool dbExist = false;
		
		private const string DBname = "dbNotes.db3";
			
		public Database()
		{
			
			// First cheking if DB exist or not, if not create one
			if (createDatabase()==1)
			{
				dbExist = true;
			} else {
				dbExist = true;
			}
		}
		
		public void openConnection()
		{
			sqlCon = new SQLiteConnection("Data Source=" + DBname + ";Version=3;New=False;Compress=True");
			sqlCon.Open();
		}
		
		public void closeConnection()
		{
			sqlCon.Close();
		}
		
		private int createDatabase()
		{
			if (File.Exists(DBname) == false )
			{
				SQLiteConnection.CreateFile(DBname);
				SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + DBname + ";Version=3;");
				m_dbConnection.Open();
				
				string sql = "CREATE TABLE notes (id integer primary key autoincrement,title text default 'MyNote', note text not null)";
				SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				sql = "INSERT INTO notes(title,note) VALUES ('Initializing','This is init notes generated for first time use.')";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				m_dbConnection.Close(); 
				return 1;
			} else {
				return 0;
			}
		}
/************************** END ****************************/		
	} //END CLASS
} //END NAMESPACE
