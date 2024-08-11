using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Properties;
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
    public partial class ctrlPost : UserControl
    {
        public ctrlPost()
        {
            InitializeComponent();
            
        }

        public event Action<object, bool> OnLikeClick;
        protected virtual void Like_Click(bool Like)
        {
            Action<object, bool> handler = OnLikeClick;
            if (handler != null)
            {
                handler(this, Like); // Raise the event with the parameter
            }
        }


        public event Action<object> OnDeleteClick;
        protected virtual void Delete_Click()
        {
            Action<object> handler = OnDeleteClick;
            if (handler != null)
            {
                handler(this); // Raise the event with the parameter
            }
        }


        public event Action<object, clsPost> OnCommentClick;
        protected virtual void Comment_Click(clsPost Comment)
        {
            Action<object, clsPost> handler = OnCommentClick;
            if (handler != null)
            {
                handler(this, Comment); // Raise the event with the parameter
            }
        }

        public event Action<object, clsPost> OnSaveClick;
        protected virtual void Save_Click(clsPost Post)
        {
            Action<object, clsPost> handler = OnSaveClick;
            if (handler != null)
            {
                handler(this, Post); // Raise the event with the parameter
            }
        }



        public enum enMode { eShow = 1, eEdit = 2, eDelete = 3 }
        public enMode mode = enMode.eShow;

        private bool _IsViewed = true;
        public bool IsViewed { get { return _IsViewed; } }

        private clsPost _Post = new clsPost();

        public clsPost Post { get { return _Post; } }

        void LoadPostDataOnForm()
        {
            pbUserPic.ImageLocation = _Post.User.ProfilePic;
            txtPostText.Text = _Post.PostText.Trim();
            int PostDateInDays = Convert.ToInt32((DateTime.Now - _Post.CreationDate).TotalDays);
            lblFullName.Text = _Post.User.FullName + "   " + (PostDateInDays > 1 ?  (PostDateInDays + " Days Ago") : (PostDateInDays + " Day Ago"));
            lblLikes.Text = _Post.Likes.ToString();
            lblComments.Text = _Post.Comments.ToString();

            btnShowPostOptions.Visible = !_IsViewed;

            //
            if (clsPost.DoesUserLikePost(clsGlobal.CurrentUser.UserID,
               _Post.PostID))
            {
                btnLike.Image = Resources.icons8_heart_50;
                btnLike.Tag = "1";
            }
        }

        public void DisplayPostInfo(int PostID, bool IsViewed)
        {
            _Post = clsPost.Find(PostID);
            _IsViewed = IsViewed;
            LoadPostDataOnForm();

        }

        public void DisplayPostInfo(clsPost Post, bool IsViewed)
        {
            _Post = Post;
            _IsViewed = IsViewed;
            LoadPostDataOnForm();

        }

        void EnableEditMode(bool Enable)
        {
            if (Enable)
            {
                btnSave.Visible = true;
                txtPostText.ReadOnly = false;
                txtPostText.BackColor = Color.Gainsboro;
                mode = enMode.eEdit;
            }
            else
            {
                btnSave.Visible = false;
                txtPostText.ReadOnly = true;
                txtPostText.BackColor = Color.WhiteSmoke;
                mode = enMode.eShow;

            }

        }

        bool ValidateInfoCompletion()
        {
            return clsGlobal.ValidateTxtBox(txtPostText, string.IsNullOrEmpty(txtPostText.Text),
              "Post Can't Be Empty!", errorProvider1);
        }


        void Save()
        {
            EnableEditMode(false);
            _Post.PostText = txtPostText.Text.Trim();
            _Post.LatestUpdateDate = DateTime.Now;

            if (ValidateInfoCompletion())
            {
                if (_Post.Save())
                    OnSaveClick?.Invoke(this, _Post);
            }

        }










        private void btnShowPostOptions_Click(object sender, EventArgs e)
        {
            cmsUserReviewOptions.Show(MousePosition);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableEditMode(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = enMode.eDelete;


            if (clsPost.DeletePost(_Post.PostID))
            {
                OnDeleteClick?.Invoke(this);
            }
            else
            {
                MessageBox.Show("Failed To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mode = enMode.eShow;

            }
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            OnCommentClick?.Invoke(this, _Post);

        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (btnLike.Tag.ToString() == "0")
            {
                if (clsGlobal.CurrentUser != null)
                {
                    _Post.Like(true, clsGlobal.CurrentUser.UserID);
                }

                lblLikes.Text = (Convert.ToInt16(lblLikes.Text) + 1).ToString();
                btnLike.Image = Resources.icons8_heart_50;
                btnLike.Tag = "1";
            }
            else
            {
                if (clsGlobal.CurrentUser != null)
                {
                    _Post.Like(false, clsGlobal.CurrentUser.UserID);
                }

                lblLikes.Text = (Convert.ToInt16(lblLikes.Text) - 1).ToString();
                btnLike.Tag = "0";
                btnLike.Image = Resources.icons8_heart_48__1_;

            }

            OnLikeClick?.Invoke(this, btnLike.Tag.ToString() != "0");
        }
    }
}
