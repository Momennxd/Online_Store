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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OnlineStore_PresentationLayer.Manage_Products
{
    public partial class frmAddUpdateProduct : Form
    {
        public frmAddUpdateProduct(clsSeller seller)
        {
            InitializeComponent();
            m_seller = seller;
            m_Product = new clsProduct();
            LoadInitialedData();

            if (cbDeliveryTypes.Items.Count > 0 && cbCategories.Items.Count > 0)
            {
                cbDeliveryTypes.SelectedIndex = 0;
                cbCategories.SelectedIndex = 0;
            }

            _Mode = enMode.eAddNew;
        }

        public frmAddUpdateProduct(clsProduct Product)
        {
            InitializeComponent();
            m_Product = Product;
            m_seller = Product.Seller;
            LoadInitialedData();

            DispalyProductData();
           // openFileDialog1.FileName = Product.ImagePath;
            _Mode = enMode.eUpdate;

        }

        public event Action<object, clsProduct> OnSaveClick;
        protected virtual void SaveClick_Click(clsProduct Product)
        {
            Action<object, clsProduct> handler = OnSaveClick;
            if (handler != null)
            {
                handler(this, Product); // Raise the event with the parameter
            }
        }



        enum enMode { eUpdate, eAddNew };

        enMode _Mode = enMode.eUpdate;



        private clsSeller m_seller = new clsSeller();

        public clsSeller seller { get { return m_seller; } }

        private clsProduct m_Product = null;

        bool ValidateInfo()
        {
            return

                clsGlobal.ValidateTxtBox(txtProductName, string.IsNullOrEmpty(txtProductName.Text),
             "Please Enter The Product Name!", errorProvider1) &&

             clsGlobal.ValidateTxtBox(txtDescription, clsUser.DoesUserExist(txtDescription.Text),
             "Please enter a description to your product", errorProvider1) &&

             clsGlobal.ValidateTxtBox(txtPrice, !clsGlobal.IsNumber(txtPrice.Text),
             "Please enter a valid price to your product!", errorProvider1);
       
        }

        void LoadInitialedData()
        {
            clsGlobal.ImportDataToComboBox(cbCategories, clsCategory.GetAllCategories(), "CategoryName");
            clsGlobal.ImportDataToComboBox(cbDeliveryTypes, clsDeliveryType.GetAllDeliveringTypes(),
                "DeliveryTypeName");

        }

        bool ValidateQuantity()
        {
            if (nmrcProductQuantity.Value == 0)
            {
                if (MessageBox.Show("Out Of Stock?", "Are You Sure You Want To Add 0 Items ?", 
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }

            return true;
        }

        void LoadProductDataToObj()
        {
            m_Product.ProductName = txtProductName.Text.Trim();
            m_Product.Brand = txtBrand.Text.Trim();
            m_Product.Description = txtDescription.Text.Trim();
            m_Product.Price = Convert.ToDecimal(txtPrice.Text);
            m_Product.Quantity = Convert.ToInt32(nmrcProductQuantity.Value);
            m_Product.CategoryID = clsCategory.Find(cbCategories.SelectedItem.ToString()).CategoryID;
            m_Product.InStock = Convert.ToInt32(nmrcProductQuantity.Value) > 0;
            m_Product.SellerID = m_seller.SellerID;
            m_Product.CreationDate = DateTime.Now;
            m_Product.DeliveringTypeID = clsDeliveryType.Find(cbDeliveryTypes.SelectedItem.ToString()).DeliveryTypeID;
            //m_Product.ImagePath = openFileDialog1.FileName;

        }

        void SaveProductImage()
        {
            if (!string.IsNullOrEmpty(pbProductImage.ImageLocation))
            {
                Guid GUID = Guid.NewGuid();
                string NewPath = clsGlobal.ProductsImagesFilePath + GUID.ToString() + ".jpg";
                File.Copy(pbProductImage.ImageLocation, NewPath);
                m_Product.ImagePath = NewPath;
            }
            else
            {
                m_Product.ImagePath = null;
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
                if (!string.IsNullOrEmpty(m_Product.ImagePath))
                    clsGlobal.DeleteOldSourceFile(m_Product.ImagePath);

                SaveProductImage();
            }         
           
        }

        void AlterFormToUpdateMode()
        {
            lblFormHeader.Text = "Update Your Product Now!";
        }

        void AlterFormToAddNewMode()
        {
            lblFormHeader.Text = "Add Your Own Product Now!";
        }

        void AlterForm(enMode Mode)
        {
            switch (Mode)
            {
                case enMode.eUpdate:
                    {
                        AlterFormToUpdateMode();
                        break;
                    }
                case enMode.eAddNew:
                    {
                        AlterFormToAddNewMode();
                        break;
                    }
            }
        }

        void DispalyProductData()
        {
            if (m_Product == null)
                return;

            clsGlobal.ShowItemAsSelectedOnComboBoxByName(ref cbCategories,
                m_Product.Category.CategoryName);

            clsGlobal.ShowItemAsSelectedOnComboBoxByName(ref cbDeliveryTypes,
                m_Product.DeliveryType.DeliveryTypeName);

            nmrcProductQuantity.Value = Convert.ToDecimal(m_Product.Quantity);

            txtPrice.Text = m_Product.Price.ToString();

            txtDescription.Text = m_Product.Description;

            txtBrand.Text = m_Product.Brand;

            txtProductName.Text = m_Product.ProductName;

            pbProductImage.ImageLocation = m_Product.ImagePath;


        }

        //this function is made by popa
        void PerformAddingProductTransaction()
        {
            clsVisa CurrentSellerVisa = clsVisa.FindByUserID(m_seller.UserID);
            int TotalFee = Convert.ToInt32(clsGlobal.AddingNewProductFeePerc / 100 * m_Product.Price);
            CurrentSellerVisa.Add(-TotalFee);

            //here we assume that momen nasr is the admin and every tranaction precentage goes to his wallet 
            
            clsVisa AdminVisa = clsVisa.FindByUserID(1);
            AdminVisa.Add(Convert.ToInt32(TotalFee));
        }

        
        bool SaveProduct()
        {
            if (ValidateInfo() && ValidateQuantity() &&
                clsGlobal.ValidateSellerVisaForAddingProduct(m_seller,
                Convert.ToInt32(Convert.ToDecimal(txtPrice.Text))))
            {
            
                if (MessageBox.Show("Are you sure you want to save ?", "Save?", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {

                    PerformProductImageSave();
                    LoadProductDataToObj();


                    if (m_Product.Save())
                    {
                        MessageBox.Show("Product Saved Successfully", "Successed");

                        //adding the product to the main godly list:
                        if (_Mode == enMode.eAddNew)
                        {
                            clsGlobal.AddProductToMainCtrlProductsList(m_Product);
                            PerformAddingProductTransaction();
                        }
                        else
                        {
                            clsGlobal.UpdateProductInMainList(m_Product);
                        }
                        //handling the transaction:
                        return true;
                    }
                    else
                        MessageBox.Show("Failed To Add Saved", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            return false;
        }
















        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DeliveryTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDeliveryTypeFee.Text = lblDeliveryTypeFee.Tag + " " + clsDeliveryType.Find(cbDeliveryTypes.SelectedItem.ToString()).DeliveryFee + "$";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SaveProduct())
            {
                OnSaveClick?.Invoke(this, m_Product);
                this.Close();

            }
        }

        private void frmAddUpdateProduct_Load(object sender, EventArgs e)
        {
            AlterForm(_Mode);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Wanna Cancel ?", "Exit ?",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbProductImage.Image = Resources.add_product;
            pbProductImage.ImageLocation = "";
            openFileDialog1.FileName = "";
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbProductImage.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
