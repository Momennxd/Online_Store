namespace OnlineStore_PresentationLayer.Products_List
{
    partial class frmProductDetails
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
            this.FpnlProductDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FpnlProductDetails
            // 
            this.FpnlProductDetails.AutoScroll = true;
            this.FpnlProductDetails.Location = new System.Drawing.Point(33, 0);
            this.FpnlProductDetails.Name = "FpnlProductDetails";
            this.FpnlProductDetails.Size = new System.Drawing.Size(1241, 864);
            this.FpnlProductDetails.TabIndex = 0;
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1275, 864);
            this.Controls.Add(this.FpnlProductDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductDetails";
            this.Text = "frmProductDetails";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlProductDetails;
    }
}