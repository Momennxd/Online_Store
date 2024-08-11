namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlProductThumbNail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlProductThumbNail));
            this.pnlImage = new System.Windows.Forms.Panel();
            this.btnHeart = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblProductName = new MaterialSkin.Controls.MaterialLabel();
            this.pnlProductName = new System.Windows.Forms.Panel();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lblPrice = new MaterialSkin.Controls.MaterialLabel();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.strsAvrgRating = new Bunifu.Framework.UI.BunifuRating();
            this.lblNumOfRatingUsers = new MaterialSkin.Controls.MaterialLabel();
            this.lblInStock = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAddToCart = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.pnlProductName.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.White;
            this.pnlImage.Controls.Add(this.btnHeart);
            this.pnlImage.Controls.Add(this.pbProductImage);
            this.pnlImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlImage.Location = new System.Drawing.Point(3, 2);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(274, 267);
            this.pnlImage.TabIndex = 0;
            this.pnlImage.Click += new System.EventHandler(this.pbProduct_Click);
            // 
            // btnHeart
            // 
            this.btnHeart.BackColor = System.Drawing.Color.White;
            this.btnHeart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeart.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_heart_48__1_1;
            this.btnHeart.ImageActive = null;
            this.btnHeart.Location = new System.Drawing.Point(236, 4);
            this.btnHeart.Name = "btnHeart";
            this.btnHeart.Size = new System.Drawing.Size(27, 27);
            this.btnHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeart.TabIndex = 9;
            this.btnHeart.TabStop = false;
            this.btnHeart.Tag = "0";
            this.btnHeart.Zoom = 12;
            this.btnHeart.Click += new System.EventHandler(this.btnHeart_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductImage.Image = global::OnlineStore_PresentationLayer.Properties.Resources.error;
            this.pbProductImage.Location = new System.Drawing.Point(0, 3);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(233, 233);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.pbProduct_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoEllipsis = true;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Depth = 0;
            this.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductName.Location = new System.Drawing.Point(5, 6);
            this.lblProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(118, 19);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Head Phones X4";
            // 
            // pnlProductName
            // 
            this.pnlProductName.Controls.Add(this.lblProductName);
            this.pnlProductName.Location = new System.Drawing.Point(3, 273);
            this.pnlProductName.Name = "pnlProductName";
            this.pnlProductName.Size = new System.Drawing.Size(176, 30);
            this.pnlProductName.TabIndex = 2;
            // 
            // pnlPrice
            // 
            this.pnlPrice.Controls.Add(this.lblPrice);
            this.pnlPrice.Location = new System.Drawing.Point(196, 273);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(78, 30);
            this.pnlPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Depth = 0;
            this.lblPrice.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblPrice.Location = new System.Drawing.Point(9, 5);
            this.lblPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "59.99$";
            // 
            // pnlDescription
            // 
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Location = new System.Drawing.Point(3, 301);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(274, 35);
            this.pnlDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescription.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblDescription.Location = new System.Drawing.Point(5, 6);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(1, 0);
            this.lblDescription.TabIndex = 1;
            // 
            // strsAvrgRating
            // 
            this.strsAvrgRating.BackColor = System.Drawing.Color.Transparent;
            this.strsAvrgRating.Enabled = false;
            this.strsAvrgRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(172)))), ((int)(((byte)(10)))));
            this.strsAvrgRating.Location = new System.Drawing.Point(7, 340);
            this.strsAvrgRating.Name = "strsAvrgRating";
            this.strsAvrgRating.Size = new System.Drawing.Size(94, 14);
            this.strsAvrgRating.TabIndex = 4;
            this.strsAvrgRating.Value = 4;
            // 
            // lblNumOfRatingUsers
            // 
            this.lblNumOfRatingUsers.AutoSize = true;
            this.lblNumOfRatingUsers.Depth = 0;
            this.lblNumOfRatingUsers.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumOfRatingUsers.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.lblNumOfRatingUsers.Location = new System.Drawing.Point(107, 342);
            this.lblNumOfRatingUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumOfRatingUsers.Name = "lblNumOfRatingUsers";
            this.lblNumOfRatingUsers.Size = new System.Drawing.Size(19, 13);
            this.lblNumOfRatingUsers.TabIndex = 2;
            this.lblNumOfRatingUsers.Text = "(20)";
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(20)))));
            this.lblInStock.Location = new System.Drawing.Point(190, 342);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(55, 13);
            this.lblInStock.TabIndex = 10;
            this.lblInStock.Text = "In Stock";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 9;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.ActiveBorderThickness = 1;
            this.btnAddToCart.ActiveCornerRadius = 20;
            this.btnAddToCart.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(41)))));
            this.btnAddToCart.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddToCart.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(41)))));
            this.btnAddToCart.BackColor = System.Drawing.Color.White;
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.ButtonText = "Add To Cart";
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.IdleBorderThickness = 1;
            this.btnAddToCart.IdleCornerRadius = 20;
            this.btnAddToCart.IdleFillColor = System.Drawing.Color.White;
            this.btnAddToCart.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddToCart.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(41)))));
            this.btnAddToCart.Location = new System.Drawing.Point(4, 360);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(122, 42);
            this.btnAddToCart.TabIndex = 12;
            this.btnAddToCart.Tag = "0";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // ctrlProductThumbNail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblInStock);
            this.Controls.Add(this.lblNumOfRatingUsers);
            this.Controls.Add(this.strsAvrgRating);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.pnlPrice);
            this.Controls.Add(this.pnlProductName);
            this.Controls.Add(this.pnlImage);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ctrlProductThumbNail";
            this.Size = new System.Drawing.Size(277, 406);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.pnlProductName.ResumeLayout(false);
            this.pnlProductName.PerformLayout();
            this.pnlPrice.ResumeLayout(false);
            this.pnlPrice.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Panel pnlProductName;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Panel pnlDescription;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuImageButton btnHeart;
        public Bunifu.Framework.UI.BunifuThinButton2 btnAddToCart;
        public System.Windows.Forms.PictureBox pbProductImage;
        public MaterialSkin.Controls.MaterialLabel lblProductName;
        public MaterialSkin.Controls.MaterialLabel lblPrice;
        public MaterialSkin.Controls.MaterialLabel lblDescription;
        public Bunifu.Framework.UI.BunifuRating strsAvrgRating;
        public MaterialSkin.Controls.MaterialLabel lblNumOfRatingUsers;
        public System.Windows.Forms.Label lblInStock;
    }
}
