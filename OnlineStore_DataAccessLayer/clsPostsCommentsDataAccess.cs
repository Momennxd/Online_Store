using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_DataAccessLayer
{
    public class clsPostsCommentsDataAccess
    {


        public static bool GetPostCommentInfoByID(int PostCommentID,
         ref int UserID, ref string CommentText, ref DateTime CreationDate,
         ref DateTime LatestUpdateDate, ref int PostID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM PostsComments WHERE PostCommentID = @PostCommentID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PostCommentID", PostCommentID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    CommentText = (string)Reader["CommentText"];
                    CreationDate = (DateTime)Reader["CreationDate"];
                    LatestUpdateDate = (DateTime)Reader["LatestUpdateDate"];
                    PostID = (int)Reader["PostID"];

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


        public static int AddNewPostComment(int UserID, string CommentText, DateTime CreationDate,
         DateTime LatestUpdateDate, int PostID)
        {
            int PostCommentID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO PostsComments (UserID, CommentText, CreationDate, LatestUpdateDate, PostID)
                             VALUES (@UserID, @CommentText, @CreationDate, @LatestUpdateDate, @PostID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@CommentText", CommentText);
            Command.Parameters.AddWithValue("@CreationDate", CreationDate);
            Command.Parameters.AddWithValue("@LatestUpdateDate", LatestUpdateDate);
            Command.Parameters.AddWithValue("@PostID", PostID);




            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PostCommentID = InsertedID;
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


            return PostCommentID;

        }


        public static bool UpdatePostComment(int PostCommentID,
        int UserID, string CommentText, DateTime CreationDate,
         DateTime LatestUpdateDate, int PostID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE PostsComments 
                             SET UserID = @UserID,
                                 CommentText = @CommentText, CreationDate = @CreationDate,
                                 LatestUpdateDate = @LatestUpdateDate, PostID = @PostID
                                 WHERE PostCommentID = @PostCommentID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@PostID", PostID);

            Command.Parameters.AddWithValue("@UserID", UserID);

            Command.Parameters.AddWithValue("@CommentText", CommentText);

            Command.Parameters.AddWithValue("@CreationDate", CreationDate);

            Command.Parameters.AddWithValue("@LatestUpdateDate", LatestUpdateDate);

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


        public static DataTable GetAllPostCommentByPostID(int PostID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM PostsComments where PostID = @PostID order by PostCommentID desc";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PostID", PostID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
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

            return DT;
        }

        public static bool DeletePostComment(int PostCommentID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE PostsComments WHERE PostCommentID = @PostCommentID";

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

        public static bool DeletePostCommentByPostID(int PostID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE PostsComments WHERE PostID = @PostID";

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


        public static int GetNumberOfPostComments(int PostID)
        {
            int NumberOfPostsComments = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM PostsComments WHERE PostID = @PostID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PostID", PostID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNum))
                {
                    NumberOfPostsComments = AcualNum;
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

            return NumberOfPostsComments;
        }


    }
}
