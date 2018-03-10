/*
 * Read Comments
 * 
 * Components:
 *    1. 4 Labels : AutoSize = true; 1 label is AutoSize = false (busybox status label)
 *    2. 1 groupBox : Text=""
 *    3. 1 Button
 * 
 *  -- When asking for root permission make sure to look onto your phone for not avoiding any onscreen pop ups
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace RootChecker
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
		/// </summary>
		/// <param name="Commands">string value = run_process(@"adb.exe shell su -version");</param>
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
		/// This is the function which will return if root exist
		/// </summary>
		/// <returns>boolean</returns>
		bool isRooted()
		{
			bool i=false; // Intialize variable with false
			var firstcheck = run_process(@"adb.exe shell su -c exit"); // Asking for root permission
			if ((firstcheck.ToLower().Contains("permission denied"))||(firstcheck.ToLower().Contains("not found"))) // Check for root
			{
				// No root found, Lets begin for further check
				run_process("adb.exe pull /system/bin/su");
				if (File.Exists("su"))
				{
					File.Delete("su"); // It exist, you can't beat us using magisk hide
					i=true;
				} 
				else
					i=false; // It does not exist
			}
			else
				i=true; // Root exist
			return i; // Returning value
		}
		
		/// <summary>
		/// This function will check if busybox exist or not
		/// </summary>
		/// <returns>boolean</returns>
		bool isBusyBox()
		{
			bool i=false; // Intialize variable with false
			var firstcheck = run_process(@"adb.exe shell busybox"); // Running busybox shell
			if ((firstcheck.ToLower().Contains("permission denied"))||(firstcheck.ToLower().Contains("not found"))) // Check for Busybox
				i=false; // No busybox exist
			else
				i=true; // It exisit
			return i; // Returning
		}
		/// <summary>
		/// This is the button onto which when we clicked we will get recieve our phone root and busybox status
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button1Click(object sender, EventArgs e)
		{
			if (isRooted()) // Lets check for root using the function
			{
				// TODO: Lets check for version
				string version = run_process(@"adb.exe shell su -version");
				rootlabel.Text = "Root Found, " + version;
			}else
				rootlabel.Text = "Not Found";
			if (isBusyBox()) // Its busybox time
			{
				// TODO: Lets check for its installation date
				string date = run_process(@"adb.exe shell busybox date");
				busyboxlabel.Text = "BusyBox Found, " + date;
			}else
				busyboxlabel.Text = "Not Found";
		}
	}
}
