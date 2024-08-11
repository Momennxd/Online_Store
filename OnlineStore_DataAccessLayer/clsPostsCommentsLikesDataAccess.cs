using DVLD_DataAccessLayer;
using System;
using System.Data.SqlClient;

namespace OnlineStore_DataAccessLayer
{
    public class clsPostsCommentsLikesDataAccess
    {

        public static bool GetPostCommentLikeInfoByCommentLikeID(int CommentLikeID,
         ref int PostCommentID, ref int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM PostsCommentsLikes WHERE CommentLikeID = @CommentLikeID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CommentLikeID", CommentLikeID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    PostCommentID = (int)Reader["PostCommentID"];

                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }

        public static bool GetPostCommentLikeInfoByPostIDUserID(ref int CommentLikeID,
          int PostCommentID,  int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM PostsCommentsLikes WHERE PostCommentID = @PostCommentID and UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PostCommentID", PostCommentID);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    CommentLikeID = (int)Reader["CommentLikeID"];

                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }

        public static int AddPostCommentLike(int UserID, int PostCommentID)
        {
            int CommentLikeID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO PostsCommentsLikes (UserID, PostCommentID)
                             VALUES (@UserID, @PostCommentID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PostCommentID", PostCommentID);




            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    CommentLikeID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }


            return CommentLikeID;

        }


        public static bool UpdatePostCommentLike(int CommentLikeID,
        int UserID, int PostCommentID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE PostsCommentsLikes 
                             SET UserID = @UserID,
                                 PostCommentID = @PostCommentID
                                 WHERE CommentLikeID = @CommentLikeID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@CommentLikeID", CommentLikeID);

            Command.Parameters.AddWithValue("@UserID", UserID);

            Command.Parameters.AddWithValue("@PostCommentID", PostCommentID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }


        public static int GetNumberOfPostCommentLikes(int PostCommentID)
        {
            int NumberOfItems = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM PostsCommentsLikes WHERE PostCommentID = @PostCommentID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PostCommentID", PostCommentID);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNum))
                {
                    NumberOfItems = AcualNum;
                }


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return NumberOfItems;
        }

        public static bool DeletePostCommentsLikes(int CommentLikeID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE PostsCommentsLikes WHERE CommentLikeID = @CommentLikeID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CommentLikeID", CommentLikeID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool DeletePostCommentsLikesByPostID(int PostID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = $@"Delete        PostsCommentsLikes
                         FROM            PostsComments INNER JOIN
                         PostsCommentsLikes ON PostsComments.PostCommentID =
                         PostsCommentsLikes.PostCommentID where PostID = @PostID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PostID", PostID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool DeletePostCommentsLikesByCommentID(int PostCommentID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE PostsCommentsLikes WHERE PostCommentID = @PostCommentID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PostCommentID", PostCommentID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }


        public static bool DoesPostCommentLikeExist(int UserID, int PostCommentID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM PostsCommentsLikes WHERE UserID = @UserID and PostCommentID = @PostCommentID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PostCommentID", PostCommentID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


    }

}
