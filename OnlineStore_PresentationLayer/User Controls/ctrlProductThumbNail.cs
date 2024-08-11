using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Properties;
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
    public partial class ctrlProductThumbNail : UserControl
    {
        public ctrlProductThumbNail()
        {
            InitializeComponent();
            bunifuElipse1.ApplyElipse(btnHeart);
        }


        public event Action<object,bool, clsProduct> OnFavouritClick;
        protected virtual void Favourite_Click(bool Favourite, clsProduct Product)
        {
            Action<object, bool, clsProduct> handler = OnFavouritClick;
            if (handler != null)
            {
                handler(this, Favourite, Product); // Raise the event with the parameter
            }
        }


        public event Action<object, bool, clsProduct> OnAddToCartClick;
        protected virtual void AddToCart_Click(bool IsAddedToCart, clsProduct Product)
        {
            Action<object, bool, clsProduct> handler = OnAddToCartClick;
            if (handler != null)
            {
                handler(this, IsAddedToCart, Product); // Raise the event with the parameter
            }
        }


        public event Action<object, clsProduct> OnProductClick;
        protected virtual void Product_Click(clsProduct Product)
        {
            Action<object, clsProduct> handler = OnProductClick;
            if (handler != null)
            {
                handler(this, Product); // Raise the event with the parameter
            }
        }



        private clsProduct _CurrentProduct = new clsProduct();

        public clsProduct CurrentProduct { get { return _CurrentProduct; } }



        private void _LoadProductDataOnForm()
        {
            pbProductImage.ImageLocation = CurrentProduct.ImagePath;

            if (clsGlobal.CurrentUser != null)
            {
                if (clsFavProduct.DoesProductExistInFavList(_CurrentProduct.ProductID,
                    clsGlobal.CurrentUser.UserID))
                {
                    clsGlobal.PerfomTwoStatesButtonStyle(btnHeart,
                    Resources.icons8_heart_48__1_, Resources.icons8_heart_50);
                }
            }

            lblProductName.Text = CurrentProduct.ProductName.Trim();
            CurrentProduct.Price = Math.Round(CurrentProduct.Price, 2);
            lblPrice.Text = CurrentProduct.Price.ToString() + "$";
            lblDescription.Text = CurrentProduct.Description.Trim();
            strsAvrgRating.Value = _CurrentProduct.AvrgReviews;
            lblNumOfRatingUsers.Text = "(" + _CurrentProduct.NumberOfReviews.ToString() + ")";
            if (!CurrentProduct.InStock)
            {
                lblInStock.ForeColor = Color.Red;
                lblInStock.Text = "Out Of Stock";
            }

            if (clsGlobal.CurrentUser != null)
            {
                if (clsCart.DoesProductExistInCartList(_CurrentProduct.ProductID,
                    clsGlobal.CurrentUser.UserID))
                {
                   PerformAddToCartClick();
                }
            }
        }

        public void PerformAddToCartClick()
        {
            if (btnAddToCart.Tag.ToString() == "0")
            {
                btnAddToCart.IdleFillColor = Color.FromArgb(0, 61, 41);
                btnAddToCart.IdleLineColor = Color.FromArgb(0, 61, 41);
                btnAddToCart.IdleForecolor = Color.White;

                btnAddToCart.ButtonText = "Added To Cart";
                btnAddToCart.Tag = "1";
            }
            else
            {
                btnAddToCart.IdleFillColor = Color.White;
                btnAddToCart.IdleLineColor = Color.FromArgb(0, 61, 41);
                btnAddToCart.IdleForecolor = Color.Black;

                btnAddToCart.ButtonText = "Add To Cart";
                btnAddToCart.Tag = "0";
            }

        }

        public void DisplayProductData(clsProduct product)
        {
            _CurrentProduct = product;
            _LoadProductDataOnForm();

        }

        public void DisplayProductData(int productID)
        {
            _CurrentProduct = clsProduct.Find(productID);
            _LoadProductDataOnForm();

        }

        private void btnHeart_Click(object sender, EventArgs e)
        {
            clsGlobal.PerfomTwoStatesButtonStyle(btnHeart,
                Resources.icons8_heart_48__1_, Resources.icons8_heart_50);


            //calling the event
            OnFavouritClick?.Invoke(this, btnHeart.Tag.ToString() != "0", _CurrentProduct);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            PerformAddToCartClick();

            //calling the event
            OnAddToCartClick?.Invoke(this, btnAddToCart.Tag.ToString() != "0", _CurrentProduct);

        }

        private void pbProduct_Click(object sender, EventArgs e)
        {
            //calling the event
            OnProductClick?.Invoke(this, this._CurrentProduct);
        }
    }
}
