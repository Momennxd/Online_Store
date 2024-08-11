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
using System.Xml.Serialization;

namespace OnlineStore_PresentationLayer.User_Controls
{
    public partial class ctrlAddPost : UserControl
    {
        public ctrlAddPost(clsUser user)
        {
            InitializeComponent();
            RoundControls();
            LoadPosterDataOnForm(user);
            _User = user;
        }

        void RoundControls()
        {
            Control[] C = { txtPostText , pnlAddPostElements};

            clsGlobal.RoundControlsByCustomElips(bunifuElipse1, C);
        }


        public event Action<object, clsPost> OnPostClick;
        protected virtual void Post_Click(clsPost Post)
        {
            Action<object, clsPost> handler = OnPostClick;
            if (handler != null)
            {
                handler(this, Post); // Raise the event with the parameter
            }
        }

        private clsPost _Post = new clsPost();

        public clsPost Post { get{ return _Post; } }

        private clsUser _User = new clsUser();

        public clsUser User { get { return _User; } }


        void LoadPosterDataOnForm(clsUser User)
        {
            pbUserPic.ImageLocation = User.ProfilePic;
        }

        void LoadPostDataToObj(clsUser User)
        {
            _Post.UserID = User.UserID;
            _Post.PostText = txtPostText.Text.Trim();
            _Post.CreationDate = DateTime.Now;
            _Post.LatestUpdateDate = DateTime.Now;
        }

        bool ValidateInfoCompletion()
        {
            return clsGlobal.ValidateTxtBox(txtPostText, string.IsNullOrEmpty(txtPostText.Text),
              "Post Can't Be Empty!", errorProvider1);         
        }

        public void ResetCommenText()
        {
            txtPostText.Text = string.Empty;
        }


        bool SavePost(clsUser User)
        {
            if (ValidateInfoCompletion())
            {
                LoadPostDataToObj(User);
                return _Post.Save();
            }

            return false;

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (SavePost(_User))
            {
                OnPostClick?.Invoke(this, _Post);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPostText.Text = "";
            pbUserPic.Focus();
        }
    }
}
