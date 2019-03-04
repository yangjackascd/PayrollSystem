/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/2/7
 * Time: 9:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WebCam_Capture;
using System.IO;
using System.ComponentModel;


namespace the_slide_shop_payroll
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	public partial class MainForm : Form
	{
		
		
		ServerConfig cf = new ServerConfig();
		
		int keypressID=99;
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e){			
			timerToday.Start();
			this.KeyPreview = true;
			this.KeyDown += new KeyEventHandler(keyPress);
			lab_showLoginLogout.Text = "Please enter your ID";
			
		}
		
		void pbWebCamLoad(object sender, EventArgs e){
		
		}
		
		void tb_inputEmployerIDCheck(object sender, EventArgs e){
			
			if (System.Text.RegularExpressions.Regex.IsMatch(tb_inputEmployerID.Text, "  ^ [0-9]"))
            {
                tb_inputEmployerID.Text = "";
            }

		}
        //number only
        
        private void tb_inputEmployerIDCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //timer
        public void timerTick(object sender, EventArgs e){
//		 	lab_todayDateTime.Text = "Date: " + DateTime.Now.AddHours(24).ToString();
		 	DateTime dt =DateTime.Now.AddHours(24);
		 	this.lab_todayDateTime.Text =  "Date: " +dt.ToString();
		 	
		 }
		void Bt_loginClick(object sender, EventArgs e)
		{
			string employerName;
			string loginWord;
			if(CheckInputIDEmpty().Equals(false)){
			int employerID = int.Parse(tb_inputEmployerID.Text);
			if(cf.sqlCheckID(employerID)){
				employerName = cf.sqlGetName(employerID);
			 	loginWord = "Thank you "+employerName+" !";
			 	lab_showLoginLogout.Text = loginWord;
			}else{
			
			loginWord = "Please Enter Correct ID Number";

			lab_showLoginLogout.Text = loginWord;
			}
			lab_showLoginLogout.Refresh();
			tb_inputEmployerID.Clear();
			}
			
		}
		void Bt_logoutClick(object sender, EventArgs e)
		{
			string logoutWord;
			string employerName;
			if(CheckInputIDEmpty().Equals(false)){
			int employerID = int.Parse(tb_inputEmployerID.Text);
			if(cf.sqlCheckID(employerID)){
				employerName = cf.sqlGetName(employerID);
			 	logoutWord = "Good Bye "+employerName+" !";
			 	lab_showLoginLogout.Text = logoutWord;
			}else{
			
			logoutWord = "Please Enter Correct ID Number";

			lab_showLoginLogout.Text = logoutWord;
			}
			
			lab_showLoginLogout.Refresh();
			tb_inputEmployerID.Clear();
			}
		}
	
		
		
		public bool CheckInputIDEmpty(){
			if(string.IsNullOrWhiteSpace(tb_inputEmployerID.Text)){
				lab_showLoginLogout.Text = "Please enter your Staff ID";
				return true;
			}
			else
				return false;
			
		}
		
		public void keyPress(object sender, KeyEventArgs e){
			switch(e.KeyCode){
				case Keys.F1:
					lab_arrowLogin.Text="→";

					tb_inputEmployerID.Select();
					lab_arrowLogout.Text="";
					keypressID = 0;
					break;
				case Keys.F2:
					lab_arrowLogout.Text="→";

					tb_inputEmployerID.Select();
					lab_arrowLogin.Text="";
					keypressID = 1;
					break;
			}
			if(e.KeyCode==Keys.Enter){
				if(keypressID.Equals(0)){
					bt_login.PerformClick();
				}
				if(keypressID.Equals(1)){
					bt_logout.PerformClick();
				}
			}

		}
	
//		void Pb_webCamClick(object sender, EventArgs e)
//		{
//			
//			
//		}
	}
}
