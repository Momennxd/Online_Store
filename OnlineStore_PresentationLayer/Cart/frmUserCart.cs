using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Products_List;
using OnlineStore_PresentationLayer.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer.Cart
{
    public partial class frmUserCart : Form
    {
        public frmUserCart()
        {
            InitializeComponent();
            clsGlobal.CurrentOpendForm = this;
        }

        void ShowCartProductOnFlowPanel(clsProduct product)
        {
            ctrlCartProduct cartProduct = new ctrlCartProduct();
            //here you should add the events:
            cartProduct.OnCartProductClick += CartProduct_Click;
            cartProduct.OnRemoveClick += RefreshForm;

            cartProduct.DisplayProductData(product);
            FpnlCartProducts.Controls.Add(cartProduct);
        }

        void DisplayCartProducts(DataTable dtCart)
        {
            FpnlCartProducts.Controls.Clear();
            //Repeating products for testing
            //for (int i= 0; i < 30; i ++)
            {
                foreach (DataRow row in dtCart.Rows)
                {
                    ShowCartProductOnFlowPanel(clsProduct.Find(Convert.ToInt16(row["ProductID"])));
                }
            }

            if (dtCart.Rows.Count == 0)
                lblEmptyProducts.Visible = true;
           
        }




        void RefreshForm(object sender)
        {
            frmUserCart_Load(sender, EventArgs.Empty);
        }

        private void frmUserCart_Load(object sender, EventArgs e)
        {
            
            DisplayCartProducts(clsCart.GetAllItemsInCart(clsGlobal.CurrentUser.UserID));
        }

        private void CartProduct_Click(object sender, clsProduct Product)
        {
            frmProductDetails frmProductDetails_v = new frmProductDetails(Product);
            clsGlobal.ShowFormInPanel(
                clsGlobal.MainScreenFormObj.pnlMainScreenFormsLoader, frmProductDetails_v);

        }

    }
}
