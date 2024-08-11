namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlPostComment
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
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowCommentOptions = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblLikes = new System.Windows.Forms.Label();
            this.btnLike = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            this.txtCommentText = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cmsUserCommentOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCommentOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.cmsUserCommentOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::OnlineStore_PresentationLayer.Properties.Resources.SaveReview;
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(860, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 26);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 36;
            this.btnSave.TabStop = false;
            this.btnSave.Tag = "0";
            this.btnSave.Visible = false;
            this.btnSave.Zoom = 12;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowCommentOptions
            // 
            this.btnShowCommentOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCommentOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCommentOptions.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_three_dots_30;
            this.btnShowCommentOptions.ImageActive = null;
            this.btnShowCommentOptions.Location = new System.Drawing.Point(858, 4);
            this.btnShowCommentOptions.Name = "btnShowCommentOptions";
            this.btnShowCommentOptions.Size = new System.Drawing.Size(46, 21);
            this.btnShowCommentOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowCommentOptions.TabIndex = 35;
            this.btnShowCommentOptions.TabStop = false;
            this.btnShowCommentOptions.Tag = "0";
            this.btnShowCommentOptions.Zoom = 12;
            this.btnShowCommentOptions.Click += new System.EventHandler(this.btnShowCommentOptions_Click);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLikes.Location = new System.Drawing.Point(110, 88);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(21, 15);
            this.lblLikes.TabIndex = 34;
            this.lblLikes.Text = "22";
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.Color.Transparent;
            this.btnLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLike.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_heart_48__1_1;
            this.btnLike.ImageActive = null;
            this.btnLike.Location = new System.Drawing.Point(82, 85);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(22, 22);
            this.btnLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLike.TabIndex = 33;
            this.btnLike.TabStop = false;
            this.btnLike.Tag = "0";
            this.btnLike.Zoom = 12;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFullName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(80, 7);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(106, 15);
            this.lblFullName.TabIndex = 32;
            this.lblFullName.Text = "Momen Nasr Taha";
            this.lblFullName.Click += new System.EventHandler(this.pbUserPic_Click);
            // 
            // pbUserPic
            // 
            this.pbUserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserPic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_account_48__1_1;
            this.pbUserPic.Location = new System.Drawing.Point(4, 4);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(70, 70);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPic.TabIndex = 29;
            this.pbUserPic.TabStop = false;
            this.pbUserPic.Click += new System.EventHandler(this.pbUserPic_Click);
            // 
            // txtCommentText
            // 
            this.txtCommentText.AnimateReadOnly = false;
            this.txtCommentText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCommentText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCommentText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCommentText.Depth = 0;
            this.txtCommentText.HideSelection = true;
            this.txtCommentText.Location = new System.Drawing.Point(82, 24);
            this.txtCommentText.MaxLength = 32767;
            this.txtCommentText.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCommentText.Name = "txtCommentText";
            this.txtCommentText.PasswordChar = '\0';
            this.txtCommentText.ReadOnly = true;
            this.txtCommentText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCommentText.SelectedText = "";
            this.txtCommentText.SelectionLength = 0;
            this.txtCommentText.SelectionStart = 0;
            this.txtCommentText.ShortcutsEnabled = true;
            this.txtCommentText.Size = new System.Drawing.Size(770, 60);
            this.txtCommentText.TabIndex = 37;
            this.txtCommentText.TabStop = false;
            this.txtCommentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCommentText.UseSystemPasswordChar = false;
            // 
            // cmsUserCommentOptions
            // 
            this.cmsUserCommentOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsUserCommentOptions.Name = "contextMenuStrip1";
            this.cmsUserCommentOptions.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_edit_48__2_;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_delete_48__1_;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 6;
            this.bunifuElipse2.TargetControl = this.pbUserPic;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 9;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ctrlPostComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCommentText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowCommentOptions);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pbUserPic);
            this.Name = "ctrlPostComment";
            this.Size = new System.Drawing.Size(906, 111);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCommentOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.cmsUserCommentOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private Bunifu.Framework.UI.BunifuImageButton btnShowCommentOptions;
        private System.Windows.Forms.Label lblLikes;
        private Bunifu.Framework.UI.BunifuImageButton btnLike;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.PictureBox pbUserPic;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCommentText;
        private System.Windows.Forms.ContextMenuStrip cmsUserCommentOptions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
