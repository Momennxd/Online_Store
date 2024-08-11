using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_DataAccessLayer
{
    public class clsPeopleDataAccess
    {

        public static bool GetPersonInfoByID(int PersonID, ref string FirstName,
           ref string SecondName, ref string ThirdName, ref DateTime DateOfBirth,
           ref byte Gender, ref string Phone, ref string Email,
           ref int NationalityCountryID, ref string ProfilePic, ref string AvatarPic)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];

                    if (Reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)Reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];

                    if (Reader["ProfilePic"] != DBNull.Value)
                    {
                        ProfilePic = (string)Reader["ProfilePic"];
                    }
                    else
                    {
                        ProfilePic = "";
                    }

                    if (Reader["AvatarPic"] != DBNull.Value)
                    {
                        AvatarPic = (string)Reader["AvatarPic"];
                    }
                    else
                    {
                        AvatarPic = "";
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


        public static int AddNewPerson(string FirstName,
           string SecondName, string ThirdName, DateTime DateOfBirth,
           byte Gender, string Phone, string Email,
           int NationalityCountryID, string ProfilePic, string AvatarPic)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO People (FirstName,
                             SecondName, ThirdName, DateOfBirth,
                             Gender, Phone, Email,
                             NationalityCountryID, ProfilePic, AvatarPic)

                             VALUES (@FirstName,
                             @SecondName, @ThirdName, @DateOfBirth,
                             @Gender, @Phone, @Email,
                             @NationalityCountryID, @ProfilePic, @AvatarPic)

                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@FirstName", FirstName);

            Command.Parameters.AddWithValue("@SecondName", SecondName);

            if (!string.IsNullOrEmpty(ThirdName))
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);


            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            Command.Parameters.AddWithValue("@Gender", Gender);

            Command.Parameters.AddWithValue("@Phone", Phone);

            Command.Parameters.AddWithValue("@Email", Email);

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);


            if (!string.IsNullOrEmpty(ProfilePic))
                Command.Parameters.AddWithValue("@ProfilePic", ProfilePic);
            else
                Command.Parameters.AddWithValue("@ProfilePic", DBNull.Value);

            if (!string.IsNullOrEmpty(AvatarPic))
                Command.Parameters.AddWithValue("@AvatarPic", AvatarPic);
            else
                Command.Parameters.AddWithValue("@AvatarPic", DBNull.Value);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
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


            return PersonID;

        }


        public static bool UpdatePersonInfo(int PersonID, string FirstName,
           string SecondName, string ThirdName, DateTime DateOfBirth,
           byte Gender, string Phone, string Email,
           int NationalityCountryID, string ProfilePic, string AvatarPic)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE People 
                             SET
                                 FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName,
                                 DateOfBirth = @DateOfBirth,
                                 Gender = @Gender,
                                 Phone = @Phone,
                                 Email = @Email,
                                 NationalityCountryID = @NationalityCountryID,
                                 ProfilePic = @ProfilePic, AvatarPic = @AvatarPic
                                 WHERE PersonID = @PersonID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@PersonID", PersonID);

            Command.Parameters.AddWithValue("@FirstName", FirstName);

            Command.Parameters.AddWithValue("@SecondName", SecondName);

            if (!string.IsNullOrEmpty(ThirdName))
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);


            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            Command.Parameters.AddWithValue("@Gender", Gender);

            Command.Parameters.AddWithValue("@Phone", Phone);

            Command.Parameters.AddWithValue("@Email", Email);

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);


            if (!string.IsNullOrEmpty(ProfilePic))
                Command.Parameters.AddWithValue("@ProfilePic", ProfilePic);
            else
                Command.Parameters.AddWithValue("@ProfilePic", DBNull.Value);

            if (!string.IsNullOrEmpty(AvatarPic))
                Command.Parameters.AddWithValue("@AvatarPic", AvatarPic);
            else
                Command.Parameters.AddWithValue("@AvatarPic", DBNull.Value);

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


        public static DataTable GetAllPeople()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM People";

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

        public static int GetNumberOfPeople()
        {
            int NumberOfPeople = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM People WHERE PersonID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfPeople))
                {
                    NumberOfPeople = AcualNumOfPeople;
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

            return NumberOfPeople;
        }

        public static bool DeletePerson(int LicenseID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", LicenseID);


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

        public static bool DoesPersonExist(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", LicenseID);


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
