using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer.User_Controls
{
    public partial class ctrlProductAd : UserControl
    {
        public ctrlProductAd()
        {
            InitializeComponent();

        }

        public class ShopNowEventArgs : EventArgs
        {
            public clsProduct Product;

            public ShopNowEventArgs(clsProduct Product)
            {
                this.Product = Product;
            }
        }

        public event Action<object, ShopNowEventArgs> OnShopNowClick;
        protected virtual void ShopNow_Click(ShopNowEventArgs shopNowEventArgs)
        {
            Action<object, ShopNowEventArgs> handler = OnShopNowClick;
            if (handler != null)
            {
                handler(this, shopNowEventArgs); // Raise the event with the parameter
            }
        }


        public class SellerEventArgs : EventArgs
        {
            public clsSeller seller;

            public SellerEventArgs(clsSeller seller)
            {
                this.seller = seller;
            }
        }

        public event Action<object, SellerEventArgs> OnSellerClick;
        protected virtual void Seller_Click(SellerEventArgs sellerEventArgs)
        {
            Action<object, SellerEventArgs> handler = OnSellerClick;
            if (handler != null)
            {
                handler(this, sellerEventArgs); // Raise the event with the parameter
            }
        }


        private clsAd _Ad = new clsAd();

        public clsAd Ad { get { return _Ad; } }



        void PerformAddToCartClick()
        {
            if (btnAddToCart.Tag.ToString() == "0")
            {
               

                btnAddToCart.IdleFillColor = Color.Black;
                btnAddToCart.IdleLineColor = Color.Black;
                btnAddToCart.IdleForecolor = Color.White;

                btnAddToCart.ButtonText = "Added To Cart";
                btnAddToCart.Tag = "1";
            }
            else
            {
                btnAddToCart.IdleFillColor = Color.White;
                btnAddToCart.IdleLineColor = Color.Black;
                btnAddToCart.IdleForecolor = Color.Black;


                btnAddToCart.ButtonText = "Add To Cart";
                btnAddToCart.Tag = "0";
            }

        }

        public void DisplayAddInfo() {

            pbAdPic.ImageLocation = _Ad.AddPicPath;
            txtProductName.Text = _Ad.Product.ProductName;
            txtAdDescription.Text = _Ad.Description;
            klblSellerName.Text = _Ad.Seller.User.FullName;

            if (clsGlobal.CurrentUser != null)
            {
                if (clsCart.DoesProductExistInCartList(_Ad.ProductID,
                    clsGlobal.CurrentUser.UserID))
                {
                    PerformAddToCartClick();
                }
            }



        }

        public void DisplayAdInfo(clsAd Ad)
        {
            _Ad = Ad;
            DisplayAddInfo();
        }
        public void DisplayAdInfo(int AdID)
        {
            _Ad = clsAd.Find(AdID);
            DisplayAddInfo();
        }










        private void btnShopNow_Click(object sender, EventArgs e)
        {
            OnShopNowClick?.Invoke(this, new ShopNowEventArgs(_Ad.Product));
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser == null)
                return;

            PerformAddToCartClick();

            clsGlobal.ctrlProductThumbNailsList[
                clsGlobal.GetProductIndexInList(_Ad.Product)].PerformAddToCartClick();           

            if (btnAddToCart.Tag.ToString() == "1")
            {
                _Ad.Product.AddToCart(clsGlobal.CurrentUser.UserID);
            }
            else
            {
                _Ad.Product.RemoveFromCart(clsGlobal.CurrentUser.UserID);
            }


        }

        private void klblSellerName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnSellerClick?.Invoke(this, new SellerEventArgs(_Ad.Seller));
        }
    }
}
