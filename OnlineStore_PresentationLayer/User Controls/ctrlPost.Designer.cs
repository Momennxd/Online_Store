namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlPost
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
            this.pnlAddPostElements = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblComments = new System.Windows.Forms.Label();
            this.btnComment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShowPostOptions = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.btnLike = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmsUserReviewOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPostText = new System.Windows.Forms.TextBox();
            this.pbUserPic = new OnlineStore_PresentationLayer.User_Controls.RoundedPictrueBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlAddPostElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPostOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLike)).BeginInit();
            this.cmsUserReviewOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddPostElements
            // 
            this.pnlAddPostElements.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAddPostElements.Controls.Add(this.btnSave);
            this.pnlAddPostElements.Controls.Add(this.lblComments);
            this.pnlAddPostElements.Controls.Add(this.btnComment);
            this.pnlAddPostElements.Controls.Add(this.btnShowPostOptions);
            this.pnlAddPostElements.Controls.Add(this.lblFullName);
            this.pnlAddPostElements.Controls.Add(this.lblLikes);
            this.pnlAddPostElements.Controls.Add(this.btnLike);
            this.pnlAddPostElements.Controls.Add(this.pbUserPic);
            this.pnlAddPostElements.Location = new System.Drawing.Point(8, 9);
            this.pnlAddPostElements.Name = "pnlAddPostElements";
            this.pnlAddPostElements.Size = new System.Drawing.Size(1044, 217);
            this.pnlAddPostElements.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::OnlineStore_PresentationLayer.Properties.Resources.SaveReview;
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(928, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 26);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 33;
            this.btnSave.TabStop = false;
            this.btnSave.Tag = "0";
            this.btnSave.Visible = false;
            this.btnSave.Zoom = 12;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblComments.Location = new System.Drawing.Point(299, 187);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(21, 15);
            this.lblComments.TabIndex = 32;
            this.lblComments.Text = "22";
            // 
            // btnComment
            // 
            this.btnComment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnComment.BackColor = System.Drawing.Color.Transparent;
            this.btnComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComment.BorderRadius = 3;
            this.btnComment.ButtonText = "Comment";
            this.btnComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComment.DisabledColor = System.Drawing.Color.Gray;
            this.btnComment.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Iconcolor = System.Drawing.Color.Transparent;
            this.btnComment.Iconimage = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_comment_50;
            this.btnComment.Iconimage_right = null;
            this.btnComment.Iconimage_right_Selected = null;
            this.btnComment.Iconimage_Selected = null;
            this.btnComment.IconMarginLeft = 0;
            this.btnComment.IconMarginRight = 0;
            this.btnComment.IconRightVisible = true;
            this.btnComment.IconRightZoom = 0D;
            this.btnComment.IconVisible = true;
            this.btnComment.IconZoom = 50D;
            this.btnComment.IsTab = false;
            this.btnComment.Location = new System.Drawing.Point(191, 180);
            this.btnComment.Name = "btnComment";
            this.btnComment.Normalcolor = System.Drawing.Color.Transparent;
            this.btnComment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnComment.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnComment.selected = false;
            this.btnComment.Size = new System.Drawing.Size(107, 28);
            this.btnComment.TabIndex = 31;
            this.btnComment.Text = "Comment";
            this.btnComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComment.Textcolor = System.Drawing.Color.Black;
            this.btnComment.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnShowPostOptions
            // 
            this.btnShowPostOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPostOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPostOptions.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_three_dots_30;
            this.btnShowPostOptions.ImageActive = null;
            this.btnShowPostOptions.Location = new System.Drawing.Point(966, 13);
            this.btnShowPostOptions.Name = "btnShowPostOptions";
            this.btnShowPostOptions.Size = new System.Drawing.Size(46, 26);
            this.btnShowPostOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowPostOptions.TabIndex = 30;
            this.btnShowPostOptions.TabStop = false;
            this.btnShowPostOptions.Tag = "0";
            this.btnShowPostOptions.Zoom = 12;
            this.btnShowPostOptions.Click += new System.EventHandler(this.btnShowPostOptions_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(92, 24);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(125, 15);
            this.lblFullName.TabIndex = 29;
            this.lblFullName.Text = "Momen Nasr Taha";
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLikes.Location = new System.Drawing.Point(129, 188);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(21, 15);
            this.lblLikes.TabIndex = 28;
            this.lblLikes.Text = "22";
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.Color.Transparent;
            this.btnLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLike.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_heart_48__1_1;
            this.btnLike.ImageActive = null;
            this.btnLike.Location = new System.Drawing.Point(94, 180);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(29, 30);
            this.btnLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLike.TabIndex = 27;
            this.btnLike.TabStop = false;
            this.btnLike.Tag = "0";
            this.btnLike.Zoom = 12;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // cmsUserReviewOptions
            // 
            this.cmsUserReviewOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsUserReviewOptions.Name = "contextMenuStrip1";
            this.cmsUserReviewOptions.Size = new System.Drawing.Size(108, 48);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPostText
            // 
            this.txtPostText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPostText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostText.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPostText.Location = new System.Drawing.Point(103, 53);
            this.txtPostText.Multiline = true;
            this.txtPostText.Name = "txtPostText";
            this.txtPostText.ReadOnly = true;
            this.txtPostText.Size = new System.Drawing.Size(917, 132);
            this.txtPostText.TabIndex = 34;
            this.txtPostText.Text = "Popa Posa";
            // 
            // pbUserPic
            // 
            this.pbUserPic.BackColor = System.Drawing.Color.White;
            this.pbUserPic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.user;
            this.pbUserPic.Location = new System.Drawing.Point(16, 18);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(70, 70);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPic.TabIndex = 0;
            this.pbUserPic.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 6;
            this.bunifuElipse2.TargetControl = this.pbUserPic;
            // 
            // ctrlPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPostText);
            this.Controls.Add(this.pnlAddPostElements);
            this.Name = "ctrlPost";
            this.Size = new System.Drawing.Size(1055, 235);
            this.pnlAddPostElements.ResumeLayout(false);
            this.pnlAddPostElements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPostOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLike)).EndInit();
            this.cmsUserReviewOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddPostElements;
        private RoundedPictrueBox pbUserPic;
        private System.Windows.Forms.Label lblLikes;
        private Bunifu.Framework.UI.BunifuImageButton btnLike;
        private System.Windows.Forms.Label lblFullName;
        private Bunifu.Framework.UI.BunifuImageButton btnShowPostOptions;
        private Bunifu.Framework.UI.BunifuFlatButton btnComment;
        private System.Windows.Forms.ContextMenuStrip cmsUserReviewOptions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label lblComments;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtPostText;
    }
}
