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
    public partial class ctrlPostComment : UserControl
    {
        public ctrlPostComment(clsPostComment postComment)
        {
            InitializeComponent();
            this.m_PostComment = postComment;
            DisplayCommentData(postComment);
        }

        public class PostCommentEventArgs : EventArgs
        {
            public bool? Like;
            public clsPost Post;
            public clsPostComment PostComment;


            public PostCommentEventArgs(bool? Like, clsPost Post, clsPostComment PostComment)
            {
                this.Like = Like;
                this.Post = Post;
                this.PostComment = PostComment;

            }
        }

        //public class LikeEventArgs : EventArgs
        //{
        //    public bool Like;

        //    public LikeEventArgs(bool Like)
        //    {
        //        this.Like = Like;
        //    }
        //}

        public event Action<object, PostCommentEventArgs> OnLikeClick;
        protected virtual void Like_Click(PostCommentEventArgs Args)
        {
            Action<object, PostCommentEventArgs> handler = OnLikeClick;
            if (handler != null)
            {
                handler(this, Args); // Raise the event with the parameter
            }
        }


        //public class DeleteEventArgs : EventArgs
        //{
        //    public clsPost Post;

        //    public DeleteEventArgs(clsPost Post)
        //    {
        //        this.Post = Post;
        //    }
        //}

        public event Action<object, PostCommentEventArgs> OnDeleteClick;
        protected virtual void Delete_Click(PostCommentEventArgs Args)
        {
            Action<object, PostCommentEventArgs> handler = OnDeleteClick;
            if (handler != null)
            {
                handler(this, Args); // Raise the event with the parameter
            }
        }


        //public class SaveEventArgs : EventArgs
        //{
        //    public clsPostComment PostComment;

        //    public SaveEventArgs(clsPostComment PostComment)
        //    {
        //        this.PostComment = PostComment;

        //    }
        //}

        public event Action<object, PostCommentEventArgs> OnSaveClick;
        protected virtual void Save_Click(PostCommentEventArgs Args)
        {
            Action<object, PostCommentEventArgs> handler = OnSaveClick;
            if (handler != null)
            {
                handler(this, Args); // Raise the event with the parameter
            }
        }


        public event Action<object, PostCommentEventArgs> OnCommenterClick;
        protected virtual void Commenter_Click(PostCommentEventArgs Args)
        {
            Action<object, PostCommentEventArgs> handler = OnCommenterClick;
            if (handler != null)
            {
                handler(this, Args); // Raise the event with the parameter
            }
        }

        public enum enMode { eShow = 1, eEdit = 2, eDelete = 3 }
        public enMode mode = enMode.eShow;


        private clsPostComment m_PostComment = new clsPostComment();

        public clsPostComment PostComment { get { return m_PostComment; } }

        void LoadCommentDataOnForm()
        {
            txtCommentText.Text = m_PostComment.CommentText.Trim();
            lblFullName.Text = m_PostComment.User.FullName + "    " +
                DateTime.Now.Subtract(m_PostComment.CreationDate).Days + " Days";

            pbUserPic.ImageLocation = m_PostComment.User.ProfilePic;
            lblLikes.Text = m_PostComment.Likes.ToString();

            if (m_PostComment.User.FullName == clsGlobal.CurrentUser.FullName)
                lblFullName.ForeColor = Color.FromArgb(66, 168, 66);

            if (m_PostComment.DoesUserLikeComment(clsGlobal.CurrentUser.UserID))
            {
                btnLike.Image = Resources.icons8_heart_50;
                btnLike.Tag = "1";
            }
        }


        void EnableEditMode()
        {
            txtCommentText.ReadOnly = false;
            txtCommentText.BackColor = Color.WhiteSmoke;

            btnSave.Visible = true;

            mode = enMode.eEdit;
        }

        void DisableEditMode()
        {
            txtCommentText.ReadOnly = true;
            txtCommentText.BackColor = Color.White;
            btnSave.Visible = false;

            mode = enMode.eShow;


        }

        void LoadCommentDataToObj()
        {
            m_PostComment.CommentText = txtCommentText.Text.Trim();
            m_PostComment.LatestUpdateDate = DateTime.Now;
        }


        void Save()
        {
            DisableEditMode();
            LoadCommentDataToObj();
            if (m_PostComment.Save())
                OnSaveClick?.Invoke(this, new PostCommentEventArgs(
                btnLike.Tag.ToString() != "0", m_PostComment.Post, m_PostComment));

        }


        void DisplayCommentData(clsPostComment PostComment)
        {
            m_PostComment = PostComment;
            if (clsGlobal.CurrentUser.UserID != PostComment.UserID)
                btnShowCommentOptions.Visible = false;

            LoadCommentDataOnForm();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (btnLike.Tag.ToString() == "0")
            {
                if (clsGlobal.CurrentUser != null)
                {
                    clsPostComment.Like(m_PostComment, clsGlobal.CurrentUser.UserID, true);
                }

                lblLikes.Text = (Convert.ToInt16(lblLikes.Text) + 1).ToString();
                btnLike.Image = Resources.icons8_heart_50;
                btnLike.Tag = "1";
            }
            else
            {
                if (clsGlobal.CurrentUser != null)
                {
                    clsPostComment.Like(m_PostComment, clsGlobal.CurrentUser.UserID, false);
                }

                lblLikes.Text = (Convert.ToInt16(lblLikes.Text) - 1).ToString();
                btnLike.Tag = "0";
                btnLike.Image = Resources.icons8_heart_48__1_;

            }

            OnLikeClick?.Invoke(this, new PostCommentEventArgs(btnLike.Tag.ToString() != "0", m_PostComment.Post, m_PostComment));
        }

        private void btnShowCommentOptions_Click(object sender, EventArgs e)
        {
            cmsUserCommentOptions.Show(MousePosition);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableEditMode();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = enMode.eDelete;


            if (clsPostComment.DeletePostComment(m_PostComment.PostCommentID))
            {
                OnDeleteClick?.Invoke(this, new PostCommentEventArgs(
                    btnLike.Tag.ToString() != "0", null, null));
            }
            else
            {
                MessageBox.Show("Failed To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mode = enMode.eShow;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();

        }

        private void pbUserPic_Click(object sender, EventArgs e)
        {
            OnCommenterClick?.Invoke(this, new PostCommentEventArgs(null, null, m_PostComment));
        }
    }
}
