using DVLD_BusinessLayer;
using OnlineStore_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_BusinessLayer
{
    public class clsPostCommentLike
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int CommentLikeID { get; set; }

        public int PostCommentID { get; set; }

        public int UserID { get; set; }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }

        public clsPostComment PostComment { get { return clsPostComment.Find(PostCommentID); } }


        public clsPostCommentLike()
        {
            CommentLikeID = -1;
            PostCommentID = -1;
            UserID = -1;
            mode = Mode.eAddNew;
        }

        private clsPostCommentLike(int CommentLikeID,
            int PostCommentID, int UserID)
        {
            this.CommentLikeID = CommentLikeID;
            this.UserID = UserID;
            this.PostCommentID = PostCommentID;
            mode = Mode.eUpdate;
        }


        bool _AddNewPostCommentLike()
        {
            CommentLikeID = clsPostsCommentsLikesDataAccess.AddPostCommentLike(
                this.UserID, this.PostCommentID);
            return CommentLikeID != -1;
        }

        bool _UpdatePostCommentLike()
        {
            return (clsPostsCommentsLikesDataAccess.UpdatePostCommentLike(
                this.CommentLikeID, this.UserID, this.PostCommentID));
        }

        public static clsPostCommentLike Find(int CommentLikeID)
        {
            int UserID = -1, PostCommentID = -1;


            if (clsPostsCommentsLikesDataAccess.GetPostCommentLikeInfoByCommentLikeID(
                CommentLikeID, ref PostCommentID, ref UserID))
            {
                return new clsPostCommentLike(CommentLikeID, PostCommentID, UserID);
            }
            else
                return null;
        }

        public static clsPostCommentLike Find(int UserID, int PostCommentID)
        {
            int CommentLikeID = -1;


            if (clsPostsCommentsLikesDataAccess.GetPostCommentLikeInfoByPostIDUserID(
                ref CommentLikeID, PostCommentID, UserID))
            {
                return new clsPostCommentLike(CommentLikeID, PostCommentID, UserID);
            }
            else
                return null;
        }


        public static int GetNumberOfPostCommentLikes(int PostCommentID)
        {
            return clsPostsCommentsLikesDataAccess.GetNumberOfPostCommentLikes(PostCommentID);
        }

        public static bool DeletePostCommentsLikes(int CommentLikeID)
        {
            return clsPostsCommentsLikesDataAccess.DeletePostCommentsLikes(CommentLikeID);
        }

        public static bool DeletePostCommentsLikesByPostID(int PostID)
        {
            return clsPostsCommentsLikesDataAccess.DeletePostCommentsLikesByPostID(PostID);
        }






        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewPostCommentLike())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdatePostCommentLike();

            }

            return false;
        }

    }
}
