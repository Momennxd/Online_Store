namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlAddPost
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnPost = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAddPostElements = new System.Windows.Forms.Panel();
            this.txtPostText = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.pbUserPic = new OnlineStore_PresentationLayer.User_Controls.RoundedPictrueBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlAddPostElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 9;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnPost
            // 
            this.btnPost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPost.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPost.Depth = 0;
            this.btnPost.HighEmphasis = true;
            this.btnPost.Icon = null;
            this.btnPost.Location = new System.Drawing.Point(92, 172);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPost.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPost.Name = "btnPost";
            this.btnPost.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPost.Size = new System.Drawing.Size(64, 36);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPost.UseAccentColor = false;
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_clear_96;
            this.btnClear.ImageActive = null;
            this.btnClear.Location = new System.Drawing.Point(177, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 35);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClear.TabIndex = 24;
            this.btnClear.TabStop = false;
            this.btnClear.Tag = "0";
            this.btnClear.Zoom = 12;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlAddPostElements
            // 
            this.pnlAddPostElements.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAddPostElements.Controls.Add(this.txtPostText);
            this.pnlAddPostElements.Controls.Add(this.btnClear);
            this.pnlAddPostElements.Controls.Add(this.btnPost);
            this.pnlAddPostElements.Controls.Add(this.pbUserPic);
            this.pnlAddPostElements.Location = new System.Drawing.Point(13, 9);
            this.pnlAddPostElements.Name = "pnlAddPostElements";
            this.pnlAddPostElements.Size = new System.Drawing.Size(778, 217);
            this.pnlAddPostElements.TabIndex = 25;
            // 
            // txtPostText
            // 
            this.txtPostText.AnimateReadOnly = false;
            this.txtPostText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPostText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPostText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostText.Depth = 0;
            this.txtPostText.HideSelection = true;
            this.txtPostText.Hint = "What\'s On Your Mind ?";
            this.txtPostText.Location = new System.Drawing.Point(94, 22);
            this.txtPostText.MaxLength = 32767;
            this.txtPostText.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPostText.Name = "txtPostText";
            this.txtPostText.PasswordChar = '\0';
            this.txtPostText.ReadOnly = false;
            this.txtPostText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPostText.SelectedText = "";
            this.txtPostText.SelectionLength = 0;
            this.txtPostText.SelectionStart = 0;
            this.txtPostText.ShortcutsEnabled = true;
            this.txtPostText.Size = new System.Drawing.Size(592, 145);
            this.txtPostText.TabIndex = 26;
            this.txtPostText.TabStop = false;
            this.txtPostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPostText.UseSystemPasswordChar = false;
            // 
            // pbUserPic
            // 
            this.pbUserPic.BackColor = System.Drawing.Color.White;
            this.pbUserPic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.user;
            this.pbUserPic.Location = new System.Drawing.Point(16, 9);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(70, 70);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPic.TabIndex = 0;
            this.pbUserPic.TabStop = false;
            // 
            // ctrlAddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAddPostElements);
            this.Name = "ctrlAddPost";
            this.Size = new System.Drawing.Size(794, 235);
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlAddPostElements.ResumeLayout(false);
            this.pnlAddPostElements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPictrueBox pbUserPic;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MaterialSkin.Controls.MaterialButton btnPost;
        private Bunifu.Framework.UI.BunifuImageButton btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlAddPostElements;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtPostText;
    }
}
