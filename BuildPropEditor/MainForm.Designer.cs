/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 3/9/2018
 * Time: 11:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BuildPropEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pullBuildpropFromDeviceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pushBuildpropToDeviceToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox1;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pullBuildpropFromDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pushBuildpropToDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(51, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(284, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "Pull Build.prop from Device to this TextBox";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.PullBuildProp);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(12, 335);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(388, 99);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(7, 54);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(375, 27);
			this.button2.TabIndex = 1;
			this.button2.Text = "Save this text and Overwrite existing Build.prop in Device";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.pushBuildProp);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(412, 28);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.pullBuildpropFromDeviceToolStripMenuItem,
			this.pushBuildpropToDeviceToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// pullBuildpropFromDeviceToolStripMenuItem
			// 
			this.pullBuildpropFromDeviceToolStripMenuItem.Name = "pullBuildpropFromDeviceToolStripMenuItem";
			this.pullBuildpropFromDeviceToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
			this.pullBuildpropFromDeviceToolStripMenuItem.Text = "&Pull Build.prop from Device";
			this.pullBuildpropFromDeviceToolStripMenuItem.Click += new System.EventHandler(this.PullBuildProp);
			// 
			// pushBuildpropToDeviceToolStripMenuItem
			// 
			this.pushBuildpropToDeviceToolStripMenuItem.Name = "pushBuildpropToDeviceToolStripMenuItem";
			this.pushBuildpropToDeviceToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
			this.pushBuildpropToDeviceToolStripMenuItem.Text = "&Push Build.prop to Device";
			this.pushBuildpropToDeviceToolStripMenuItem.Click += new System.EventHandler(this.pushBuildProp);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 31);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(388, 298);
			this.textBox1.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 443);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "BuildPropEditor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
