/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-5-7
 * Time: 18:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MyEmail
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmMainForm : Form
	{
		public frmMainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void 账户ToolStripMenuItemClick(object sender, EventArgs e)
		{
			string Current;
            Current = Directory.GetCurrentDirectory();//获取当前根目录

            iniFile ini=new iniFile(Current+"/config.ini");
            ArrayList list=ini.ReadSections();
            if(list.Count==0)
            {
            	frmAccount firstAccount=new frmAccount();
            	firstAccount.firstAccount="yes";
            	firstAccount.Show();
            }
            else
            {
            	frmAccount firstAccount=new frmAccount();
            	firstAccount.firstAccount="no";
            	firstAccount.Show();
            }
//            string stemp=ini.ReadValue("Account","AccountName");


//            if(string.IsNullOrEmpty(stemp))
//            {
//            	frmAccount firstAccount=new frmAccount();
//            	firstAccount.firstAccount="yes";
//            	firstAccount.Show();
////			addAccount.panel1.Visible=false;
//			
////            	frmAccount firstAccount=new frmAccount();
////            	firstAccount.Show();
////            	firstAccount.
////            		firstAccount.paa
////            					addAccount.Show();
////			addAccount.panel1.Visible=false;
////			addAccount.label6.Visible=true;
////			addAccount.txtAccountName.Visible=true;
//            }
//            else
//            {
//            	frmAccount firstAccount=new frmAccount();
////            	firstAccount.firstAccount="yes";
//            	firstAccount.Show();
//            }
            
		}
//		public void ReadAccount()
//		{
//			lbAccount.Refresh();
//			string Current;
//            Current = Directory.GetCurrentDirectory();//获取当前根目录
//            // 写入ini
//            iniFile ini=new iniFile(Current+"/config.ini");
//            txtAccountName.Text=ini.ReadValue("Account","AccountName");
//            txtPOP3.Text=ini.ReadValue("Account","POP3");
//            txtSMTP.Text=ini.ReadValue("Account","SMTP");
//            txtUsername.Text=ini.ReadValue("Account","username");
//            txtPassword.Text=ini.ReadValue("Account","password");
//            txtPort.Text=ini.ReadValue("Account","port");
//			lbAccount.Items.Add(txtAccountName.Text);
//					
//		}
	}
}
