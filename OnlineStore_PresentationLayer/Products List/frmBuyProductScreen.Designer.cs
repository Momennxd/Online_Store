namespace OnlineStore_PresentationLayer
{
    partial class frmBuyProductScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblNumOfRatingUsers = new MaterialSkin.Controls.MaterialLabel();
            this.strsAvrgRating = new Bunifu.Framework.UI.BunifuRating();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantityText = new System.Windows.Forms.Label();
            this.lblDeliveringFeeText = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuyNow = new MaterialSkin.Controls.MaterialButton();
            this.txtPIN = new MaterialSkin.Controls.MaterialTextBox();
            this.txtVisaNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbProductPic = new System.Windows.Forms.PictureBox();
            this.nmrcUserQuantity = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUserQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblHeader.Location = new System.Drawing.Point(35, 41);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(331, 31);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Review Item And Shipping";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(261, 109);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(153, 33);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "RTX 4090";
            // 
            // lblNumOfRatingUsers
            // 
            this.lblNumOfRatingUsers.AutoSize = true;
            this.lblNumOfRatingUsers.Depth = 0;
            this.lblNumOfRatingUsers.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumOfRatingUsers.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.lblNumOfRatingUsers.Location = new System.Drawing.Point(367, 157);
            this.lblNumOfRatingUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumOfRatingUsers.Name = "lblNumOfRatingUsers";
            this.lblNumOfRatingUsers.Size = new System.Drawing.Size(19, 13);
            this.lblNumOfRatingUsers.TabIndex = 7;
            this.lblNumOfRatingUsers.Text = "(20)";
            // 
            // strsAvrgRating
            // 
            this.strsAvrgRating.BackColor = System.Drawing.Color.Transparent;
            this.strsAvrgRating.Enabled = false;
            this.strsAvrgRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(172)))), ((int)(((byte)(10)))));
            this.strsAvrgRating.Location = new System.Drawing.Point(267, 155);
            this.strsAvrgRating.Name = "strsAvrgRating";
            this.strsAvrgRating.Size = new System.Drawing.Size(94, 14);
            this.strsAvrgRating.TabIndex = 8;
            this.strsAvrgRating.Value = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(261, 195);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(143, 33);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "$1999.99";
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.AutoSize = true;
            this.lblQuantityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.lblQuantityText.Location = new System.Drawing.Point(264, 241);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(61, 16);
            this.lblQuantityText.TabIndex = 13;
            this.lblQuantityText.Text = "Quantity :";
            // 
            // lblDeliveringFeeText
            // 
            this.lblDeliveringFeeText.AutoEllipsis = true;
            this.lblDeliveringFeeText.AutoSize = true;
            this.lblDeliveringFeeText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeliveringFeeText.Depth = 0;
            this.lblDeliveringFeeText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDeliveringFeeText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeliveringFeeText.Location = new System.Drawing.Point(92, 309);
            this.lblDeliveringFeeText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeliveringFeeText.Name = "lblDeliveringFeeText";
            this.lblDeliveringFeeText.Size = new System.Drawing.Size(147, 19);
            this.lblDeliveringFeeText.TabIndex = 21;
            this.lblDeliveringFeeText.Tag = "Delivering Fee Is";
            this.lblDeliveringFeeText.Text = "Delivering Fee Is $65";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Order Summery";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuyNow);
            this.groupBox1.Controls.Add(this.txtPIN);
            this.groupBox1.Controls.Add(this.txtVisaNumber);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.bunifuSeparator2);
            this.groupBox1.Controls.Add(this.bunifuSeparator1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(585, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 469);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label5.Location = new System.Drawing.Point(25, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "PIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label4.Location = new System.Drawing.Point(19, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Visa Number";
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuyNow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuyNow.Depth = 0;
            this.btnBuyNow.HighEmphasis = true;
            this.btnBuyNow.Icon = null;
            this.btnBuyNow.Location = new System.Drawing.Point(32, 418);
            this.btnBuyNow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuyNow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuyNow.Size = new System.Drawing.Size(86, 36);
            this.btnBuyNow.TabIndex = 29;
            this.btnBuyNow.Text = "Buy Now";
            this.btnBuyNow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuyNow.UseAccentColor = false;
            this.btnBuyNow.UseVisualStyleBackColor = true;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.AnimateReadOnly = false;
            this.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPIN.Depth = 0;
            this.txtPIN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPIN.LeadingIcon = null;
            this.txtPIN.Location = new System.Drawing.Point(23, 338);
            this.txtPIN.MaxLength = 50;
            this.txtPIN.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPIN.Multiline = false;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(335, 50);
            this.txtPIN.TabIndex = 28;
            this.txtPIN.Text = "";
            this.txtPIN.TrailingIcon = null;
            // 
            // txtVisaNumber
            // 
            this.txtVisaNumber.AnimateReadOnly = false;
            this.txtVisaNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisaNumber.Depth = 0;
            this.txtVisaNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVisaNumber.LeadingIcon = null;
            this.txtVisaNumber.Location = new System.Drawing.Point(23, 240);
            this.txtVisaNumber.MaxLength = 50;
            this.txtVisaNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVisaNumber.Multiline = false;
            this.txtVisaNumber.Name = "txtVisaNumber";
            this.txtVisaNumber.Size = new System.Drawing.Size(335, 50);
            this.txtVisaNumber.TabIndex = 27;
            this.txtVisaNumber.Text = "";
            this.txtVisaNumber.TrailingIcon = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::OnlineStore_PresentationLayer.Properties.Resources.visa;
            this.pictureBox1.Location = new System.Drawing.Point(229, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(23, 166);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(432, 35);
            this.bunifuSeparator2.TabIndex = 26;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(32, 66);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(432, 35);
            this.bunifuSeparator1.TabIndex = 25;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Payment Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_truck_unscreen;
            this.pictureBox2.Location = new System.Drawing.Point(46, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pbProductPic
            // 
            this.pbProductPic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.error1;
            this.pbProductPic.Location = new System.Drawing.Point(39, 84);
            this.pbProductPic.Name = "pbProductPic";
            this.pbProductPic.Size = new System.Drawing.Size(207, 207);
            this.pbProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductPic.TabIndex = 1;
            this.pbProductPic.TabStop = false;
            // 
            // nmrcUserQuantity
            // 
            this.nmrcUserQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.nmrcUserQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrcUserQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcUserQuantity.Location = new System.Drawing.Point(267, 264);
            this.nmrcUserQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrcUserQuantity.Name = "nmrcUserQuantity";
            this.nmrcUserQuantity.Size = new System.Drawing.Size(129, 27);
            this.nmrcUserQuantity.TabIndex = 10;
            this.nmrcUserQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrcUserQuantity.ThousandsSeparator = true;
            this.nmrcUserQuantity.ValueChanged += new System.EventHandler(this.nmrcUserQuantity_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(40, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Price :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(205, 353);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(143, 33);
            this.lblTotalPrice.TabIndex = 26;
            this.lblTotalPrice.Text = "$1999.99";
            // 
            // frmBuyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 499);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrcUserQuantity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDeliveringFeeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblQuantityText);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNumOfRatingUsers);
            this.Controls.Add(this.strsAvrgRating);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pbProductPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBuyProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy Your Product Now!";
            this.Load += new System.EventHandler(this.frmBuyProductScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUserQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProductPic;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblProductName;
        private MaterialSkin.Controls.MaterialLabel lblNumOfRatingUsers;
        private Bunifu.Framework.UI.BunifuRating strsAvrgRating;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantityText;
        private MaterialSkin.Controls.MaterialLabel lblDeliveringFeeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton btnBuyNow;
        private MaterialSkin.Controls.MaterialTextBox txtPIN;
        private MaterialSkin.Controls.MaterialTextBox txtVisaNumber;
        private System.Windows.Forms.NumericUpDown nmrcUserQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
    }
}