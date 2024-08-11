namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlTopProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FpnlHotProductsLoader = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FpnlHotProductsLoader
            // 
            this.FpnlHotProductsLoader.AutoScroll = true;
            this.FpnlHotProductsLoader.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FpnlHotProductsLoader.Location = new System.Drawing.Point(3, 50);
            this.FpnlHotProductsLoader.Name = "FpnlHotProductsLoader";
            this.FpnlHotProductsLoader.Size = new System.Drawing.Size(1247, 449);
            this.FpnlHotProductsLoader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(122)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popular Products";
            // 
            // ctrlTopProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FpnlHotProductsLoader);
            this.Name = "ctrlTopProducts";
            this.Size = new System.Drawing.Size(1250, 502);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlHotProductsLoader;
        private System.Windows.Forms.Label label1;
    }
}
