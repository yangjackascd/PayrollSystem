/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/2/10
 * Time: 0:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace the_slide_shop_payroll
{
	/// <summary>
	/// Description of ServerConfig.
	
	/// </summary>
	public class ServerConfig
	{
		string server = "192.168.50.184";
			string port = "3306";
			string userid="jackascd";
			string password= "1";
			string database = "PayRollSystem";
			string connectionString;
			
			MySqlConnection cnn =  null;
			
		public ServerConfig()
		{
			
		
		}
		public void sqlConnection(){			
			connectionString = "server="+server+";user="+userid+";database="+database+";port="+port+";password="+password+";"; 
			
			try{
				 cnn = new MySqlConnection(connectionString);
				cnn.Open();
				MessageBox.Show("connection open");
				cnn.Close();
			}
			
			catch(Exception ex){
				MessageBox.Show("Cant open connection!!!!!!!!!"+ex);
			}
		}
		
//		public void sqlReader(){
//			connectionString = "server="+server+";user="+userid+";database="+database+";port="+port+";password="+password+";";
//			string mySelectQuery = "SELECT * FROM tabStaffInfo";	
//			string ID = string.Empty;
//			string fname = string.Empty;
//			string lname = string.Empty;
////				MySqlDataReader myReader;
//				
////				myReader = sccommand.ExecuteReader();			
//			try{
//				cnn = new MySqlConnection(connectionString);
//				
//				MySqlCommand myCommand  = new MySqlCommand(mySelectQuery ,cnn);
//				MySqlDataAdapter adapter = new MySqlDataAdapter();
//				cnn.Open();
//				MySqlDataReader myReader = myCommand.ExecuteReader();
//				
//				
//				while(myReader.Read()){
//					ID=myReader.GetString(0);
//					fname=myReader.GetString(1);
//					lname=myReader.GetString(2);
////					Console.WriteLine(temp1);
//					System.Diagnostics.Debug.WriteLine(ID);
//					System.Diagnostics.Debug.WriteLine(fname);
//					System.Diagnostics.Debug.WriteLine(lname);
//				}
//			}
//			finally{
//				
//				cnn.Close();
//			}
//		}
			public bool sqlCheckID(int ID){
			
			connectionString = "server="+server+";user="+userid+";database="+database+";port="+port+";password="+password+";";
			string mySelectQuery = "SELECT * FROM tabStaffInfo";	
			string staffID = string.Empty;
		
			try{
				cnn = new MySqlConnection(connectionString);
				
				MySqlCommand myCommand  = new MySqlCommand(mySelectQuery ,cnn);
				MySqlDataAdapter adapter = new MySqlDataAdapter();
				cnn.Open();
				MySqlDataReader myReader = myCommand.ExecuteReader();
				
				
				while(myReader.Read()){
					staffID=myReader.GetString(0);
					if(ID.ToString()==staffID){
						System.Diagnostics.Debug.WriteLine(staffID);
						return true;
					}
					
				}
				
			}
			finally{
				
				cnn.Close();
			}
			return false;
		}
		public String sqlGetName(int ID){
			
			connectionString = "server="+server+";user="+userid+";database="+database+";port="+port+";password="+password+";";
			string mySelectQuery = "SELECT * FROM tabStaffInfo";	
			string staffName = string.Empty;
			string staffID = string.Empty;
			try{
				cnn = new MySqlConnection(connectionString);
				
				MySqlCommand myCommand  = new MySqlCommand(mySelectQuery ,cnn);
				MySqlDataAdapter adapter = new MySqlDataAdapter();
				cnn.Open();
				MySqlDataReader myReader = myCommand.ExecuteReader();
				 
				
				while(myReader.Read()){
					staffID=myReader.GetString(0);
					if(ID.ToString()==staffID){
						staffName=myReader.GetString(1);	
						System.Diagnostics.Debug.WriteLine(staffName);						
					}
					
				}
				
			}
			finally{
				
				cnn.Close();
			}
			return staffName;
		}
	}
}
