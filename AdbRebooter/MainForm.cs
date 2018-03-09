/*
 * Read Comments they will be most helpfull
 * 
 * What I have added
 * 1. GroupBox  : Text = Reboot Options
 * 2. 4 Buttons
 * 3. 1 Textbox : Multiline = true 
 *                ReadOnly = true (this means it is only readable you can't manually type in)
 * 4. Click Form: Text = ADB Toolkit
 *                Icon = Browse then check local resource > Import and browse for your icon. 
 *   
 * To Change icon of exe : Go to Right click on ADB_Project > Properties or From top Project > Project Options
 * From there you can change file name, assembly name. To Change icon you will see something like application icon there. 
 * Click on browse button and browse for any icon.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics; // Add this Import

namespace ADB_Project
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		/// <summary>
		/// This is a function through which we pass the commands the cmd.exe explicitly for running various task.
		/// Usage:- run_process(@"adb.exe reboot recovery");
		/// </summary>
		/// <param name="Arguments"></param>
		public void run_process(string Commands)
		{
			var p = new Process(); // Declaring new process
		   
			// Defining the process, setting its parameters
			p.StartInfo.FileName = "cmd.exe"; // Passing main function to cmd.exe
			p.StartInfo.Arguments = "/c " + Commands; // Commands string passed here. /c argument is used to passed parameters explicitly.
			p.StartInfo.CreateNoWindow = true; // No displaying a window
			p.StartInfo.UseShellExecute = false; // No using cmd.exe to execute shell
			p.Start(); // Starting the process
			do 
			{
				Application.DoEvents(); // This will prevent application from hang
			}while(!p.HasExited); // Will wait until process been released from memory
		}
		
		/// <summary>
		/// This is for Normal Reboot button will Restart your device
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.AppendText("Rebooting Device..."); // Append text means it will add text to new line.
			run_process(@"adb.exe reboot"); // Always put @ simple when dealing with files.
			textBox1.AppendText("OK\n");
		}
		
		/// <summary>
		/// This is Button for Rebooting into Bootloader or Fastboot
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button2Click(object sender, EventArgs e)
		{
		    textBox1.AppendText("Rebooting Bootloader..."); // Append text means it will add text to new line.
			run_process(@"adb.exe reboot bootloader"); // Always put @ simple when dealing with files.
			textBox1.AppendText("OK\n");	
		}
		
		/// <summary>
		/// This is Button for rebooting into Recovery
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button3Click(object sender, EventArgs e)
		{
	        textBox1.AppendText("Rebooting Recovery..."); // Append text means it will add text to new line.
			run_process(@"adb.exe reboot recovery"); // Always put @ simple when dealing with files.
			textBox1.AppendText("OK\n");
		}
		
		/// <summary>
		/// This is something new, this will restart systemui. It comes handy when you change font or theme to apply it.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button4Click(object sender, EventArgs e)
		{  
			textBox1.AppendText("Restarting SystemUI..."); // Append text means it will add text to new line.
			run_process(@"adb.exe shell pkill com.android.systemui"); // Here you will see adb shell, shell means these are android linux commands which we are entering
			textBox1.AppendText("OK\n");	
		}
	}
}
