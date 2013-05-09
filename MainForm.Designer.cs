/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-5-7
 * Time: 18:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyEmail
{
	partial class frmMainForm
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
			this.components = new System.ComponentModel.Container();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.邮件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.文件ToolStripMenuItem,
									this.查看ToolStripMenuItem,
									this.邮件ToolStripMenuItem,
									this.工具ToolStripMenuItem,
									this.帮助ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(714, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.文件ToolStripMenuItem.Text = "文件";
			// 
			// 查看ToolStripMenuItem
			// 
			this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
			this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.查看ToolStripMenuItem.Text = "查看";
			// 
			// 邮件ToolStripMenuItem
			// 
			this.邮件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.账户ToolStripMenuItem});
			this.邮件ToolStripMenuItem.Name = "邮件ToolStripMenuItem";
			this.邮件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.邮件ToolStripMenuItem.Text = "邮件";
			// 
			// 账户ToolStripMenuItem
			// 
			this.账户ToolStripMenuItem.Name = "账户ToolStripMenuItem";
			this.账户ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.账户ToolStripMenuItem.Text = "账户";
			// 
			// 工具ToolStripMenuItem
			// 
			this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
			this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.工具ToolStripMenuItem.Text = "工具";
			// 
			// 帮助ToolStripMenuItem
			// 
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.帮助ToolStripMenuItem.Text = "帮助";
			// 
			// frmMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 438);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMainForm";
			this.Text = "MyEmail";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 账户ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 邮件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}
