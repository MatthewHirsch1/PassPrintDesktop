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
using System.Diagnostics;

namespace PassPrintDesktop
{
    public partial class FormMainMenu : Form
    {
        private System.Windows.Forms.Timer timer1;

        public FormMainMenu()
        {
            InitializeComponent();
            this.Select();
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }
        private void resetTimer()
        {
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // lock user access
            Debug.WriteLine("Screen locked", "Timer");
        }

        private void btnAddCred_Click(object sender, EventArgs e)
        {
            new FormAddCred().Show();
        }

        private void btnEditDelCred_Click(object sender, EventArgs e)
        {
            //using (Place_Finger form = new Place_Finger())
            //{
            //    Place_Finger.fingerOK = false;
            //    form.ShowDialog();
            //}
            //if (Place_Finger.fingerOK)
            //{ new FormEditDelCred().Show(); }
            new FormEditDelCred().Show();
        }

        private void btnConnectBT_Click(object sender, EventArgs e)
        { // Click this button to connect to Bluetooth
            Variables.serialBluetooth.Open();
            lblConnectSuccess.Text = "✓";
            //btnConnectBT
        }

        private void btnAddFP_Click(object sender, EventArgs e)
        {
            //using (Place_Finger form = new Place_Finger())
            //{
            //    Place_Finger.fingerOK = false;
            //    form.ShowDialog();
            //}
            //if (Place_Finger.fingerOK) { new AddFP().Show(); }
            new AddFP().Show();
        }

        private void Btn_Authenticate_Click(object sender, EventArgs e)
        {
            new Place_Finger().Show();
            resetTimer();
        }

        private void btnRemoveFP_Click(object sender, EventArgs e)
        {
            using (Place_Finger form = new Place_Finger())
            {
                Place_Finger.fingerOK = false;
                form.ShowDialog();
            }
        }
    }
}
