/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/2/7
 * Time: 9:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace the_slide_shop_payroll
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
		//任务失败，因为未找到“AxImp.exe”，或未安装正确的 Microsoft Windows SDK。任务正在注册表项 HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SDKs\Windows\v8.0A\WinSDK-NetFx40Tools-x86 的 InstallationFolder 值中所指定位置下的“bin”子目录中查找“AxImp.exe”。通过执行下列操作之一可以解决此问题:  1) 安装 Microsoft Windows SDK。2) 安装 Visual Studio 2010。3) 手动向正确的位置设置上面的注册表项。4) 将正确的位置传入任务的“ToolPath”参数中。 (MSB3091)
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.bt_login = new System.Windows.Forms.Button();
			this.tb_inputEmployerID = new System.Windows.Forms.TextBox();
			this.bt_logout = new System.Windows.Forms.Button();
			this.lab_showLoginLogout = new System.Windows.Forms.Label();
			this.lab_todayDateTime = new System.Windows.Forms.Label();
			this.timerToday = new System.Windows.Forms.Timer(this.components);
			this.lab_arrowLogin = new System.Windows.Forms.Label();
			this.lab_arrowLogout = new System.Windows.Forms.Label();
			this.pb_webCam = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pb_webCam)).BeginInit();
			this.SuspendLayout();
			// 
			// bt_login
			// 
			this.bt_login.AccessibleName = "";
			this.bt_login.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_login.Location = new System.Drawing.Point(905, 139);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(232, 72);
			this.bt_login.TabIndex = 0;
			this.bt_login.Text = "Login";
			this.bt_login.UseVisualStyleBackColor = true;
			this.bt_login.Click += new System.EventHandler(this.Bt_loginClick);
			// 
			// tb_inputEmployerID
			// 
			this.tb_inputEmployerID.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_inputEmployerID.Location = new System.Drawing.Point(158, 464);
			this.tb_inputEmployerID.Name = "tb_inputEmployerID";
			this.tb_inputEmployerID.Size = new System.Drawing.Size(177, 63);
			this.tb_inputEmployerID.TabIndex = 1;
			this.tb_inputEmployerID.TextChanged += new System.EventHandler(this.tb_inputEmployerIDCheck);
			this.tb_inputEmployerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_inputEmployerIDCheck);
			// 
			// bt_logout
			// 
			this.bt_logout.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_logout.Location = new System.Drawing.Point(905, 267);
			this.bt_logout.Name = "bt_logout";
			this.bt_logout.Size = new System.Drawing.Size(232, 66);
			this.bt_logout.TabIndex = 2;
			this.bt_logout.Text = "Logout";
			this.bt_logout.UseVisualStyleBackColor = true;
			this.bt_logout.Click += new System.EventHandler(this.Bt_logoutClick);
			// 
			// lab_showLoginLogout
			// 
			this.lab_showLoginLogout.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_showLoginLogout.Location = new System.Drawing.Point(358, 487);
			this.lab_showLoginLogout.Name = "lab_showLoginLogout";
			this.lab_showLoginLogout.Size = new System.Drawing.Size(308, 35);
			this.lab_showLoginLogout.TabIndex = 3;
			this.lab_showLoginLogout.Text = "stage";
			// 
			// lab_todayDateTime
			// 
			this.lab_todayDateTime.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_todayDateTime.Location = new System.Drawing.Point(905, 46);
			this.lab_todayDateTime.Name = "lab_todayDateTime";
			this.lab_todayDateTime.Size = new System.Drawing.Size(268, 35);
			this.lab_todayDateTime.TabIndex = 5;
			this.lab_todayDateTime.Text = "time";
			// 
			// timerToday
			// 
			this.timerToday.Tick += new System.EventHandler(this.timerTick);
			// 
			// lab_arrowLogin
			// 
			this.lab_arrowLogin.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_arrowLogin.Location = new System.Drawing.Point(799, 139);
			this.lab_arrowLogin.Name = "lab_arrowLogin";
			this.lab_arrowLogin.Size = new System.Drawing.Size(107, 72);
			this.lab_arrowLogin.TabIndex = 6;
			// 
			// lab_arrowLogout
			// 
			this.lab_arrowLogout.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_arrowLogout.Location = new System.Drawing.Point(799, 267);
			this.lab_arrowLogout.Name = "lab_arrowLogout";
			this.lab_arrowLogout.Size = new System.Drawing.Size(107, 66);
			this.lab_arrowLogout.TabIndex = 7;
			// 
			// pb_webCam
			// 
			this.pb_webCam.Location = new System.Drawing.Point(111, 74);
			this.pb_webCam.Name = "pb_webCam";
			this.pb_webCam.Size = new System.Drawing.Size(565, 294);
			this.pb_webCam.TabIndex = 8;
			this.pb_webCam.TabStop = false;
			
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1262, 711);
			this.Controls.Add(this.pb_webCam);
			this.Controls.Add(this.lab_arrowLogout);
			this.Controls.Add(this.lab_arrowLogin);
			this.Controls.Add(this.lab_todayDateTime);
			this.Controls.Add(this.lab_showLoginLogout);
			this.Controls.Add(this.bt_logout);
			this.Controls.Add(this.tb_inputEmployerID);
			this.Controls.Add(this.bt_login);
			this.Name = "MainForm";
			this.Text = "the slide shop payroll";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pb_webCam)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pb_webCam;
		private System.Windows.Forms.Label lab_arrowLogout;
		private System.Windows.Forms.Label lab_arrowLogin;
		private System.Windows.Forms.Timer timerToday;
		private System.Windows.Forms.Label lab_todayDateTime;
		private System.Windows.Forms.Button bt_login;
		private System.Windows.Forms.Label lab_showLoginLogout;
		private System.Windows.Forms.Button bt_logout;
		private System.Windows.Forms.TextBox tb_inputEmployerID;
	}
}
