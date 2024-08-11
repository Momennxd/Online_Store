using DVLD_BusinessLayer;
using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Manage_Products;
using OnlineStore_PresentationLayer.Posts;
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

namespace OnlineStore_PresentationLayer.User_Profile
{
    public partial class frmUserProfile : Form
    {
        public frmUserProfile(clsUser User, ctrlUserProfileHeaderInfo.enMode mode, bool isViewed)
        {
            InitializeComponent();
            Mode = mode;
            IsViewed = isViewed;
            CurrentUser = User;
        }

        public frmUserProfile(clsSeller Seller, ctrlUserProfileHeaderInfo.enMode mode, bool isViewed)
        {
            InitializeComponent();
            Mode = mode;
            IsViewed = isViewed;
            CurrentUser = Seller.User;
            CurrentSeller = Seller;
        }


        public bool IsViewed = true;

        public static clsUser CurrentUser = new clsUser();

        public static clsSeller CurrentSeller = new clsSeller();

        public ctrlUserProfileHeaderInfo.enMode Mode = ctrlUserProfileHeaderInfo.enMode.eUser;

        class clsMainControls
        {
            public static ctrlUserProfileHeaderInfo profileHeaderInfo = new ctrlUserProfileHeaderInfo();
            public static ctrlManageProducts ManageProductsHeader = new ctrlManageProducts();
            public static ctrlAddPost AddPost = new ctrlAddPost(clsGlobal.CurrentUser);


        }

        void AddUserHeaderInfo()
        {
            //here you should add the events

            switch (Mode)
            {
                case ctrlUserProfileHeaderInfo.enMode.eUser:
                    {
                        clsMainControls.profileHeaderInfo.DisplayUserData(CurrentUser, Mode, IsViewed);
                        break;
                    }
                case ctrlUserProfileHeaderInfo.enMode.eSeller:
                    {
                        clsMainControls.profileHeaderInfo.DisplaySellerData(CurrentSeller, Mode, IsViewed);
                        break;

                    }
            }

            FpnlUserProfileElements.Controls.Add(clsMainControls.profileHeaderInfo);

        }

        void AddSellerManageProductsHeader()
        {
            //here you should add the events
            clsMainControls.ManageProductsHeader.OnAddProductClick += ShowAddNewProductForm;

            switch (Mode)
            {
                case ctrlUserProfileHeaderInfo.enMode.eUser:
                    {
                        break;
                    }
                case ctrlUserProfileHeaderInfo.enMode.eSeller:
                    {
                        if (!IsViewed)
                            FpnlUserProfileElements.Controls.Add(clsMainControls.ManageProductsHeader);
                        break;
                    }
            }


        }

        void AddPostAddingInfo()
        {
            //here you should add the events
            clsMainControls.AddPost.OnPostClick += RefreshForm;


            switch (Mode)
            {
                case ctrlUserProfileHeaderInfo.enMode.eUser:
                    {
                        break;
                    }
                case ctrlUserProfileHeaderInfo.enMode.eSeller:
                    {
                        break;

                    }
            }


            if (!IsViewed)
            {
                clsMainControls.AddPost.ResetCommenText();
                FpnlUserProfileElements.Controls.Add(clsMainControls.AddPost);
            }

        }

        void AddPosts(DataTable dtPosts)
        {
            foreach(DataRow Row in dtPosts.Rows)
            {
                ctrlPost post = new ctrlPost();
                post.DisplayPostInfo(Convert.ToInt32(Row["PostID"]), IsViewed);
                //here you should add the events
                post.OnDeleteClick += RefreshForm;
                post.OnCommentClick += ShowPostDetails;

                FpnlUserProfileElements.Controls.Add(post);
            }
        }


        void PrepareFormToLoad()
        {
            FpnlUserProfileElements.Controls.Clear();
            AddUserHeaderInfo();
            AddSellerManageProductsHeader();
            AddPostAddingInfo();
            AddPosts(clsPost.GetAllPostsByUserID(CurrentUser.UserID));
        }

        void RefreshForm(object sender, clsPost post)
        {
            PrepareFormToLoad();
        }

        void RefreshForm(object sender)
        {
            PrepareFormToLoad();
        }

        void ShowCommenterAccount(object sender, ctrlPostComment.PostCommentEventArgs args)
        {
            clsUser user = args.PostComment.User;
            clsSeller seller = clsSeller.FindByUserID(user.UserID);
            frmUserProfile frmUserProfile_v;

            if (seller != null)
            {
                frmUserProfile_v = new frmUserProfile(seller,
                ctrlUserProfileHeaderInfo.enMode.eSeller, clsGlobal.CurrentUser.UserID != user.UserID);
            }
            else
            {
                frmUserProfile_v = new frmUserProfile(user,
                ctrlUserProfileHeaderInfo.enMode.eUser, clsGlobal.CurrentUser.UserID != user.UserID);
            }

            clsGlobal.ShowFormInPanel(clsGlobal.MainScreenFormObj.pnlMainScreenFormsLoader,
                frmUserProfile_v);
        }

        void ShowAddNewProductForm(object sender)
        {
            if (CurrentSeller!= null)
            {
                frmAddUpdateProduct frmAddUpdateProduct_v = new frmAddUpdateProduct(CurrentSeller);
                frmAddUpdateProduct_v.ShowDialog();
            }
        }

        private void ShowPostDetails(object sender, clsPost post)
        {
            frmPostDetails frmPostDetails_v = new frmPostDetails(post);
            frmPostDetails_v.DataBack += RefreshForm;
            frmPostDetails_v.dlgUserProfileClick += ShowCommenterAccount;
            frmPostDetails_v.ShowDialog();
        }




        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            PrepareFormToLoad();
        }
    }
}
