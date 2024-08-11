using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
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
    public partial class ctrlAddProductReview : UserControl
    {
        public ctrlAddProductReview(clsProduct Product)
        {
            InitializeComponent();
            if (clsGlobal.CurrentUser != null) pbUserPic.ImageLocation = clsGlobal.CurrentUser.ProfilePic;
            _Product = Product;
        }

        public event Action<object, clsProduct> OnSubmitClick;
        protected virtual void SubmitClick_Click(clsProduct Product)
        {
            Action<object, clsProduct> handler = OnSubmitClick;
            if (handler != null)
            {
                handler(this, Product); // Raise the event with the parameter
            }
        }


        clsProductReview _ProductReview = new clsProductReview();

        public clsProductReview ProductReview { get { return _ProductReview; } }

        clsProduct _Product = new clsProduct();

        public clsProduct Product { get { return _Product; } }


        bool SubmitReview()
        {

            if (clsGlobal.CurrentUser == null)
                return false;

            _ProductReview.ReviewComment = txtReviewComment.Text.Trim();
            _ProductReview.Rating = Convert.ToByte(strsAvrgRating.Value);
            _ProductReview.RatingDate = DateTime.Now;
            _ProductReview.UserID = clsGlobal.CurrentUser.UserID;
            _ProductReview.ProductID = _Product.ProductID;
            return _ProductReview.Save();

        }


       
















        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitReview();


            //Raising event
            OnSubmitClick?.Invoke(this, _ProductReview.Product);
        }

        private void txtReviewComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitReview();


                //Raising event
                OnSubmitClick?.Invoke(this, _ProductReview.Product);
            }
        }
    }
}
