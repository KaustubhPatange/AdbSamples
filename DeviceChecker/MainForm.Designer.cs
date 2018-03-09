/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 3/9/2018
 * Time: 11:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DeviceChecker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label status;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(378, 68);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(44, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(291, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "Check Whether Device is Connected or Not";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Red;
			this.pictureBox1.Location = new System.Drawing.Point(12, 86);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(39, 27);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "---";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Status:";
			// 
			// status
			// 
			this.status.AutoSize = true;
			this.status.Location = new System.Drawing.Point(70, 126);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(23, 17);
			this.status.TabIndex = 4;
			this.status.Text = "---";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 156);
			this.Controls.Add(this.status);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Device Checker";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
