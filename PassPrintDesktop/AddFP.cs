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
            string finger_select = FingerSelect.SelectedItem.ToString();



            Variables.serialBluetooth.Write("Add Fingerprint%");
            //if (finger_select == "Left Thumb")
            //    Variables.serialBluetooth.Write("1%");
            //else if (finger_select == "Left Index")
            //    Variables.serialBluetooth.Write("2%");
            //else if (finger_select == "Left Middle")
            //    Variables.serialBluetooth.Write("3%");
            //else if (finger_select == "Left Ring")
            //    Variables.serialBluetooth.Write("4%");
            //else if (finger_select == "Left Pinky")
            //    Variables.serialBluetooth.Write("5%");
            //else if (finger_select == "Right Thumb")
            //    Variables.serialBluetooth.Write("6%");
            //else if (finger_select == "Right Index")
            //    Variables.serialBluetooth.Write("7%");
            //else if (finger_select == "Right Middle")
            //    Variables.serialBluetooth.Write("8%");
            //else if (finger_select == "Right Ring")
            //    Variables.serialBluetooth.Write("9%");
            //else if (finger_select == "Right Pinky")
            //    Variables.serialBluetooth.Write("10%");

            //ctrl+k+c comment NOT AT SAME TIME
            //ctrl+k+u uncomment NOT AT SAME TIME

            string incData = Variables.serialBluetooth.ReadLine();
            MessageBox.Show(incData, "From BT through Variables class");
            //MessageBox.Show("NOT From BT through Variables class");


            //this.Hide();
            //var form2 = new AddFPStep2();
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
             this.Close();
            
        }
    }
}
