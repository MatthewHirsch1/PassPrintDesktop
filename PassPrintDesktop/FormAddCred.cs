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
    public partial class FormAddCred : Form
    {
        public FormAddCred()
        {
            InitializeComponent();
            this.Select(); // Added this so first textbox isn't auto selected when this form is shown            
        }

        private void txtAccountName_Enter(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "e.g., gmail.com, yahoo.com, etc...")
            {
                txtAccountName.Text = "";
                txtAccountName.ForeColor = Color.Black;
            }
        }

        private void txtAccountName_Leave(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                txtAccountName.Text = "e.g., gmail.com, yahoo.com, etc...";
                txtAccountName.ForeColor = Color.DarkGray;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "someone@example.com")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "someone@example.com";
                txtUsername.ForeColor = Color.DarkGray;
            }
        }

        private void btnOKAddCred_Click(object sender, EventArgs e)
        {
            String pwd = txtPassword.Text;
            String confirmPwd = txtPasswordConfirm.Text;
            if (pwd.Equals(confirmPwd))
            {
                // TO-DO: Need to encrypt uname and pwd before sending over to Arduino
                Variables.serialBluetooth.Write("Adding Credentials%");
                Variables.serialBluetooth.Write("Testing comm");
                String incData = Variables.serialBluetooth.ReadLine();
                MessageBox.Show(incData, "From BT through Variables class");
            } 
            else // If password was not confirmed
            {
                MessageBox.Show("Please confirm your password. \nPasswords did not match.", "Password Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
