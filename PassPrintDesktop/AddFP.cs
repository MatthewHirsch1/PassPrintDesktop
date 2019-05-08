using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace PassPrintDesktop
{
    public partial class AddFP : Form
    {
        public AddFP()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            string finger_select = "";
            try
            {
                finger_select = FingerSelect.SelectedItem.ToString();
                Console.WriteLine("Finger: " + finger_select);

                if (finger_select != "Select Finger")
                {
                    Variables.serialBluetooth.Write("Choose Fingerprint%");
                    // TO-DO: Add feedback so user knows to lift finger for adding FP // Done
                    if (finger_select == "Left Thumb")
                        Variables.serialBluetooth.WriteLine("0%");
                    else if (finger_select == "Left Index")
                        Variables.serialBluetooth.WriteLine("1%");
                    else if (finger_select == "Left Middle")
                        Variables.serialBluetooth.WriteLine("2%");
                    else if (finger_select == "Left Ring")
                        Variables.serialBluetooth.WriteLine("3%");
                    else if (finger_select == "Left Pinky")
                        Variables.serialBluetooth.WriteLine("4%");
                    else if (finger_select == "Right Thumb")
                        Variables.serialBluetooth.WriteLine("5%");
                    else if (finger_select == "Right Index")
                        Variables.serialBluetooth.WriteLine("6%");
                    else if (finger_select == "Right Middle")
                        Variables.serialBluetooth.WriteLine("7%");
                    else if (finger_select == "Right Ring")
                        Variables.serialBluetooth.WriteLine("8%");
                    else if (finger_select == "Right Pinky")
                        Variables.serialBluetooth.WriteLine("9%");

                    string id = Variables.serialBluetooth.ReadLine();
                    Console.WriteLine("ID from Arduino: " + id);

                    //ctrl+k+c comment NOT AT SAME TIME
                    //ctrl+k+u uncomment NOT AT SAME TIME

                    //string incData = Variables.serialBluetooth.ReadLine();
                    //MessageBox.Show(incData, "From BT through Variables class");
                    //MessageBox.Show("NOT From BT through Variables class");


                    this.Hide();
                    var form2 = new AddFPStep2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
            } catch { }
        }

        private void Back_Click(object sender, EventArgs e)
        {
             this.Close();
            
        }
    }
}
