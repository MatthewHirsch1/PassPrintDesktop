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
    public partial class Place_Finger : Form
    {

        public static bool fingerOK;

        public Place_Finger()
        {
            InitializeComponent();
            fingerOK = false;
        }



        private void Begin_Click(object sender, EventArgs e)
        {
            fingerOK = Variables.authenticatefunc();
            if (fingerOK)
            {
                this.Close();
                //return Variables.authenticatefunc();

            } // handle false case

            //return Variables.authenticatefunc();

        }
    }
}
