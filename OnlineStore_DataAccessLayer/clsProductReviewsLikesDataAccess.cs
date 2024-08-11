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
    public class clsProductReviewsLikesDataAccess
    {

        public static bool GetProductReviewLikeInfoByID(int ProductReviewLikeID,
          ref int UserID, ref int ProductReviewID, ref bool IsLike)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM ProductReviewsLikes WHERE ProductReviewLikeID = @ProductReviewLikeID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductReviewLikeID", ProductReviewLikeID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    ProductReviewID = (int)Reader["ProductReviewID"];
                    IsLike = (bool)Reader["IsLike"];

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

        public static int AddNewProductReviewLike(int UserID, int ProductReviewID, bool IsLike)
        {
            int ProductReviewLikeID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO ProductReviewsLikes (UserID, ProductReviewID, IsLike)
                             VALUES (@UserID, @ProductReviewID, @IsLike)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);
            Command.Parameters.AddWithValue("@IsLike", IsLike);




            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ProductReviewLikeID = InsertedID;
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


            return ProductReviewLikeID;

        }


        public static bool UpdateProductReviewLike(int ProductReviewLikeID,
         int UserID, int ProductReviewID, bool IsLike)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE ProductReviewsLikes 
                             SET UserID = @UserID,
                                 ProductReviewID = @ProductReviewID, IsLike = @IsLike
                                 WHERE ProductReviewLikeID = @ProductReviewLikeID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@ProductReviewLikeID", ProductReviewLikeID);

            Command.Parameters.AddWithValue("@UserID", UserID);

            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);
            Command.Parameters.AddWithValue("@IsLike", IsLike);


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


        public static DataTable GetAllProductReviewLikes(int ProductReviewID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM ProductReviewsLikes where ProductReviewID = @ProductReviewID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);


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

        public static int GetNumberOfProductReviewLikes(int ProductReviewID)
        {
            int NumberOfItems = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM ProductReviewsLikes WHERE ProductReviewID = @ProductReviewID and IsLike = 1";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);

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

        public static bool LikeUnlikeProductReview(int ProductReviewID, int UserID, bool IsLike)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE ProductReviewsLikes 
                             SET IsLike = @IsLike
                                 WHERE ProductReviewID = @ProductReviewID and UserID = @UserID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);
            Command.Parameters.AddWithValue("@UserID", UserID);

            Command.Parameters.AddWithValue("@IsLike", IsLike);


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

        public static bool DoesProductReviewLikeExist(int ProductReviewID, int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "select found = 1 from ProductReviewsLikes where ProductReviewID = @ProductReviewID and UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);
            Command.Parameters.AddWithValue("@UserID", UserID);


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

        public static bool DoesUserLikeProductReview(int ProductReviewID, int UserID)
        {
            bool Like = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "select IsLike from ProductReviewsLikes where ProductReviewID = @ProductReviewID and UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);
            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                Like = Convert.ToBoolean(Result);
                

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return Like;
        }


        public static bool DeleteProductReviewsLikes(int ProductReviewID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE ProductReviewsLikes WHERE ProductReviewID = @ProductReviewID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);


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





    }
}
