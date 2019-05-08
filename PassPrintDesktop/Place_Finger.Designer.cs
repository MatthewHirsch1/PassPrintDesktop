namespace PassPrintDesktop
{
    partial class Place_Finger
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
            this.lblPlace = new System.Windows.Forms.Label();
            this.picboxFP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlace
            // 
            this.lblPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(82, 36);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(755, 55);
            this.lblPlace.TabIndex = 6;
            this.lblPlace.Text = "Place finger on fingerprint scanner";
            this.lblPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxFP
            // 
            this.picboxFP.Image = global::PassPrintDesktop.Properties.Resources.fingerprint;
            this.picboxFP.Location = new System.Drawing.Point(202, 120);
            this.picboxFP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picboxFP.Name = "picboxFP";
            this.picboxFP.Size = new System.Drawing.Size(515, 322);
            this.picboxFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxFP.TabIndex = 5;
            this.picboxFP.TabStop = false;
            // 
            // Place_Finger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 497);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.picboxFP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Place_Finger";
            this.Text = "Place_Finger";
            this.Shown += new System.EventHandler(this.Place_Finger_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picboxFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.PictureBox picboxFP;
    }
}