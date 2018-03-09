/*
 * Read the comments
 * 
 * Components:
 *    1. 3 Labels
 *    2. 1 GroupBox
 *    3. 1 Button
 * 
 * What we are trying to achieve?
 * -- By clicking on the button it will check the device if it is connected in Fastboot or not. If yes then it will change the color of pictureBox
 *    to Blue.
 *    You also must provide the vendor ID of the device
 *       https://android.googlesource.com/platform/system/core/+/android-4.4_r1/adb/usb_vendors.c
 *       Visit this to see some command vendor ID's of some devices :)
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace FastbootChecker
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
		/// This is a function which tells if device is connected in fastboot or not
		/// Usage: if (isFastbootMode()){  // do your stuffs }
		/// </summary>
		/// <returns></returns>
		public bool isFastbootMode(string vendorID) // This is a unique ID, different for different devices. For Coolpad it is 0x1ebf
		{
			string check=null; // Start variable declaration as null
			if (vendorID==null) // If vendor id is null normal command else use vendor with -i argument
				check = run_process("fastboot.exe devices");
			else
				check = run_process("fastboot.exe -i " + vendorID + " devices");
			if (string.IsNullOrEmpty(check)) // If string is empty that means no device connected else Device is connected
			{
				// If Not Connected
				pictureBox1.BackColor = Color.Red; // Change Color of Picture Box
				label1.Text = "Device Not Connected!";
				return false; // Returning boolean value
			}
			else
			{
				// If Connected, we will also check its status
				pictureBox1.BackColor = Color.Blue;
				label1.Text = "Device Connected!";
 				return true;  // Returning boolean value
			}
			
		}
		
		/// <summary>
		/// When clicked on this will show if device is connected or not
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button1Click(object sender, EventArgs e)
		{
			if (isFastbootMode(null)) // Fill this with your vendor ID, For Coolpad it is 0x1ebf
			{
				// TODO: Your Stuff here
			}
		}
	}
	
}
