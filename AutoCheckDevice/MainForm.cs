/*
 * Read Comments
 * 
 * First of all Click on Project > Add Reference and browse for the AndroidLib.dll from lib folder here.
 * 
 * Components:
 *    Labels, PictureBox, Timer, BackgoundWorder
 * 
 * This will automatically check if the device is connected to PC or not. Such process requires a good amount of memory, this project requires 10-16 MB or Memory to run which is considerably high amount of memory.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RegawMOD.Android;

namespace AutoCheckDevice
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// Declaration of some variables...
		Device device; AndroidController android=null; string serial;
		
		public MainForm()
		{
			InitializeComponent();
			android = AndroidController.Instance; // Setting Android instance
			timer1.Interval = 200; // Setting timer interval to 2 milliseconds, This means it will check devices after every 2 milliseconds
			timer1.Start(); // Start the Timer :)
		}
		
		/// <summary>
		/// This will check if device is connected or not
		/// </summary>
		/// <returns>bool</returns>
		bool isConnected()
		{
			bool i=false; // Initialize variable as false
			android.UpdateDeviceList(); // Update connected device list
			if (android.HasConnectedDevices) // Check for connected devices
			{
				serial = android.ConnectedDevices[0]; // Get first connected device's serial '0' means first
                device = android.GetConnectedDevice(serial); // Use device serial to get device
                i=true; // It is connected
           }
			else
				i=false; // It is not connected
			return i; // Return as function says
		}
		
		/// <summary>
		/// Set the work of background work, What it will do....
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
        	if (isConnected())
			{
				pictureBox1.BackColor = Color.Green; // Setting color to green
				statuslabel.Text = device.BuildProp.GetProp("ro.product.device") + ", " + device.State; // Show device name in status label as connected with its state
			}
			else
			{
				pictureBox1.BackColor = Color.Red; // Setting color to Red as not connected
				statuslabel.Text = "---";
			}
		}
		
		/// <summary>
		/// Set the timer Function,,
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Timer1Tick(object sender, EventArgs e)
		{
			if (!backgroundWorker1.IsBusy) // Check if backgroud worker is NOT (indicated by ! at start) busy otherwise both process may collide with each other
			{
				backgroundWorker1.RunWorkerAsync(); // Run Background worker, it will automatically prevent Application from hangs as it runs in background
			}
		}
		
	}
}
