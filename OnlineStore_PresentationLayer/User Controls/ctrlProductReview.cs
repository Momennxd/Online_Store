using DVLD_BusinessLayer;
using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Properties;
using OnlineStore_PresentationLayer.User_Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer.User_Controls
{
    public partial class ctrlProductReview : UserControl
    {
        public ctrlProductReview()
        {
            InitializeComponent();
        }

        public event Action<object, bool> OnLikeClick;
        protected virtual void Like_Click(bool Like)
        {
            Action<object, bool> handler = OnLikeClick;
            if (handler != null)
            {
                handler(this, Like); // Raise the event with the parameter
            }
        }


        public event Action<object, clsProduct> OnDeleteClick;
        protected virtual void Delete_Click(clsProduct product)
        {
            Action<object, clsProduct> handler = OnDeleteClick;
            if (handler != null)
            {
                handler(this, product); // Raise the event with the parameter
            }
        }

        public event Action<object, clsProduct> OnSaveClick;
        protected virtual void Save_Click(clsProduct Product)
        {
            Action<object, clsProduct> handler = OnSaveClick;
            if (handler != null)
            {
                handler(this, Product); // Raise the event with the parameter
            }
        }

        public enum enMode { eShow = 1, eEdit = 2, eDelete = 3 }
        public enMode mode = enMode.eShow;


        clsProductReview _ProductReview = new clsProductReview();

        public clsProductReview ProductReview { get {  return _ProductReview; } }

        void _LoadReviewDataOnForm()
        {
            pbUserPic.ImageLocation = _ProductReview.User.ProfilePic;

            
            lblFullName.Text = _ProductReview.User.FullName + "    " +
                DateTime.Now.Subtract(_ProductReview.RatingDate).Days + " Days";
            if (_ProductReview.User.FullName == clsGlobal.CurrentUser.FullName)
                lblFullName.ForeColor = Color.FromArgb(66, 168, 66);

            txtReviewComment.Text = _ProductReview.ReviewComment.Trim();
            strsAvrgRating.Value = _ProductReview.Rating;
            lblLikes.Text = _ProductReview.ProductReviewLikes.ToString();

            if (clsProductReviewLike.DoesUserLikeProductReview(_ProductReview.ProductReviewID,
                clsGlobal.CurrentUser.UserID))
            {
                btnLike.Image = Resources.icons8_heart_50;
                btnLike.Tag = "1";
            }
           
        }


        void EnableEditMode()
        {
            txtReviewComment.ReadOnly = false;
            txtReviewComment.BackColor = Color.WhiteSmoke;

            strsAvrgRating.Enabled = true;
            btnSave.Visible = true;

            mode = enMode.eEdit;
        }

        void DisableEditMode()
        {
            txtReviewComment.ReadOnly = true;
            txtReviewComment.BackColor = Color.White;

            strsAvrgRating.Enabled = false;
            btnSave.Visible = false;

            mode = enMode.eShow;


        }

        void LoadReviewDataToObj()
        {
            _ProductReview.ReviewComment = txtReviewComment.Text.Trim();
            _ProductReview.Rating = Convert.ToByte(strsAvrgRating.Value);
        }

        void Save()
        {
            DisableEditMode();
            LoadReviewDataToObj();
            _ProductReview.Save();

            OnSaveClick?.Invoke(this, _ProductReview.Product);
        }


        void ShowReviewerAccount()
        {

            clsUser user = _ProductReview.User;
            clsSeller seller = clsSeller.FindByUserID(user.UserID);
            frmUserProfile frmUserProfile_v;

            if (seller != null)
            {
                frmUserProfile_v = new frmUserProfile(seller,
                ctrlUserProfileHeaderInfo.enMode.eSeller, clsGlobal.CurrentUser.UserID != user.UserID);
            }
            else
            {
                frmUserProfile_v = new frmUserProfile(user,
                ctrlUserProfileHeaderInfo.enMode.eUser, clsGlobal.CurrentUser.UserID != user.UserID);
            }
          
            clsGlobal.ShowFormInPanel(clsGlobal.MainScreenFormObj.pnlMainScreenFormsLoader,
                frmUserProfile_v);

        }








        public void DisplayReviewData(clsProductReview productReview)
        {
            _ProductReview = productReview;
            if (clsGlobal.CurrentUser.UserID != productReview.UserID)
                btnShowCommentOptions.Visible = false;

            _LoadReviewDataOnForm();
        }

        public void DisplayReviewData(int ProductReviewID)
        {
            _ProductReview = clsProductReview.Find(ProductReviewID);
            _LoadReviewDataOnForm();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (btnLike.Tag.ToString() == "0")
            {
                if (clsGlobal.CurrentUser != null)
                {
                    _ProductReview.Like(clsGlobal.CurrentUser.UserID, true);
                }

                lblLikes.Text = (Convert.ToInt16(lblLikes.Text) + 1).ToString();
                btnLike.Image = Resources.icons8_heart_50;
                btnLike.Tag = "1";
            }
            else
            {
                if (clsGlobal.CurrentUser != null)
                {
                    _ProductReview.Like(clsGlobal.CurrentUser.UserID, false);
                }

                lblLikes.Text = (Convert.ToInt16(lblLikes.Text) - 1).ToString();
                btnLike.Tag = "0";
                btnLike.Image = Resources.icons8_heart_48__1_;

            }

            OnLikeClick?.Invoke(this, btnLike.Tag.ToString() != "0");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableEditMode();
        }

        private void btnShowCommentOptions_Click(object sender, EventArgs e)
        {
            cmsUserReviewOptions.Show(MousePosition);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = enMode.eDelete;


            if (clsProductReview.DeleteProductReview(_ProductReview.ProductReviewID))
            {
                OnDeleteClick?.Invoke(this, _ProductReview.Product);
            }
            else
            {
                MessageBox.Show("Failed To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mode = enMode.eShow;

            }
        }

        private void txtReviewComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        private void pbUserPic_Click(object sender, EventArgs e)
        {
            ShowReviewerAccount();
        }
    }
}
