/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 3/9/2018
 * Time: 10:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BasicDeviceInfo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label serial;
		private System.Windows.Forms.Label modelID;
		private System.Windows.Forms.Label model;
		private System.Windows.Forms.Label manufacture;
		private System.Windows.Forms.Label USBType;
		private System.Windows.Forms.Label PlatformVer;
		private System.Windows.Forms.Label HardwareInfo;
		private System.Windows.Forms.Label BuildVer;
		private System.Windows.Forms.Label BuildDate;
		private System.Windows.Forms.Label Selinux;
		private System.Windows.Forms.Label RoAdb;
		private System.Windows.Forms.Label RoSecure;
		private System.Windows.Forms.Label Encryption;
		private System.Windows.Forms.Label Bootloader;
		
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.manufacture = new System.Windows.Forms.Label();
			this.model = new System.Windows.Forms.Label();
			this.modelID = new System.Windows.Forms.Label();
			this.serial = new System.Windows.Forms.Label();
			this.BuildDate = new System.Windows.Forms.Label();
			this.BuildVer = new System.Windows.Forms.Label();
			this.HardwareInfo = new System.Windows.Forms.Label();
			this.PlatformVer = new System.Windows.Forms.Label();
			this.USBType = new System.Windows.Forms.Label();
			this.Bootloader = new System.Windows.Forms.Label();
			this.Encryption = new System.Windows.Forms.Label();
			this.RoSecure = new System.Windows.Forms.Label();
			this.RoAdb = new System.Windows.Forms.Label();
			this.Selinux = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.serial);
			this.groupBox1.Controls.Add(this.modelID);
			this.groupBox1.Controls.Add(this.model);
			this.groupBox1.Controls.Add(this.manufacture);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(381, 131);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Device Serial:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Model ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Product Model:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Product Manufacture:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.USBType);
			this.groupBox2.Controls.Add(this.PlatformVer);
			this.groupBox2.Controls.Add(this.HardwareInfo);
			this.groupBox2.Controls.Add(this.BuildVer);
			this.groupBox2.Controls.Add(this.BuildDate);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(12, 149);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(381, 165);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(19, 128);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(119, 17);
			this.label9.TabIndex = 13;
			this.label9.Text = "Connection Type:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(19, 102);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "Platform Version:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 17);
			this.label7.TabIndex = 11;
			this.label7.Text = "Hardware Info:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Build Version:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Build Date:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.Selinux);
			this.groupBox3.Controls.Add(this.RoAdb);
			this.groupBox3.Controls.Add(this.RoSecure);
			this.groupBox3.Controls.Add(this.Encryption);
			this.groupBox3.Controls.Add(this.Bootloader);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Location = new System.Drawing.Point(13, 321);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(380, 156);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(21, 124);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(90, 17);
			this.label14.TabIndex = 18;
			this.label14.Text = "Selinux level:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(18, 98);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(141, 17);
			this.label13.TabIndex = 17;
			this.label13.Text = "Ro.Adb Secure level:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(18, 71);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 17);
			this.label12.TabIndex = 16;
			this.label12.Text = "Ro.Secure level:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(18, 45);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(116, 17);
			this.label11.TabIndex = 15;
			this.label11.Text = "Encryption State:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(18, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 17);
			this.label10.TabIndex = 14;
			this.label10.Text = "Bootloader:";
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(313, 485);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 27);
			this.button1.TabIndex = 3;
			this.button1.Text = "CheckInfo";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// manufacture
			// 
			this.manufacture.AutoSize = true;
			this.manufacture.Location = new System.Drawing.Point(169, 18);
			this.manufacture.Name = "manufacture";
			this.manufacture.Size = new System.Drawing.Size(23, 17);
			this.manufacture.TabIndex = 4;
			this.manufacture.Text = "---";
			// 
			// model
			// 
			this.model.AutoSize = true;
			this.model.Location = new System.Drawing.Point(169, 44);
			this.model.Name = "model";
			this.model.Size = new System.Drawing.Size(23, 17);
			this.model.TabIndex = 5;
			this.model.Text = "---";
			// 
			// modelID
			// 
			this.modelID.AutoSize = true;
			this.modelID.Location = new System.Drawing.Point(169, 71);
			this.modelID.Name = "modelID";
			this.modelID.Size = new System.Drawing.Size(23, 17);
			this.modelID.TabIndex = 6;
			this.modelID.Text = "---";
			// 
			// serial
			// 
			this.serial.AutoSize = true;
			this.serial.Location = new System.Drawing.Point(169, 98);
			this.serial.Name = "serial";
			this.serial.Size = new System.Drawing.Size(23, 17);
			this.serial.TabIndex = 7;
			this.serial.Text = "---";
			// 
			// BuildDate
			// 
			this.BuildDate.AutoSize = true;
			this.BuildDate.Location = new System.Drawing.Point(169, 18);
			this.BuildDate.Name = "BuildDate";
			this.BuildDate.Size = new System.Drawing.Size(23, 17);
			this.BuildDate.TabIndex = 14;
			this.BuildDate.Text = "---";
			// 
			// BuildVer
			// 
			this.BuildVer.AutoSize = true;
			this.BuildVer.Location = new System.Drawing.Point(169, 46);
			this.BuildVer.Name = "BuildVer";
			this.BuildVer.Size = new System.Drawing.Size(23, 17);
			this.BuildVer.TabIndex = 15;
			this.BuildVer.Text = "---";
			// 
			// HardwareInfo
			// 
			this.HardwareInfo.AutoSize = true;
			this.HardwareInfo.Location = new System.Drawing.Point(169, 74);
			this.HardwareInfo.Name = "HardwareInfo";
			this.HardwareInfo.Size = new System.Drawing.Size(23, 17);
			this.HardwareInfo.TabIndex = 16;
			this.HardwareInfo.Text = "---";
			// 
			// PlatformVer
			// 
			this.PlatformVer.AutoSize = true;
			this.PlatformVer.Location = new System.Drawing.Point(169, 102);
			this.PlatformVer.Name = "PlatformVer";
			this.PlatformVer.Size = new System.Drawing.Size(23, 17);
			this.PlatformVer.TabIndex = 17;
			this.PlatformVer.Text = "---";
			// 
			// USBType
			// 
			this.USBType.AutoSize = true;
			this.USBType.Location = new System.Drawing.Point(169, 128);
			this.USBType.Name = "USBType";
			this.USBType.Size = new System.Drawing.Size(23, 17);
			this.USBType.TabIndex = 18;
			this.USBType.Text = "---";
			// 
			// Bootloader
			// 
			this.Bootloader.AutoSize = true;
			this.Bootloader.Location = new System.Drawing.Point(168, 18);
			this.Bootloader.Name = "Bootloader";
			this.Bootloader.Size = new System.Drawing.Size(23, 17);
			this.Bootloader.TabIndex = 19;
			this.Bootloader.Text = "---";
			// 
			// Encryption
			// 
			this.Encryption.AutoSize = true;
			this.Encryption.Location = new System.Drawing.Point(168, 45);
			this.Encryption.Name = "Encryption";
			this.Encryption.Size = new System.Drawing.Size(23, 17);
			this.Encryption.TabIndex = 20;
			this.Encryption.Text = "---";
			// 
			// RoSecure
			// 
			this.RoSecure.AutoSize = true;
			this.RoSecure.Location = new System.Drawing.Point(168, 71);
			this.RoSecure.Name = "RoSecure";
			this.RoSecure.Size = new System.Drawing.Size(23, 17);
			this.RoSecure.TabIndex = 21;
			this.RoSecure.Text = "---";
			// 
			// RoAdb
			// 
			this.RoAdb.AutoSize = true;
			this.RoAdb.Location = new System.Drawing.Point(168, 98);
			this.RoAdb.Name = "RoAdb";
			this.RoAdb.Size = new System.Drawing.Size(23, 17);
			this.RoAdb.TabIndex = 22;
			this.RoAdb.Text = "---";
			// 
			// Selinux
			// 
			this.Selinux.AutoSize = true;
			this.Selinux.Location = new System.Drawing.Point(168, 124);
			this.Selinux.Name = "Selinux";
			this.Selinux.Size = new System.Drawing.Size(23, 17);
			this.Selinux.TabIndex = 23;
			this.Selinux.Text = "---";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 521);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Basic Device Info";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
