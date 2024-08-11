namespace OnlineStore_PresentationLayer.Main_Screen
{
    partial class frmHomeScreen
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
            this.FpnlMainScreenLoader = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FpnlMainScreenLoader
            // 
            this.FpnlMainScreenLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FpnlMainScreenLoader.Location = new System.Drawing.Point(0, 0);
            this.FpnlMainScreenLoader.Name = "FpnlMainScreenLoader";
            this.FpnlMainScreenLoader.Size = new System.Drawing.Size(1192, 864);
            this.FpnlMainScreenLoader.TabIndex = 0;
            // 
            // frmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 864);
            this.Controls.Add(this.FpnlMainScreenLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeScreen";
            this.Text = "frmHomeScreen";
            this.Load += new System.EventHandler(this.frmHomeScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlMainScreenLoader;
    }
}