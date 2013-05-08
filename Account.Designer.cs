/*
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbAccount = new System.Windows.Forms.ListBox();
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.btnDelAccount = new System.Windows.Forms.Button();
			this.gbAccount = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pnlAccount.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbAccount.SuspendLayout();
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
			// lbAccount
			// 
			this.lbAccount.FormattingEnabled = true;
			this.lbAccount.ItemHeight = 12;
			this.lbAccount.Location = new System.Drawing.Point(3, 5);
			this.lbAccount.Name = "lbAccount";
			this.lbAccount.Size = new System.Drawing.Size(128, 256);
			this.lbAccount.TabIndex = 0;
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.Location = new System.Drawing.Point(3, 267);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(47, 23);
			this.btnAddAccount.TabIndex = 1;
			this.btnAddAccount.Text = "增加";
			this.btnAddAccount.UseVisualStyleBackColor = true;
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
			// gbAccount
			// 
			this.gbAccount.Controls.Add(this.label5);
			this.gbAccount.Controls.Add(this.label4);
			this.gbAccount.Controls.Add(this.label3);
			this.gbAccount.Controls.Add(this.label2);
			this.gbAccount.Controls.Add(this.label1);
			this.gbAccount.Location = new System.Drawing.Point(3, 5);
			this.gbAccount.Name = "gbAccount";
			this.gbAccount.Size = new System.Drawing.Size(379, 256);
			this.gbAccount.TabIndex = 0;
			this.gbAccount.TabStop = false;
			this.gbAccount.Text = "账户信息";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "POP3服务器";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "SMTP服务器";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "用户名";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "密码";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "端口";
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
			this.panel1.ResumeLayout(false);
			this.gbAccount.ResumeLayout(false);
			this.ResumeLayout(false);
		}
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
