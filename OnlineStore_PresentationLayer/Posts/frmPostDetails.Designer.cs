namespace OnlineStore_PresentationLayer.Posts
{
    partial class frmPostDetails
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
            this.FpnlPostDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FpnlPostDetails
            // 
            this.FpnlPostDetails.AutoScroll = true;
            this.FpnlPostDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FpnlPostDetails.Location = new System.Drawing.Point(0, 0);
            this.FpnlPostDetails.Name = "FpnlPostDetails";
            this.FpnlPostDetails.Size = new System.Drawing.Size(1074, 705);
            this.FpnlPostDetails.TabIndex = 0;
            // 
            // frmPostDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 705);
            this.Controls.Add(this.FpnlPostDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPostDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPostDetails";
            this.Load += new System.EventHandler(this.frmPostDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlPostDetails;
    }
}