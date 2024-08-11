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
    public class clsProduct
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public int CategoryID { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool InStock { get; set; }

        public int SellerID { get; set; }

        public DateTime CreationDate { get; set; }

        public string ImagePath { get; set; }

        public int DeliveringTypeID { get; set; }

        public clsDeliveryType DeliveryType { get {  return clsDeliveryType.Find(DeliveringTypeID); } }

        public int AvrgReviews { get { return clsProductReview.GetAvrgProductReviewsByProduct(this.ProductID); } }

        public int NumberOfReviews { get { return clsProductReview.GetNumberOfProductReviews(this.ProductID); } }

        public clsCategory Category { get { return clsCategory.Find(this.CategoryID); } }

        public clsSeller Seller { get { return clsSeller.Find(this.SellerID); } }




        public clsProduct()
        {
            ProductID = -1;
            ProductName = "";
            Description = "";
            CategoryID = -1;
            Brand = "";
            Price = 0;
            Quantity = 0;
            InStock = false;
            SellerID = -1;
            CreationDate = DateTime.Now;
            ImagePath = "";
            DeliveringTypeID = -1;
            mode = Mode.eAddNew;
        }

        private clsProduct(int ProductID, string ProductName, string Description,
           int CategoryID, string Brand, decimal Price, int Quantity, bool InStock,
            int SellerID, DateTime CreationDate, string ImagePath, int DeliveringTypeID)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Description = Description;
            this.CategoryID = CategoryID;
            this.Brand = Brand;
            this.Price = Price;
            this.Quantity = Quantity;
            this.InStock = InStock;
            this.SellerID = SellerID;
            this.CreationDate = CreationDate;
            this.ImagePath = ImagePath;
            this.DeliveringTypeID = DeliveringTypeID;

            mode = Mode.eUpdate;
        }


        bool _AddNewProduct()
        {
            ProductID =clsProductsDataAccess.AddNewProduct(ProductName, Description,
           CategoryID, Brand, Price, Quantity, InStock,
            SellerID, CreationDate, ImagePath, DeliveringTypeID);

            return ProductID != -1;
        }

        bool _UpdateProduct()
        {
            return (clsProductsDataAccess.UpdateProductInfo(ProductID, ProductName, Description,
           CategoryID, Brand, Price, Quantity, InStock,
            SellerID, CreationDate, ImagePath, DeliveringTypeID));
        }

        public static clsProduct Find(int ProductID)
        {
            int CategoryID = -1, SellerID = -1, DeliveringTypeID = -1;
            string ProductName = "", Description = "", Brand = "", ImagePath = "";
            decimal Price = 0;
            int Quantity = 0;
            bool InStock = false;
            DateTime CreationDate = DateTime.Now;

            if (clsProductsDataAccess.GetProductInfoByID(ProductID, ref ProductName, ref Description,
           ref CategoryID, ref Brand, ref Price, ref Quantity, ref InStock,
            ref SellerID, ref CreationDate, ref ImagePath, ref DeliveringTypeID))
            {
                return new clsProduct(ProductID, ProductName, Description,
           CategoryID, Brand, Price, Quantity, InStock,
            SellerID, CreationDate, ImagePath, DeliveringTypeID);
            }
            else
                return null;
        }

        public static DataTable GetAllProducts()
        {
            DataTable DT = clsProductsDataAccess.GetAllProducts();
            return DT;
        }

        public static DataTable GetTop10RatedProducts()
        {
            DataTable DT = clsProductsDataAccess.GetTop10RatedProducts();
            return DT;
        }


        public static int GetNumberOfProducts()
        {
            return clsProductsDataAccess.GetNumberOfProducts();
        }

        public static bool DeleteProduct(int ProductID)
        {
            return (clsProductsDataAccess.DeleteProduct(ProductID));
        }

        public static bool DoesProductExist(int ProductID)
        {
            return (clsProductsDataAccess.DoesProductExist(ProductID));
        }

        public bool AddToFavourit(int UserID)
        {
            clsFavProduct favProduct = new clsFavProduct();
            favProduct.ProductID = this.ProductID;
            favProduct.UserID = UserID;
            return favProduct.Save();
        }

        public bool RemoveFromFavourit(int UserID)
        {
            return clsFavProduct.DeleteItemFromFavProductsList(UserID, this.ProductID);           
        }

        public bool AddToCart(int UserID)
        {
            clsCart Cart = new clsCart();
            Cart.ProductID = this.ProductID;
            Cart.UserID = UserID;
            return Cart.Save();
        }

        public bool RemoveFromCart(int UserID)
        {
            return clsCart.DeleteItemFromCart(UserID, this.ProductID);
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewProduct())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateProduct();

            }

            return false;
        }

    }
}
