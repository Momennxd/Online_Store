namespace OnlineStore_PresentationLayer.Manage_Products
{
    partial class frmMarketProduct
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
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.dpAdEndDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMarketProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRemoveImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbAdImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMarketProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(2)))));
            this.lblFormHeader.Location = new System.Drawing.Point(298, 18);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(420, 40);
            this.lblFormHeader.TabIndex = 48;
            this.lblFormHeader.Text = "Market Your Own Product Now!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(35)))));
            this.label6.Location = new System.Drawing.Point(73, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Click To Add Your Ad Image";
            // 
            // txtAdDescription
            // 
            this.txtAdDescription.AnimateReadOnly = false;
            this.txtAdDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAdDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdDescription.Depth = 0;
            this.txtAdDescription.HideSelection = true;
            this.txtAdDescription.Hint = " Advertisement Description";
            this.txtAdDescription.Location = new System.Drawing.Point(338, 110);
            this.txtAdDescription.MaxLength = 32767;
            this.txtAdDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdDescription.Name = "txtAdDescription";
            this.txtAdDescription.PasswordChar = '\0';
            this.txtAdDescription.ReadOnly = false;
            this.txtAdDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdDescription.SelectedText = "";
            this.txtAdDescription.SelectionLength = 0;
            this.txtAdDescription.SelectionStart = 0;
            this.txtAdDescription.ShortcutsEnabled = true;
            this.txtAdDescription.Size = new System.Drawing.Size(668, 244);
            this.txtAdDescription.TabIndex = 69;
            this.txtAdDescription.TabStop = false;
            this.txtAdDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdDescription.UseSystemPasswordChar = false;
            // 
            // dpAdEndDate
            // 
            this.dpAdEndDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpAdEndDate.BorderRadius = 0;
            this.dpAdEndDate.ForeColor = System.Drawing.Color.White;
            this.dpAdEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpAdEndDate.FormatCustom = null;
            this.dpAdEndDate.Location = new System.Drawing.Point(338, 385);
            this.dpAdEndDate.Name = "dpAdEndDate";
            this.dpAdEndDate.Size = new System.Drawing.Size(303, 36);
            this.dpAdEndDate.TabIndex = 70;
            this.dpAdEndDate.Value = new System.DateTime(2023, 12, 30, 20, 12, 9, 517);
            this.dpAdEndDate.onValueChanged += new System.EventHandler(this.dpAdEndDate_onValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(35)))));
            this.label4.Location = new System.Drawing.Point(338, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Advertisement End Date";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(669, 385);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(181, 32);
            this.lblTotalFee.TabIndex = 76;
            this.lblTotalFee.Tag = "Total Fee :";
            this.lblTotalFee.Text = "Total Fee : 100$";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(2)))));
            this.label5.Location = new System.Drawing.Point(320, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Note That The Fee Of Marketing A Product Is 100$ Per Day";
            // 
            // btnMarketProduct
            // 
            this.btnMarketProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnMarketProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarketProduct.Image = global::OnlineStore_PresentationLayer.Properties.Resources.advertising1;
            this.btnMarketProduct.ImageActive = null;
            this.btnMarketProduct.Location = new System.Drawing.Point(591, 494);
            this.btnMarketProduct.Name = "btnMarketProduct";
            this.btnMarketProduct.Size = new System.Drawing.Size(50, 50);
            this.btnMarketProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMarketProduct.TabIndex = 75;
            this.btnMarketProduct.TabStop = false;
            this.btnMarketProduct.Tag = "0";
            this.btnMarketProduct.Zoom = 12;
            this.btnMarketProduct.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = global::OnlineStore_PresentationLayer.Properties.Resources.cancel;
            this.btnCancel.ImageActive = null;
            this.btnCancel.Location = new System.Drawing.Point(398, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 50);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 74;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "0";
            this.btnCancel.Zoom = 12;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_minus_48;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(965, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 73;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Tag = "0";
            this.btnMinimize.Zoom = 12;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_multiply_64;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(999, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 72;
            this.btnExit.TabStop = false;
            this.btnExit.Tag = "0";
            this.btnExit.Zoom = 12;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImage.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_remove_image_96__1_;
            this.btnRemoveImage.ImageActive = null;
            this.btnRemoveImage.Location = new System.Drawing.Point(138, 427);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(50, 50);
            this.btnRemoveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveImage.TabIndex = 67;
            this.btnRemoveImage.TabStop = false;
            this.btnRemoveImage.Tag = "0";
            this.btnRemoveImage.Zoom = 12;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // pbAdImage
            // 
            this.pbAdImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdImage.Image = global::OnlineStore_PresentationLayer.Properties.Resources.search;
            this.pbAdImage.Location = new System.Drawing.Point(21, 110);
            this.pbAdImage.Name = "pbAdImage";
            this.pbAdImage.Size = new System.Drawing.Size(311, 311);
            this.pbAdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdImage.TabIndex = 66;
            this.pbAdImage.TabStop = false;
            this.pbAdImage.Click += new System.EventHandler(this.pbAdImage_Click);
            // 
            // frmMarketProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 611);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.btnMarketProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dpAdEndDate);
            this.Controls.Add(this.txtAdDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.pbAdImage);
            this.Controls.Add(this.lblFormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMarketProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Your Product Now !";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMarketProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveImage;
        private System.Windows.Forms.PictureBox pbAdImage;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtAdDescription;
        private Bunifu.Framework.UI.BunifuDatepicker dpAdEndDate;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnCancel;
        private Bunifu.Framework.UI.BunifuImageButton btnMarketProduct;
        private System.Windows.Forms.Label lblTotalFee;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
    }
}