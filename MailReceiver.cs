/*
 * Created by SharpDevelop.
 * User: 123
 * Date: 2013/5/9
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace MyEmail
{
	/// <summary>
	/// Description of MailReceiver.
	/// </summary>
	public partial class MailReceiver : Form
	{
		public MailReceiver()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public TcpClient Server;
		public NetworkStream NetStrm;
		public StreamReader RdStrm;
		public string Data;
		public byte[] szData;
		public string CRLF="\r\n";
		
	
		
		void ConnectClick(object sender, EventArgs e)
		{

			Cursor cr=Cursor.Current;
			Cursor.Current=Cursors.WaitCursor;
			Server=new TcpClient(PopServer.Text,110);
			Status.Items.Clear();
			try
			{
				NetStrm=Server.GetStream();
				RdStrm=new StreamReader(Server.GetStream());
				Status.Items.Add(RdStrm.ReadLine());
				
				Data="USER"+Username.Text+CRLF;
				szData=System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
				NetStrm.Write(szData,0,szData.Length);
				Status.Items.Add(RdStrm.ReadLine());
				Data="PASS"+Password.Text+CRLF;
				szData=System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
				NetStrm.Write(szData,0,szData.Length);
				Status.Items.Add(RdStrm.ReadLine());
				
				//??????STAT??,???????????:???????
				Data="STAT"+CRLF;
				szData=System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
				NetStrm.Write(szData,0,szData.Length);
				Status.Items.Add(RdStrm.ReadLine());
				
				//???????
				Connect.Enabled=false;
				Disconnect.Enabled=true;
				Retrieve.Enabled=true;
				
				//??????????
				Cursor.Current=cr;
				
			}
			catch(InvalidOperationException err)
			{
				Status.Items.Add("Error:"+err.ToString());
			}
		}
		
		void DisconnectClick(object sender, EventArgs e)
		{
			  //?????????
             Cursor cr = Cursor.Current;
             Cursor.Current = Cursors.WaitCursor;

             //??????QUIT???????POP3??????
             Data = "QUIT"+CRLF;                            
             szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
             NetStrm.Write(szData,0,szData.Length);
             Status.Items.Add(RdStrm.ReadLine());

             //????
             NetStrm.Close();
             RdStrm.Close();

             //???????
             Connect.Enabled = true;
             Disconnect.Enabled = false;
             Retrieve.Enabled = false;

             //??????????
             Cursor.Current = cr;

		}
		
		void RetrieveClick(object sender, EventArgs e)
		{
			 //?????????
             Cursor cr = Cursor.Current;
             Cursor.Current = Cursors.WaitCursor;  
             string szTemp;                                     
             Message.Clear();

             try
             {
                    //????????????????
                    Data = "RETR "+ MailNum.Text+CRLF;                          
                    szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                    NetStrm.Write(szData,0,szData.Length);
                    szTemp = RdStrm.ReadLine();

                    if(szTemp[0]!='-') 
                    {
                           //?????????,??????:????
                           while(szTemp!=".")
                           {
                                  Message.Text += szTemp;
                                  szTemp = RdStrm.ReadLine();
                           }

                           //?BackupChBox???,??????,????????????
                           if(BackupChBox.Checked == false)
                           {
                                  Data = "DELE" + MailNum.Text + CRLF;
                                  szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                                  NetStrm.Write(szData,0,szData.Length);
                                  Status.Items.Add(RdStrm.ReadLine());
                           }
                    }
                    else
                    {
                           Status.Items.Add(szTemp);
                    }
                                         
                    //??????????
                    Cursor.Current = cr;
             }

             catch(InvalidOperationException err)
             {
                    Status.Items.Add("Error: "+err.ToString());
             }   
		}
		
		void MailReceiverLoad(object sender, EventArgs e)
		{
			PopServer.Text="pop.163.com";
			Username.Text="supportfamily";
			Password.Text="16319880101";
		}
	}
}
