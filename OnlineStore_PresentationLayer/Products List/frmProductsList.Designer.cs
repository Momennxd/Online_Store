namespace OnlineStore_PresentationLayer.Products_List
{
    partial class frmProductsList
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
            this.FpnlProductsLoader = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmptyProducts = new System.Windows.Forms.Label();
            this.FpnlFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FpnlProductsLoader
            // 
            this.FpnlProductsLoader.AutoScroll = true;
            this.FpnlProductsLoader.BackColor = System.Drawing.Color.White;
            this.FpnlProductsLoader.Location = new System.Drawing.Point(201, 38);
            this.FpnlProductsLoader.Name = "FpnlProductsLoader";
            this.FpnlProductsLoader.Size = new System.Drawing.Size(1073, 826);
            this.FpnlProductsLoader.TabIndex = 0;
            // 
            // lblEmptyProducts
            // 
            this.lblEmptyProducts.AutoSize = true;
            this.lblEmptyProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmptyProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyProducts.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmptyProducts.Location = new System.Drawing.Point(492, 10);
            this.lblEmptyProducts.Name = "lblEmptyProducts";
            this.lblEmptyProducts.Size = new System.Drawing.Size(242, 20);
            this.lblEmptyProducts.TabIndex = 1;
            this.lblEmptyProducts.Text = "There Are No Products Here Yet!";
            this.lblEmptyProducts.Visible = false;
            // 
            // FpnlFilter
            // 
            this.FpnlFilter.Location = new System.Drawing.Point(4, 38);
            this.FpnlFilter.Name = "FpnlFilter";
            this.FpnlFilter.Size = new System.Drawing.Size(194, 826);
            this.FpnlFilter.TabIndex = 2;
            // 
            // frmProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 864);
            this.Controls.Add(this.FpnlFilter);
            this.Controls.Add(this.lblEmptyProducts);
            this.Controls.Add(this.FpnlProductsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductsList";
            this.Text = "frmProductsList";
            this.Load += new System.EventHandler(this.frmProductsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlProductsLoader;
        private System.Windows.Forms.Label lblEmptyProducts;
        private System.Windows.Forms.FlowLayoutPanel FpnlFilter;
    }
}