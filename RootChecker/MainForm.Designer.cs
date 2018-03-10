/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 3/10/2018
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RootChecker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label busyboxlabel;
		private System.Windows.Forms.Label rootlabel;
		
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
			this.busyboxlabel = new System.Windows.Forms.Label();
			this.rootlabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.busyboxlabel);
			this.groupBox1.Controls.Add(this.rootlabel);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(390, 123);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// busyboxlabel
			// 
			this.busyboxlabel.Location = new System.Drawing.Point(91, 82);
			this.busyboxlabel.Name = "busyboxlabel";
			this.busyboxlabel.Size = new System.Drawing.Size(293, 35);
			this.busyboxlabel.TabIndex = 6;
			this.busyboxlabel.Text = "---";
			// 
			// rootlabel
			// 
			this.rootlabel.AutoSize = true;
			this.rootlabel.Location = new System.Drawing.Point(91, 56);
			this.rootlabel.Name = "rootlabel";
			this.rootlabel.Size = new System.Drawing.Size(23, 17);
			this.rootlabel.TabIndex = 4;
			this.rootlabel.Text = "---";
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(112, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 27);
			this.button1.TabIndex = 2;
			this.button1.Text = "Check Root && BusyBox";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "BusyBox:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Root:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 145);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Root Checker";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
