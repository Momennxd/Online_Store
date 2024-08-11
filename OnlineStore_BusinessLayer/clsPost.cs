using DVLD_BusinessLayer;
using OnlineStore_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_BusinessLayer
{
    public class clsPost
    {
        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int PostID { get; set; }

        public int UserID { get; set; }

        public string PostText { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LatestUpdateDate { get; set; }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }

        public int Likes { get { return clsPostLike.GetNumberOfPostLikes(this.PostID); } }

        public int Comments { get { return clsPostComment.GetNumberOfPostsComments(this.PostID); } }


        public clsPost()
        {
            PostID = -1;
            UserID = -1;
            PostText = "";
            CreationDate = DateTime.Now;
            LatestUpdateDate = DateTime.Now;

            mode = Mode.eAddNew;
        }

        private clsPost(int PostID,
            int UserID, string PostText, DateTime CreationDate, DateTime LatestUpdateDate)
        {
            this.PostID = PostID;
            this.UserID = UserID;
            this.PostText = PostText;
            this.CreationDate = CreationDate;
            this.LatestUpdateDate = LatestUpdateDate;
            mode = Mode.eUpdate;
        }



        bool _AddNewPost()
        {
            PostID = clsPostsDataAccess.AddNewPost(
                this.UserID, this.PostText, this.CreationDate, this.LatestUpdateDate);
            return PostID != -1;
        }

        bool _UpdatePost()
        {
            return (clsPostsDataAccess.UpdatePost(
                this.PostID, this.UserID, this.PostText, this.CreationDate, this.LatestUpdateDate));
        }


        public static clsPost Find(int PostID)
        {
            int UserID = -1; string PostText = "";
            DateTime CreationDate = DateTime.Now, LatestUpdateDate = DateTime.Now;


            if (clsPostsDataAccess.GetPostInfoByID(
                PostID, ref UserID, ref PostText, ref CreationDate, ref LatestUpdateDate))
            {
                return new clsPost(PostID, UserID, PostText, CreationDate, LatestUpdateDate);
            }
            else
                return null;
        }


        public static DataTable GetAllPostsByUserID(int UserID)
        {
            DataTable DT = clsPostsDataAccess.GetAllPostsByUserID(UserID);
            return DT;
        }

        public static int GetNumberOfPosts(int UserID)
        {
            return clsPostsDataAccess.GetNumberOfPosts(UserID);
        }

        public static bool DeletePost(int PostID)
        {
            clsPostCommentLike.DeletePostCommentsLikesByPostID(PostID);
            clsPostComment.DeletePostCommentByPostID(PostID);
            clsPostLike.DeletePostLikesByPostID(PostID);
            return clsPostsDataAccess.DeletePost(PostID);
        }

        public bool Like(bool Like, int UserID)
        {
            if (Like)
            {
                clsPostLike postLike = new clsPostLike();
                postLike.PostID = this.PostID;
                postLike.UserID = UserID;
                return postLike.Save();
            }
            else
            {
                return clsPostLike.DeletePostLike(UserID, this.PostID);
            }
           


        }

        public static bool DoesUserLikePost(int UserID, int PostID)
        {
            return clsPostLike.DoesPostLikeExist(UserID, PostID);
        }

        public bool AddComment(string CommentText, int UserID)
        {
            clsPostComment comment = new clsPostComment();
            comment.CommentText = CommentText.Trim();
            comment.UserID = UserID;
            comment.CreationDate = DateTime.Now;
            comment.LatestUpdateDate = DateTime.Now;
            comment.PostID = this.PostID;

            return comment.Save();
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewPost())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdatePost();

            }

            return false;
        }


    }
}
