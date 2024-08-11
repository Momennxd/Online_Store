namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlCartProduct
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
            this.lblProductName = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumOfRatingUsers = new MaterialSkin.Controls.MaterialLabel();
            this.strsAvrgRating = new Bunifu.Framework.UI.BunifuRating();
            this.btnProcessBuying = new MaterialSkin.Controls.MaterialButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnRemove = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoEllipsis = true;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductName.Depth = 0;
            this.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblProductName.Location = new System.Drawing.Point(100, 34);
            this.lblProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(149, 24);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Head Phones X4";
            this.lblProductName.Click += new System.EventHandler(this.ctrlCartProduct_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Depth = 0;
            this.lblPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblPrice.Location = new System.Drawing.Point(937, 38);
            this.lblPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 24);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "59.99$";
            // 
            // lblNumOfRatingUsers
            // 
            this.lblNumOfRatingUsers.AutoSize = true;
            this.lblNumOfRatingUsers.Depth = 0;
            this.lblNumOfRatingUsers.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumOfRatingUsers.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblNumOfRatingUsers.Location = new System.Drawing.Point(669, 41);
            this.lblNumOfRatingUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumOfRatingUsers.Name = "lblNumOfRatingUsers";
            this.lblNumOfRatingUsers.Size = new System.Drawing.Size(27, 17);
            this.lblNumOfRatingUsers.TabIndex = 5;
            this.lblNumOfRatingUsers.Text = "(20)";
            // 
            // strsAvrgRating
            // 
            this.strsAvrgRating.BackColor = System.Drawing.Color.Transparent;
            this.strsAvrgRating.Enabled = false;
            this.strsAvrgRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(172)))), ((int)(((byte)(10)))));
            this.strsAvrgRating.Location = new System.Drawing.Point(560, 39);
            this.strsAvrgRating.Name = "strsAvrgRating";
            this.strsAvrgRating.Size = new System.Drawing.Size(103, 19);
            this.strsAvrgRating.TabIndex = 6;
            this.strsAvrgRating.Value = 4;
            // 
            // btnProcessBuying
            // 
            this.btnProcessBuying.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcessBuying.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProcessBuying.Depth = 0;
            this.btnProcessBuying.HighEmphasis = true;
            this.btnProcessBuying.Icon = null;
            this.btnProcessBuying.Location = new System.Drawing.Point(1048, 31);
            this.btnProcessBuying.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcessBuying.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcessBuying.Name = "btnProcessBuying";
            this.btnProcessBuying.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProcessBuying.Size = new System.Drawing.Size(152, 36);
            this.btnProcessBuying.TabIndex = 7;
            this.btnProcessBuying.Text = "Proccess Buying";
            this.btnProcessBuying.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProcessBuying.UseAccentColor = false;
            this.btnProcessBuying.UseVisualStyleBackColor = true;
            this.btnProcessBuying.Click += new System.EventHandler(this.btnProcessBuying_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_remove_96;
            this.btnRemove.ImageActive = null;
            this.btnRemove.Location = new System.Drawing.Point(1218, 28);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(36, 41);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemove.TabIndex = 9;
            this.btnRemove.TabStop = false;
            this.btnRemove.Zoom = 12;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductImage.Image = global::OnlineStore_PresentationLayer.Properties.Resources.error2;
            this.pbProductImage.Location = new System.Drawing.Point(4, 3);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(85, 85);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 1;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.ctrlCartProduct_Click);
            // 
            // ctrlCartProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnProcessBuying);
            this.Controls.Add(this.lblNumOfRatingUsers);
            this.Controls.Add(this.strsAvrgRating);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pbProductImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ctrlCartProduct";
            this.Size = new System.Drawing.Size(1266, 92);
            this.Click += new System.EventHandler(this.ctrlCartProduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbProductImage;
        public MaterialSkin.Controls.MaterialLabel lblProductName;
        public MaterialSkin.Controls.MaterialLabel lblPrice;
        public MaterialSkin.Controls.MaterialLabel lblNumOfRatingUsers;
        public Bunifu.Framework.UI.BunifuRating strsAvrgRating;
        private MaterialSkin.Controls.MaterialButton btnProcessBuying;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnRemove;
    }
}
