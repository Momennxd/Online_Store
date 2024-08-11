using DVLD_BusinessLayer;
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
    public partial class ctrlUserProfileHeaderInfo : UserControl
    {
        public ctrlUserProfileHeaderInfo()
        {
            InitializeComponent();
           
        }

        public event Action<object, bool> OnFollowClick;
        protected virtual void Follow_Click(bool Like)
        {
            Action<object, bool> handler = OnFollowClick;
            if (handler != null)
            {
                handler(this, Like); // Raise the event with the parameter
            }
        }



        public event Action<object, clsUser> OnEditProfileClick;
        protected virtual void EditProfile_Click(clsUser User)
        {
            Action<object, clsUser> handler = OnEditProfileClick;
            if (handler != null)
            {
                handler(this, User); // Raise the event with the parameter
            }
        }


        //this mode is for who this profile presents it might be a user or a seller.
        public enum enMode { eUser = 1, eSeller = 2 }

        public enMode Mode = enMode.eUser;

        //represents if another user is viewing current profile
        public bool IsViewed = true;

        public static clsUser CurrentUser = new clsUser();

        public static clsSeller CurrentSeller = new clsSeller();

        void AlterFormForUserMode()
        {
            btnFollow.Visible = false;
            lblFollowers.Visible = false;
        }

        void AlterFormForSellerMode()
        {
            btnFollow.Visible = true;
            lblFollowers.Visible = true;

        }

        void AlterFormForIsViewdMode()
        {
            btnEditProfile.Visible = !IsViewed;

            if (!IsViewed)
            {
                if (Mode == enMode.eSeller)
                {
                    btnFollow.Visible = false;
                }
               

            }
            

           
           

        }

        void LoadDataOnForm()
        {
            pbAvatarPic.ImageLocation = CurrentUser.AvatarPic;
            pbUserProfilePic.ImageLocation = CurrentUser.ProfilePic;
            lblUserFullName.Text = CurrentUser.FirstName + " " + CurrentUser.SecondName;

            //setting the follow button:
            if (CurrentSeller != null && clsUser.DoesUserFollowSeller(CurrentSeller.SellerID,
                clsGlobal.CurrentUser.UserID))
            {
                btnFollow.Tag = "1";
                btnFollow.IdleFillColor = Color.FromArgb(105, 119, 197);
                btnFollow.IdleLineColor = Color.FromArgb(105, 119, 197);

                btnFollow.ButtonText = "Following";
            }

            if (CurrentSeller != null) lblFollowers.Text = CurrentSeller.Followers.ToString() + " Followers";
        }

        public void DisplayUserData(int UserID, enMode mode, bool isViewed)
        {
            Mode = mode;
            IsViewed = isViewed;
            CurrentUser = clsUser.FindByUserID(UserID);

            AlterFormForUserMode();
            AlterFormForIsViewdMode();
            LoadDataOnForm();
        }

        public void DisplayUserData(clsUser User, enMode mode, bool isViewed)
        {
            Mode = mode;
            IsViewed = isViewed;
            CurrentUser = User;

            AlterFormForUserMode();
            AlterFormForIsViewdMode();
            LoadDataOnForm();
        }

        public void DisplaySellerData(clsSeller Seller, enMode mode, bool isViewed)
        {
            Mode = mode;
            IsViewed = isViewed;
            CurrentSeller = Seller;
            CurrentUser = CurrentSeller.User;

            AlterFormForSellerMode();
            AlterFormForIsViewdMode();
            LoadDataOnForm();
        }

        public void DisplaySellerData(int SellerID, enMode mode, bool isViewed)
        {
            Mode = mode;
            IsViewed = isViewed;
            CurrentSeller = clsSeller.Find(SellerID);

            AlterFormForSellerMode();
            AlterFormForIsViewdMode();
            LoadDataOnForm();
        }





        //this part is kinda done but do a quick check again ;)





        private void btnFollow_Click(object sender, EventArgs e)
        {
            int SellerFollowers = CurrentSeller.Followers;
            if (btnFollow.Tag.ToString() == "0")
            {
                btnFollow.IdleFillColor = Color.FromArgb(105, 119, 197);
                btnFollow.IdleLineColor = Color.FromArgb(105, 119, 197);
                btnFollow.ButtonText = "Following";
                CurrentSeller.Follow(clsGlobal.CurrentUser.UserID, true);
                lblFollowers.Text = (SellerFollowers + 1).ToString() + " Followers";
                btnFollow.Tag = "1";
                OnFollowClick?.Invoke(this, true);
            }
            else
            {
                btnFollow.IdleFillColor = Color.White;
                btnFollow.IdleLineColor = Color.FromArgb(105, 119, 197);

                btnFollow.ButtonText = "Follow";
                CurrentSeller.Follow(clsGlobal.CurrentUser.UserID, false);
                lblFollowers.Text = (SellerFollowers - 1).ToString() + " Followers";
                btnFollow.Tag = "0";
                OnFollowClick?.Invoke(this, false);
            }


        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            OnEditProfileClick?.Invoke(this, CurrentUser);
        }
    
       
    }
}
