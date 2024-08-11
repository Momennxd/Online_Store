namespace OnlineStore_PresentationLayer.Categories
{
    partial class frmCategories
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
            this.FpnlCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FpnlCategories
            // 
            this.FpnlCategories.AutoScroll = true;
            this.FpnlCategories.BackColor = System.Drawing.Color.White;
            this.FpnlCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FpnlCategories.Location = new System.Drawing.Point(0, 0);
            this.FpnlCategories.Name = "FpnlCategories";
            this.FpnlCategories.Size = new System.Drawing.Size(1190, 864);
            this.FpnlCategories.TabIndex = 0;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 864);
            this.Controls.Add(this.FpnlCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlCategories;
    }
}