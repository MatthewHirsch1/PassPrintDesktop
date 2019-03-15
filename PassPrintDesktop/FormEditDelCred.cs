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
            
            this.dataGridViewCreds.Rows.Add("gmail.com", "bob123@gmail.com","456");
            this.dataGridViewCreds.Rows.Add("yahoo.com", "bob123@yahoo.com", "123");
            this.dataGridViewCreds.Rows.Add("ask.com", "bob123@ask.com", "789");
            this.dataGridViewCreds.Rows.Add("aol.com", "bob123@aol.com", "321");
            this.dataGridViewCreds.Rows.Add("outlook.com", "bob123@outlook.com", "123456");
            this.Select();
        }

        private void dataGridViewCreds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //if (e.ColumnIndex == this.dataGridViewCreds.Columns["SaveChanges"].Index && e.RowIndex >= 0)
            //{
            //    MessageBox.Show("Save Changes: Button on row " + e.RowIndex + " clicked", "Test Save Changes");
            //}
            //if (e.ColumnIndex == dataGridViewCreds.Columns["Delete"].Index && e.RowIndex >= 0)
            //{
            //    MessageBox.Show("Save Changes: Button on row " + e.RowIndex + " clicked", "Test Save Changes");
            //}
            //}
            //catch (Exception) { return;  }

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3) { // Save changes column
                    MessageBox.Show("Save Changes: Button on row " + e.RowIndex + " clicked", "Test Save Changes");
                }
                else
                {
                    MessageBox.Show("Delete: Button on row " + e.RowIndex + " clicked", "Test Delete");
                }
            }
        }
    }
}
