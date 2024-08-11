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
    public class clsProductReviewsDataAccess
    {

        public static bool GetProductReviewInfoByID(int ProductReviewID,
            ref int UserID, ref byte Rating, ref int ProductID, ref DateTime RatingDate,
            ref string ReviewComment)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM ProductReviews WHERE ProductReviewID = @ProductReviewID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    Rating = (byte)Reader["Rating"];
                    ProductID = (int)Reader["ProductID"];
                    RatingDate = (DateTime)Reader["RatingDate"];

                    if (Reader["ReviewComment"] != DBNull.Value)
                    {
                        ReviewComment = (string)Reader["ReviewComment"];
                    }
                    else
                    {
                        ReviewComment = "";
                    }


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

        public static bool GetProductReviewInfo(ref int ProductReviewID,
           int UserID, ref byte Rating, int ProductID, ref DateTime RatingDate,
           ref string ReviewComment)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM ProductReviews WHERE UserID = @UserID and ProductID = @ProductID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@ProductID", ProductID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                   
                    Rating = (byte)Reader["Rating"];
                    ProductReviewID = (int)Reader["ProductReviewID"];
                    RatingDate = (DateTime)Reader["RatingDate"];

                    if (Reader["ReviewComment"] != DBNull.Value)
                    {
                        ReviewComment = (string)Reader["ReviewComment"];
                    }
                    else
                    {
                        ReviewComment = "";
                    }


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


        public static int AddNewProductReview(int UserID, byte Rating, int ProductID,
            DateTime RatingDate, string ReviewComment)
        {
            int ProductReviewID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO ProductReviews (UserID, Rating, ProductID, RatingDate, ReviewComment)
                             VALUES (@UserID, @Rating, @ProductID, @RatingDate, @ReviewComment)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@Rating", Rating);
            Command.Parameters.AddWithValue("@ProductID", ProductID);
            Command.Parameters.AddWithValue("@RatingDate", RatingDate);
            Command.Parameters.AddWithValue("@ReviewComment", ReviewComment);




            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ProductReviewID = InsertedID;
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


            return ProductReviewID;

        }

        public static bool UpdateProductReviewInfo(int ProductReviewID, int UserID, byte Rating, int ProductID,
            DateTime RatingDate, string ReviewComment)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE ProductReviews 
                             SET UserID = @UserID,   
                                 Rating = @Rating, 
                                 ProductID = @ProductID,   
                                 RatingDate = @RatingDate,   
                                 ReviewComment = @ReviewComment
                                 WHERE ProductReviewID = @ProductReviewID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@ProductReviewID", ProductReviewID);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@Rating", Rating);
            Command.Parameters.AddWithValue("@ProductID", ProductID);
            Command.Parameters.AddWithValue("@RatingDate", RatingDate);
            Command.Parameters.AddWithValue("@ReviewComment", ReviewComment);


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

      
        public static DataTable GetAllProductReviews()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM ProductReviews";

            SqlCommand Command = new SqlCommand(Query, connection);

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

        public static DataTable GetAllProductReviewsByProductID(int ProductID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM ProductReviews where ProductID = @ProductID order by ProductReviewID desc";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductID", ProductID);


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

        public static DataTable GetAllProductReviewsByUserID(int UserID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM ProductReviews where UserID = @UserID order by ProductReviewID desc";

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

        public static int GetNumberOfProductReviews(int ProductID)
        {
            int NumberOfProductReviews = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM ProductReviews WHERE ProductID = @ProductID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductID", ProductID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfPeople))
                {
                    NumberOfProductReviews = AcualNumOfPeople;
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

            return NumberOfProductReviews;
        }

        public static int GetAvrgProductReviewsByProduct(int ProductID)
        {
            int AvrgProductReviews = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = $@"select sum(Rating)  / count(*)       as AvrgRating
                              from ProductReviews where ProductID = @ProductID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductID", ProductID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfPeople))
                {
                    AvrgProductReviews = AcualNumOfPeople;
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

            return AvrgProductReviews;
        }

        public static bool DoesProductReviewExist(int ProductID, int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM ProductReviews WHERE ProductID = @ProductID and UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductID", ProductID);
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

        public static bool DeleteProductReview(int ProductReviewID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE ProductReviews WHERE ProductReviewID = @ProductReviewID";

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
