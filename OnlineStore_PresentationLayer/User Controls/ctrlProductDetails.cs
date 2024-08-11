using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Manage_Products;
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
    public partial class ctrlProductDetails : UserControl
    {
        public ctrlProductDetails()
        {
            InitializeComponent();
        }


        public event Action<object, bool, clsProduct> OnFavouritClick;
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


        public event Action<object, int> OnBuyClick;
        protected virtual void BuyNow_Click(int UserQuantity)
        {
            Action<object, int> handler = OnBuyClick;
            if (handler != null)
            {
                handler(this, UserQuantity); // Raise the event with the parameter
            }
        }


        public event Action<object, clsSeller> OnSellerClick;
        protected virtual void Seller_Click(clsSeller Seller)
        {
            Action<object, clsSeller> handler = OnSellerClick;
            if (handler != null)
            {
                handler(this, Seller); // Raise the event with the parameter
            }
        }


        public event Action<object, clsProduct> OnEditProduct;
        protected virtual void EditProduct_Click(clsProduct Product)
        {
            Action<object, clsProduct> handler = OnEditProduct;
            if (handler != null)
            {
                handler(this, Product); // Raise the event with the parameter
            }
        }

        public event Action<object, clsProduct> OnMarketProductClick;
        protected virtual void MarketProduct_Click(clsProduct Product)
        {
            Action<object, clsProduct> handler = OnMarketProductClick;
            if (handler != null)
            {
                handler(this, Product); // Raise the event with the parameter
            }
        }



        private clsProduct _Product = new clsProduct();

        public clsProduct Product { get {  return _Product; } }


        void _LoadProductDataOnForm()
        {
            //set the edit if the the Product seller is logged in:
            if (clsGlobal.CurrentSeller != null && _Product.SellerID == clsGlobal.CurrentSeller.SellerID)
            {
                btnEditProduct.Visible = true;
                btnMarketProduct.Visible = true;

            }
            else
            {
                btnMarketProduct.Visible = false;
                btnEditProduct.Visible = false;
            }





            lblProductCategoryPath.Text = _Product.Category.CategoryName + " / " + _Product.ProductName;
            lblProductName.Text = _Product.ProductName;
            pbProductPic.ImageLocation = _Product.ImagePath;

            if (clsGlobal.CurrentUser != null)
            {
                if (clsFavProduct.DoesProductExistInFavList(_Product.ProductID,
                    clsGlobal.CurrentUser.UserID))
                {
                    clsGlobal.PerfomTwoStatesButtonStyle(btnHeart,
                    Resources.icons8_heart_48__1_, Resources.icons8_heart_50);
                }
            }

            txtProductDescription.Text = _Product.Description.Trim();
            strsAvrgRating.Value = _Product.AvrgReviews;
            lblNumOfRatingUsers.Text = "(" + _Product.NumberOfReviews.ToString() + ")";
            lblPrice.Text = "$" + _Product.Price.ToString();
            lblBrandText.Text = lblBrandText.Tag + " " + _Product.Brand.ToString();

            SetProductQuantityMinMax();
            lblQuantityText.Text = "Only " + _Product.Quantity.ToString() +" Items Left \nDon't Miss!";

            if (!_Product.InStock)
            {
                lblInStock.ForeColor = Color.Red;
                lblInStock.Text = "Out Of Stock";
            }

            lblDeliveringFeeText.Text = lblDeliveringFeeText.Tag + " $" + Math.Round(_Product.DeliveryType.DeliveryFee, 2);
            pbSellerPic.ImageLocation = _Product.Seller.User.ProfilePic;
            lblSellerFullName.Text = _Product.Seller.User.FullName;
            lblEmail.Text = _Product.Seller.User.Email;
            lblFollowers.Text = _Product.Seller.Followers.ToString() + " Followers";

            if (clsGlobal.CurrentUser != null)
            {
                if (clsCart.DoesProductExistInCartList(_Product.ProductID,
                    clsGlobal.CurrentUser.UserID))
                {
                    PerformAddToCartClick();
                }
            }




        }

        void PerformAddToCartClick()
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
            _Product = product;
            _LoadProductDataOnForm();
        }

        public void DisplayProductData(int productID)
        {
            _Product = clsProduct.Find(productID);
            _LoadProductDataOnForm();
        }

        void SetProductQuantityMinMax()
        {
            nmrcUserQuantity.Minimum = 0;
            nmrcUserQuantity.Maximum = _Product.Quantity;
        }




















        private void btnHeart_Click(object sender, EventArgs e)
        {
            clsGlobal.PerfomTwoStatesButtonStyle(btnHeart,
               Resources.icons8_heart_48__1_, Resources.icons8_heart_50);

            clsGlobal.PerfomTwoStatesButtonStyle(
                clsGlobal.ctrlProductThumbNailsList[clsGlobal.GetProductIndexInList(Product)].btnHeart,
                Resources.icons8_heart_48__1_, Resources.icons8_heart_50);


            //calling the event
            OnFavouritClick?.Invoke(this, btnHeart.Tag.ToString() != "0", _Product);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            PerformAddToCartClick();

            clsGlobal.ctrlProductThumbNailsList[clsGlobal.GetProductIndexInList(Product)].PerformAddToCartClick();


            //calling the event
            OnAddToCartClick?.Invoke(this, btnAddToCart.Tag.ToString() != "0", _Product);
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            if (_Product.Quantity > 0)
            {
                OnBuyClick?.Invoke(this, Convert.ToInt16(nmrcUserQuantity.Value));
            }
            else
            {
                MessageBox.Show(
                    "Sorry, You This Quantity In InValid\nPlease Enter A Number Between 0 - 100 Items");
            }

        }

        private void pbSeller_Click(object sender, EventArgs e)
        {
            OnSellerClick?.Invoke(this, _Product.Seller);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            OnEditProduct?.Invoke(this, _Product);
        }

        private void btnMarketProduct_Click(object sender, EventArgs e)
        {
            OnMarketProductClick?.Invoke(this, _Product);
        }
    }
}
