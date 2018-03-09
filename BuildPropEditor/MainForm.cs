/*
 * Read Comments
 * 
 * Components
 *    1. 1 MenuStrip
 *    2. 2 Buttons
 *    3. 1 GroupBox
 *    4. 1 textBox
 * 
 * -- By clicking via Button or File > Option it will do the task as it is written over there.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO; // For Files reading and writting

namespace BuildPropEditor
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
		/// This is a function through which we pass the commands the cmd.exe explicitly for running various task.
		/// Usage:- run_process(@"adb.exe reboot recovery");
		/// </summary>
		/// <param name="Commands"></param>
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
		///  Common clicks for Menustrip and button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void PullBuildProp(object sender, EventArgs e)
		{
			run_process("adb.exe pull /system/build.prop"); // This is where build.prop lies, pulling build.prop to Computer
			if (File.Exists(@"build.prop")) // Checks if build.prop is properly pulled to computer.
			{
				textBox1.Text = File.ReadAllText(@"build.prop"); // If yes read and add text to PC
			}
			else
			{
				MessageBox.Show("Could not pull build.prop from Device"); // If not show a message
			}			
		}
		
		/// <summary>
		/// By click on this command button text from textbox will be first written to build.prop the copied to system
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void pushBuildProp(object sender, EventArgs e)
		{
			File.WriteAllText("build.prop",textBox1.Text); // Write text from textbox to a file.
			run_process("adb.exe push build.prop /sdcard/build.prop"); // Push the .prop to Internal Storage.
			run_process("adb.exe -d shell su -c cp -f /sdcard/build.prop /system/build.prop"); // Executing Root shell to copy file to system and overwrite existing build.prop file. Be sure to check device when using root shell 'su' if you might get an onscreen pop up. :)
			MessageBox.Show("File Pushed Successfully"); // Show a message of success
		}
	}	
}
