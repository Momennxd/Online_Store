using DVLD_BusinessLayer;
using OnlineStore_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_BusinessLayer
{
    public class clsVisa
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int VisaID { get; set; }

        public string VisaNumber { get; set; }

        public int PIN { get; set; }

        public int UserID { get; set; }

        public int TotalAmount { get; set; }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }



        public clsVisa()
        {
            VisaID = -1;
            UserID = -1;
            VisaNumber = "";
            PIN = 0;
            TotalAmount = 0;

            mode = Mode.eAddNew;
        }

        private clsVisa(int VisaID,
                   string VisaNumber, int PIN, int UserID, int TotalAmount)
        {
            this.VisaID = VisaID;
            this.UserID = UserID;
            this.VisaNumber = VisaNumber;
            this.PIN = PIN;
            this.TotalAmount = TotalAmount;
            mode = Mode.eUpdate;
        }


        bool _AddNewVisa()
        {
            VisaID = clsVisasDataAccess.AddNewVisa(this.VisaNumber, this.PIN,
                this.UserID, this.TotalAmount);
            return VisaID != -1;
        }

        bool _UpdateVisa()
        {
            return (clsVisasDataAccess.UpdateVisa(
                this.VisaID, this.VisaNumber, this.PIN,
                this.UserID, this.TotalAmount));
        }



        public static clsVisa FindByVisaID(int VisaID)
        {
            int UserID = -1; string VisaNumber = "";
            int PIN = 0, TotalAmount = 0;


            if (clsVisasDataAccess.GetVisaInfoByVisaID(VisaID,
                 ref VisaNumber, ref PIN, ref UserID, ref TotalAmount))
            {
                return new clsVisa(VisaID,
                   VisaNumber, PIN, UserID, TotalAmount);
            }
            else
                return null;
        }

        public static clsVisa FindByVisaInfo(string VisaNumber, int PIN)
        {
            int UserID = -1, VisaID = -1;
            int  TotalAmount = 0;


            if (clsVisasDataAccess.GetVisaInfoByVisaInfo(ref VisaID,
                 VisaNumber, PIN, ref UserID, ref TotalAmount))
            {
                return new clsVisa(VisaID,
                   VisaNumber, PIN, UserID, TotalAmount);
            }
            else
                return null;
        }

        public static clsVisa FindByUserID(int UserID)
        {
            int VisaID = -1; string VisaNumber = "";
            int PIN = 0, TotalAmount = 0;


            if (clsVisasDataAccess.GetVisaInfoByUserID(ref VisaID,
                 ref VisaNumber, ref PIN, UserID, ref TotalAmount))
            {
                return new clsVisa(VisaID,
                   VisaNumber, PIN, UserID, TotalAmount);
            }
            else
                return null;
        }

        public static DataTable GetAllVisasByUserID(int UserID)
        {
            DataTable DT = clsVisasDataAccess.GetAllVisasByUserID(UserID);
            return DT;
        }

        public static bool DeleteVisa(int VisaID)
        {
            return clsVisasDataAccess.DeleteVisa(VisaID);
        }

        public static int GetNumberOfVisas(int UserID)
        {
            return clsVisasDataAccess.GetNumberOfVisas(UserID);
        }

        public bool Add(int NewAmount)
        {
            TotalAmount += NewAmount;
            return this.Save();
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewVisa())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateVisa();

            }

            return false;
        }


    }
}
