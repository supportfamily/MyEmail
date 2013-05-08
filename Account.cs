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
            ini.Writue("Setting","key1","hello word!");
            ini.Writue("Setting","key2","hello ini!");
            ini.Writue("SettingImg", "Path", "IMG.Path");
            // 读取ini
            string stemp = ini.ReadValue("Setting","key2");
            lbAccount.Items.Add(stemp);



		}
		
		void FrmAccountLoad(object sender, EventArgs e)
		{
			LoadIniFile();
		}
	}
}
