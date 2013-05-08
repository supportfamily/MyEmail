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
			this.lvAccount = new System.Windows.Forms.ListView();
			this.pnlAccount.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlAccount
			// 
			this.pnlAccount.Controls.Add(this.lvAccount);
			this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAccount.Location = new System.Drawing.Point(0, 0);
			this.pnlAccount.Name = "pnlAccount";
			this.pnlAccount.Size = new System.Drawing.Size(522, 315);
			this.pnlAccount.TabIndex = 0;
			// 
			// lvAccount
			// 
			this.lvAccount.Location = new System.Drawing.Point(12, 24);
			this.lvAccount.Name = "lvAccount";
			this.lvAccount.Size = new System.Drawing.Size(121, 232);
			this.lvAccount.TabIndex = 0;
			this.lvAccount.UseCompatibleStateImageBehavior = false;
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
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListView lvAccount;
		private System.Windows.Forms.Panel pnlAccount;
	}
}
