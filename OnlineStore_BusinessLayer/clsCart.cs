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
    public class clsCart
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int CartID { get; set; }

        public int UserID { get; set; }

        public int ProductID { get; set; }

        public clsProduct Product { get { return clsProduct.Find(ProductID); } }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }


        public clsCart()
        {
            CartID = -1;
            UserID = -1;
            ProductID = -1;

            mode = Mode.eAddNew;
        }

        private clsCart(int CartID,
            int UserID, int ProductID)
        {
            this.CartID = CartID;
            this.UserID = UserID;
            this.ProductID = ProductID;
            mode = Mode.eUpdate;
        }


        bool _AddNewItemToCart()
        {
            CartID = clsCartsDataAccess.AddToCart(
                this.UserID, this.ProductID);
            return CartID != -1;
        }

        bool _UpdateItemInCart()
        {
            return (clsCartsDataAccess.UpdateCart(
                this.CartID, this.UserID, this.ProductID));
        }

        public static clsCart Find(int CartID)
        {
            int UserID = -1, ProductID = -1;
            

            if (clsCartsDataAccess.GetCartInfoByID(
                CartID, ref UserID, ref ProductID))
            {
                return new clsCart(CartID, UserID, ProductID);
            }
            else
                return null;
        }

        public static DataTable GetAllItemsInCart(int UserID)
        {
            DataTable DT = clsCartsDataAccess.GetAllItemsInCart(UserID);
            return DT;
        }

        public static bool DeleteItemFromCart(int CartID)
        {
            return (clsCartsDataAccess.DeleteItemFromCart(CartID));
        }

        public static bool DeleteItemFromCart(int UserID, int ProductID)
        {
            return (clsCartsDataAccess.DeleteItemFromCart(UserID, ProductID));
        }

        public static int GetNumberOfItemsInCart(int UserID)
        {
            return clsCartsDataAccess.GetNumberOfItemsInCart(UserID);
        }

        public static bool DoesProductExistInCartList(int ProductID, int UserID)
        {
            return (clsCartsDataAccess.DoesProductExistInCartList(ProductID, UserID));
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewItemToCart())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateItemInCart();

            }

            return false;
        }

    }
}
