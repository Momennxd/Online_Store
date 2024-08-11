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
    public class clsFavProduct
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int FavProductID { get; set; }

        public int UserID { get; set; }

        public int ProductID { get; set; }

        public clsProduct Product { get { return clsProduct.Find(ProductID); } }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }


        public clsFavProduct()
        {
            FavProductID = -1;
            UserID = -1;
            ProductID = -1;

            mode = Mode.eAddNew;
        }

        private clsFavProduct(int FavProductID,
            int UserID, int ProductID)
        {
            this.FavProductID = FavProductID;
            this.UserID = UserID;
            this.ProductID = ProductID;
            mode = Mode.eUpdate;
        }

        bool _AddNewItemToFavList()
        {
            FavProductID = clsFavProductsDataAccess.AddNewFavProduct(
                this.UserID, this.ProductID);
            return FavProductID != -1;
        }

        bool _UpdateItemInFavList()
        {
            return (clsFavProductsDataAccess.UpdateFavProduct(
                this.FavProductID, this.UserID, this.ProductID));
        }


        public static clsFavProduct Find(int FavProductID)
        {
            int UserID = -1, ProductID = -1;


            if (clsFavProductsDataAccess.GetFavProductInfoByID(
                FavProductID, ref UserID, ref ProductID))
            {
                return new clsFavProduct(FavProductID, UserID, ProductID);
            }
            else
                return null;
        }

        public static DataTable GetAllItemsInFavProductsList(int UserID)
        {
            DataTable DT = clsFavProductsDataAccess.GetAllItemsInFavProductsList(UserID);
            return DT;
        }

        public static bool DeleteItemFromFavProductsList(int FavProductID)
        {
            return (clsFavProductsDataAccess.DeleteItemFromFavProductsList(FavProductID));
        }
        public static bool DeleteItemFromFavProductsList(int UserID, int ProductID)
        {
            return (clsFavProductsDataAccess.DeleteItemFromFavProductsList(UserID, ProductID));
        }


        public static int GetNumberOfItemsInFavProductsList(int UserID)
        {
            return clsFavProductsDataAccess.GetNumberOfItemsInFavProductsList(UserID);
        }

        public static bool DoesProductExistInFavList(int ProductID, int UserID)
        {
            return (clsFavProductsDataAccess.DoesProductExistInFavList(ProductID, UserID));
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewItemToFavList())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateItemInFavList();

            }

            return false;
        }


    }
}
