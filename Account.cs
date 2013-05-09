/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-5-7
 * Time: 18:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace MyEmail
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class frmAccount : Form
	{
		public frmAccount()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		public void LoadIniFile()
		{
			string Current;
            Current = Directory.GetCurrentDirectory();//获取当前根目录

            // 写入ini
            iniFile ini=new iniFile(Current+"/config.ini");
            ini.WriteValue("Setting","key1","hello word!");
            ini.WriteValue("Setting","key2","hello ini!");
            ini.WriteValue("SettingImg", "Path", "IMG.Path");
            // 读取ini
            string stemp = ini.ReadValue("Setting","key2");
            lbAccount.Items.Add(stemp);



		}
		
		void FrmAccountLoad(object sender, EventArgs e)
		{
//			LoadIniFile();
			ReadAccount();
		}
		public void ReadAccount()
		{
			lbAccount.Refresh();
			string Current;
            Current = Directory.GetCurrentDirectory();//获取当前根目录
            // 写入ini
            iniFile ini=new iniFile(Current+"/config.ini");
            txtAccountName.Text=ini.ReadValue("Account","AccountName");
            txtPOP3.Text=ini.ReadValue("Account","POP3");
            txtSMTP.Text=ini.ReadValue("Account","SMTP");
            txtUsername.Text=ini.ReadValue("Account","username");
            txtPassword.Text=ini.ReadValue("Account","password");
            txtPort.Text=ini.ReadValue("Account","port");
			lbAccount.Items.Add(txtAccountName.Text);
					
		}
		public void WriteAccount()
		{
			//Account.ini :
			//AccountName;
			//POP3
			//SMTP
			//username
			//password
			//port
			string Current;
            Current = Directory.GetCurrentDirectory();//获取当前根目录
            // 写入ini
            iniFile ini=new iniFile(Current+"/config.ini");
            ini.WriteValue("Account","AccountName",txtAccountName.Text.Trim());
            ini.WriteValue("Account","POP3",txtPOP3.Text.Trim());
            ini.WriteValue("Account","SMTP",txtSMTP.Text.Trim());
            ini.WriteValue("Account","username",txtUsername.Text.Trim());
            ini.WriteValue("Account","password",txtPassword.Text.Trim());
            ini.WriteValue("Account","port",txtPort.Text.Trim());
		}
		
		void BtnAddAccountClick(object sender, EventArgs e)
		{
			WriteAccount();
			Form addAccount=new frmAccount();
//			addAccount
		}
	}
}
