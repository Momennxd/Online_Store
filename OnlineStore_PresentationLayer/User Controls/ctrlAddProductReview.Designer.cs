namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlAddProductReview
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
            this.txtReviewComment = new System.Windows.Forms.TextBox();
            this.strsAvrgRating = new Bunifu.Framework.UI.BunifuRating();
            this.lblFullName = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSubmit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReviewComment
            // 
            this.txtReviewComment.BackColor = System.Drawing.Color.White;
            this.txtReviewComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReviewComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewComment.ForeColor = System.Drawing.Color.Black;
            this.txtReviewComment.Location = new System.Drawing.Point(79, 36);
            this.txtReviewComment.Multiline = true;
            this.txtReviewComment.Name = "txtReviewComment";
            this.txtReviewComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReviewComment.Size = new System.Drawing.Size(848, 47);
            this.txtReviewComment.TabIndex = 9;
            this.txtReviewComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReviewComment_KeyDown);
            // 
            // strsAvrgRating
            // 
            this.strsAvrgRating.BackColor = System.Drawing.Color.Transparent;
            this.strsAvrgRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(172)))), ((int)(((byte)(10)))));
            this.strsAvrgRating.Location = new System.Drawing.Point(79, 13);
            this.strsAvrgRating.Name = "strsAvrgRating";
            this.strsAvrgRating.Size = new System.Drawing.Size(105, 17);
            this.strsAvrgRating.TabIndex = 10;
            this.strsAvrgRating.Value = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFullName.Location = new System.Drawing.Point(203, 13);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(204, 15);
            this.lblFullName.TabIndex = 24;
            this.lblFullName.Text = "How Would You Rate This Product ?";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 8;
            this.bunifuElipse2.TargetControl = this.txtReviewComment;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_select_checkmark_symbol_to_choose_true_answer_96__1_;
            this.btnSubmit.ImageActive = null;
            this.btnSubmit.Location = new System.Drawing.Point(938, 41);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(35, 35);
            this.btnSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Tag = "0";
            this.btnSubmit.Zoom = 12;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pbUserPic
            // 
            this.pbUserPic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_account_48__1_1;
            this.pbUserPic.Location = new System.Drawing.Point(3, 13);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(70, 70);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPic.TabIndex = 1;
            this.pbUserPic.TabStop = false;
            // 
            // ctrlAddProductReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.strsAvrgRating);
            this.Controls.Add(this.txtReviewComment);
            this.Controls.Add(this.pbUserPic);
            this.Name = "ctrlAddProductReview";
            this.Size = new System.Drawing.Size(982, 102);
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserPic;
        private System.Windows.Forms.TextBox txtReviewComment;
        private Bunifu.Framework.UI.BunifuRating strsAvrgRating;
        private Bunifu.Framework.UI.BunifuImageButton btnSubmit;
        private System.Windows.Forms.Label lblFullName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}
