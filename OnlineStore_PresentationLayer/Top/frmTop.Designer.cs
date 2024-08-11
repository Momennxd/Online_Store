namespace OnlineStore_PresentationLayer.Top
{
    partial class frmTop
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
            this.FpnlProductsAdsLoader = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FpnlProductsAdsLoader
            // 
            this.FpnlProductsAdsLoader.AutoScroll = true;
            this.FpnlProductsAdsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FpnlProductsAdsLoader.Location = new System.Drawing.Point(0, 0);
            this.FpnlProductsAdsLoader.Name = "FpnlProductsAdsLoader";
            this.FpnlProductsAdsLoader.Size = new System.Drawing.Size(1250, 864);
            this.FpnlProductsAdsLoader.TabIndex = 0;
            // 
            // frmTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 864);
            this.Controls.Add(this.FpnlProductsAdsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTop";
            this.Text = "frmTop";
            this.Load += new System.EventHandler(this.frmTop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlProductsAdsLoader;
    }
}