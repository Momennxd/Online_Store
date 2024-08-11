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
    public partial class ctrlCartProduct : UserControl
    {
        public ctrlCartProduct()
        {
            InitializeComponent();
        }


        public event Action<object, clsProduct> OnCartProductClick;
        protected virtual void CartProduct_Click(clsProduct Product)
        {
            Action<object, clsProduct> handler = OnCartProductClick;
            if (handler != null)
            {
                handler(this, Product); // Raise the event with the parameter
            }
        }

        public event Action<object, clsProduct> OnProccessBuyingClick;
        protected virtual void PoroccessBuying_Click(clsProduct Product)
        {
            Action<object, clsProduct> handler = OnCartProductClick;
            if (handler != null)
            {
                handler(this, Product); // Raise the event with the parameter
            }
        }


        public event Action<object> OnRemoveClick;
        protected virtual void RemoveFromCart_Click()
        {
            Action<object> handler = OnRemoveClick;
            if (handler != null)
            {
                handler(this); // Raise the event with the parameter
            }
        }



        private clsProduct _CurrentProduct = new clsProduct();

        public clsProduct CurrentProduct { get { return _CurrentProduct; } }




        private void _LoadProductDataOnForm()
        {
            pbProductImage.ImageLocation = CurrentProduct.ImagePath;
          
            lblProductName.Text = CurrentProduct.ProductName.Trim();
            CurrentProduct.Price = Math.Round(CurrentProduct.Price, 2);
            lblPrice.Text = CurrentProduct.Price.ToString() + "$";
            strsAvrgRating.Value = _CurrentProduct.AvrgReviews;
            lblNumOfRatingUsers.Text = "(" + _CurrentProduct.NumberOfReviews.ToString() + ")";

          
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




        private void ctrlCartProduct_Click(object sender, EventArgs e)
        {
            OnCartProductClick?.Invoke(this, _CurrentProduct);
        }

        private void btnProcessBuying_Click(object sender, EventArgs e)
        {
            OnProccessBuyingClick?.Invoke(this, _CurrentProduct);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            clsGlobal.frmProductsList.AddToCartClick(this, false, _CurrentProduct);

            clsGlobal.ctrlProductThumbNailsList
                [clsGlobal.GetProductIndexInList(_CurrentProduct)].PerformAddToCartClick();

            OnRemoveClick?.Invoke(this);
        }
    }
}
