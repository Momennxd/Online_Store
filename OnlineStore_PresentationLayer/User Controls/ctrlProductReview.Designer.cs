namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlProductReview
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
            this.strsAvrgRating = new Bunifu.Framework.UI.BunifuRating();
            this.txtReviewComment = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblFullName = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            this.lblLikes = new System.Windows.Forms.Label();
            this.cmsUserReviewOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowCommentOptions = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLike = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.cmsUserReviewOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCommentOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLike)).BeginInit();
            this.SuspendLayout();
            // 
            // strsAvrgRating
            // 
            this.strsAvrgRating.BackColor = System.Drawing.Color.Transparent;
            this.strsAvrgRating.Enabled = false;
            this.strsAvrgRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(172)))), ((int)(((byte)(10)))));
            this.strsAvrgRating.Location = new System.Drawing.Point(6, 79);
            this.strsAvrgRating.Name = "strsAvrgRating";
            this.strsAvrgRating.Size = new System.Drawing.Size(70, 13);
            this.strsAvrgRating.TabIndex = 7;
            this.strsAvrgRating.Value = 4;
            // 
            // txtReviewComment
            // 
            this.txtReviewComment.BackColor = System.Drawing.Color.White;
            this.txtReviewComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReviewComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewComment.ForeColor = System.Drawing.Color.Black;
            this.txtReviewComment.Location = new System.Drawing.Point(94, 29);
            this.txtReviewComment.Multiline = true;
            this.txtReviewComment.Name = "txtReviewComment";
            this.txtReviewComment.ReadOnly = true;
            this.txtReviewComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReviewComment.Size = new System.Drawing.Size(844, 47);
            this.txtReviewComment.TabIndex = 8;
            this.txtReviewComment.Text = "I recomment it, it\'s worth it";
            this.txtReviewComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReviewComment_KeyDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 9;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFullName.Location = new System.Drawing.Point(91, 11);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(110, 15);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "Momen Nasr Taha";
            this.lblFullName.Click += new System.EventHandler(this.pbUserPic_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 6;
            this.bunifuElipse2.TargetControl = this.pbUserPic;
            // 
            // pbUserPic
            // 
            this.pbUserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserPic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_account_48__1_1;
            this.pbUserPic.Location = new System.Drawing.Point(6, 6);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(70, 70);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPic.TabIndex = 0;
            this.pbUserPic.TabStop = false;
            this.pbUserPic.Click += new System.EventHandler(this.pbUserPic_Click);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLikes.Location = new System.Drawing.Point(125, 79);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(21, 15);
            this.lblLikes.TabIndex = 23;
            this.lblLikes.Text = "22";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::OnlineStore_PresentationLayer.Properties.Resources.SaveReview;
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(944, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 26);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 28;
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
            this.btnShowCommentOptions.Location = new System.Drawing.Point(933, 0);
            this.btnShowCommentOptions.Name = "btnShowCommentOptions";
            this.btnShowCommentOptions.Size = new System.Drawing.Size(46, 26);
            this.btnShowCommentOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowCommentOptions.TabIndex = 26;
            this.btnShowCommentOptions.TabStop = false;
            this.btnShowCommentOptions.Tag = "0";
            this.btnShowCommentOptions.Zoom = 12;
            this.btnShowCommentOptions.Click += new System.EventHandler(this.btnShowCommentOptions_Click);
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.Color.Transparent;
            this.btnLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLike.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_heart_48__1_1;
            this.btnLike.ImageActive = null;
            this.btnLike.Location = new System.Drawing.Point(97, 76);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(22, 22);
            this.btnLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLike.TabIndex = 22;
            this.btnLike.TabStop = false;
            this.btnLike.Tag = "0";
            this.btnLike.Zoom = 12;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // ctrlProductReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowCommentOptions);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtReviewComment);
            this.Controls.Add(this.strsAvrgRating);
            this.Controls.Add(this.pbUserPic);
            this.Name = "ctrlProductReview";
            this.Size = new System.Drawing.Size(982, 102);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.cmsUserReviewOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCommentOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserPic;
        private Bunifu.Framework.UI.BunifuRating strsAvrgRating;
        private System.Windows.Forms.TextBox txtReviewComment;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblFullName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label lblLikes;
        private Bunifu.Framework.UI.BunifuImageButton btnLike;
        private Bunifu.Framework.UI.BunifuImageButton btnShowCommentOptions;
        private System.Windows.Forms.ContextMenuStrip cmsUserReviewOptions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
    }
}
