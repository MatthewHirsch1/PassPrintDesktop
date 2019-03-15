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
    public partial class FormEditDelCred : Form
    {
        public FormEditDelCred()
        {
            InitializeComponent();

            //this.dataGridViewCreds.Rows.Add("gmail.com", "bob123@gmail.com", "456");
            //this.dataGridViewCreds.Rows.Add("yahoo.com", "bob123@yahoo.com", "123");
            //this.dataGridViewCreds.Rows.Add("ask.com", "bob123@ask.com", "789");
            //this.dataGridViewCreds.Rows.Add("aol.com", "bob123@aol.com", "321");
            //this.dataGridViewCreds.Rows.Add("outlook.com", "bob123@outlook.com", "123456");
            Variables.serialBluetooth.Write("Retrieve Credentials%");
            //while (Variables.serialBluetooth.DataReceived())
            //{

            //}
            int numCreds = Int32.Parse(Variables.serialBluetooth.ReadLine());
            //int num = Int32.Parse(numCreds);
            //string num2 = "";
            //MessageBox.Show("String: " + numCreds + "\nint: " + num, "test");
            //int num = 1;
            for (int i = 0; i < numCreds; i++)
            {
                String cred = Variables.serialBluetooth.ReadLine();
                string[] arrCreds = cred.Split(':');
                //MessageBox.Show("Account: " + arrCreds[0] + " Username: " + arrCreds[1] + " Pwd: " + arrCreds[2], "test");
                this.dataGridViewCreds.Rows.Add(arrCreds[0], arrCreds[1], arrCreds[2]);
            }

            //String f1 = Variables.serialBluetooth.ReadLine();
            //String f2 = Variables.serialBluetooth.ReadLine();
            //String f3 = Variables.serialBluetooth.ReadLine();
            //String f4 = Variables.serialBluetooth.ReadLine();
            //String fileContents = f1 + f2 + f3 + f4;
            //MessageBox.Show(fileContents, "I hope this works");
            this.Select();
        }

        private void dataGridViewCreds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3) { // Save changes column
                    MessageBox.Show("Save Changes: Button on row " + e.RowIndex + " clicked\n" + (string)dataGridViewCreds[0, e.RowIndex].Value, "Test Save Changes");
                }
                else // Delete column
                {
                    MessageBox.Show("Delete: Button on row " + e.RowIndex + " clicked\n" + senderGrid.Columns, "Test Delete");
                }
            }
        }

        private void dataGridViewCreds_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                //{
                //    if (e.Value != null)
                //    {
                //        e.Value = new string('\u25CF', e.Value.ToString().Length);
                //    }
                //    else { e.Value = "Null"; }
                //}

                dataGridViewCreds.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }     
        }

        private void dataGridViewCreds_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewCreds.CurrentCell.ColumnIndex == 2)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
            else
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }
    }
}
