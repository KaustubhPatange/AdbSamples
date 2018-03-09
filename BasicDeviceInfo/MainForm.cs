/*
 * Read Comments
 * 
 * I have used 28 labels : AutoSize=true
 *                       : I have changed name of some labels check them in property window
 *            3 GroupBox : Text=""
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace BasicDeviceInfo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		/// <summary>
		/// This is a function through which we pass the commands to cmd.exe and we get a standard output of it.
		/// Usage:- string value = run_process(@"adb.exe shell getprop ro.secure");
		/// </summary>
		/// <param name="Commands"></param>
		public string run_process(string Commands)
		{
			var p = new Process(); // Declaring new process
		   
			// Defining the process, setting its parameters
			p.StartInfo.FileName = "cmd.exe"; // Passing main function to cmd.exe
			p.StartInfo.Arguments = "/c " + Commands; // Commands string passed here. /c argument is used to passed parameters explicitly.
			p.StartInfo.CreateNoWindow = true; // No displaying a window
			p.StartInfo.UseShellExecute = false; // No using cmd.exe to execute shell
			p.StartInfo.RedirectStandardOutput = true;
			p.Start(); // Starting the process
			do 
			{
				Application.DoEvents(); // This will prevent application from hang
			}while(!p.HasExited); // Will wait until process been released from memory
			return p.StandardOutput.ReadToEnd(); // This will return the output from the process.
		}
		
		/// <summary>
		/// This will check all the device info and print them onto their respective labels.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button1Click(object sender, EventArgs e)
		{
			button1.Enabled=false; // Disabling button to prevent from running process again by user if pressed twice.
			
			// Getting All values and adding it to the respective labels.Text
			manufacture.Text = run_process("adb.exe shell getprop ro.product.manufacturer");
			model.Text = run_process("adb.exe shell getprop ro.product.manufacturer");
			modelID.Text = run_process("adb.exe shell getprop ro.product.device");
			serial.Text = run_process("adb.exe shell getprop ro.serialno");
			BuildDate.Text = run_process("adb.exe shell getprop ro.build.date");
			BuildVer.Text = run_process("adb.exe shell getprop ro.build.version.release");
			HardwareInfo.Text = run_process("adb.exe shell getprop ro.hardware");
			PlatformVer.Text = run_process("adb.exe shell getprop ro.board.platform");
			USBType.Text = run_process("adb.exe shell getprop sys.usb.config");
			Bootloader.Text = run_process("adb.exe shell getprop ro.bootloader");
			Encryption.Text = run_process("adb.exe shell getprop ro.crypto.state");
			RoSecure.Text = run_process("adb.exe shell getprop ro.secure");
			RoAdb.Text = run_process("adb.exe shell getprop ro.adb.secure");
			Selinux.Text = run_process("adb.exe shell getprop ro.build.selinux.enforce");	

			button1.Enabled=true; // Enabling button after task is completed
		}
	}
}
