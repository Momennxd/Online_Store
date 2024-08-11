namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlUserProfileHeaderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlUserProfileHeaderInfo));
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.btnEditProfile = new MaterialSkin.Controls.MaterialButton();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.pbAvatarPic = new System.Windows.Forms.PictureBox();
            this.btnFollow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbUserProfilePic = new OnlineStore_PresentationLayer.User_Controls.RoundedPictrueBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.Black;
            this.lblUserFullName.Location = new System.Drawing.Point(187, 586);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(202, 39);
            this.lblUserFullName.TabIndex = 20;
            this.lblUserFullName.Text = "User Name";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditProfile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditProfile.Depth = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.HighEmphasis = true;
            this.btnEditProfile.Icon = null;
            this.btnEditProfile.Location = new System.Drawing.Point(1130, 586);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditProfile.Size = new System.Drawing.Size(114, 36);
            this.btnEditProfile.TabIndex = 22;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditProfile.UseAccentColor = false;
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowers.ForeColor = System.Drawing.Color.Gray;
            this.lblFollowers.Location = new System.Drawing.Point(193, 633);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(70, 15);
            this.lblFollowers.TabIndex = 23;
            this.lblFollowers.Tag = "0";
            this.lblFollowers.Text = "0 Followers";
            // 
            // pbAvatarPic
            // 
            this.pbAvatarPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbAvatarPic.Location = new System.Drawing.Point(3, 0);
            this.pbAvatarPic.Name = "pbAvatarPic";
            this.pbAvatarPic.Size = new System.Drawing.Size(1242, 579);
            this.pbAvatarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarPic.TabIndex = 19;
            this.pbAvatarPic.TabStop = false;
            // 
            // btnFollow
            // 
            this.btnFollow.ActiveBorderThickness = 2;
            this.btnFollow.ActiveCornerRadius = 20;
            this.btnFollow.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(119)))), ((int)(((byte)(197)))));
            this.btnFollow.ActiveForecolor = System.Drawing.Color.White;
            this.btnFollow.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(119)))), ((int)(((byte)(197)))));
            this.btnFollow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFollow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFollow.BackgroundImage")));
            this.btnFollow.ButtonText = "Follow";
            this.btnFollow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFollow.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFollow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(119)))), ((int)(((byte)(197)))));
            this.btnFollow.IdleBorderThickness = 1;
            this.btnFollow.IdleCornerRadius = 20;
            this.btnFollow.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btnFollow.IdleForecolor = System.Drawing.Color.Black;
            this.btnFollow.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(119)))), ((int)(((byte)(197)))));
            this.btnFollow.Location = new System.Drawing.Point(178, 655);
            this.btnFollow.Margin = new System.Windows.Forms.Padding(4);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(119, 47);
            this.btnFollow.TabIndex = 26;
            this.btnFollow.Tag = "0";
            this.btnFollow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // pbUserProfilePic
            // 
            this.pbUserProfilePic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.user1;
            this.pbUserProfilePic.Location = new System.Drawing.Point(12, 527);
            this.pbUserProfilePic.Name = "pbUserProfilePic";
            this.pbUserProfilePic.Size = new System.Drawing.Size(157, 157);
            this.pbUserProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserProfilePic.TabIndex = 1;
            this.pbUserProfilePic.TabStop = false;
            // 
            // ctrlUserProfileHeaderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnFollow);
            this.Controls.Add(this.lblFollowers);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.pbUserProfilePic);
            this.Controls.Add(this.pbAvatarPic);
            this.Name = "ctrlUserProfileHeaderInfo";
            this.Size = new System.Drawing.Size(1250, 711);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedPictrueBox pbUserProfilePic;
        private System.Windows.Forms.PictureBox pbAvatarPic;
        private System.Windows.Forms.Label lblUserFullName;
        private MaterialSkin.Controls.MaterialButton btnEditProfile;
        private System.Windows.Forms.Label lblFollowers;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFollow;
    }
}
