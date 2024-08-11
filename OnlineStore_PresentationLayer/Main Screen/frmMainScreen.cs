using Bunifu.Framework.UI;
using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Cart;
using OnlineStore_PresentationLayer.Categories;
using OnlineStore_PresentationLayer.Main_Screen;
using OnlineStore_PresentationLayer.Products_List;
using OnlineStore_PresentationLayer.Top;
using OnlineStore_PresentationLayer.User_Controls;
using OnlineStore_PresentationLayer.User_Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            clsGlobal.MainScreenFormObj = this;
            this.FormClosed += FrmMainScreen_FormClosed;
        }

        public event Action<object, string> OnSearchClick;
        protected virtual void SearchClick_Click(string SearchInput)
        {
            Action<object, string> handler = OnSearchClick;
            if (handler != null)
            {
                handler(this, SearchInput); // Raise the event with the parameter
            }
        }

        //frmHomeScreen frmHomeScreen_v = new frmHomeScreen();

        void SetHomeButtonAsDefault()
        {
            StyleButton(btnGoBackHome);
        }

        void BackToProductsListForm(object sender, EventArgs e)
        {
            //Here we stored the form already in the static global class to make loading products faster.
            clsGlobal.frmProductsList.DisplayAllProductsThums();
            clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, clsGlobal.frmProductsList);
            clsGlobal.frmProductsList.ctrlProductsFilter_v.rbAll.Checked = true;
            clsGlobal.frmProductsList.CurrentCatagory = null;
            clsGlobal.frmProductsList.SearchInput = "";

            clsGlobal.frmProductsList.ctrlProductsFilter_v.RestPriceFilterText();
            clsGlobal.frmProductsList.ResetPriceFilterVals();
            txtSearchBar.Text = "";

            //to simulate clicking on the home button:
            StyleButton(btnGoBackHome);

        }

        void BackToHomeScreen(object sender, EventArgs e)
        {
            ShowHomeScreen();
        }

        void ShowHomeScreen()
        {
            clsGlobal.frmProductsList.ctrlProductsFilter_v.rbAll.Checked = true;
            clsGlobal.frmProductsList.CurrentCatagory = null;
            clsGlobal.frmProductsList.ctrlProductsFilter_v.RestPriceFilterText();
            clsGlobal.frmProductsList.ResetPriceFilterVals();
            txtSearchBar.Text = "";
            clsGlobal.frmProductsList.SearchInput = "";

            //showing the home screen
            StyleButton(btnGoBackHome);
            frmHomeScreen frmHomeScreen_v = new frmHomeScreen();
            frmHomeScreen_v.OnFrmCategoryClick += ShowCategoryScreenEventOverloading;
            clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, frmHomeScreen_v);
            frmHomeScreen_v.ShowTopProductsSection();

        }

        void ShowCategoryScreenEventOverloading(object sender)
        {
            StyleButton(btnCategories);
            ShowCategoryScreen();
        }

        void ShowCategoryScreen()
        {
            frmCategories frmCategories_v = new frmCategories();
            frmCategories_v.OnCategoryClick += Category_Click;
            clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, frmCategories_v);
        }



        void ColorButton(Color Clr, BunifuFlatButton btn)
        {
            btn.Textcolor = Clr;
        }

        void ColorAllMSButtonsExcept(BunifuFlatButton btn, Color Clr)
        {
            if (btnCategories.Name != btn.Name)
                ColorButton(Clr, btnCategories);

            if (btnGoBackHome.Name != btn.Name)
                ColorButton(Clr, btnGoBackHome);

            if (btnTop.Name != btn.Name)
                ColorButton(Clr, btnTop);

            if (btnAccount.Name != btn.Name)
                ColorButton(Clr, btnAccount);

            if (btnCart.Name != btn.Name)
                ColorButton(Clr, btnCart);

        }

        void StyleButton(object sender)
        {
            ((BunifuFlatButton)sender).Textcolor = Color.Black;
            ColorAllMSButtonsExcept(((BunifuFlatButton)sender), Color.FromArgb(68, 64, 63));

        }
   
        void ShowInnerForm(BunifuFlatButton btn)
        {
            pnlMainScreenFormsLoader.Controls.Clear();
            clsGlobal.frmProductsList.ctrlProductsFilter_v.rbAll.Checked = true;

            switch (btn.Name)
            {

                case "btnCategories":
                    ShowCategoryScreen();
                    break;
                case "btnCart":
                    frmUserCart frmUserCart_v = new frmUserCart();
                    clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, frmUserCart_v);
                    break;
                case "btnAccount":
                    ShowCurrentUserAccount();
                    break;
                case "btnTop":
                    frmTop frmTop_v = new frmTop();
                    clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, frmTop_v);
                    break;



            }

        }

        void ShowCurrentUserAccount()
        {
            frmUserProfile frmUserProfile_v;
            if (clsGlobal.CurrentSeller == null)
            {
                frmUserProfile_v = new frmUserProfile(
                clsGlobal.CurrentUser, ctrlUserProfileHeaderInfo.enMode.eUser, false);
            }
            else
            {
                frmUserProfile_v = new frmUserProfile(
               clsGlobal.CurrentSeller, ctrlUserProfileHeaderInfo.enMode.eSeller, false);
            }

            clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, frmUserProfile_v);
        }

        void ShowProductListSearch()
        {
            if (txtSearchBar.Text != "")
            {
                clsGlobal.frmProductsList.DisplayCustomProductsThumsBySearchFilter(txtSearchBar.Text.Trim());
                clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, clsGlobal.frmProductsList);
                OnSearchClick?.Invoke(this, txtSearchBar.Text.Trim());
            }
        }













        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            SetHomeButtonAsDefault();

            //showing the home screen
            frmHomeScreen frmHomeScreen_v = new frmHomeScreen();
            frmHomeScreen_v.OnFrmCategoryClick += ShowCategoryScreenEventOverloading;
            clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, frmHomeScreen_v);


            //here we load all the products to make the app faster
            //when the user clicks on any category or the main screen
            frmProductsList frmProductsList_v = new frmProductsList();
            frmProductsList_v.DisplayProductThumbNailsFrstTime(clsProduct.GetAllProducts());
            //clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, frmProductsList_v);


            //displaying the top products //TODO
            frmHomeScreen_v.ShowTopProductsSection();


            pbUserProfilePic.ImageLocation = clsGlobal.CurrentUser.ProfilePic;
            lblUserFullName.Text = clsGlobal.CurrentUser.FullName;

        }

        private void btnMainButtons_Click(object sender, EventArgs e)
        {
            StyleButton((BunifuFlatButton)sender);
            ShowInnerForm((BunifuFlatButton)sender);
        }

        private void FrmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsGlobal.CurrentOpendForm.Close();
            clsGlobal.LoginScreen.Close();
        }

        private void Category_Click(object sender, clsCategory Category)
        {
            clsGlobal.frmProductsList.DisplayCustomProductsThums(Category.CategoryID);
            clsGlobal.ShowFormInPanel(pnlMainScreenFormsLoader, clsGlobal.frmProductsList);

        }

        private void pbUserProfilePic_Click(object sender, EventArgs e)
        {
            ShowCurrentUserAccount();
        }








        private void btnPerformSearch_Click(object sender, EventArgs e)
        {
            ShowProductListSearch();
        }

      

        private void txtSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSearchBar.Text != "")
            {
                ShowProductListSearch();

            }
        }

       
    }
}
