using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using Microsoft.Win32;

namespace Shutdown
{
    public partial class Form1 : Form
    {
        public int hours = 0;
        public int minutes = 0;
        public int seconds = 0;

        public Form1()
        {
            InitializeComponent();

            cmbbxAction.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (VerifyTime())
            {
                btnStart.Text = "Pause";
                btnStart.Click += btnStart_Click2;
                FillLabels();
                tmrCountdown.Start();
            }
        }

        private bool VerifyTime()
        {
            string strHours = mtxtbxHour.Text;
            string strMin = mtxtbxMin.Text;
            string strSec = mtxtbxSec.Text;

            if (!int.TryParse(strHours, out hours) && !(strHours == string.Empty))
            {
                MessageBox.Show("Wrong hour syntax");
                return false;
            }
            if ((!int.TryParse(strMin, out minutes) && !(strMin == string.Empty)) || minutes > 59)
            {
                MessageBox.Show("Wrong minute syntax");
                return false;
            }
            if ((!int.TryParse(strSec, out seconds) && !(strSec == string.Empty)) || seconds > 59)
            {
                MessageBox.Show("Wrong second syntax");
                return false;
            }

            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                MessageBox.Show("You need to set a time");
                return false;
            }
            return true;
        }

        private void btnStart_Click2(object sender, EventArgs e)
        {
            tmrCountdown.Stop();
            btnStart.Text = "Start";
            btnStart.Click += btnStart_Click;
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            // Verify if the time didn't pass.
            if ((minutes == 0) && (hours == 0) && (seconds == 0))
            {
                // If the time is over, clear all settings and fields.
                // Also, show the message, notifying that the time is over.
                tmrCountdown.Enabled = false;
                TimerDone();
            }
            else
            {
                // Else continue counting.
                if (seconds < 1)
                {
                    seconds = 59;
                    if (minutes == 0)
                    {
                        minutes = 59;
                        if (hours != 0)
                            hours -= 1;

                    }
                    else
                    {
                        minutes -= 1;
                    }
                }
                else
                    seconds -= 1;
                // Display the current values of hours, minutes and seconds in
                // the corresponding fields.
                FillLabels();
            }
        }

        public void FillLabels()
        {
            lblHours.Text = hours.ToString();
            lblMin.Text = minutes.ToString();
            lblSec.Text = seconds.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            mtxtbxHour.ResetText();
            mtxtbxMin.ResetText();
            mtxtbxSec.ResetText();
        }

        private void Reset()
        {
            tmrCountdown.Stop();
            btnStart.Text = "Start";
            btnStart.Click += btnStart_Click;
            lblHours.Text = "00";
            lblMin.Text = "00";
            lblSec.Text = "00";
        }

        public void TimerDone()
        {
            ManagementBaseObject outParameters = null;
            ManagementClass sysOS = new ManagementClass("Win32_OperatingSystem");
            sysOS.Get();
            // enables required security privilege.
            sysOS.Scope.Options.EnablePrivileges = true;
            // get our in parameters
            ManagementBaseObject inParameters = sysOS.GetMethodParameters("Win32Shutdown");
            // The possible flags for controlling the system
            // 0 = Log off the network.
            // 1 = Shut down the system.
            // 2 = Perform a full reboot of the system.
            // 4 = Force any applications to quit instead of prompting the user to close them.
            // 8 = Shut down the system and, if possible, turn the computer off.
            switch (cmbbxAction.SelectedItem.ToString())
            {
                case "Shutdown":
                    inParameters["Flags"] = "1";
                    break;
                case "Restart":
                    inParameters["Flags"] = "2";
                    break;
                default:
                    break;
            }
            
            inParameters["Reserved"] = "0";
            foreach (ManagementObject manObj in sysOS.GetInstances())
            {
                outParameters = manObj.InvokeMethod("Win32Shutdown", inParameters, null);
            }

            Reset();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Made by Stiig Gade");
        }

        private void mtxtbxHour_TextChanged(object sender, EventArgs e)
        {
            if (mtxtbxHour.Text.Length == 2)
            {
                mtxtbxMin.Focus();
            }
        }

        private void mtxtbxMin_TextChanged(object sender, EventArgs e)
        {
            if (mtxtbxMin.Text.Length == 2)
            {
                mtxtbxSec.Focus();
            }
            else if (mtxtbxMin.Text.Length == 0)
            {
                mtxtbxHour.Focus();
                mtxtbxHour.SelectionStart = mtxtbxHour.Text.Length;
            }
        }

        private void mtxtbxSec_TextChanged(object sender, EventArgs e)
        {
            if (mtxtbxSec.Text.Length == 0)
            {
                mtxtbxMin.Focus();
                mtxtbxMin.SelectionStart = mtxtbxMin.Text.Length;
            }
        }
    }
}
