using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Products_List;
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

namespace OnlineStore_PresentationLayer.Top
{
    public partial class frmTop : Form
    {
        public frmTop()
        {
            InitializeComponent();
        }

        void ShowProductDetailsForm(object sender, ctrlProductAd.ShopNowEventArgs ShopNowEventArgs)
        {
            frmProductDetails frmProductDetails_v = new frmProductDetails(ShopNowEventArgs.Product);
            clsGlobal.ShowFormInPanel(clsGlobal.MainScreenFormObj.pnlMainScreenFormsLoader, frmProductDetails_v);
        }

        void ShowSellerAccountForm(object sender, ctrlProductAd.SellerEventArgs SellerEventArgs)
        {
            bool IsViewed;
            if (clsGlobal.CurrentSeller != null)
            {
                IsViewed = clsGlobal.CurrentSeller.SellerID != SellerEventArgs.seller.SellerID;
            }
            else
                IsViewed = true;

            frmUserProfile frmUserProfile_v = new frmUserProfile(SellerEventArgs.seller,
                ctrlUserProfileHeaderInfo.enMode.eSeller, IsViewed);

            clsGlobal.ShowFormInPanel(clsGlobal.MainScreenFormObj.pnlMainScreenFormsLoader, frmUserProfile_v);
        }


        void DisplayTopProductsAds(DataTable dtTopAds)
        {
            foreach (DataRow Row in dtTopAds.Rows)
            {
                ctrlProductAd postComment = new ctrlProductAd();
                postComment.DisplayAdInfo(Convert.ToInt32(Row["AddID"]));

                //here you should add the events
                postComment.OnShopNowClick += ShowProductDetailsForm;
                postComment.OnSellerClick += ShowSellerAccountForm;



                FpnlProductsAdsLoader.Controls.Add(postComment);
            }
        }

        private void frmTop_Load(object sender, EventArgs e)
        {
            clsAd.InActiveExpiredAds();
            DisplayTopProductsAds(clsAd.GetAllAds());
        }
    }
}
