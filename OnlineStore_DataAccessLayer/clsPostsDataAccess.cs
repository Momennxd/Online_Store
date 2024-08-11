using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace OnlineStore_DataAccessLayer
{
    public class clsPostsDataAccess
    {

        public static bool GetPostInfoByID(int PostID,
         ref int UserID, ref string PostText, ref DateTime CreationDate, ref DateTime LatestUpdateDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Posts WHERE PostID = @PostID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PostID", PostID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    PostText = (string)Reader["PostText"];
                    CreationDate = (DateTime)Reader["CreationDate"];
                    LatestUpdateDate = (DateTime)Reader["LatestUpdateDate"];

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


        public static int AddNewPost(int UserID, string PostText,
            DateTime CreationDate, DateTime LatestUpdateDate)
        {
            int PostID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO Posts (UserID, PostText, CreationDate, LatestUpdateDate)
                             VALUES (@UserID, @PostText, @CreationDate, @LatestUpdateDate)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PostText", PostText);
            Command.Parameters.AddWithValue("@CreationDate", CreationDate);
            Command.Parameters.AddWithValue("@LatestUpdateDate", LatestUpdateDate);




            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PostID = InsertedID;
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


            return PostID;

        }

        public static bool UpdatePost(int PostID,
         int UserID, string PostText,
            DateTime CreationDate, DateTime LatestUpdateDate)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE Posts 
                             SET UserID = @UserID,
                                 PostText = @PostText, CreationDate = @CreationDate,
                                 LatestUpdateDate = @LatestUpdateDate
                                 WHERE PostID = @PostID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@PostID", PostID);

            Command.Parameters.AddWithValue("@UserID", UserID);

            Command.Parameters.AddWithValue("@PostText", PostText);

            Command.Parameters.AddWithValue("@CreationDate", CreationDate);

            Command.Parameters.AddWithValue("@LatestUpdateDate", LatestUpdateDate);


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

        public static DataTable GetAllPostsByUserID(int UserID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM Posts where UserID = @UserID order by PostID desc";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);


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

        public static bool DeletePost(int PostID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE Posts WHERE PostID = @PostID";

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

        public static int GetNumberOfPosts(int UserID)
        {
            int NumberOfPosts = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM Posts WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNum))
                {
                    NumberOfPosts = AcualNum;
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

            return NumberOfPosts;
        }




    }
}
