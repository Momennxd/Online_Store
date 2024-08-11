namespace OnlineStore_PresentationLayer.User_Controls
{
    partial class ctrlProductsFilter
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
            this.gnReviewsFilter = new System.Windows.Forms.GroupBox();
            this.rbAll = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn5Stars = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb4Stars = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb3StarsOrLess = new MaterialSkin.Controls.MaterialRadioButton();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.btnConfirmSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtMaxValue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinValue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gnReviewsFilter.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnReviewsFilter
            // 
            this.gnReviewsFilter.Controls.Add(this.rbAll);
            this.gnReviewsFilter.Controls.Add(this.btn5Stars);
            this.gnReviewsFilter.Controls.Add(this.rb4Stars);
            this.gnReviewsFilter.Controls.Add(this.rb3StarsOrLess);
            this.gnReviewsFilter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnReviewsFilter.Location = new System.Drawing.Point(12, 6);
            this.gnReviewsFilter.Name = "gnReviewsFilter";
            this.gnReviewsFilter.Size = new System.Drawing.Size(170, 190);
            this.gnReviewsFilter.TabIndex = 1;
            this.gnReviewsFilter.TabStop = false;
            this.gnReviewsFilter.Text = "Reviews";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Depth = 0;
            this.rbAll.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(12, 141);
            this.rbAll.Margin = new System.Windows.Forms.Padding(0);
            this.rbAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAll.Name = "rbAll";
            this.rbAll.Ripple = true;
            this.rbAll.Size = new System.Drawing.Size(53, 37);
            this.rbAll.TabIndex = 3;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbReviewFilterVal_CheckedChanged);
            // 
            // btn5Stars
            // 
            this.btn5Stars.AutoSize = true;
            this.btn5Stars.Depth = 0;
            this.btn5Stars.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Stars.Location = new System.Drawing.Point(12, 101);
            this.btn5Stars.Margin = new System.Windows.Forms.Padding(0);
            this.btn5Stars.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn5Stars.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn5Stars.Name = "btn5Stars";
            this.btn5Stars.Ripple = true;
            this.btn5Stars.Size = new System.Drawing.Size(85, 37);
            this.btn5Stars.TabIndex = 2;
            this.btn5Stars.TabStop = true;
            this.btn5Stars.Text = "5 Stars";
            this.btn5Stars.UseVisualStyleBackColor = true;
            this.btn5Stars.CheckedChanged += new System.EventHandler(this.rbReviewFilterVal_CheckedChanged);
            // 
            // rb4Stars
            // 
            this.rb4Stars.AutoSize = true;
            this.rb4Stars.Depth = 0;
            this.rb4Stars.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4Stars.Location = new System.Drawing.Point(12, 61);
            this.rb4Stars.Margin = new System.Windows.Forms.Padding(0);
            this.rb4Stars.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb4Stars.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb4Stars.Name = "rb4Stars";
            this.rb4Stars.Ripple = true;
            this.rb4Stars.Size = new System.Drawing.Size(85, 37);
            this.rb4Stars.TabIndex = 1;
            this.rb4Stars.TabStop = true;
            this.rb4Stars.Text = "4 Stars";
            this.rb4Stars.UseVisualStyleBackColor = true;
            this.rb4Stars.CheckedChanged += new System.EventHandler(this.rbReviewFilterVal_CheckedChanged);
            // 
            // rb3StarsOrLess
            // 
            this.rb3StarsOrLess.AutoSize = true;
            this.rb3StarsOrLess.Depth = 0;
            this.rb3StarsOrLess.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3StarsOrLess.Location = new System.Drawing.Point(12, 21);
            this.rb3StarsOrLess.Margin = new System.Windows.Forms.Padding(0);
            this.rb3StarsOrLess.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb3StarsOrLess.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb3StarsOrLess.Name = "rb3StarsOrLess";
            this.rb3StarsOrLess.Ripple = true;
            this.rb3StarsOrLess.Size = new System.Drawing.Size(97, 37);
            this.rb3StarsOrLess.TabIndex = 0;
            this.rb3StarsOrLess.TabStop = true;
            this.rb3StarsOrLess.Text = "> 3 Stars";
            this.rb3StarsOrLess.UseVisualStyleBackColor = true;
            this.rb3StarsOrLess.CheckedChanged += new System.EventHandler(this.rbReviewFilterVal_CheckedChanged);
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.btnConfirmSearch);
            this.gbPrice.Controls.Add(this.txtMaxValue);
            this.gbPrice.Controls.Add(this.label1);
            this.gbPrice.Controls.Add(this.txtMinValue);
            this.gbPrice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrice.Location = new System.Drawing.Point(12, 202);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(170, 148);
            this.gbPrice.TabIndex = 4;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Price";
            // 
            // btnConfirmSearch
            // 
            this.btnConfirmSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmSearch.Depth = 0;
            this.btnConfirmSearch.HighEmphasis = true;
            this.btnConfirmSearch.Icon = null;
            this.btnConfirmSearch.Location = new System.Drawing.Point(52, 93);
            this.btnConfirmSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmSearch.Name = "btnConfirmSearch";
            this.btnConfirmSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmSearch.Size = new System.Drawing.Size(64, 36);
            this.btnConfirmSearch.TabIndex = 8;
            this.btnConfirmSearch.Text = "Ok";
            this.btnConfirmSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmSearch.UseAccentColor = false;
            this.btnConfirmSearch.UseVisualStyleBackColor = true;
            this.btnConfirmSearch.Click += new System.EventHandler(this.btnConfirmSearch_Click);
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaxValue.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtMaxValue.HintText = "Max";
            this.txtMaxValue.isPassword = false;
            this.txtMaxValue.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMaxValue.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaxValue.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMaxValue.LineThickness = 3;
            this.txtMaxValue.Location = new System.Drawing.Point(102, 43);
            this.txtMaxValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(58, 28);
            this.txtMaxValue.TabIndex = 7;
            this.txtMaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // txtMinValue
            // 
            this.txtMinValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMinValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMinValue.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtMinValue.HintText = "Min";
            this.txtMinValue.isPassword = false;
            this.txtMinValue.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMinValue.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMinValue.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMinValue.LineThickness = 3;
            this.txtMinValue.Location = new System.Drawing.Point(7, 43);
            this.txtMinValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(58, 28);
            this.txtMinValue.TabIndex = 5;
            this.txtMinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ctrlProductsFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.gnReviewsFilter);
            this.Name = "ctrlProductsFilter";
            this.Size = new System.Drawing.Size(194, 826);
            this.gnReviewsFilter.ResumeLayout(false);
            this.gnReviewsFilter.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gnReviewsFilter;
        private MaterialSkin.Controls.MaterialRadioButton btn5Stars;
        private MaterialSkin.Controls.MaterialRadioButton rb4Stars;
        private MaterialSkin.Controls.MaterialRadioButton rb3StarsOrLess;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnConfirmSearch;
        public MaterialSkin.Controls.MaterialRadioButton rbAll;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtMinValue;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtMaxValue;
    }
}
