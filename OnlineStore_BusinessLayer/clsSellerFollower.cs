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
    public class clsSellerFollower
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int FollowerID { get; set; }

        public int UserID { get; set; }

        public int SellerID { get; set; }


        public clsSeller Seller { get { return clsSeller.Find(SellerID); } }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }



        public clsSellerFollower()
        {
            FollowerID = -1;
            UserID = -1;
            SellerID = -1;
            mode = Mode.eAddNew;
        }

        private clsSellerFollower(int FollowerID,
            int UserID, int SellerID)
        {
            this.FollowerID = FollowerID;
            this.UserID = UserID;
            this.SellerID = SellerID;
            mode = Mode.eUpdate;
        }


        bool _AddNewSellerFollower()
        {
            FollowerID = clsSellersFollowersDataAccess.AddNewSellerFollower(
                this.UserID, this.SellerID);
            return FollowerID != -1;
        }

        bool _UpdateSellerFollower()
        {
            return clsSellersFollowersDataAccess.UpdateSellerFollower(
                this.FollowerID, this.UserID, this.SellerID);
        }

        public static bool DoesFollowerExist(int SellerID, int UserID)
        {
            return (clsSellersFollowersDataAccess.DoesFollowerExist(UserID, SellerID));
        }


        public static clsSellerFollower Find(int FollowerID)
        {
            int UserID = -1, SellerID = -1;


            if (clsSellersFollowersDataAccess.GetSellerFollowerInfoByID(
                FollowerID, ref UserID, ref SellerID))
            {
                return new clsSellerFollower(FollowerID, UserID, SellerID);
            }
            else
                return null;
        }


        public static int GetNumberOfSellerFollower(int SellerID)
        {
            return clsSellersFollowersDataAccess.GetNumberOfSellerFollower(SellerID);
        }


        public static bool DeleteSellerFollower(int SellerID, int UserID)
        {
            return clsSellersFollowersDataAccess.DeleteSellerFollower(SellerID, UserID);
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewSellerFollower())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateSellerFollower();

            }

            return false;
        }


    }
}
