namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlCategory
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
            this.btnCategoryName = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnCategoryName
            // 
            this.btnCategoryName.Activecolor = System.Drawing.Color.White;
            this.btnCategoryName.BackColor = System.Drawing.Color.White;
            this.btnCategoryName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCategoryName.BorderRadius = 0;
            this.btnCategoryName.ButtonText = "Category Name";
            this.btnCategoryName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryName.DisabledColor = System.Drawing.Color.Gray;
            this.btnCategoryName.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCategoryName.Iconimage = null;
            this.btnCategoryName.Iconimage_right = null;
            this.btnCategoryName.Iconimage_right_Selected = null;
            this.btnCategoryName.Iconimage_Selected = null;
            this.btnCategoryName.IconMarginLeft = 0;
            this.btnCategoryName.IconMarginRight = 0;
            this.btnCategoryName.IconRightVisible = true;
            this.btnCategoryName.IconRightZoom = 0D;
            this.btnCategoryName.IconVisible = true;
            this.btnCategoryName.IconZoom = 90D;
            this.btnCategoryName.IsTab = false;
            this.btnCategoryName.Location = new System.Drawing.Point(10, 67);
            this.btnCategoryName.Name = "btnCategoryName";
            this.btnCategoryName.Normalcolor = System.Drawing.Color.White;
            this.btnCategoryName.OnHovercolor = System.Drawing.Color.White;
            this.btnCategoryName.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCategoryName.selected = false;
            this.btnCategoryName.Size = new System.Drawing.Size(170, 48);
            this.btnCategoryName.TabIndex = 0;
            this.btnCategoryName.Text = "Category Name";
            this.btnCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCategoryName.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnCategoryName.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryName.Click += new System.EventHandler(this.btnCategoryName_Click);
            // 
            // ctrlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCategoryName);
            this.Name = "ctrlCategory";
            this.Size = new System.Drawing.Size(190, 190);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnCategoryName;
    }
}
