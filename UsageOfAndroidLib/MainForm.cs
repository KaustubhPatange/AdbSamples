/*
 * Read Comments
 * 
 * First of all Click on Project > Add Reference and browse for the AndroidLib.dll from lib folder here.
 * 
 * Components:
 *    Labels, Group Box, TextBox, PictureBox, ComboBox, Buttons
 * 
 *    ComboBox : Collections = (check that property)
 *             : DropDownStyle = DropDownList
 * 
 * Basic Device Info, Device Checker, Root Checker, Adb Rebooter all in one sample using androidlib.dll
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RegawMOD.Android; // Android lib imports

namespace UsageOfAndroidLib
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// Declaring some variables
		Device device; AndroidController android=null; string serial;
		
		
		public MainForm()
		{
			InitializeComponent();
			android = AndroidController.Instance; // Setting Android instance
			comboBox1.SelectedIndex = 0; // First option will be selected in comboBox which is Normal Reboot
			groupBox2.Enabled = false; // Disabling group box at the start which contains reboot options
		}
		
		/// <summary>
		/// This will check if device is connected or not
		/// </summary>
		/// <returns>bool</returns>
		bool isConnected()
		{
			bool i=false; // Initialize variable as false
			groupBox2.Enabled = false; // Disabling group box so what if there is no connected device, we may not want user to click on reboot button to prevent error
			android.UpdateDeviceList(); // Update connected device list
			if (android.HasConnectedDevices) // Check for connected devices
			{
				serial = android.ConnectedDevices[0]; // Get first connected device's serial '0' means first
                device = android.GetConnectedDevice(serial); // Use device serial to get device
                i=true; // It is connected
                groupBox2.Enabled = true; // Enabling groupBox as we know device is connected
			}
			else
				i=false; // It is not connected
			return i; // Return as function says
		}
		
		/// <summary>
		/// Main click of the button1, you know what it does;
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button1Click(object sender, EventArgs e)
		{
			if (isConnected())
			{
				pictureBox1.BackColor = Color.Green; // Setting color to green
				statuslabel.Text = device.BuildProp.GetProp("ro.product.device") + ", " + device.State; // Show device name in status label as connected with its state
			    
				// Get some Additional details and show in textbox
				textBox1.Text="-------Device Connected-------" + Environment.NewLine;
				textBox1.AppendText("Product Model: " + device.BuildProp.GetProp("ro.product.model") + Environment.NewLine);  // Show device's model, you can use other prop commands to, you will find it in basic device info project
				textBox1.AppendText("Battery Status: " + device.Battery.Level.ToString() + Environment.NewLine); // Show battery percentage as string
				textBox1.AppendText("Battery Temperature: "+ device.Battery.Temperature + Environment.NewLine); // Show battery temperature
				textBox1.AppendText("Encryption: "+ device.BuildProp.GetProp("ro.crypto.state") + Environment.NewLine); // Show encryption state
				textBox1.AppendText("Is Rooted: "+ device.HasRoot + Environment.NewLine); // Show if device rooted
				textBox1.AppendText("Su Version: " + device.Su.Version + Environment.NewLine); // Show the SU Version installed
				textBox1.AppendText("BusyBox: "+device.BusyBox.IsInstalled + ", " + device.BusyBox.Version + Environment.NewLine); // Checks if busybox installed and its version
			
			}
			else
			{
				textBox1.Text = "-------Error No Device Connected--------";
				pictureBox1.BackColor = Color.Red; // Setting color to Red as not connected
				statuslabel.Text = "---";
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			switch(comboBox1.SelectedIndex) // Checking which option been selected in comboxBox using integers
			{
				case 0: // First element been selected
					device.Reboot(); 
					break;
				case 1: // Second element been selected
					device.RebootRecovery();
					break;
				case 2:  // Third element been selected
					device.RebootBootloader();
					break;
			}
		}
	}
}
