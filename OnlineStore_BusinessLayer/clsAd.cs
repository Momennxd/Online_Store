using OnlineStore_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_BusinessLayer
{
    public class clsAd
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }

        public enMode mode = enMode.eAddNew;

        public int AddID { get; set; }

        public int SellerID { get; set; }

        public string AddPicPath { get; set; }

        public string Description { get; set; }
    
        public decimal AddFee { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsAvailable { get; set; }

        public int ProductID { get; set; }


        public clsProduct Product { get { return clsProduct.Find(this.ProductID); } }

        public clsSeller Seller { get { return clsSeller.Find(this.SellerID); } }


        public clsAd()
        {
            AddID = -1;
            SellerID = -1;
            AddPicPath = "";
            Description = "";
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            IsAvailable = false;
            ProductID = -1;
            AddFee = 0;
            mode = enMode.eAddNew;
        }

        private clsAd(int AddID, int SellerID,
          string AddPicPath, string Description, decimal AddFee,
          DateTime StartDate, DateTime EndDate,
          bool IsAvailable, int ProductID)
        {
            this.AddID = AddID;
            this.SellerID = SellerID;
            this.AddPicPath = AddPicPath;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IsAvailable = IsAvailable;
            this.ProductID = ProductID;
            this.AddFee = AddFee;
            mode = enMode.eUpdate;
        }


        bool _AddNewAd()
        {
            this.AddID = clsAdsDataAccess.AddNewAd(this.SellerID,
          this.AddPicPath, this.Description, this.AddFee,
          this.StartDate, this.EndDate,
          this.IsAvailable, this.ProductID);

            return this.AddID != -1;
        }


        bool _UpdateAd()
        {
            return (clsAdsDataAccess.UpdateAdInfo(this.AddID, this.SellerID,
          this.AddPicPath, this.Description, this.AddFee,
          this.StartDate, this.EndDate,
          this.IsAvailable, this.ProductID));
        }

        public static clsAd Find(int AddID)
        {
            string AddPicPath = "", Description = "";

            DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;

            int SellerID = -1, ProductID = -1;

            bool IsAvailable = false; decimal AddFee = 0;

            if (clsAdsDataAccess.GetAdInfoByID(AddID, ref SellerID,
          ref AddPicPath, ref Description, ref AddFee,
          ref StartDate, ref EndDate,
          ref IsAvailable, ref ProductID))
            {
                return new clsAd(AddID, SellerID,
                   AddPicPath, Description, AddFee,
                   StartDate, EndDate,
                   IsAvailable, ProductID);
            }
            else
                return null;
        }

        public static DataTable GetAllAds()
        {
            DataTable DT = clsAdsDataAccess.GetAllAds();
            return DT;
        }

        public static int GetNumberOfAds()
        {
            return clsAdsDataAccess.GetNumberOfAds();
        }


        public static bool DeleteAd(int AddID)
        {
            return (clsAdsDataAccess.DeleteAd(AddID));
        }

        public static bool DoesAdExist(int AddID)
        {
            return (clsAdsDataAccess.DoesAdExist(AddID));
        }

        public static bool IsAdAvailable(int AddID)
        {
            return (clsAdsDataAccess.IsAdAvailable(AddID));
        }

        public static bool InActiveExpiredAds()
        {
            return (clsAdsDataAccess.InActiveExpiredAds());
        }


        public bool Save()
        {
            switch (mode)
            {
                case enMode.eAddNew:
                    {
                        if (_AddNewAd())
                        {
                            mode = enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case enMode.eUpdate:

                    return _UpdateAd();

            }

            return false;
        }


    }
}
