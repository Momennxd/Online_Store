using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Manage_Products;
using OnlineStore_PresentationLayer.User_Controls;
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

namespace OnlineStore_PresentationLayer.Products_List
{
    public partial class frmProductDetails : Form
    {
        public frmProductDetails(clsProduct Product)
        {
            InitializeComponent();
            CurrentProduct = Product;
        }

        public frmProductDetails(int ProductID)
        {
            InitializeComponent();
            CurrentProduct = clsProduct.Find(ProductID);
        }
   
        clsProduct CurrentProduct = new clsProduct();

        ctrlProductDetails ProductDetails = new ctrlProductDetails();

        List<ctrlProductReview> ProductReviewsList = new List<ctrlProductReview>();
            
        void AddProductCtrlToFlowPanel()
        {
            ctrlProductDetails productDetails = new ctrlProductDetails();
            productDetails.DisplayProductData(CurrentProduct);

            //adding events
            productDetails.OnAddToCartClick += clsGlobal.frmProductsList.AddToCartClick;
            productDetails.OnFavouritClick += clsGlobal.frmProductsList.FavouritClick;
            productDetails.OnSellerClick += ShowSellerAccount;
            productDetails.OnEditProduct += ShowUpdateProductForm;
            productDetails.OnMarketProductClick += ShowMarketProductForm;
            productDetails.OnBuyClick += ShowBuyProductScreen;

            //add buy product event here 

            ProductDetails = productDetails;
            FpnlProductDetails.Controls.Add(productDetails);
        }

        void ShowBuyProductScreen(object sender, int Quantity)
        {
            frmBuyProductScreen frmBuyProductScreen_v = new frmBuyProductScreen(CurrentProduct, Quantity);
            frmBuyProductScreen_v.ShowDialog();
        }


        void AddProductReviewsCtrlToFlowPanel()
        {
            DataTable ProductReviews =
                clsProductReview.GetAllProductReviewsByProductID(CurrentProduct.ProductID);

            foreach(DataRow Row in ProductReviews.Rows)
            {
                ctrlProductReview productReview = new ctrlProductReview();
                productReview.DisplayReviewData(clsProductReview.Find(Convert.ToInt16(Row["ProductReviewID"])));
                //adding events
                productReview.OnDeleteClick += RefreshFormAfterDeletingEditingComment;
                productReview.OnSaveClick += RefreshFormAfterDeletingEditingComment;

                ProductReviewsList.Add(productReview);
                FpnlProductDetails.Controls.Add(productReview);
            }
        }


        void AddReviewAddingToFlowPanel()
        {
            if (!clsGlobal.CurrentUser.DoesUserHaveReview(CurrentProduct.ProductID))
            {
                ctrlAddProductReview addProductReview = new ctrlAddProductReview(CurrentProduct);
                addProductReview.OnSubmitClick += RefreshFormAfterAddingComment;
                FpnlProductDetails.Controls.Add(addProductReview);
            }
            
        }

        void ApplyChangesToPorductList(clsProduct Product)
        {

            int ProductIndexInList = clsGlobal.GetProductIndexInList(Product);

            clsGlobal.ctrlProductThumbNailsList[ProductIndexInList].strsAvrgRating.Value =
                Product.AvrgReviews;

            clsGlobal.ctrlProductThumbNailsList[ProductIndexInList].lblNumOfRatingUsers.Text = "(" + 
                Product.NumberOfReviews.ToString() + ")";


        }

        void ApplyChangesToProductREVIEWSList(ctrlProductReview ProductReview)
        {
            int ProductRiviewIndexInList =
                clsGlobal.GetProductRiviewIndexInList(ProductReview, ProductReviewsList);

            ProductReviewsList.Remove(ProductReviewsList[ProductRiviewIndexInList]);
        }

        void ManageLastAddedReview(ref ctrlProductReview LastAddedReview)
        {
            LastAddedReview.OnDeleteClick += RefreshFormAfterDeletingEditingComment;
            LastAddedReview.OnSaveClick += RefreshFormAfterDeletingEditingComment;
            ProductReviewsList.Add(LastAddedReview);
        }


        void RefreshFormAfterAddingComment(object sender, clsProduct Product)
        {
            FpnlProductDetails.Controls.Clear();
            FpnlProductDetails.Controls.Add(ProductDetails);

            ctrlProductReview LastAddedReview = new ctrlProductReview();



            LastAddedReview.DisplayReviewData(
            clsProductReview.Find(
             clsGlobal.CurrentUser.UserID, CurrentProduct.ProductID));
            FpnlProductDetails.Controls.Add(LastAddedReview);


            ManageLastAddedReview(ref LastAddedReview);
            FpnlProductDetails.Controls.AddRange(ProductReviewsList.ToArray());


            ApplyChangesToPorductList(Product);


        }

        void RefreshFormAfterDeletingEditingComment(object sender, clsProduct Product)
        {
            FpnlProductDetails.Controls.Clear();
            FpnlProductDetails.Controls.Add(ProductDetails);

            if (((ctrlProductReview)sender).mode == ctrlProductReview.enMode.eDelete)
                ApplyChangesToProductREVIEWSList((ctrlProductReview)sender);

            AddReviewAddingToFlowPanel();
            FpnlProductDetails.Controls.AddRange(ProductReviewsList.ToArray());


            ApplyChangesToPorductList(Product);
        }


        void PrepareFormToLoad()
        {
            FpnlProductDetails.Controls.Clear();
            AddProductCtrlToFlowPanel();
            AddReviewAddingToFlowPanel();
            AddProductReviewsCtrlToFlowPanel();
        }

        void ShowMainMenuScreen(object sender, clsProduct product)
        {
            //clsGlobal.ShowFormInPanel(clsGlobal.MainScreenFormObj.pnlMainScreenFormsLoader,
            //    clsGlobal.MainScreenFormObj);
        }

        void ShowSellerAccount(object sender, clsSeller seller)
        {
            frmUserProfile frmUserProfile_v = new frmUserProfile(seller, ctrlUserProfileHeaderInfo.enMode.eSeller, clsGlobal.CurrentUser.UserID != seller.UserID);
            clsGlobal.ShowFormInPanel(clsGlobal.MainScreenFormObj.pnlMainScreenFormsLoader, frmUserProfile_v);
        }

        void ShowUpdateProductForm(object sender, clsProduct product)
        {
            frmAddUpdateProduct frmAddUpdateProduct_v = new frmAddUpdateProduct(product);
            frmAddUpdateProduct_v.OnSaveClick += ShowMainMenuScreen;
            frmAddUpdateProduct_v.ShowDialog();

        }

        void ShowMarketProductForm(object sender, clsProduct product)
        {
            frmMarketProduct frmMarketProduct_v = new frmMarketProduct(product);
            frmMarketProduct_v.ShowDialog();

        }


        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            PrepareFormToLoad();
        }
    }
}
