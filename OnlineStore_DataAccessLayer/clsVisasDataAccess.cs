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
    public class clsVisasDataAccess
    {

        public static bool GetVisaInfoByVisaID(int VisaID,
      ref string VisaNumber, ref int PIN, ref int UserID, ref int TotalAmount)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Visas WHERE VisaID = @VisaID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@VisaID", VisaID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    VisaNumber = (string)Reader["VisaNumber"];
                    PIN = (int)Reader["PIN"];
                    TotalAmount = (int)Reader["TotalAmount"];

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

        public static bool GetVisaInfoByVisaInfo(ref int VisaID,
     string VisaNumber, int PIN, ref int UserID, ref int TotalAmount)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Visas WHERE VisaNumber = @VisaNumber and PIN = @PIN";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@VisaNumber", VisaNumber);
            Command.Parameters.AddWithValue("@PIN", PIN);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    TotalAmount = (int)Reader["TotalAmount"];
                    VisaID = (int)Reader["VisaID"];

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

        public static bool GetVisaInfoByUserID(ref int VisaID,
     ref string VisaNumber, ref int PIN, int UserID, ref int TotalAmount)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Visas WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    VisaID = (int)Reader["VisaID"];
                    VisaNumber = (string)Reader["VisaNumber"];
                    PIN = (int)Reader["PIN"];
                    TotalAmount = (int)Reader["TotalAmount"];

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


        public static int AddNewVisa(string VisaNumber, int PIN, int UserID, int TotalAmount)
        {
            int VisaID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO Visas (VisaNumber, PIN, UserID, TotalAmount)
                             VALUES (@VisaNumber, @PIN, @UserID, @TotalAmount)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@VisaNumber", VisaNumber);
            Command.Parameters.AddWithValue("@PIN", PIN);
            Command.Parameters.AddWithValue("@TotalAmount", TotalAmount);




            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    VisaID = InsertedID;
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


            return VisaID;

        }

        public static bool UpdateVisa(int VisaID,
        string VisaNumber, int PIN, int UserID, int TotalAmount)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE Visas 
                             SET VisaNumber = @VisaNumber,
                                 PIN = @PIN, UserID = @UserID,
                                 TotalAmount = @TotalAmount
                                 WHERE VisaID = @VisaID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@VisaID", VisaID);

            Command.Parameters.AddWithValue("@UserID", UserID);

            Command.Parameters.AddWithValue("@VisaNumber", VisaNumber);

            Command.Parameters.AddWithValue("@PIN", PIN);

            Command.Parameters.AddWithValue("@TotalAmount", TotalAmount);


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

        public static DataTable GetAllVisasByUserID(int UserID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM Visas where UserID = @UserID";

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

        public static bool DeleteVisa(int VisaID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE Visas WHERE VisaID = @VisaID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@VisaID", VisaID);


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

        public static int GetNumberOfVisas(int UserID)
        {
            int NumberOfVisas = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM Visas WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNum))
                {
                    NumberOfVisas = AcualNum;
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

            return NumberOfVisas;
        }





    }
}
