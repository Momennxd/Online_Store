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

namespace OnlineStore_PresentationLayer
{
    public partial class frmBuyProductScreen : Form
    {
        public frmBuyProductScreen(clsProduct product, int orderedQuantity)
        {
            InitializeComponent();
            _Product = product;
            OrderedQuantity = orderedQuantity;
        }

        private clsProduct _Product = new clsProduct();

        public clsProduct Product { get { return _Product; } }

        private int OrderedQuantity = 0;

        private decimal TotalPrice { get { return OrderedQuantity * _Product.Price; } }

       
        void LoadProductDataOnForm()
        {
            if (_Product != null)
            {
                pbProductPic.ImageLocation = _Product.ImagePath;
                lblProductName.Text = _Product.ProductName;
                lblPrice.Text = _Product.Price.ToString();
                lblNumOfRatingUsers.Text = "(" + _Product.NumberOfReviews.ToString() + ")";
                lblDeliveringFeeText.Text = lblDeliveringFeeText.Tag + " $" +
                    Math.Round(_Product.DeliveryType.DeliveryFee, 2);
                strsAvrgRating.Value = _Product.AvrgReviews;
                nmrcUserQuantity.Value = OrderedQuantity;
                nmrcUserQuantity.Maximum = _Product.Quantity;
                lblTotalPrice.Text = TotalPrice.ToString();

                if (clsGlobal.CurrentUser.Visa != null)
                {
                    txtVisaNumber.Text = clsGlobal.CurrentUser.Visa.VisaNumber;
                    txtPIN.Text = clsGlobal.CurrentUser.Visa.PIN.ToString();
                }
               


            }
        }

        bool ValidateInfoCompletion()
        {
            return clsGlobal.ValidateTxtBox(txtVisaNumber, string.IsNullOrEmpty(txtVisaNumber.Text),
              "Please, Enter Your Visa Number!", errorProvider1) &&

              clsGlobal.ValidateTxtBox(txtPIN, string.IsNullOrEmpty(txtPIN.Text),
              "Please, Enter Your Visa PIN!", errorProvider1) &&

               ValidateQuantity() &&  ValidateVisa();

             


        }

        bool ValidateQuantity()
        {
            if (nmrcUserQuantity.Value == 0)
            {
                MessageBox.Show("Please Choose A Valide Quantity.", "Invalid Quantity",
                    MessageBoxButtons.OK);
                return false;

            }

            return true;
        }


        bool ValidateVisa()
        {
            clsVisa visa = clsVisa.FindByVisaInfo(txtVisaNumber.Text.Trim(), Convert.ToInt16(txtPIN.Text));

            if (visa != null)
            {
                return clsGlobal.ValidateUserVisaForBuyingProduct(clsGlobal.CurrentUser, TotalPrice);
            }
            else
            {
                MessageBox.Show("Sorry This Visa Does Not Exist!",
                    "Visa Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return false;

        }

        void HandleTransaction()
        {
            clsGlobal.CurrentUser.Visa.Add(Convert.ToInt32(-TotalPrice));
            _Product.Seller.User.Visa.Add(Convert.ToInt32(TotalPrice));

            //handling the transaction by adding the clsTransaction Object //TODO
        }

        bool HandleProductUpdate()
        {
            _Product.Quantity -= OrderedQuantity;
            return _Product.Save();
        }


        bool PerformBuying()
        {
            if (ValidateInfoCompletion())
            {
                if (MessageBox.Show("Are you sure you want to buy this product ?",
                    "Buy?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    HandleTransaction();
                    HandleProductUpdate();
                    MessageBox.Show("Congratulation, Process is Done Successfully", "Successed");
                    return true;

                }
            }

            return false;
        }








        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            if (PerformBuying())
                this.Close();
        }

        private void nmrcUserQuantity_ValueChanged(object sender, EventArgs e)
        {
            OrderedQuantity = Convert.ToInt16(nmrcUserQuantity.Value);
            lblTotalPrice.Text = TotalPrice.ToString();

        }

        private void frmBuyProductScreen_Load(object sender, EventArgs e)
        {
            LoadProductDataOnForm();
        }
    }
}
