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
    public class clsAdsDataAccess
    {

        public static bool GetAdInfoByID(int AddID, ref int SellerID,
          ref string AddPicPath, ref string Description, ref decimal AddFee,
          ref DateTime StartDate, ref DateTime EndDate,
          ref bool IsAvailable, ref int ProductID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Ads WHERE AddID = @AddID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@AddID", AddID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    SellerID = (int)Reader["SellerID"];
                    AddPicPath = (string)Reader["AddPicPath"];

                    Description = (string)Reader["Description"];


                    AddFee = (decimal)Reader["AddFee"];
                    StartDate = (DateTime)Reader["StartDate"];
                    EndDate = (DateTime)Reader["EndDate"];
                    IsAvailable = (bool)Reader["IsAvailable"];


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

        public static int AddNewAd(int SellerID,
          string AddPicPath, string Description, decimal AddFee,
          DateTime StartDate,  DateTime EndDate,
          bool IsAvailable, int ProductID)
        {
            int AddID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO Ads (SellerID,
                             AddPicPath, Description, AddFee,
                             StartDate, EndDate,
                             IsAvailable, ProductID)

                             VALUES (@SellerID,
                             @AddPicPath, @Description, @AddFee,
                             @StartDate, @EndDate,
                             @IsAvailable, @ProductID)

                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@SellerID", SellerID);

            Command.Parameters.AddWithValue("@AddPicPath", AddPicPath);
          

            Command.Parameters.AddWithValue("@Description", Description);

            Command.Parameters.AddWithValue("@AddFee", AddFee);

            Command.Parameters.AddWithValue("@StartDate", StartDate);

            Command.Parameters.AddWithValue("@EndDate", EndDate);

            Command.Parameters.AddWithValue("@IsAvailable", IsAvailable);



            Command.Parameters.AddWithValue("@ProductID", ProductID);



            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    AddID = InsertedID;
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


            return AddID;

        }



        public static bool UpdateAdInfo(int AddID, int SellerID,
          string AddPicPath, string Description, decimal AddFee,
          DateTime StartDate, DateTime EndDate,
          bool IsAvailable, int ProductID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE Ads 
                             SET
                                 SellerID = @SellerID,
                                 AddPicPath = @AddPicPath,
                                 Description = @Description,
                                 AddFee = @AddFee,
                                 StartDate = @StartDate,
                                 EndDate = @EndDate,
                                 IsAvailable = @IsAvailable,
                                 ProductID = @ProductID
                                 WHERE AddID = @AddID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@AddID", AddID);

            Command.Parameters.AddWithValue("@SellerID", SellerID);

            Command.Parameters.AddWithValue("@AddPicPath", AddPicPath);


            Command.Parameters.AddWithValue("@Description", Description);

            Command.Parameters.AddWithValue("@AddFee", AddFee);

            Command.Parameters.AddWithValue("@StartDate", StartDate);

            Command.Parameters.AddWithValue("@EndDate", EndDate);

            Command.Parameters.AddWithValue("@IsAvailable", IsAvailable);



            Command.Parameters.AddWithValue("@ProductID", ProductID);



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


        public static DataTable GetAllAds()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"select AddID From Ads  where IsAvailable = 1 order by AddFee desc";

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

        public static int GetNumberOfAds()
        {
            int TotalNumber = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM ads WHERE AddID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfPeople))
                {
                    TotalNumber = AcualNumOfPeople;
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

            return TotalNumber;
        }


        public static bool DeleteAd(int AddID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE Ads WHERE AddID = @AddID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@AddID", AddID);


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

        public static bool DoesAdExist(int AddID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM Ads WHERE AddID = @AddID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@AddID", AddID);


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

        public static bool IsAdAvailable(int AddID)
        {
            bool IsAvailable = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "select IsAvailable from Ads where AddID = @AddID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@AddID", AddID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && Convert.ToBoolean(Result) == true)
                {
                    IsAvailable = true;
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

            return IsAvailable;
        }

        public static bool InActiveExpiredAds()
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = $@"update Ads set
                         IsAvailable = 0
                         where EndDate <  GETDATE() and IsAvailable = 1";
                         
            SqlCommand Command = new SqlCommand(Query, connection);

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


    }
}
