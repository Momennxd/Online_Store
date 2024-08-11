namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlAddNewComment
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            this.txtCommentText = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFullName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(75, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(69, 15);
            this.lblFullName.TabIndex = 25;
            this.lblFullName.Text = "User Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_submit_progress_96;
            this.btnSubmit.ImageActive = null;
            this.btnSubmit.Location = new System.Drawing.Point(703, 33);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(35, 35);
            this.btnSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Tag = "0";
            this.btnSubmit.Zoom = 12;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pbUserPic
            // 
            this.pbUserPic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbUserPic.Image = global::OnlineStore_PresentationLayer.Properties.Resources.icons8_account_48__1_1;
            this.pbUserPic.Location = new System.Drawing.Point(12, 20);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(55, 55);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPic.TabIndex = 10;
            this.pbUserPic.TabStop = false;
            // 
            // txtCommentText
            // 
            this.txtCommentText.AnimateReadOnly = false;
            this.txtCommentText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCommentText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCommentText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCommentText.Depth = 0;
            this.txtCommentText.HideSelection = true;
            this.txtCommentText.Hint = "Write a comment ?";
            this.txtCommentText.Location = new System.Drawing.Point(78, 27);
            this.txtCommentText.MaxLength = 32767;
            this.txtCommentText.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCommentText.Name = "txtCommentText";
            this.txtCommentText.PasswordChar = '\0';
            this.txtCommentText.ReadOnly = false;
            this.txtCommentText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCommentText.SelectedText = "";
            this.txtCommentText.SelectionLength = 0;
            this.txtCommentText.SelectionStart = 0;
            this.txtCommentText.ShortcutsEnabled = true;
            this.txtCommentText.Size = new System.Drawing.Size(608, 49);
            this.txtCommentText.TabIndex = 27;
            this.txtCommentText.TabStop = false;
            this.txtCommentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCommentText.UseSystemPasswordChar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAddNewComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCommentText);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pbUserPic);
            this.Name = "ctrlAddNewComment";
            this.Size = new System.Drawing.Size(742, 91);
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbUserPic;
        private System.Windows.Forms.Label lblFullName;
        private Bunifu.Framework.UI.BunifuImageButton btnSubmit;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCommentText;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
