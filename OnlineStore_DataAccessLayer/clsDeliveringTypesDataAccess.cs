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
    public class clsDeliveringTypesDataAccess
    {
        //DeliveryType

        public static bool GetDeliveringTypeInfoByID(int DeliveryTypeID,
            ref string DeliveryTypeName, ref decimal DeliveryFee)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM DeliveringTypes WHERE DeliveryTypeID = @DeliveryTypeID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DeliveryTypeID", DeliveryTypeID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    DeliveryTypeName = (string)Reader["DeliveryTypeName"];
                    DeliveryFee = (decimal)Reader["DeliveryFee"];

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

        public static bool GetDeliveringTypeInfoByName(ref int DeliveryTypeID,
            string DeliveryTypeName, ref decimal DeliveryFee)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM DeliveringTypes WHERE DeliveryTypeName = @DeliveryTypeName";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DeliveryTypeName", DeliveryTypeName);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    DeliveryTypeID = (int)Reader["DeliveryTypeID"];
                    DeliveryFee = (decimal)Reader["DeliveryFee"];

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


        public static int AddNewDeliveringType(string DeliveryTypeName, decimal DeliveryFee)
        {
            int DeliveryTypeID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO DeliveringTypes (DeliveryTypeName, DeliveryFee)
                             VALUES (@DeliveryTypeName, @DeliveryFee)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DeliveryTypeName", DeliveryTypeName);
            Command.Parameters.AddWithValue("@DeliveryFee", DeliveryFee);




            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    DeliveryTypeID = InsertedID;
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


            return DeliveryTypeID;

        }

        public static bool UpdateCategoryInfo(int DeliveryTypeID,
            string DeliveryTypeName, decimal DeliveryFee)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE DeliveringTypes 
                             SET DeliveryTypeName = @DeliveryTypeName,
                                 DeliveryFee = @DeliveryFee
                                 WHERE DeliveryTypeID = @DeliveryTypeID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@DeliveryTypeID", DeliveryTypeID);

            Command.Parameters.AddWithValue("@DeliveryTypeName", DeliveryTypeName);

            Command.Parameters.AddWithValue("@DeliveryFee", DeliveryFee);


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

        public static DataTable GetAllDeliveringTypes()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM DeliveringTypes";

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
