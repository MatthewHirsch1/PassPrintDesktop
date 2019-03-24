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
            // If any of the four text boxes are empty, inform user
            if ((txtAccountName.Text == "e.g., gmail.com, yahoo.com, etc..." && txtAccountName.ForeColor == Color.DarkGray) || (txtUsername.Text == "someone@example.com" && txtUsername.ForeColor == Color.DarkGray) || txtPassword.Text == "" || txtPasswordConfirm.Text == "")
            {
                if (!lblAccountName.Text.Contains("*")) { lblAccountName.Text += "*"; }
                if (!lblUsername.Text.Contains("*")) { lblUsername.Text += "*"; }
                if (!lblPassword.Text.Contains("*")) { lblPassword.Text += "*"; }
                if (!lblConfirmPassword.Text.Contains("*")) { lblConfirmPassword.Text += "*"; }
                lblRequiredFields.Text = "Please fill in all required (*) fields";
                return;
            }

            String pwd = txtPassword.Text;
            String confirmPwd = txtPasswordConfirm.Text;
            if (pwd.Equals(confirmPwd)) // If passwords match, proceed
            {
                String siteName = txtAccountName.Text;
                String userName = txtUsername.Text;

                // TO-DO: Need to encrypt uname and pwd before sending over to Arduino
                // TO-DO: Pop up Success or Failure Form for result of FP Auth
                // TO-DO: Remove Asterisk (*) from the 4 labels' Text elements after Auth is done
                // TO-DO: reset lblRequiredFields after Auth is done

                Variables.serialBluetooth.Write("Add Credential%");
                Variables.serialBluetooth.Write(siteName + ":");
                Variables.serialBluetooth.Write(userName + ":");
                Variables.serialBluetooth.Write(pwd + ":");
                //String incData = Variables.serialBluetooth.ReadLine();
                //MessageBox.Show(incData, "From BT through Variables class");
                // Close form once adding credential is complete
                this.Close();
            } 
            else // If password was not confirmed, prevent user from proceeding until it matches
            {
                MessageBox.Show("Please confirm your password. \nPasswords did not match.", "Password Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
