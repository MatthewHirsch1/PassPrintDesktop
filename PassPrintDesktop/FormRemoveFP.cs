using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassPrintDesktop
{
    public partial class FormRemoveFP : Form
    {
        public FormRemoveFP()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                string finger_select = dropdownFingerSelect.SelectedItem.ToString();
                if (finger_select != "Select Finger")
                {
                    Variables.serialBluetooth.Write("Remove Fingerprint%");
                    // TO-DO: Add feedback so user knows to lift finger for adding FP // Done
                    if (finger_select == "Left Thumb")
                        Variables.serialBluetooth.Write("0%");
                    else if (finger_select == "Left Index")
                        Variables.serialBluetooth.Write("1%");
                    else if (finger_select == "Left Middle")
                        Variables.serialBluetooth.Write("2%");
                    else if (finger_select == "Left Ring")
                        Variables.serialBluetooth.Write("3%");
                    else if (finger_select == "Left Pinky")
                        Variables.serialBluetooth.Write("4%");
                    else if (finger_select == "Right Thumb")
                        Variables.serialBluetooth.Write("5%");
                    else if (finger_select == "Right Index")
                        Variables.serialBluetooth.Write("6%");
                    else if (finger_select == "Right Middle")
                        Variables.serialBluetooth.Write("7%");
                    else if (finger_select == "Right Ring")
                        Variables.serialBluetooth.Write("8%");
                    else if (finger_select == "Right Pinky")
                        Variables.serialBluetooth.Write("9%");

                    //ctrl+k+c comment NOT AT SAME TIME
                    //ctrl+k+u uncomment NOT AT SAME TIME

                    //string incData = Variables.serialBluetooth.ReadLine();
                    //MessageBox.Show(incData, "From BT through Variables class");
                    //MessageBox.Show("NOT From BT through Variables class");

                    this.Close();
                    //this.Hide();
                    //var form2 = new Place_Finger();
                    //form2.Closed += (s, args) => this.Close();
                    //form2.Show();
                    //new Place_Finger().Show();
                    //using (Place_Finger form = new Place_Finger())
                    //{
                    //    Place_Finger.fingerOK = false;
                    //    form.ShowDialog();
                    //}
                    //if (Place_Finger.fingerOK)
                    //{
                    //string deleteInfo = Variables.serialBluetooth.ReadLine();
                    //    Console.WriteLine("Delete Info: ", deleteInfo);
                    //    if (string.Compare(deleteInfo.Trim(), "Deleted") == 0)
                    //    {
                    //        MessageBox.Show("Finger Deleted Successfully", "Alert");
                    //        this.Close();
                    //    }
                    //}
                }
            } catch { }
        }

        private void FormRemoveFP_Load(object sender, EventArgs e)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(0, "Left Thumb");
            dict.Add(1, "Left Index");
            dict.Add(2, "Left Middle");
            dict.Add(3, "Left Ring");
            dict.Add(4, "Left Pinky");
            dict.Add(5, "Right Thumb");
            dict.Add(6, "Right Index");
            dict.Add(7, "Right Middle");
            dict.Add(8, "Right Ring");
            dict.Add(9, "Right Pinky");

            Variables.serialBluetooth.WriteLine("How Many Fingers%");
            string strNum = Variables.serialBluetooth.ReadLine();
            int intNum = 0;
            try
            {
                intNum = Int32.Parse(strNum);
            }
            catch (Exception) { }
            Console.WriteLine("Finger Count: " + intNum);
            Variables.serialBluetooth.WriteLine("Get Stored Fingers%");
            for (int i = 0; i < intNum; i++)
            {
                string finger = Variables.serialBluetooth.ReadLine();
                int fingerID = Int32.Parse(finger);
                dropdownFingerSelect.Items.Add(dict[fingerID]);
            }
        }
    }
}
