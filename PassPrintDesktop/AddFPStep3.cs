﻿using System;
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
    public partial class AddFPStep3 : Form
    {
        public AddFPStep3()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            this.Close();
            var form3 = new AddFP();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
