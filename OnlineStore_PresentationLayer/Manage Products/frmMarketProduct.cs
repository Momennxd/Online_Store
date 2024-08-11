using DVLD_BusinessLayer;
using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer.Manage_Products
{
    public partial class frmMarketProduct : Form
    {
        public frmMarketProduct(clsProduct Product)
        {
            InitializeComponent();
            m_Product = Product;

        }


        private clsProduct m_Product = new clsProduct();

        private clsAd m_Ad = new clsAd();

        bool ValidateInfo()
        {
            return

                clsGlobal.ValidateTxtBox(txtAdDescription, string.IsNullOrEmpty(txtAdDescription.Text),
             "Please Enter Your Add Description!", errorProvider1) &&  
             
             pbAdImage.ImageLocation != "" &&

             clsGlobal.ValidateCustomDatePicker(dpAdEndDate, DateTime.Now, DateTime.MaxValue,
             "End Date Can't be in the past!", errorProvider1);

        }

        bool ValidateImage()
        {
           if (string.IsNullOrEmpty(pbAdImage.ImageLocation))
           {
                MessageBox.Show("Dont Forget To Add Your Ad Image",
                    "Image Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
           }

            return true;

        }

        void LoadDataToAdObj()
        {
            m_Ad.SellerID = clsGlobal.CurrentSeller.SellerID;
            m_Ad.Description = txtAdDescription.Text.Trim();
            //100 dollars each day as the fee:
            m_Ad.AddFee = Convert.ToDecimal((dpAdEndDate.Value - DateTime.Now).TotalDays) * 100;
            m_Ad.StartDate = DateTime.Now;
            m_Ad.EndDate = dpAdEndDate.Value;
            m_Ad.IsAvailable = true;
            m_Ad.ProductID = m_Product.ProductID;
        }

        void SaveProductImage()
        {
            if (!string.IsNullOrEmpty(pbAdImage.ImageLocation))
            {
                Guid GUID = Guid.NewGuid();
                string NewPath = clsGlobal.AdsImagesFilePath + GUID.ToString() + ".jpg";
                File.Copy(pbAdImage.ImageLocation, NewPath);
                m_Ad.AddPicPath = NewPath;
            }
            else
            {
                m_Ad.AddPicPath = null;
            }


        }

        void PerformProductImageSave()
        {
            //if (!string.IsNullOrEmpty(m_Product.ImagePath) && m_Product.ImagePath != pbProductImage.ImageLocation)
            //{
            //    clsGlobal.DeleteOldSourceFile(m_Product.ImagePath);
            //}

            //SaveProductImage();


            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                if (!string.IsNullOrEmpty(m_Ad.AddPicPath))
                    clsGlobal.DeleteOldSourceFile(m_Ad.AddPicPath);

                SaveProductImage();
            }

        }

        void PerformAddingProductTransaction()
        {
            clsVisa CurrentSellerVisa = clsVisa.FindByUserID(m_Product.Seller.UserID);
            int TotalFee = Convert.ToInt16((dpAdEndDate.Value - DateTime.Now).TotalDays) * 100;
            CurrentSellerVisa.Add(-TotalFee);

            //here we assume that momen nasr is the admin and every tranaction precentage goes to his wallet 

            clsVisa AdminVisa = clsVisa.FindByUserID(1);
            AdminVisa.Add(Convert.ToInt32(TotalFee));
        }

        bool SaveAdd()
        {
            if (ValidateInfo() && ValidateImage() && 
                clsGlobal.ValidateSellerVisaForMarketingProduct(m_Product.Seller,
                Convert.ToInt32(Convert.ToDecimal((dpAdEndDate.Value - DateTime.Now).TotalDays) * 100)))
            {

                if (MessageBox.Show("Are you sure you want to save ?", "Save?", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {

                    PerformProductImageSave();
                    LoadDataToAdObj();


                    if (m_Ad.Save())
                    {
                        //handling the transaction:
                        PerformAddingProductTransaction();
                        MessageBox.Show("Ad Saved Successfully", "Successed");
                        return true;
                    }
                    else
                        MessageBox.Show("Failed To Save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dpAdEndDate_onValueChanged(object sender, EventArgs e)
        {
            lblTotalFee.Text = lblTotalFee.Tag.ToString() +
                (Convert.ToInt16((dpAdEndDate.Value - DateTime.Now).TotalDays) * 100) + "$";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (SaveAdd())
                this.Close();
        }

        private void pbAdImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbAdImage.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbAdImage.Image = Resources.search;
            pbAdImage.ImageLocation = "";
            openFileDialog1.FileName = "";
        }
    }
}
