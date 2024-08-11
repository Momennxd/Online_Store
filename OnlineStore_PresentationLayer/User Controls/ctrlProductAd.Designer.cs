namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlProductAd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlProductAd));
            this.pbAdPic = new System.Windows.Forms.PictureBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtAdDescription = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnShopNow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.klblSellerName = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAdPic
            // 
            this.pbAdPic.Image = global::OnlineStore_PresentationLayer.Properties.Resources._6dbff394b1befb2efda157fbd1f0be21;
            this.pbAdPic.Location = new System.Drawing.Point(3, 3);
            this.pbAdPic.Name = "pbAdPic";
            this.pbAdPic.Size = new System.Drawing.Size(590, 524);
            this.pbAdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdPic.TabIndex = 0;
            this.pbAdPic.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Location = new System.Drawing.Point(603, 42);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(472, 102);
            this.txtProductName.TabIndex = 7;
            this.txtProductName.Text = "Prada T-Shirt\r\nLatest";
            // 
            // txtAdDescription
            // 
            this.txtAdDescription.BackColor = System.Drawing.Color.White;
            this.txtAdDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdDescription.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtAdDescription.ForeColor = System.Drawing.Color.Black;
            this.txtAdDescription.Location = new System.Drawing.Point(615, 150);
            this.txtAdDescription.Multiline = true;
            this.txtAdDescription.Name = "txtAdDescription";
            this.txtAdDescription.ReadOnly = true;
            this.txtAdDescription.Size = new System.Drawing.Size(472, 273);
            this.txtAdDescription.TabIndex = 8;
            this.txtAdDescription.Text = resources.GetString("txtAdDescription.Text");
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.ActiveBorderThickness = 2;
            this.btnAddToCart.ActiveCornerRadius = 20;
            this.btnAddToCart.ActiveFillColor = System.Drawing.Color.Black;
            this.btnAddToCart.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddToCart.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAddToCart.BackColor = System.Drawing.Color.White;
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.ButtonText = "Add To Cart";
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.IdleBorderThickness = 2;
            this.btnAddToCart.IdleCornerRadius = 20;
            this.btnAddToCart.IdleFillColor = System.Drawing.Color.White;
            this.btnAddToCart.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddToCart.IdleLineColor = System.Drawing.Color.Black;
            this.btnAddToCart.Location = new System.Drawing.Point(918, 430);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(190, 52);
            this.btnAddToCart.TabIndex = 16;
            this.btnAddToCart.Tag = "0";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnShopNow
            // 
            this.btnShopNow.ActiveBorderThickness = 1;
            this.btnShopNow.ActiveCornerRadius = 20;
            this.btnShopNow.ActiveFillColor = System.Drawing.Color.Black;
            this.btnShopNow.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnShopNow.ActiveLineColor = System.Drawing.Color.Black;
            this.btnShopNow.BackColor = System.Drawing.Color.White;
            this.btnShopNow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShopNow.BackgroundImage")));
            this.btnShopNow.ButtonText = "SHOP NOW";
            this.btnShopNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShopNow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopNow.ForeColor = System.Drawing.Color.White;
            this.btnShopNow.IdleBorderThickness = 1;
            this.btnShopNow.IdleCornerRadius = 20;
            this.btnShopNow.IdleFillColor = System.Drawing.Color.Black;
            this.btnShopNow.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.btnShopNow.IdleLineColor = System.Drawing.Color.Black;
            this.btnShopNow.Location = new System.Drawing.Point(660, 430);
            this.btnShopNow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnShopNow.Name = "btnShopNow";
            this.btnShopNow.Size = new System.Drawing.Size(192, 52);
            this.btnShopNow.TabIndex = 15;
            this.btnShopNow.Tag = "0";
            this.btnShopNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShopNow.Click += new System.EventHandler(this.btnShopNow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(773, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "This Advertisment Is Posted By";
            // 
            // klblSellerName
            // 
            this.klblSellerName.AutoSize = true;
            this.klblSellerName.LinkColor = System.Drawing.Color.Black;
            this.klblSellerName.Location = new System.Drawing.Point(942, 512);
            this.klblSellerName.Name = "klblSellerName";
            this.klblSellerName.Size = new System.Drawing.Size(67, 13);
            this.klblSellerName.TabIndex = 18;
            this.klblSellerName.TabStop = true;
            this.klblSellerName.Text = "Momen Nasr";
            this.klblSellerName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.klblSellerName_LinkClicked);
            // 
            // ctrlProductAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.klblSellerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnShopNow);
            this.Controls.Add(this.txtAdDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.pbAdPic);
            this.Name = "ctrlProductAd";
            this.Size = new System.Drawing.Size(1182, 528);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAdPic;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtAdDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddToCart;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShopNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel klblSellerName;
    }
}
