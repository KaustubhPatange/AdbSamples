/*
 * Read Comments
 * 
 * Components
 *    1. 3 Labels
 *    2. 1 GroupBox
 *    3. 1 Button
 * 
 * What we are trying to achieve?
 * -- By clicking on the button it will check the device if it is connected or not. If yes then it will change the color of pictureBox
 *    to green and further using process we will check its status else it will change color of picturebox to Red.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace DeviceChecker
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
		
		public bool isConnected()
		{
			var check = run_process("adb.exe get-serialno"); // Will check for connected devices and set it to a string
			if (check.Contains("unknown")) // If string is empty that means no device connected else Device is connected
			{
				// If Not Connected
				pictureBox1.BackColor = Color.Red; // Change Color of Picture Box
				label1.Text = "Device Not Connected!";
				status.Text = "---";
				return false; // Returning boolean value
			}
			else
			{
				// If Connected, we will also check its status
				pictureBox1.BackColor = Color.Green;
				label1.Text = "Device Connected!";
				status.Text = run_process("adb.exe get-state"); // This will check status of device i.e Android, Recovery, Sideload, etc
				return true;  // Returning boolean value
			}
			
		}
		
		/// <summary>
		/// By clicking this button we will check our device if it is connected or not.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button1Click(object sender, EventArgs e)
		{
			if (isConnected())
			{
				// It is Connected, do your stuff in this loop
			}
		}
	}
}
