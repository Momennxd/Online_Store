namespace OnlineStore_PresentationLayer.User_Profile
{
    partial class frmUserProfile
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
            this.FpnlUserProfileElements = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FpnlUserProfileElements
            // 
            this.FpnlUserProfileElements.AutoScroll = true;
            this.FpnlUserProfileElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FpnlUserProfileElements.Location = new System.Drawing.Point(0, 0);
            this.FpnlUserProfileElements.Name = "FpnlUserProfileElements";
            this.FpnlUserProfileElements.Size = new System.Drawing.Size(1275, 864);
            this.FpnlUserProfileElements.TabIndex = 0;
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 864);
            this.Controls.Add(this.FpnlUserProfileElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserProfile";
            this.Text = "frmUserProfile";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlUserProfileElements;
    }
}