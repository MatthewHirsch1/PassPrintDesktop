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
        List<string[]> credList = new List<string[]>(); // Will hold credentials locally for saving changes
        public FormEditDelCred()
        {
            InitializeComponent();

            //this.dataGridViewCreds.Rows.Add("gmail.com", "bob123@gmail.com", "456");
            //this.dataGridViewCreds.Rows.Add("yahoo.com", "bob123@yahoo.com", "123");
            //this.dataGridViewCreds.Rows.Add("ask.com", "bob123@ask.com", "789");
            //this.dataGridViewCreds.Rows.Add("aol.com", "bob123@aol.com", "321");
            //this.dataGridViewCreds.Rows.Add("outlook.com", "bob123@outlook.com", "123456");
            //Variables.serialBluetooth.ReadExisting();
            Variables.serialBluetooth.Write("Retrieve Credentials%");
            //string strCreds = "0";
            //try
            //{
            //    strCreds = Variables.serialBluetooth.ReadLine();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("You have no credentials to manage.", "No Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //this.Close();
            //}
            string strCreds = Variables.serialBluetooth.ReadLine();
            int numCreds = 0;
            try
            {
                numCreds = Int32.Parse(strCreds);
            }
            catch (Exception) { MessageBox.Show("String: " + strCreds, "test"); }
            //string num2 = "";
            //MessageBox.Show("String: " + strCreds + "\nint: " + numCreds, "test");
            //int num = 1;
            for (int i = 0; i < numCreds; i++)
            {
                String cred = Variables.serialBluetooth.ReadLine();
                string[] arrCred = cred.Split(':');
                credList.Add(arrCred); // Add cred to arraylist
                //MessageBox.Show("Account: " + arrCreds[0] + " Username: " + arrCreds[1] + " Pwd: " + arrCreds[2], "test");
                this.dataGridViewCreds.Rows.Add(arrCred[0], arrCred[1], arrCred[2]);
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
                if (e.ColumnIndex == 3)
                { // Save column
                    //MessageBox.Show("Save Changes: Button on row " + e.RowIndex + " clicked\n" + (string)dataGridViewCreds[0, e.RowIndex].Value, "Test Save Changes");
                    string[] cred = credList[e.RowIndex];
                    //MessageBox.Show("OLD: " + cred[0] + ":" + cred[1] + ":" + cred[2] + ":\n" + "NEW: " + (string)dataGridViewCreds[0, e.RowIndex].Value + ":" + (string)dataGridViewCreds[1, e.RowIndex].Value + ":" + (string)dataGridViewCreds[2, e.RowIndex].Value + ":", "test");
                    //MessageBox.Show("NEW: " + (string)dataGridViewCreds[0, e.RowIndex].Value + ":" + (string)dataGridViewCreds[0, e.RowIndex].Value + ":" + (string)dataGridViewCreds[0, e.RowIndex].Value + ":", "test");

                    // TO-DO: Need auth FP for action
                    // TO-DO: Encrypt data before sending to Arduino
                    new Place_Finger().Show(); // Authenticate action
                    Variables.serialBluetooth.Write("Save Credential%");
                    // Send old credential to be removed from file
                    Variables.serialBluetooth.Write(cred[0] + ":");
                    Variables.serialBluetooth.Write(cred[1] + ":");
                    Variables.serialBluetooth.Write(cred[2] + ":");
                    // Send new credential to be added to file
                    Variables.serialBluetooth.Write((string)dataGridViewCreds[0, e.RowIndex].Value + ":");
                    Variables.serialBluetooth.Write((string)dataGridViewCreds[1, e.RowIndex].Value + ":");
                    Variables.serialBluetooth.Write((string)dataGridViewCreds[2, e.RowIndex].Value + ":");

                }
                else // Delete column
                {
                    // TO-DO: Need auth FP for action
                    //MessageBox.Show("Delete: Button on row " + e.RowIndex + " clicked\n" + senderGrid.Columns, "Test Delete");
                    string[] cred = credList[e.RowIndex];
                    new Place_Finger().Show(); // Authenticate action
                    Variables.serialBluetooth.Write("Delete Credential%");
                    Variables.serialBluetooth.Write(cred[0] + ":");
                    Variables.serialBluetooth.Write(cred[1] + ":");
                    Variables.serialBluetooth.Write(cred[2] + ":");
                    this.dataGridViewCreds.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridViewCreds_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
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
