using DVLD_DataAccessLayer;
using OnlineStore_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_BusinessLayer
{
    public class clsPerson
    {

        public enum enMode { eAddNew = 0, eUpdate = 1 }

        public enMode mode = enMode.eAddNew;

        public int PersonID { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName; }

        }

        public DateTime DateOfBirth { get; set; }

        public byte Gender { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int NationalityCountryID { get; set; }

        public string ProfilePic { get; set; }

        public string AvatarPic { get; set; }


        public clsPerson()
        {
            PersonID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            DateOfBirth = new DateTime(2005, 10, 9);
            Gender = 0;
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ProfilePic = "";
            AvatarPic = "";


            mode = enMode.eAddNew;
        }


        private clsPerson(int PersonID, string FirstName,
           string SecondName, string ThirdName, DateTime DateOfBirth,
           byte Gender, string Phone, string Email,
           int NationalityCountryID, string ProfilePic, string AvatarPic)
        {
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


        bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDataAccess.AddNewPerson(this.FirstName,
            this.SecondName, this.ThirdName, this.DateOfBirth,
            this.Gender, this.Phone, this.Email,
            this.NationalityCountryID, this.ProfilePic, this.AvatarPic);

            return this.PersonID != -1;
        }

        bool _UpdatePerson()
        {
            return (clsPeopleDataAccess.UpdatePersonInfo(this.PersonID, this.FirstName,
            this.SecondName, this.ThirdName, this.DateOfBirth,
            this.Gender, this.Phone, this.Email,
            this.NationalityCountryID, this.ProfilePic, this.AvatarPic));
        }

        public static clsPerson Find(int PersonID)
        {
            byte Gender = 0; int NationalityCountryID = -1;
            string FirstName = "", SecondName = "", ThirdName = "",
                 Phone = "", Email = "", ProfilePic = "", AvatarPic = "";
            DateTime DateOfBirth = new DateTime(2005, 10, 9);


            if (clsPeopleDataAccess.GetPersonInfoByID(PersonID, ref FirstName,
           ref SecondName, ref ThirdName, ref DateOfBirth,
           ref Gender, ref Phone, ref Email,
           ref NationalityCountryID, ref ProfilePic, ref AvatarPic))
            {
                return new clsPerson(PersonID, FirstName,
                SecondName, ThirdName, DateOfBirth,
                Gender, Phone, Email,
                NationalityCountryID, ProfilePic, AvatarPic);
            }
            else
                return null;
        }

        public static DataTable GetAllPeople()
        {
            DataTable DT = clsPeopleDataAccess.GetAllPeople();
            return DT;
        }

        public static int GetNumberOfPeople()
        {
            return clsPeopleDataAccess.GetNumberOfPeople();
        }

        public static bool DeletePerson(int PersonID)
        {
            return (clsPeopleDataAccess.DeletePerson(PersonID));
        }

        public static bool DoesPersonExist(int PersonID)
        {
            return (clsPeopleDataAccess.DoesPersonExist(PersonID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.eAddNew:
                    {
                        if (_AddNewPerson())
                        {
                            mode = enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case enMode.eUpdate:

                    return _UpdatePerson();

            }

            return false;
        }


    }
}
