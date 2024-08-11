namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlManageProducts
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
            this.components = new System.ComponentModel.Container();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.color = System.Drawing.Color.Transparent;
            this.btnAddProduct.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Image = global::OnlineStore_PresentationLayer.Properties.Resources.add_cart;
            this.btnAddProduct.ImagePosition = 20;
            this.btnAddProduct.ImageZoom = 50;
            this.btnAddProduct.LabelPosition = 41;
            this.btnAddProduct.LabelText = "Add a Product";
            this.btnAddProduct.Location = new System.Drawing.Point(515, 6);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(226, 203);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ctrlManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddProduct);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ctrlManageProducts";
            this.Size = new System.Drawing.Size(1250, 219);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnAddProduct;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
