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
    public class clsCategoriesDataAccess
    {

        //Category
        public static bool GetCategoryInfoByID(int CategoryID, ref string CategoryName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Categories WHERE CategoryID = @CategoryID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CategoryID", CategoryID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    CategoryName = (string)Reader["CategoryName"];
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

        public static bool GetCategoryInfoByName(ref int CategoryID, string CategoryName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Categories WHERE CategoryName = @CategoryName";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CategoryName", CategoryName);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    CategoryID = (int)Reader["CategoryID"];
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


        public static int AddNewCategory(string CategoryName)
        {
            int CategoryID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO Categories (CategoryName)
                             VALUES (@CategoryName)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CategoryName", CategoryName);




            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    CategoryID = InsertedID;
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


            return CategoryID;

        }

        public static bool UpdateCategoryInfo(int CategoryID, string CategoryName)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE Categories 
                             SET CategoryName = @CategoryName                                
                                 WHERE CategoryID = @CategoryID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@CategoryID", CategoryID);

            Command.Parameters.AddWithValue("@CategoryName", CategoryName);


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

        public static DataTable GetAllCategories()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM Categories";

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



    }
}
