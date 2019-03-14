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
    public partial class FormAddCred : Form
    {
        public FormAddCred()
        {
            InitializeComponent();
            this.Select();
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
    }
}
