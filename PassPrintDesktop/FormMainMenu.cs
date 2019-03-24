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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            this.Select();
        }

        private void btnAddCred_Click(object sender, EventArgs e)
        {
            new FormAddCred().Show();
        }

        private void btnEditDelCred_Click(object sender, EventArgs e)
        {
            new FormEditDelCred().Show();
        }

        private void btnConnectBT_Click(object sender, EventArgs e)
        { // Click this button to connect to Bluetooth
            Variables.serialBluetooth.Open();
            lblConnectSuccess.Text = "✓";
            //btnConnectBT

        }
    }
}
