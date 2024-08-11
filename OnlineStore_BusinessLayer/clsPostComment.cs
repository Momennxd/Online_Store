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
    public class clsPostComment
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int PostCommentID { get; set; }

        public int UserID { get; set; }

        public string CommentText { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LatestUpdateDate { get; set; }

        public int PostID { get; set; }

        public clsPost Post { get { return clsPost.Find(PostID); } }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }

        public int Likes { get{ return clsPostCommentLike.GetNumberOfPostCommentLikes(this.PostCommentID); } }


        public clsPostComment()
        {
            PostID = -1;
            UserID = -1;
            CommentText = "";
            CreationDate = DateTime.Now;
            LatestUpdateDate = DateTime.Now;
            PostCommentID = -1;

            mode = Mode.eAddNew;
        }

        private clsPostComment(int PostCommentID, int PostID,
            int UserID, string CommentText, DateTime CreationDate, DateTime LatestUpdateDate)
        {
            this.PostCommentID = PostCommentID;
            this.PostID = PostID;
            this.UserID = UserID;
            this.CommentText = CommentText;
            this.CreationDate = CreationDate;
            this.LatestUpdateDate = LatestUpdateDate;
            mode = Mode.eUpdate;
        }


        bool _AddNewPostComment()
        {
            PostCommentID = clsPostsCommentsDataAccess.AddNewPostComment(
                this.UserID, this.CommentText, this.CreationDate, this.LatestUpdateDate, this.PostID);
            return PostCommentID != -1;
        }

        bool _UpdatePostComment()
        {
            return (clsPostsCommentsDataAccess.UpdatePostComment(
                this.PostCommentID, this.UserID, this.CommentText,
                this.CreationDate, this.LatestUpdateDate, this.PostID));
        }


        public static clsPostComment Find(int PostCommentID)
        {
            int UserID = -1, PostID = -1; string CommentText = "";
            DateTime CreationDate = DateTime.Now, LatestUpdateDate = DateTime.Now;


            if (clsPostsCommentsDataAccess.GetPostCommentInfoByID(
                PostCommentID, ref UserID, ref CommentText, ref CreationDate, ref LatestUpdateDate, ref PostID))
            {
                return new clsPostComment(PostCommentID, PostID, UserID,
                    CommentText, CreationDate, LatestUpdateDate);
            }
            else
                return null;
        }

        public static DataTable GetAllPostsComments(int PostID)
        {
            DataTable DT = clsPostsCommentsDataAccess.GetAllPostCommentByPostID(PostID);
            return DT;
        }

        public static int GetNumberOfPostsComments(int PostID)
        {
            return clsPostsCommentsDataAccess.GetNumberOfPostComments(PostID);
        }


        public static bool DeletePostComment(int PostCommentID)
        {
            clsPostsCommentsLikesDataAccess.DeletePostCommentsLikesByCommentID(PostCommentID);
            return clsPostsCommentsDataAccess.DeletePostComment(PostCommentID);
        }

        public static bool DeletePostCommentByPostID(int PostID)
        {
            return clsPostsCommentsDataAccess.DeletePostCommentByPostID(PostID);
        }

       


        public bool DoesUserLikeComment(int UserID)
        {
            return clsPostsCommentsLikesDataAccess.DoesPostCommentLikeExist(UserID, this.PostCommentID);
        }

        public static bool DoesUserLikeComment(clsPostComment postComment, int UserID)
        {
            return clsPostsCommentsLikesDataAccess.DoesPostCommentLikeExist(
                UserID, postComment.PostCommentID);
        }


        public static bool Like(clsPostComment postComment, int UserID, bool Like)
        {


            if (Like && !DoesUserLikeComment(postComment, UserID)) 
            {
                clsPostCommentLike postCommentLike = new clsPostCommentLike();
                postCommentLike.UserID = UserID;
                postCommentLike.PostCommentID = postComment.PostCommentID;
                return postCommentLike.Save();
            }
            else
            {
                return clsPostCommentLike.DeletePostCommentsLikes(
                    clsPostCommentLike.Find(UserID, postComment.PostCommentID).CommentLikeID);
            }
            

        }
      
        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewPostComment())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdatePostComment();

            }

            return false;
        }


    }
}
