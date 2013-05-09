/*
 * Created by SharpDevelop.
 * User: 123
 * Date: 2013/5/9
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyEmail
{
	partial class MailReceiver
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
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.PopServer = new System.Windows.Forms.TextBox();
			this.Username = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Message = new System.Windows.Forms.RichTextBox();
			this.BackupChBox = new System.Windows.Forms.CheckBox();
			this.Status = new System.Windows.Forms.ListBox();
			this.Connect = new System.Windows.Forms.Button();
			this.Disconnect = new System.Windows.Forms.Button();
			this.MailNum = new System.Windows.Forms.TextBox();
			this.Retrieve = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "POP3服务器：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "用户名：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(11, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "密码：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PopServer
			// 
			this.PopServer.Location = new System.Drawing.Point(117, 12);
			this.PopServer.Name = "PopServer";
			this.PopServer.Size = new System.Drawing.Size(163, 21);
			this.PopServer.TabIndex = 0;
			// 
			// Username
			// 
			this.Username.Location = new System.Drawing.Point(117, 40);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(163, 21);
			this.Username.TabIndex = 1;
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(117, 68);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(163, 21);
			this.Password.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "信息：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 258);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "邮件编号";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(-4, 281);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "状态：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Message
			// 
			this.Message.Location = new System.Drawing.Point(12, 150);
			this.Message.Name = "Message";
			this.Message.Size = new System.Drawing.Size(366, 96);
			this.Message.TabIndex = 2;
			this.Message.Text = "";
			// 
			// BackupChBox
			// 
			this.BackupChBox.Location = new System.Drawing.Point(129, 256);
			this.BackupChBox.Name = "BackupChBox";
			this.BackupChBox.Size = new System.Drawing.Size(164, 24);
			this.BackupChBox.TabIndex = 3;
			this.BackupChBox.Text = "在邮件服务器上保留备份";
			this.BackupChBox.UseVisualStyleBackColor = true;
			// 
			// Status
			// 
			this.Status.FormattingEnabled = true;
			this.Status.ItemHeight = 12;
			this.Status.Location = new System.Drawing.Point(12, 307);
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(366, 64);
			this.Status.TabIndex = 4;
			// 
			// Connect
			// 
			this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Connect.Location = new System.Drawing.Point(303, 28);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(75, 23);
			this.Connect.TabIndex = 3;
			this.Connect.Text = "连接";
			this.Connect.UseVisualStyleBackColor = true;
			this.Connect.Click += new System.EventHandler(this.ConnectClick);
			// 
			// Disconnect
			// 
			this.Disconnect.Enabled = false;
			this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Disconnect.Location = new System.Drawing.Point(303, 66);
			this.Disconnect.Name = "Disconnect";
			this.Disconnect.Size = new System.Drawing.Size(75, 23);
			this.Disconnect.TabIndex = 4;
			this.Disconnect.Text = "断开连接";
			this.Disconnect.UseVisualStyleBackColor = true;
			this.Disconnect.Click += new System.EventHandler(this.DisconnectClick);
			// 
			// MailNum
			// 
			this.MailNum.Location = new System.Drawing.Point(73, 260);
			this.MailNum.Name = "MailNum";
			this.MailNum.Size = new System.Drawing.Size(38, 21);
			this.MailNum.TabIndex = 6;
			// 
			// Retrieve
			// 
			this.Retrieve.Enabled = false;
			this.Retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Retrieve.Location = new System.Drawing.Point(299, 258);
			this.Retrieve.Name = "Retrieve";
			this.Retrieve.Size = new System.Drawing.Size(75, 23);
			this.Retrieve.TabIndex = 5;
			this.Retrieve.Text = "收取邮件";
			this.Retrieve.UseVisualStyleBackColor = true;
			this.Retrieve.Click += new System.EventHandler(this.RetrieveClick);
			// 
			// MailReceiver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 379);
			this.Controls.Add(this.MailNum);
			this.Controls.Add(this.Retrieve);
			this.Controls.Add(this.Disconnect);
			this.Controls.Add(this.Connect);
			this.Controls.Add(this.Status);
			this.Controls.Add(this.BackupChBox);
			this.Controls.Add(this.Message);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.PopServer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Name = "MailReceiver";
			this.Text = "MailReceiver";
			this.Load += new System.EventHandler(this.MailReceiverLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Retrieve;
		private System.Windows.Forms.TextBox MailNum;
		private System.Windows.Forms.Button Disconnect;
		private System.Windows.Forms.Button Connect;
		private System.Windows.Forms.ListBox Status;
		private System.Windows.Forms.CheckBox BackupChBox;
		private System.Windows.Forms.RichTextBox Message;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.TextBox Username;
		private System.Windows.Forms.TextBox PopServer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
