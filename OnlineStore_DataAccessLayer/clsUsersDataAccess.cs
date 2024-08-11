using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsUsersDataAccess
    {

        //Users Code

        public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string UserName,
            ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];

                   
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

        public static bool GetUserInfoByPersonID(ref int UserID, int PersonID, ref string UserName,
            ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Users WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];


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

        public static bool GetUserInfoByUserName(ref int UserID, ref int PersonID, string UserName,
            ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Users WHERE UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];


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

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO Users (PersonID, UserName,
                             Password, IsActive)

                             VALUES (@PersonID, @UserName,
                             @Password, @IsActive)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            Command.Parameters.AddWithValue("@UserName", UserName);

            Command.Parameters.AddWithValue("@Password", Password);

            Command.Parameters.AddWithValue("@IsActive", IsActive);

        
            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
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


            return UserID;

        }


        public static bool UpdateUserInfo(int UserID,
            int PersonID, string UserName, string Password, bool IsActive)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE Users 
                             SET PersonID = @PersonID,
                                 UserName = @UserName,
                                 Password = @Password,
                                 IsActive = @IsActive                             
                                 WHERE UserID = @UserID";


            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            Command.Parameters.AddWithValue("@UserName", UserName);

            Command.Parameters.AddWithValue("@Password", Password);

            Command.Parameters.AddWithValue("@IsActive", IsActive);

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


        public static DataTable GetAllUsers()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM Users";

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

        public static int GetNumberOfUsers()
        {
            int NumberOfUsers = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM Users WHERE UserID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfUsers))
                {
                    NumberOfUsers = AcualNumOfUsers;
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

            return NumberOfUsers;
        }

        public static int GetNumberOfUsersByActive(bool IsActive)
        {
            int NumberOfUsers = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM Users WHERE UserID is not null and IsActive = @IsActive";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@IsActive", IsActive);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfUsers))
                {
                    NumberOfUsers = AcualNumOfUsers;
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

            return NumberOfUsers;
        }


        public static bool DeleteUser(int TestAppointmentID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", TestAppointmentID);


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

        public static bool DoesUserExist(int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

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

        public static bool DoesUserExist(string UserName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserName", UserName);


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


        public static bool IsUserActive(int UserID)
        {
            bool IsActive = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT IsActive FROM Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && bool.TryParse(Result.ToString(), out bool AcualIsActive))
                {
                    IsActive = AcualIsActive;
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

            return IsActive;
        }

       

    }
}
