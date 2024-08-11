using DVLD_BusinessLayer;
using OnlineStore_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_BusinessLayer
{
    public class clsPostLike
    {
        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int LikeID { get; set; }

        public int PostID { get; set; }

        public int UserID { get; set; }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }

        public clsPost Post { get { return clsPost.Find(PostID); } }


        public clsPostLike()
        {
            LikeID = -1;
            PostID = -1;
            UserID = -1;
            mode = Mode.eAddNew;
        }

        private clsPostLike(int LikeID,
            int PostID, int UserID)
        {
            this.LikeID = LikeID;
            this.UserID = UserID;
            this.PostID = PostID;
            mode = Mode.eUpdate;
        }


        bool _AddNewPostLike()
        {
            LikeID = clsPostsLikesDataAccess.AddPostLike(
                this.PostID, this.UserID);
            return LikeID != -1;
        }

        bool _UpdatePostLike()
        {
            return (clsPostsLikesDataAccess.UpdatePostLike(
                this.LikeID, this.PostID, this.UserID));
        }

        public static clsPostLike Find(int LikeID)
        {
            int PostID = -1, UserID = -1;


            if (clsPostsLikesDataAccess.GetPostLikeInfoByLikeID(
                LikeID, ref PostID, ref UserID))
            {
                return new clsPostLike(LikeID, PostID, UserID);
            }
            else
                return null;
        }


        public static int GetNumberOfPostLikes(int PostID)
        {
            return clsPostsLikesDataAccess.GetNumberOfPostLikes(PostID);
        }


        public static bool DeletePostLike(int LikeID)
        {
            return clsPostsLikesDataAccess.DeletePostLike(LikeID);
        }

        public static bool DeletePostLikesByPostID(int PostID)
        {
            return clsPostsLikesDataAccess.DeletePostLikesByPostID(PostID);
        }

        public static bool DeletePostLike(int UserID, int PostID)
        {
            return clsPostsLikesDataAccess.DeletePostLike(UserID, PostID);
        }

        public static bool DoesPostLikeExist(int UserID, int PostID)
        {
            return (clsPostsLikesDataAccess.DoesPostLikeExist(UserID, PostID));
        }



        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewPostLike())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdatePostLike();

            }

            return false;
        }
    }
}
