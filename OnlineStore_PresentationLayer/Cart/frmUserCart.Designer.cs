namespace OnlineStore_PresentationLayer.Cart
{
    partial class frmUserCart
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
            this.FpnlCartProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmptyProducts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FpnlCartProducts
            // 
            this.FpnlCartProducts.AutoScroll = true;
            this.FpnlCartProducts.Location = new System.Drawing.Point(1, 53);
            this.FpnlCartProducts.Name = "FpnlCartProducts";
            this.FpnlCartProducts.Size = new System.Drawing.Size(1274, 809);
            this.FpnlCartProducts.TabIndex = 0;
            // 
            // lblEmptyProducts
            // 
            this.lblEmptyProducts.AutoSize = true;
            this.lblEmptyProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmptyProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyProducts.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmptyProducts.Location = new System.Drawing.Point(539, 21);
            this.lblEmptyProducts.Name = "lblEmptyProducts";
            this.lblEmptyProducts.Size = new System.Drawing.Size(147, 20);
            this.lblEmptyProducts.TabIndex = 2;
            this.lblEmptyProducts.Text = "Your Cart Is Empty!";
            this.lblEmptyProducts.Visible = false;
            // 
            // frmUserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 864);
            this.Controls.Add(this.lblEmptyProducts);
            this.Controls.Add(this.FpnlCartProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserCart";
            this.Text = "frmUserCart";
            this.Load += new System.EventHandler(this.frmUserCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlCartProducts;
        private System.Windows.Forms.Label lblEmptyProducts;
    }
}