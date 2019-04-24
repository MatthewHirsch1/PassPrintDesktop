using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassPrintDesktop
{
    public partial class AddFPStep2 : Form
    {
        public AddFPStep2()
        {
            InitializeComponent();
        }
       
        private void AddFPStep2_Shown(object sender, EventArgs e)
        {
            Variables.serialBluetooth.Write("Adding Fingerprint%");

            bool disconnectRequested = false;

            while (!disconnectRequested)
            {
                try
                {
                    string removeNotice = Variables.serialBluetooth.ReadLine();
                    Console.WriteLine("Remove Notice: " + removeNotice.Trim());
                    Console.WriteLine("String compare: " + string.Compare(removeNotice.Trim(), "stored"));

                    if (string.Compare(removeNotice.Trim(), "Remove finger") == 0)
                    {
                        lblLift.Text += "Lift finger\nPlace finger again";
                    }

                    if (string.Compare(removeNotice.Trim(), "No match") == 0)
                    {
                        MessageBox.Show("Fingers didn't match!", "Alert");
                        disconnectRequested = true;
                        this.Close();
                        new AddFP().Show();
                    }

                    if (string.Compare(removeNotice.Trim(), "stored") == 0)
                    {
                        disconnectRequested = true;
                        MessageBox.Show("Fingerprint Stored!", "Alert");
                        //continue;
                        this.Close();
                        var form3 = new AddFPStep3();
                        form3.Closed += (s, args) => this.Close();
                        form3.Show();
                    }
                }
                catch { }
            }
        }
    }
}
