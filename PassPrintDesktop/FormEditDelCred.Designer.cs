namespace PassPrintDesktop
{
    partial class FormEditDelCred
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblManageCreds = new System.Windows.Forms.Label();
            this.dataGridViewCreds = new System.Windows.Forms.DataGridView();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSave = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreds)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageCreds
            // 
            this.lblManageCreds.Font = new System.Drawing.Font("Arial Unicode MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCreds.Location = new System.Drawing.Point(320, 19);
            this.lblManageCreds.Name = "lblManageCreds";
            this.lblManageCreds.Size = new System.Drawing.Size(532, 61);
            this.lblManageCreds.TabIndex = 3;
            this.lblManageCreds.Text = "Manage Your Credentials";
            this.lblManageCreds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCreds
            // 
            this.dataGridViewCreds.AllowUserToAddRows = false;
            this.dataGridViewCreds.AllowUserToDeleteRows = false;
            this.dataGridViewCreds.AllowUserToOrderColumns = true;
            this.dataGridViewCreds.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCreds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCreds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccount,
            this.colUsername,
            this.colPassword,
            this.colSave,
            this.colDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCreds.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCreds.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewCreds.Name = "dataGridViewCreds";
            this.dataGridViewCreds.RowTemplate.Height = 28;
            this.dataGridViewCreds.Size = new System.Drawing.Size(1156, 639);
            this.dataGridViewCreds.TabIndex = 11;
            this.dataGridViewCreds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCreds_CellContentClick);
            // 
            // colAccount
            // 
            this.colAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAccount.HeaderText = "Account";
            this.colAccount.Name = "colAccount";
            this.colAccount.Width = 144;
            // 
            // colUsername
            // 
            this.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.Width = 167;
            // 
            // colPassword
            // 
            this.colPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 163;
            // 
            // colSave
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.colSave.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colSave.HeaderText = "Save";
            this.colSave.Name = "colSave";
            this.colSave.ReadOnly = true;
            this.colSave.Text = "✔";
            this.colSave.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "🗑️";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // FormEditDelCred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 747);
            this.Controls.Add(this.dataGridViewCreds);
            this.Controls.Add(this.lblManageCreds);
            this.Name = "FormEditDelCred";
            this.Text = "PassPrint";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblManageCreds;
        private System.Windows.Forms.DataGridView dataGridViewCreds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewButtonColumn colSave;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}