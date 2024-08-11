namespace OnlineStore_PresentationLayer
{
    partial class frmMainScreen
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
            this.pnlUpperHeader = new System.Windows.Forms.Panel();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbUserProfilePic = new System.Windows.Forms.PictureBox();
            this.pnlMainScreenHeader = new System.Windows.Forms.Panel();
            this.btnTop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGoBackHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCategories = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.pbHeaderPic = new System.Windows.Forms.PictureBox();
            this.btnPerformSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlMainScreenFormsLoader = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlUpperHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePic)).BeginInit();
            this.pnlMainScreenHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPerformSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpperHeader
            // 
            this.pnlUpperHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(41)))));
            this.pnlUpperHeader.Controls.Add(this.lblUserFullName);
            this.pnlUpperHeader.Controls.Add(this.btnHome);
            this.pnlUpperHeader.Controls.Add(this.pbUserProfilePic);
            this.pnlUpperHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlUpperHeader.Name = "pnlUpperHeader";
            this.pnlUpperHeader.Size = new System.Drawing.Size(1278, 27);
            this.pnlUpperHeader.TabIndex = 0;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserFullName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.White;
            this.lblUserFullName.Location = new System.Drawing.Point(46, 4);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(97, 17);
            this.lblUserFullName.TabIndex = 0;
            this.lblUserFullName.Text = "User Full Name";
            this.lblUserFullName.Click += new System.EventHandler(this.pbUserProfilePic_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_home_48;
            this.btnHome.ImageActive = null;
            this.btnHome.Location = new System.Drawing.Point(1241, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(25, 25);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 11;
            this.btnHome.TabStop = false;
            this.btnHome.Tag = "0";
            this.btnHome.Zoom = 12;
            this.btnHome.Click += new System.EventHandler(this.BackToHomeScreen);
            // 
            // pbUserProfilePic
            // 
            this.pbUserProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserProfilePic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.user2;
            this.pbUserProfilePic.Location = new System.Drawing.Point(14, 2);
            this.pbUserProfilePic.Name = "pbUserProfilePic";
            this.pbUserProfilePic.Size = new System.Drawing.Size(23, 23);
            this.pbUserProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserProfilePic.TabIndex = 0;
            this.pbUserProfilePic.TabStop = false;
            this.pbUserProfilePic.Click += new System.EventHandler(this.pbUserProfilePic_Click);
            // 
            // pnlMainScreenHeader
            // 
            this.pnlMainScreenHeader.Controls.Add(this.btnTop);
            this.pnlMainScreenHeader.Controls.Add(this.btnGoBackHome);
            this.pnlMainScreenHeader.Controls.Add(this.btnCategories);
            this.pnlMainScreenHeader.Controls.Add(this.lblStoreName);
            this.pnlMainScreenHeader.Controls.Add(this.pbHeaderPic);
            this.pnlMainScreenHeader.Controls.Add(this.btnPerformSearch);
            this.pnlMainScreenHeader.Controls.Add(this.txtSearchBar);
            this.pnlMainScreenHeader.Controls.Add(this.btnAccount);
            this.pnlMainScreenHeader.Controls.Add(this.btnCart);
            this.pnlMainScreenHeader.Location = new System.Drawing.Point(3, 27);
            this.pnlMainScreenHeader.Name = "pnlMainScreenHeader";
            this.pnlMainScreenHeader.Size = new System.Drawing.Size(1275, 59);
            this.pnlMainScreenHeader.TabIndex = 7;
            // 
            // btnTop
            // 
            this.btnTop.Activecolor = System.Drawing.Color.White;
            this.btnTop.BackColor = System.Drawing.Color.White;
            this.btnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTop.BorderRadius = 0;
            this.btnTop.ButtonText = "Top";
            this.btnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop.DisabledColor = System.Drawing.Color.Gray;
            this.btnTop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTop.Iconimage = null;
            this.btnTop.Iconimage_right = null;
            this.btnTop.Iconimage_right_Selected = null;
            this.btnTop.Iconimage_Selected = null;
            this.btnTop.IconMarginLeft = 0;
            this.btnTop.IconMarginRight = 0;
            this.btnTop.IconRightVisible = true;
            this.btnTop.IconRightZoom = 0D;
            this.btnTop.IconVisible = true;
            this.btnTop.IconZoom = 50D;
            this.btnTop.IsTab = false;
            this.btnTop.Location = new System.Drawing.Point(419, 16);
            this.btnTop.Name = "btnTop";
            this.btnTop.Normalcolor = System.Drawing.Color.White;
            this.btnTop.OnHovercolor = System.Drawing.Color.White;
            this.btnTop.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTop.selected = false;
            this.btnTop.Size = new System.Drawing.Size(86, 32);
            this.btnTop.TabIndex = 37;
            this.btnTop.Text = "Top";
            this.btnTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTop.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnTop.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.Click += new System.EventHandler(this.btnMainButtons_Click);
            // 
            // btnGoBackHome
            // 
            this.btnGoBackHome.Activecolor = System.Drawing.Color.White;
            this.btnGoBackHome.BackColor = System.Drawing.Color.White;
            this.btnGoBackHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoBackHome.BorderRadius = 0;
            this.btnGoBackHome.ButtonText = "Home";
            this.btnGoBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBackHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnGoBackHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGoBackHome.Iconimage = null;
            this.btnGoBackHome.Iconimage_right = null;
            this.btnGoBackHome.Iconimage_right_Selected = null;
            this.btnGoBackHome.Iconimage_Selected = null;
            this.btnGoBackHome.IconMarginLeft = 0;
            this.btnGoBackHome.IconMarginRight = 0;
            this.btnGoBackHome.IconRightVisible = true;
            this.btnGoBackHome.IconRightZoom = 0D;
            this.btnGoBackHome.IconVisible = true;
            this.btnGoBackHome.IconZoom = 50D;
            this.btnGoBackHome.IsTab = false;
            this.btnGoBackHome.Location = new System.Drawing.Point(196, 15);
            this.btnGoBackHome.Name = "btnGoBackHome";
            this.btnGoBackHome.Normalcolor = System.Drawing.Color.White;
            this.btnGoBackHome.OnHovercolor = System.Drawing.Color.White;
            this.btnGoBackHome.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGoBackHome.selected = false;
            this.btnGoBackHome.Size = new System.Drawing.Size(100, 32);
            this.btnGoBackHome.TabIndex = 36;
            this.btnGoBackHome.Text = "Home";
            this.btnGoBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoBackHome.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnGoBackHome.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBackHome.Click += new System.EventHandler(this.BackToHomeScreen);
            // 
            // btnCategories
            // 
            this.btnCategories.Activecolor = System.Drawing.Color.White;
            this.btnCategories.BackColor = System.Drawing.Color.White;
            this.btnCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCategories.BorderRadius = 0;
            this.btnCategories.ButtonText = "Categories";
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.DisabledColor = System.Drawing.Color.Gray;
            this.btnCategories.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCategories.Iconimage = null;
            this.btnCategories.Iconimage_right = null;
            this.btnCategories.Iconimage_right_Selected = null;
            this.btnCategories.Iconimage_Selected = null;
            this.btnCategories.IconMarginLeft = 0;
            this.btnCategories.IconMarginRight = 0;
            this.btnCategories.IconRightVisible = true;
            this.btnCategories.IconRightZoom = 0D;
            this.btnCategories.IconVisible = true;
            this.btnCategories.IconZoom = 50D;
            this.btnCategories.IsTab = false;
            this.btnCategories.Location = new System.Drawing.Point(302, 15);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Normalcolor = System.Drawing.Color.White;
            this.btnCategories.OnHovercolor = System.Drawing.Color.White;
            this.btnCategories.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCategories.selected = false;
            this.btnCategories.Size = new System.Drawing.Size(111, 32);
            this.btnCategories.TabIndex = 38;
            this.btnCategories.Text = "Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCategories.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnCategories.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Click += new System.EventHandler(this.btnMainButtons_Click);
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStoreName.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(41)))));
            this.lblStoreName.Location = new System.Drawing.Point(61, 12);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(112, 37);
            this.lblStoreName.TabIndex = 2;
            this.lblStoreName.Text = "Luxuria";
            this.lblStoreName.Click += new System.EventHandler(this.BackToHomeScreen);
            // 
            // pbHeaderPic
            // 
            this.pbHeaderPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHeaderPic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.diamond;
            this.pbHeaderPic.Location = new System.Drawing.Point(6, 8);
            this.pbHeaderPic.Name = "pbHeaderPic";
            this.pbHeaderPic.Size = new System.Drawing.Size(50, 49);
            this.pbHeaderPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeaderPic.TabIndex = 1;
            this.pbHeaderPic.TabStop = false;
            this.pbHeaderPic.Click += new System.EventHandler(this.BackToHomeScreen);
            // 
            // btnPerformSearch
            // 
            this.btnPerformSearch.BackColor = System.Drawing.Color.White;
            this.btnPerformSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerformSearch.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_search_48__1_1;
            this.btnPerformSearch.ImageActive = null;
            this.btnPerformSearch.Location = new System.Drawing.Point(978, 11);
            this.btnPerformSearch.Name = "btnPerformSearch";
            this.btnPerformSearch.Size = new System.Drawing.Size(30, 27);
            this.btnPerformSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPerformSearch.TabIndex = 35;
            this.btnPerformSearch.TabStop = false;
            this.btnPerformSearch.Zoom = 10;
            this.btnPerformSearch.Click += new System.EventHandler(this.btnPerformSearch_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchBar.HintForeColor = System.Drawing.Color.Silver;
            this.txtSearchBar.HintText = "Search For a Product";
            this.txtSearchBar.isPassword = false;
            this.txtSearchBar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(41)))));
            this.txtSearchBar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchBar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(41)))));
            this.txtSearchBar.LineThickness = 3;
            this.txtSearchBar.Location = new System.Drawing.Point(548, 4);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(460, 40);
            this.txtSearchBar.TabIndex = 0;
            this.txtSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBar_KeyDown);
            // 
            // btnAccount
            // 
            this.btnAccount.Activecolor = System.Drawing.Color.White;
            this.btnAccount.BackColor = System.Drawing.Color.White;
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccount.BorderRadius = 0;
            this.btnAccount.ButtonText = "Account";
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccount.Iconimage = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_account_48__1_;
            this.btnAccount.Iconimage_right = null;
            this.btnAccount.Iconimage_right_Selected = null;
            this.btnAccount.Iconimage_Selected = null;
            this.btnAccount.IconMarginLeft = 0;
            this.btnAccount.IconMarginRight = 0;
            this.btnAccount.IconRightVisible = true;
            this.btnAccount.IconRightZoom = 0D;
            this.btnAccount.IconVisible = true;
            this.btnAccount.IconZoom = 50D;
            this.btnAccount.IsTab = false;
            this.btnAccount.Location = new System.Drawing.Point(1042, 11);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Normalcolor = System.Drawing.Color.White;
            this.btnAccount.OnHovercolor = System.Drawing.Color.White;
            this.btnAccount.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAccount.selected = false;
            this.btnAccount.Size = new System.Drawing.Size(97, 32);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccount.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnAccount.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Click += new System.EventHandler(this.btnMainButtons_Click);
            // 
            // btnCart
            // 
            this.btnCart.Activecolor = System.Drawing.Color.White;
            this.btnCart.BackColor = System.Drawing.Color.White;
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCart.BorderRadius = 0;
            this.btnCart.ButtonText = "Cart";
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.DisabledColor = System.Drawing.Color.Gray;
            this.btnCart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCart.Iconimage = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_cart_64;
            this.btnCart.Iconimage_right = null;
            this.btnCart.Iconimage_right_Selected = null;
            this.btnCart.Iconimage_Selected = null;
            this.btnCart.IconMarginLeft = 0;
            this.btnCart.IconMarginRight = 0;
            this.btnCart.IconRightVisible = true;
            this.btnCart.IconRightZoom = 0D;
            this.btnCart.IconVisible = true;
            this.btnCart.IconZoom = 50D;
            this.btnCart.IsTab = false;
            this.btnCart.Location = new System.Drawing.Point(1158, 11);
            this.btnCart.Name = "btnCart";
            this.btnCart.Normalcolor = System.Drawing.Color.White;
            this.btnCart.OnHovercolor = System.Drawing.Color.White;
            this.btnCart.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCart.selected = false;
            this.btnCart.Size = new System.Drawing.Size(84, 32);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCart.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnCart.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Click += new System.EventHandler(this.btnMainButtons_Click);
            // 
            // pnlMainScreenFormsLoader
            // 
            this.pnlMainScreenFormsLoader.AutoScroll = true;
            this.pnlMainScreenFormsLoader.BackColor = System.Drawing.Color.White;
            this.pnlMainScreenFormsLoader.Location = new System.Drawing.Point(3, 92);
            this.pnlMainScreenFormsLoader.Name = "pnlMainScreenFormsLoader";
            this.pnlMainScreenFormsLoader.Size = new System.Drawing.Size(1275, 864);
            this.pnlMainScreenFormsLoader.TabIndex = 8;
            this.pnlMainScreenFormsLoader.Click += new System.EventHandler(this.BackToHomeScreen);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.pbUserProfilePic;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 956);
            this.Controls.Add(this.pnlMainScreenHeader);
            this.Controls.Add(this.pnlMainScreenFormsLoader);
            this.Controls.Add(this.pnlUpperHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUXURIA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.pnlUpperHeader.ResumeLayout(false);
            this.pnlUpperHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePic)).EndInit();
            this.pnlMainScreenHeader.ResumeLayout(false);
            this.pnlMainScreenHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPerformSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpperHeader;
        private Bunifu.Framework.UI.BunifuFlatButton btnCart;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccount;
        private System.Windows.Forms.Panel pnlMainScreenHeader;
        private Bunifu.Framework.UI.BunifuFlatButton btnTop;
        private Bunifu.Framework.UI.BunifuFlatButton btnGoBackHome;
        private Bunifu.Framework.UI.BunifuImageButton btnPerformSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchBar;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.PictureBox pbHeaderPic;
        private Bunifu.Framework.UI.BunifuFlatButton btnCategories;
        public System.Windows.Forms.Panel pnlMainScreenFormsLoader;
        public Bunifu.Framework.UI.BunifuImageButton btnHome;
        private System.Windows.Forms.PictureBox pbUserProfilePic;
        private System.Windows.Forms.Label lblUserFullName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

