namespace PassPrintDesktop
{
    partial class FormMainMenu
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnAddFP = new System.Windows.Forms.Button();
            this.btnRemoveFP = new System.Windows.Forms.Button();
            this.btnAddCred = new System.Windows.Forms.Button();
            this.btnEditDelCred = new System.Windows.Forms.Button();
            this.btnConnectBT = new System.Windows.Forms.Button();
            this.lblConnectSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(150, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(495, 55);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to PassPrint";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(276, 122);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(262, 48);
            this.lblMainMenu.TabIndex = 1;
            this.lblMainMenu.Text = "Main Menu";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddFP
            // 
            this.btnAddFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFP.Location = new System.Drawing.Point(161, 172);
            this.btnAddFP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFP.Name = "btnAddFP";
            this.btnAddFP.Size = new System.Drawing.Size(490, 75);
            this.btnAddFP.TabIndex = 2;
            this.btnAddFP.Text = "Add a Fingerprint";
            this.btnAddFP.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFP
            // 
            this.btnRemoveFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFP.Location = new System.Drawing.Point(161, 254);
            this.btnRemoveFP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFP.Name = "btnRemoveFP";
            this.btnRemoveFP.Size = new System.Drawing.Size(490, 75);
            this.btnRemoveFP.TabIndex = 3;
            this.btnRemoveFP.Text = "Remove a Fingerprint";
            this.btnRemoveFP.UseVisualStyleBackColor = true;
            // 
            // btnAddCred
            // 
            this.btnAddCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCred.Location = new System.Drawing.Point(161, 335);
            this.btnAddCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCred.Name = "btnAddCred";
            this.btnAddCred.Size = new System.Drawing.Size(490, 75);
            this.btnAddCred.TabIndex = 4;
            this.btnAddCred.Text = "Add Credential";
            this.btnAddCred.UseVisualStyleBackColor = true;
            this.btnAddCred.Click += new System.EventHandler(this.btnAddCred_Click);
            // 
            // btnEditDelCred
            // 
            this.btnEditDelCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDelCred.Location = new System.Drawing.Point(161, 416);
            this.btnEditDelCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditDelCred.Name = "btnEditDelCred";
            this.btnEditDelCred.Size = new System.Drawing.Size(490, 75);
            this.btnEditDelCred.TabIndex = 5;
            this.btnEditDelCred.Text = "Edit / Delete Credentials";
            this.btnEditDelCred.UseVisualStyleBackColor = true;
            this.btnEditDelCred.Click += new System.EventHandler(this.btnEditDelCred_Click);
            // 
            // btnConnectBT
            // 
            this.btnConnectBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectBT.Location = new System.Drawing.Point(44, 542);
            this.btnConnectBT.Name = "btnConnectBT";
            this.btnConnectBT.Size = new System.Drawing.Size(325, 57);
            this.btnConnectBT.TabIndex = 6;
            this.btnConnectBT.Text = "Connect Bluetooth";
            this.btnConnectBT.UseVisualStyleBackColor = true;
            this.btnConnectBT.Click += new System.EventHandler(this.btnConnectBT_Click);
            // 
            // lblConnectSuccess
            // 
            this.lblConnectSuccess.AutoSize = true;
            this.lblConnectSuccess.BackColor = System.Drawing.Color.YellowGreen;
            this.lblConnectSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectSuccess.Location = new System.Drawing.Point(375, 546);
            this.lblConnectSuccess.Name = "lblConnectSuccess";
            this.lblConnectSuccess.Size = new System.Drawing.Size(0, 46);
            this.lblConnectSuccess.TabIndex = 7;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 642);
            this.Controls.Add(this.lblConnectSuccess);
            this.Controls.Add(this.btnConnectBT);
            this.Controls.Add(this.btnEditDelCred);
            this.Controls.Add(this.btnAddCred);
            this.Controls.Add(this.btnRemoveFP);
            this.Controls.Add(this.btnAddFP);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMainMenu";
            this.Text = "PassPrint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnAddFP;
        private System.Windows.Forms.Button btnRemoveFP;
        private System.Windows.Forms.Button btnAddCred;
        private System.Windows.Forms.Button btnEditDelCred;
        private System.Windows.Forms.Button btnConnectBT;
        private System.Windows.Forms.Label lblConnectSuccess;
    }
}

