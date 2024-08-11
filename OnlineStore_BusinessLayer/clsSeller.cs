using DVLD_BusinessLayer;
using DVLD_DataAccessLayer;
using OnlineStore_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_BusinessLayer
{
    public class clsSeller
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int SellerID { get; set; }

        public int UserID { get; set; }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }

        public int Followers { get { return clsSellerFollower.GetNumberOfSellerFollower(this.SellerID); } }

        public clsSeller()
        {
            SellerID = -1;
            UserID = -1;

            mode = Mode.eAddNew;
        }

        private clsSeller(int SellerID, int UserID)
        {
            this.SellerID = SellerID;
            this.UserID = UserID;          
            mode = Mode.eUpdate;
        }

        bool _AddNewSeller()
        {
            this.SellerID =  clsSellersDataAccess.AddNewSeller(this.UserID);
            return this.SellerID != -1;
        }

        bool _UpdateSeller()
        {
            return (clsSellersDataAccess.UpdateSellerInfo(this.SellerID, this.UserID));
        }

        public bool Follow(int UserID, bool Follow)
        {
            if (!clsSellerFollower.DoesFollowerExist(this.SellerID, UserID) && Follow)
            {
                clsSellerFollower sellerFollower = new clsSellerFollower();
                sellerFollower.SellerID = this.SellerID;
                sellerFollower.UserID = UserID;
                return sellerFollower.Save();                                          
            }
            else if (!Follow)
            {
                return clsSellerFollower.DeleteSellerFollower(this.SellerID, UserID);
            }

            return false;

        }


        public static clsSeller Find(int SellerID)
        {
            int UserID = -1;
           

            if (clsSellersDataAccess.GetSellerInfoByID(SellerID, ref UserID))
            {
                return new clsSeller(SellerID, UserID);
            }
            else
                return null;
        }

        public static clsSeller FindByUserID(int UserID)
        {
            int SellerID = -1;


            if (clsSellersDataAccess.GetSellerInfoByUserID(ref SellerID, UserID))
            {
                return new clsSeller(SellerID, UserID);
            }
            else
                return null;
        }


        public static DataTable GetAllSellers()
        {
            DataTable DT = clsSellersDataAccess.GetAllSellers();
            return DT;
        }
  
        public static int GetNumberOSellers()
        {
            return clsSellersDataAccess.GetNumberOSellers();
        }

        public static bool DoesSellerExist(int SellerID)
        {
            return (clsSellersDataAccess.DoesSellerExist(SellerID));
        }

        public bool Save()
        {          
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewSeller())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateSeller();

            }

            return false;
        }


    }
}
