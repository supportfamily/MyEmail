﻿/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-5-7
 * Time: 18:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyEmail
{
	partial class frmAccount
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
			this.pnlAccount = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gbAccount = new System.Windows.Forms.GroupBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtSMTP = new System.Windows.Forms.TextBox();
			this.txtPOP3 = new System.Windows.Forms.TextBox();
			this.txtAccountName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDelAccount = new System.Windows.Forms.Button();
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.lbAccount = new System.Windows.Forms.ListBox();
			this.pnlAccount.SuspendLayout();
			this.panel2.SuspendLayout();
			this.gbAccount.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlAccount
			// 
			this.pnlAccount.Controls.Add(this.panel2);
			this.pnlAccount.Controls.Add(this.panel1);
			this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAccount.Location = new System.Drawing.Point(0, 0);
			this.pnlAccount.Name = "pnlAccount";
			this.pnlAccount.Size = new System.Drawing.Size(522, 315);
			this.pnlAccount.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.gbAccount);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(137, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(385, 315);
			this.panel2.TabIndex = 1;
			// 
			// gbAccount
			// 
			this.gbAccount.Controls.Add(this.txtPort);
			this.gbAccount.Controls.Add(this.txtPassword);
			this.gbAccount.Controls.Add(this.txtUsername);
			this.gbAccount.Controls.Add(this.txtSMTP);
			this.gbAccount.Controls.Add(this.txtPOP3);
			this.gbAccount.Controls.Add(this.txtAccountName);
			this.gbAccount.Controls.Add(this.label5);
			this.gbAccount.Controls.Add(this.label4);
			this.gbAccount.Controls.Add(this.label3);
			this.gbAccount.Controls.Add(this.label2);
			this.gbAccount.Controls.Add(this.label6);
			this.gbAccount.Controls.Add(this.label1);
			this.gbAccount.Location = new System.Drawing.Point(3, 5);
			this.gbAccount.Name = "gbAccount";
			this.gbAccount.Size = new System.Drawing.Size(379, 256);
			this.gbAccount.TabIndex = 0;
			this.gbAccount.TabStop = false;
			this.gbAccount.Text = "账户信息";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(101, 164);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(225, 21);
			this.txtPort.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(101, 134);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(225, 21);
			this.txtPassword.TabIndex = 1;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(101, 104);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(225, 21);
			this.txtUsername.TabIndex = 1;
			// 
			// txtSMTP
			// 
			this.txtSMTP.Location = new System.Drawing.Point(101, 74);
			this.txtSMTP.Name = "txtSMTP";
			this.txtSMTP.Size = new System.Drawing.Size(225, 21);
			this.txtSMTP.TabIndex = 1;
			// 
			// txtPOP3
			// 
			this.txtPOP3.Location = new System.Drawing.Point(101, 44);
			this.txtPOP3.Name = "txtPOP3";
			this.txtPOP3.Size = new System.Drawing.Size(225, 21);
			this.txtPOP3.TabIndex = 1;
			// 
			// txtAccountName
			// 
			this.txtAccountName.Location = new System.Drawing.Point(101, 17);
			this.txtAccountName.Name = "txtAccountName";
			this.txtAccountName.Size = new System.Drawing.Size(225, 21);
			this.txtAccountName.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "端口";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "密码";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "用户名";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "SMTP服务器";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 17);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "账户名称";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "POP3服务器";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDelAccount);
			this.panel1.Controls.Add(this.btnAddAccount);
			this.panel1.Controls.Add(this.lbAccount);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(137, 315);
			this.panel1.TabIndex = 0;
			// 
			// btnDelAccount
			// 
			this.btnDelAccount.Location = new System.Drawing.Point(56, 267);
			this.btnDelAccount.Name = "btnDelAccount";
			this.btnDelAccount.Size = new System.Drawing.Size(47, 23);
			this.btnDelAccount.TabIndex = 1;
			this.btnDelAccount.Text = "删除";
			this.btnDelAccount.UseVisualStyleBackColor = true;
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.Location = new System.Drawing.Point(3, 267);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(47, 23);
			this.btnAddAccount.TabIndex = 1;
			this.btnAddAccount.Text = "增加";
			this.btnAddAccount.UseVisualStyleBackColor = true;
			this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccountClick);
			// 
			// lbAccount
			// 
			this.lbAccount.FormattingEnabled = true;
			this.lbAccount.ItemHeight = 12;
			this.lbAccount.Location = new System.Drawing.Point(3, 5);
			this.lbAccount.Name = "lbAccount";
			this.lbAccount.Size = new System.Drawing.Size(128, 256);
			this.lbAccount.TabIndex = 0;
			// 
			// frmAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 315);
			this.Controls.Add(this.pnlAccount);
			this.Name = "frmAccount";
			this.Text = "账户";
			this.Load += new System.EventHandler(this.FrmAccountLoad);
			this.pnlAccount.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.gbAccount.ResumeLayout(false);
			this.gbAccount.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtPOP3;
		private System.Windows.Forms.TextBox txtSMTP;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtAccountName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbAccount;
		private System.Windows.Forms.Button btnDelAccount;
		private System.Windows.Forms.Button btnAddAccount;
		private System.Windows.Forms.ListBox lbAccount;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnlAccount;
	}
}
