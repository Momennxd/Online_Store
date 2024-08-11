namespace OnlineStore_PresentationLayer.Manage_Products
{
    partial class frmAddUpdateProduct
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
            this.txtProductName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBrand = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbCategories = new MaterialSkin.Controls.MaterialComboBox();
            this.cbDeliveryTypes = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlUserQuantity = new System.Windows.Forms.Panel();
            this.nmrcProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDeliveryTypeFee = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRemoveImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlUserQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(2)))));
            this.lblFormHeader.Location = new System.Drawing.Point(30, 18);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(384, 40);
            this.lblFormHeader.TabIndex = 47;
            this.lblFormHeader.Text = "Add Your Own Product Now!";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.txtProductName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.txtProductName.HintText = "Product Name";
            this.txtProductName.isPassword = false;
            this.txtProductName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtProductName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtProductName.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtProductName.LineThickness = 2;
            this.txtProductName.Location = new System.Drawing.Point(31, 103);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(256, 44);
            this.txtProductName.TabIndex = 48;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.txtBrand.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.txtBrand.HintText = "Product Brand";
            this.txtBrand.isPassword = false;
            this.txtBrand.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtBrand.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtBrand.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtBrand.LineThickness = 2;
            this.txtBrand.Location = new System.Drawing.Point(311, 103);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(256, 44);
            this.txtBrand.TabIndex = 49;
            this.txtBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbCategories
            // 
            this.cbCategories.AutoResize = false;
            this.cbCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCategories.Depth = 0;
            this.cbCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCategories.DropDownHeight = 174;
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.DropDownWidth = 121;
            this.cbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.IntegralHeight = false;
            this.cbCategories.ItemHeight = 43;
            this.cbCategories.Location = new System.Drawing.Point(33, 385);
            this.cbCategories.MaxDropDownItems = 4;
            this.cbCategories.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(256, 49);
            this.cbCategories.StartIndex = 0;
            this.cbCategories.TabIndex = 50;
            // 
            // cbDeliveryTypes
            // 
            this.cbDeliveryTypes.AutoResize = false;
            this.cbDeliveryTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDeliveryTypes.Depth = 0;
            this.cbDeliveryTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDeliveryTypes.DropDownHeight = 174;
            this.cbDeliveryTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeliveryTypes.DropDownWidth = 121;
            this.cbDeliveryTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDeliveryTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDeliveryTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDeliveryTypes.FormattingEnabled = true;
            this.cbDeliveryTypes.IntegralHeight = false;
            this.cbDeliveryTypes.ItemHeight = 43;
            this.cbDeliveryTypes.Location = new System.Drawing.Point(37, 479);
            this.cbDeliveryTypes.MaxDropDownItems = 4;
            this.cbDeliveryTypes.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDeliveryTypes.Name = "cbDeliveryTypes";
            this.cbDeliveryTypes.Size = new System.Drawing.Size(256, 49);
            this.cbDeliveryTypes.StartIndex = 0;
            this.cbDeliveryTypes.TabIndex = 51;
            this.cbDeliveryTypes.SelectedIndexChanged += new System.EventHandler(this.DeliveryTypes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(35)))));
            this.label4.Location = new System.Drawing.Point(30, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Product Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(34, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Product Delivery Type";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.txtDescription.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.txtDescription.HintText = "Product Description";
            this.txtDescription.isPassword = false;
            this.txtDescription.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDescription.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDescription.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtDescription.LineThickness = 2;
            this.txtDescription.Location = new System.Drawing.Point(31, 166);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(536, 56);
            this.txtDescription.TabIndex = 54;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.txtPrice.HintText = "Product Price";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPrice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtPrice.LineThickness = 2;
            this.txtPrice.Location = new System.Drawing.Point(31, 230);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(256, 44);
            this.txtPrice.TabIndex = 55;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlUserQuantity
            // 
            this.pnlUserQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnlUserQuantity.Controls.Add(this.nmrcProductQuantity);
            this.pnlUserQuantity.Location = new System.Drawing.Point(31, 308);
            this.pnlUserQuantity.Name = "pnlUserQuantity";
            this.pnlUserQuantity.Size = new System.Drawing.Size(192, 42);
            this.pnlUserQuantity.TabIndex = 57;
            // 
            // nmrcProductQuantity
            // 
            this.nmrcProductQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.nmrcProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrcProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcProductQuantity.Location = new System.Drawing.Point(5, 8);
            this.nmrcProductQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrcProductQuantity.Name = "nmrcProductQuantity";
            this.nmrcProductQuantity.Size = new System.Drawing.Size(184, 27);
            this.nmrcProductQuantity.TabIndex = 10;
            this.nmrcProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrcProductQuantity.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(34, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Product Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(2)))));
            this.label5.Location = new System.Drawing.Point(381, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Note That The Fee Of Adding A Product Is 5% Of The Product Price";
            // 
            // lblDeliveryTypeFee
            // 
            this.lblDeliveryTypeFee.AutoSize = true;
            this.lblDeliveryTypeFee.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryTypeFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(35)))));
            this.lblDeliveryTypeFee.Location = new System.Drawing.Point(38, 533);
            this.lblDeliveryTypeFee.Name = "lblDeliveryTypeFee";
            this.lblDeliveryTypeFee.Size = new System.Drawing.Size(25, 15);
            this.lblDeliveryTypeFee.TabIndex = 60;
            this.lblDeliveryTypeFee.Tag = "Delivery Type Fee Is";
            this.lblDeliveryTypeFee.Text = "65$";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::OnlineStore_PresentationLayer.Properties.Resources.add_button__1_;
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(634, 505);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 57);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 64;
            this.btnAdd.TabStop = false;
            this.btnAdd.Tag = "0";
            this.btnAdd.Zoom = 12;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = global::OnlineStore_PresentationLayer.Properties.Resources.cancel;
            this.btnCancel.ImageActive = null;
            this.btnCancel.Location = new System.Drawing.Point(457, 511);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 50);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 63;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "0";
            this.btnCancel.Zoom = 12;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImage.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_remove_image_96__1_;
            this.btnRemoveImage.ImageActive = null;
            this.btnRemoveImage.Location = new System.Drawing.Point(785, 412);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(50, 50);
            this.btnRemoveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveImage.TabIndex = 62;
            this.btnRemoveImage.TabStop = false;
            this.btnRemoveImage.Tag = "0";
            this.btnRemoveImage.Zoom = 12;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductImage.Image = global::OnlineStore_PresentationLayer.Properties.Resources.add_product;
            this.pbProductImage.Location = new System.Drawing.Point(650, 95);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(311, 311);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 61;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.pbProductImage_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_minus_48;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1036, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 46;
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
            this.btnExit.Location = new System.Drawing.Point(1070, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 45;
            this.btnExit.TabStop = false;
            this.btnExit.Tag = "0";
            this.btnExit.Zoom = 12;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(35)))));
            this.label6.Location = new System.Drawing.Point(702, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Click To Add Your Product Image";
            this.label6.Click += new System.EventHandler(this.pbProductImage_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1103, 619);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.lblDeliveryTypeFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlUserQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDeliveryTypes);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblFormHeader);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Product";
            this.Load += new System.EventHandler(this.frmAddUpdateProduct_Load);
            this.pnlUserQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Label lblFormHeader;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBrand;
        private MaterialSkin.Controls.MaterialComboBox cbCategories;
        private MaterialSkin.Controls.MaterialComboBox cbDeliveryTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescription;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private System.Windows.Forms.Panel pnlUserQuantity;
        private System.Windows.Forms.NumericUpDown nmrcProductQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDeliveryTypeFee;
        private System.Windows.Forms.PictureBox pbProductImage;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveImage;
        private Bunifu.Framework.UI.BunifuImageButton btnCancel;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}