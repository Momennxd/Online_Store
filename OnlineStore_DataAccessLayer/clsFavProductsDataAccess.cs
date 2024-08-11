using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_DataAccessLayer
{
    public class clsFavProductsDataAccess
    {

        public static bool GetFavProductInfoByID(int FavProductID,
           ref int UserID, ref int ProductID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM FavouriteProducts WHERE FavProductID = @FavProductID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@FavProductID", FavProductID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    ProductID = (int)Reader["ProductID"];

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


        public static int AddNewFavProduct(int UserID, int ProductID)
        {
            int FavProductID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO FavouriteProducts (UserID, ProductID)
                             VALUES (@UserID, @ProductID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@ProductID", ProductID);




            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    FavProductID = InsertedID;
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


            return FavProductID;

        }

        public static bool UpdateFavProduct(int FavProductID,
          int UserID, int ProductID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE FavouriteProducts 
                             SET UserID = @UserID,
                                 ProductID = @ProductID
                                 WHERE FavProductID = @FavProductID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@FavProductID", FavProductID);

            Command.Parameters.AddWithValue("@ProductID", ProductID);

            Command.Parameters.AddWithValue("@UserID", UserID);


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

        public static DataTable GetAllItemsInFavProductsList(int UserID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM FavouriteProducts where UserID = @UserID";

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

        public static int GetNumberOfItemsInFavProductsList(int UserID)
        {
            int NumberOfItems = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM FavouriteProducts WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool DeleteItemFromFavProductsList(int FavProductID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE FavouriteProducts WHERE FavProductID = @FavProductID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@FavProductID", FavProductID);


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

        public static bool DeleteItemFromFavProductsList(int UserID, int ProductID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE FavouriteProducts WHERE UserID = @UserID and ProductID = @ProductID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@ProductID", ProductID);


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


        public static bool DoesProductExistInFavList(int ProductID, int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "select found = 1 from FavouriteProducts where ProductID = @ProductID and UserID = @UserID";

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


    }
}
