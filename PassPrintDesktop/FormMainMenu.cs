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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            this.Select();
            //while (true)
            //{
            //    try { // Try to open serial port for Bluetooth connection
            //        serialBluetooth.Open();
            //        break; }
            //    catch (Exception) { MessageBox.Show("Please connect the device via Bluetooth and try again.", "Connection Error"); }
            //}

            }

        private void btnAddCred_Click(object sender, EventArgs e)
        {
            new FormAddCred().Show();
        }

        private void btnEditDelCred_Click(object sender, EventArgs e)
        {
            new FormEditDelCred().Show();
        }
    }
}
