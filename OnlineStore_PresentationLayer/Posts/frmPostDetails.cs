using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
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
using static OnlineStore_PresentationLayer.User_Controls.ctrlPostComment;

namespace OnlineStore_PresentationLayer.Posts
{
    public partial class frmPostDetails : Form
    {
        public frmPostDetails(clsPost Post)
        {
            InitializeComponent();
            this._Post = Post;
        }

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        // Declare a delegate
        public delegate void UserProfileClickEventHandler(object sender, ctrlPostComment.PostCommentEventArgs args);

        // Declare an event using the delegate
        public event UserProfileClickEventHandler dlgUserProfileClick;


        private clsPost _Post = new clsPost();

        public clsPost Post { get { return _Post; } }

        

        void PostDeleted(object sender)
        {
            DataBack?.Invoke(sender);
            this.Close();

        }

        void UserProfileClicked(object sender, ctrlPostComment.PostCommentEventArgs args)
        {
            dlgUserProfileClick?.Invoke(this, args);
            this.Close();
        }

        void DisplayMainPostSection()
        {
            ctrlPost Post = new ctrlPost();
            Post.DisplayPostInfo(_Post, _Post.UserID != clsGlobal.CurrentUser.UserID);
            //post events:
            Post.OnDeleteClick += PostDeleted;


            FpnlPostDetails.Controls.Add(Post);
        }

        void DisplayCommentAddingSection()
        {
            ctrlAddNewComment NewComment = new ctrlAddNewComment(_Post);
            //adding events:
            NewComment.OnSubmitClick += RefreshForm;


            FpnlPostDetails.Controls.Add(NewComment);
        }

        void DisplayCommentsSection(DataTable dtComments)
        {
            foreach (DataRow Row in dtComments.Rows)
            {
                ctrlPostComment postComment = new ctrlPostComment(
                    clsPostComment.Find(Convert.ToInt32(Row["PostCommentID"])));
                //here you should add the events
                postComment.OnSaveClick += RefreshForm;
                postComment.OnDeleteClick += RefreshForm;
                postComment.OnCommenterClick += UserProfileClicked;

                FpnlPostDetails.Controls.Add(postComment);
            }
        }

        void RefreshForm(object sender, ctrlPostComment.PostCommentEventArgs Args)
        {
            PrepareFormToLoad();
        }

        void RefreshForm(object sender, ctrlAddNewComment.SubmitEventArgs Args)
        {
            PrepareFormToLoad();
        }

        void PrepareFormToLoad()
        {
            FpnlPostDetails.Controls.Clear();
            DisplayMainPostSection();
            DisplayCommentAddingSection();
            DisplayCommentsSection(clsPostComment.GetAllPostsComments(_Post.PostID));
        }



        private void frmPostDetails_Load(object sender, EventArgs e)
        {
            PrepareFormToLoad();
        }
    }
}
