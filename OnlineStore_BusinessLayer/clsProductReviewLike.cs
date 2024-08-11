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
    public class clsProductReviewLike
    {


        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int ProductReviewLikeID { get; set; }

        public int UserID { get; set; }

        public int ProductReviewID { get; set; }

        public bool Like { get; set; }


        public clsProductReview ProductReview { get { return clsProductReview.Find(ProductReviewID); } }

        public clsUser User { get { return clsUser.FindByUserID(UserID); } }


        public clsProductReviewLike()
        {
            ProductReviewLikeID = -1;
            UserID = -1;
            ProductReviewID = -1;
            Like = false;
            mode = Mode.eAddNew;
        }

        private clsProductReviewLike(int ProductReviewLikeID,
            int UserID, int ProductReviewID, bool Like)
        {
            this.ProductReviewLikeID = ProductReviewLikeID;
            this.UserID = UserID;
            this.ProductReviewID = ProductReviewID;
            this.Like = Like;
            mode = Mode.eUpdate;
        }



        bool _AddNewProductReviewLike()
        { 
            ProductReviewLikeID = clsProductReviewsLikesDataAccess.AddNewProductReviewLike(
                this.UserID, this.ProductReviewID, this.Like);
            return ProductReviewLikeID != -1;
        }

        bool _UpdateProductReviewLike()
        {
            return (clsProductReviewsLikesDataAccess.UpdateProductReviewLike(
                this.ProductReviewLikeID, this.UserID, this.ProductReviewID, this.Like));
        }

        public static clsProductReviewLike Find(int ProductReviewLikeID)
        {
            int UserID = -1, ProductReviewID = -1;
            bool Like = false;


            if (clsProductReviewsLikesDataAccess.GetProductReviewLikeInfoByID(
                ProductReviewLikeID, ref UserID, ref ProductReviewID, ref Like))
            {
                return new clsProductReviewLike(ProductReviewLikeID, UserID, ProductReviewID, Like);
            }
            else
                return null;
        }


        public static DataTable GetAllProductReviewLikes(int ProductReviewID)
        {
            DataTable DT = clsProductReviewsLikesDataAccess.GetAllProductReviewLikes(ProductReviewID);
            return DT;
        }

        public static int GetNumberOfProductReviewLikes(int ProductReviewID)
        {
            return clsProductReviewsLikesDataAccess.GetNumberOfProductReviewLikes(ProductReviewID);
        }

        public static bool DoesUserLikeProductReview(int ProductReviewID, int UserID)
        {
            if (clsProductReviewsLikesDataAccess.DoesProductReviewLikeExist(ProductReviewID, UserID))
            {
                return clsProductReviewsLikesDataAccess.DoesUserLikeProductReview(ProductReviewID, UserID);
            }

            return false;
        }

        public static bool DeleteProductReviewLikes(int ProductReviewID)
        {
            return clsProductReviewsLikesDataAccess.DeleteProductReviewsLikes(ProductReviewID);
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewProductReviewLike())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateProductReviewLike();

            }

            return false;
        }



    }
}
