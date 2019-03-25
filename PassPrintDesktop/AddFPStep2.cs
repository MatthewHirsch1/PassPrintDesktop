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
        //private void AddFPStep2_Load(object sender, EventArgs e)
        //{
            

        //    Variables.serialBluetooth.Write("Adding Fingerprint%");

        //    ////int n = 0;
        //    ////while (n < 100)
        //    ////{
        //    //string incData = Variables.serialBluetooth.ReadLine();
        //    //int milliseconds = 5000;
        //    //Thread.Sleep(milliseconds);
        //    //string CompTo = "Image taken";

        //    //if (string.Compare(incData, CompTo) == 0)
        //    //{
        //    //n = 100;
        //    //MessageBox.Show(incData, "From BT through Variables class");
        //    //}
        //    //n++;

        //    //}



        //    //if (CompTo=="Image taken")
        //    //{
        //    //    MessageBox.Show(incData, "From BT");
        //    //}

        //    //this.Hide();
        //    //var form3 = new AddFPStep3();
        //    //form3.Closed += (s, args) => this.Close();
        //    //form3.Show();
        //    bool disconnectRequested = false;

        //    while (!disconnectRequested)
        //    {

            
        //        try
        //        {

        //            string incData1 = Variables.serialBluetooth.ReadLine();
        //            //MessageBox.Show(incData1, "PRIOR TO IF: From BT through Variables class");
        //            if (incData1 != null)
        //            {
        //                disconnectRequested = true;
        //                MessageBox.Show(incData1, "From BT through Variables class");
        //                continue;
        //            }
        //        }
        //        catch { }
        //    }
            



        //}


        private void Begin_Click(object sender, EventArgs e)
        {
            Variables.serialBluetooth.Write("Adding Fingerprint%");
            //MessageBox.Show("Button Click!");

            bool disconnectRequested = false;

            while (!disconnectRequested)
            {


                try
                {

                    string incData1 = Variables.serialBluetooth.ReadLine();
                    //MessageBox.Show(incData1, "PRIOR TO IF: From BT through Variables class");
                    if (incData1 != null)
                    {
                        disconnectRequested = true;
                        MessageBox.Show(incData1, "From BT through Variables class");
                        continue;
                    }
                }
                catch { }
            }
            this.Hide();
            var form3 = new AddFPStep3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
