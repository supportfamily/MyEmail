﻿/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-5-7
 * Time: 18:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Xml;
using System.Collections;

namespace MyEmail
{
	/// <summary>
	/// Description of iniFile.
	/// </summary>
	public class iniFile:Files
	{
		  // 声明INI文件的写操作函数 WritePrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
 		public extern static int GetPrivateProfileSectionNamesA(byte[] buffer, int iLen, string fileName);
 

        private string sPath = null;
        public iniFile(string path)
        {
            this.sPath = path;
        }
        public void WriteValue(string section, string key, string value)
        {
            // section=配置节，key=键名，value=键值，path=路径
            WritePrivateProfileString(section, key, value, sPath);
        }
        public string ReadValue(string section, string key)
        {
            // 每次从ini中读取多少字节
            System.Text.StringBuilder temp = new System.Text.StringBuilder(255);
            // section=配置节，key=键名，temp=上面，path=路径
            GetPrivateProfileString(section, key, "", temp, 255, sPath);
            return temp.ToString();

        }

		/// 返回该配置文件中所有Section名称的集合
		 public ArrayList ReadSections() {
		     byte[] buffer = new byte[65535];
		     int rel = GetPrivateProfileSectionNamesA(buffer, buffer.GetUpperBound(0), sPath);
		     int iCnt,
		     iPos;
		     ArrayList arrayList = new ArrayList();
		     string tmp;
		     if (rel > 0) {
		         iCnt = 0;
		         iPos = 0;
		         for (iCnt = 0; iCnt < rel; iCnt++) {
		             if (buffer[iCnt] == 0x00) {
		                 tmp = System.Text.ASCIIEncoding.Default.GetString(buffer, iPos, iCnt - iPos).Trim();
		                 iPos = iCnt + 1;
		                 if (tmp != "") arrayList.Add(tmp);
		             }
		         }
		     }
		     
		     return arrayList;
		 }
		
//		string path="";
//
//		string path=System.Environment.CurrentDirectory+"\Account\account.ini";
		
		public iniFile()
		{
			
		}
//		public override void writeFile()
//		{
//		
//		}
//		public override void readFile()
//		{
//			
//		}
	}
}
