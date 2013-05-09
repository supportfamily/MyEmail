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
using System.Collections;

//TODO:新增加账号后，frmAccount窗体需刷新


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
		public string isFirstAccount="no";
		public string firstAccount
		{
			get
			{
				return isFirstAccount;
			}
			set
			{
				if(isFirstAccount!=value)
				{
//					this.label6.Visible=true;
//					this.txtAccountName.Visible=true;
					this.panel1.Visible=false;
//					this.btnOK.Visible=true;
//					this.btnCancel.Visible=true;
					this.AcceptButton=btnOK;
					this.CancelButton=btnCancel;	
					this.gbAccount.Controls.Remove(label6);
				}
				else
				{				
					//删除账户名称及其文本框控件
					this.gbAccount.Controls.Remove(label6);
					this.gbAccount.Controls.Remove(txtAccountName);
//					btnOK.Text="确定修改";
					
					//改变控件位置
					foreach(Control c in this.gbAccount.Controls)
					{
						c.Location=new Point(c.Location.X, c.Location.Y-30);
					}					
				}
			}			
		}

		public void LoadIniFile()
		{
			string Current;
            Current = Directory.GetCurrentDirectory();//获取当前根目录
            // 写入ini
            iniFile ini=new iniFile(Current+"/config.ini");
//            ini.WriteValue("Setting","key1","hello word!");
//            ini.WriteValue("Setting","key2","hello ini!");
//            ini.WriteValue("SettingImg", "Path", "IMG.Path");
            // 读取ini
//            string stemp = ini.ReadValue("Setting","key2");
//                  lbAccount.Items.Add(stemp);
            ArrayList list=ini.ReadSections();
            foreach(object o in list)
            {
            	lbAccount.Items.Add(o.ToString());
            }
            if(lbAccount.Items.Count!=0)
            {
            	lbAccount.SelectedIndex=0;
            }  
		}
		
		void FrmAccountLoad(object sender, EventArgs e)
		{
			LoadIniFile();
//			ReadAccount();
		}
		public void ReadAccount()
		{
			lbAccount.Refresh();
			string Current;
            Current = Directory.GetCurrentDirectory();//获取当前根目录
            string AccountName=lbAccount.SelectedItem.ToString();
            iniFile ini=new iniFile(Current+"/config.ini");
            txtAccountName.Text=ini.ReadValue(AccountName,"AccountName");
            txtPOP3.Text=ini.ReadValue(AccountName,"POP3");
            txtSMTP.Text=ini.ReadValue(AccountName,"SMTP");
            txtUsername.Text=ini.ReadValue(AccountName,"username");
            txtPassword.Text=ini.ReadValue(AccountName,"password");
            txtPort.Text=ini.ReadValue(AccountName,"port");					
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

            string AccountName=txtAccountName.Text.Trim();
            if(!string.IsNullOrEmpty(AccountName))
            {
            	string Current;
	            Current = Directory.GetCurrentDirectory();//获取当前根目录
	            // 写入ini
	            iniFile ini=new iniFile(Current+"/config.ini");
	            ini.WriteValue(AccountName,"AccountName",AccountName);
	            ini.WriteValue(AccountName,"POP3",txtPOP3.Text.Trim());
	            ini.WriteValue(AccountName,"SMTP",txtSMTP.Text.Trim());
	            ini.WriteValue(AccountName,"username",txtUsername.Text.Trim());
	            ini.WriteValue(AccountName,"password",txtPassword.Text.Trim());
	            ini.WriteValue(AccountName,"port",txtPort.Text.Trim());
            }
		}
		
		void BtnAddAccountClick(object sender, EventArgs e)
		{
//			WriteAccount();
//			frmAccount addAccount=new frmAccount();
//			addAccount.Show();
//			addAccount.panel1.Visible=false;
//			addAccount.label6.Visible=true;
//			addAccount.txtAccountName.Visible=true;
			frmAccount firstAccount=new frmAccount();
            firstAccount.firstAccount="yes";
            firstAccount.Show();
			
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnOKClick(object sender, EventArgs e)
		{
			WriteAccount();
			this.Close();
		}
		
		void LbAccountSelectedIndexChanged(object sender, EventArgs e)
		{
			ReadAccount();
		}
	}
}
