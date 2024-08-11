using DVLD_DataAccessLayer;
using OnlineStore_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsUser : clsPerson
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }

        public enMode mode = enMode.eAddNew;

        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public DataTable Visas { get { return clsVisa.GetAllVisasByUserID(this.UserID); } }

        public clsVisa Visa { get { return clsVisa.FindByUserID(this.UserID); } }

        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = false;         
            mode = enMode.eAddNew;
        }

        private clsUser(int UserID, string UserName, string Password, bool IsActive , int PersonID, string FirstName,
           string SecondName, string ThirdName, DateTime DateOfBirth,
           byte Gender, string Phone, string Email,
           int NationalityCountryID, string ProfilePic, string AvatarPic)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ProfilePic = ProfilePic;
            this.AvatarPic = AvatarPic;

            mode = enMode.eUpdate;
        }

        bool _AddNewUser()
        {
            this.UserID = clsUsersDataAccess.AddNewUser(this.PersonID, this.UserName,
            this.Password, this.IsActive);

            return this.UserID != -1;
        }

        bool _UpdateUser()
        {
            return (clsUsersDataAccess.UpdateUserInfo(this.UserID, this.PersonID, this.UserName,
            this.Password, this.IsActive));
        }

        public static clsUser FindByUserID(int UserID)
        {
            bool IsActive = false; int PersonID = -1;
            string UserName = "", Password = "";

            if (clsUsersDataAccess.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {

                clsPerson MainPerson = clsPerson.Find(PersonID);

                return new clsUser(UserID, UserName, Password, IsActive, PersonID, MainPerson.FirstName,
                MainPerson.SecondName, MainPerson.ThirdName, MainPerson.DateOfBirth,
                MainPerson.Gender, MainPerson.Phone, MainPerson.Email,
                MainPerson.NationalityCountryID, MainPerson.ProfilePic, MainPerson.AvatarPic);
            }
            else
                return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            bool IsActive = false; int UserID = -1;
            string UserName = "", Password = "";

            if (clsUsersDataAccess.GetUserInfoByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive))
            {

                clsPerson MainPerson = clsPerson.Find(PersonID);

                return new clsUser(UserID, UserName, Password, IsActive, PersonID, MainPerson.FirstName,
                MainPerson.SecondName, MainPerson.ThirdName, MainPerson.DateOfBirth,
                MainPerson.Gender, MainPerson.Phone, MainPerson.Email,
                MainPerson.NationalityCountryID, MainPerson.ProfilePic, MainPerson.AvatarPic);
            }
            else
                return null;
        }

        public static clsUser FindByUserName(string UserName)
        {
            bool IsActive = false; int UserID = -1, PersonID = -1;
            string Password = "";

            if (clsUsersDataAccess.GetUserInfoByUserName(ref UserID, ref PersonID, UserName, ref Password, ref IsActive))
            {

                clsPerson MainPerson = clsPerson.Find(PersonID);

                return new clsUser(UserID, UserName, Password, IsActive, PersonID, MainPerson.FirstName,
                MainPerson.SecondName, MainPerson.ThirdName, MainPerson.DateOfBirth,
                MainPerson.Gender, MainPerson.Phone, MainPerson.Email,
                MainPerson.NationalityCountryID, MainPerson.ProfilePic, MainPerson.AvatarPic);
            }
            else
                return null;
        }


        public static DataTable GetAllUsers()
        {
            DataTable DT = clsUsersDataAccess.GetAllUsers();
            return DT;
        }   

        public static DataTable GetBlankUsersTable()
        {
            DataTable DT = clsUsersDataAccess.GetAllUsers();
            DT.Rows.Clear();
            return DT;
        }
       
        public static int GetNumberOfUsers()
        {
            return clsUsersDataAccess.GetNumberOfUsers();
        }

        public static int GetNumberOfUsers(bool IsActive)
        {
            return clsUsersDataAccess.GetNumberOfUsersByActive(IsActive);
        }

        public static bool DeleteUser(int UserID)
        {
            return (clsUsersDataAccess.DeleteUser(UserID));
        }

        public static bool DoesUserExist(int UserID)
        {
            return (clsUsersDataAccess.DoesUserExist(UserID));
        }

        public static bool DoesUserExist(string UserName)
        {
            return (clsUsersDataAccess.DoesUserExist(UserName));
        }


        public static bool IsUserActive(int UserID)
        {
            return (clsUsersDataAccess.IsUserActive(UserID));
        }      

        public bool DoesUserHaveReview(int ProductID)
        {
            return clsProductReview.DoesProductReviewExist(ProductID, this.UserID);
        }

        public static bool DoesUserFollowSeller(int SellerID, int UserID)
        {
            return clsSellerFollower.DoesFollowerExist(SellerID, UserID);
        }

        public bool Save()
        {

            base.mode = (clsPerson.enMode)mode;

            if (!base.Save())
                return false;

            switch (mode)
            {
                case enMode.eAddNew:
                    {
                        if (_AddNewUser())
                        {
                            mode = enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case enMode.eUpdate:

                    return _UpdateUser();

            }

            return false;
        }



    }
}
