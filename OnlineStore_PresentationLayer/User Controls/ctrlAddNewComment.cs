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
    public partial class ctrlAddNewComment : UserControl
    {
        public ctrlAddNewComment(clsPost Post)
        {
            InitializeComponent();
            this.m_Post = Post;
            DisplayCommenterData();
        }

        public class SubmitEventArgs : EventArgs
        {
            public clsPost Post;
            public clsPostComment PostComment;

            public SubmitEventArgs(clsPost Post, clsPostComment PostComment)
            {
                this.Post = Post;
                this.PostComment = PostComment;
            }
        }

        public event Action<object, SubmitEventArgs> OnSubmitClick;
        protected virtual void SubmitClick_Click(SubmitEventArgs Args)
        {
            Action<object, SubmitEventArgs> handler = OnSubmitClick;
            if (handler != null)
            {
                handler(this, Args); // Raise the event with the parameter
            }
        }


        private clsPost m_Post = new clsPost();

        private clsPostComment m_PostComment = new clsPostComment();

        public clsPost Post { get { return m_Post; } }

        public clsPostComment PostComment { get { return m_PostComment; } }


        void DisplayCommenterData()
        {
            lblFullName.Text = clsGlobal.CurrentUser.FullName;
            pbUserPic.ImageLocation = clsGlobal.CurrentUser.ProfilePic;
        }

        bool SubmitComment()
        {
            if (ValidateInfoCompletion())
            {
                return m_Post.AddComment(txtCommentText.Text.Trim(), clsGlobal.CurrentUser.UserID);
            }

            return false;
        }


        bool ValidateInfoCompletion()
        {
            return clsGlobal.ValidateTxtBox(txtCommentText, string.IsNullOrEmpty(txtCommentText.Text),
              "Comment Can't Be Empty!", errorProvider1);
        }








        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (SubmitComment())
                OnSubmitClick?.Invoke(this, new SubmitEventArgs(m_Post, m_PostComment));
        }

      
    }
}
