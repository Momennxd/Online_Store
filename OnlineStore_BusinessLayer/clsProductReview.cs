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
    public class clsProductReview
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int ProductReviewID { get; set; }

        public int UserID { get; set; }

        public byte Rating { get; set; }

        public int ProductID { get; set; }

        public DateTime RatingDate { get; set; }

        public string ReviewComment { get; set; }   

        public clsUser User { get { return clsUser.FindByUserID(this.UserID); }  }

        public int ProductReviewLikes 
        { get { return clsProductReviewLike.GetNumberOfProductReviewLikes(this.ProductReviewID); } }

        public clsProduct Product { get { return clsProduct.Find(this.ProductID); } }



        public clsProductReview()
        {
            ProductReviewID = -1;
            UserID = -1;
            Rating = 0;
            ProductID = -1;
            RatingDate = DateTime.Now;
            ReviewComment = "";
            mode = Mode.eAddNew;
        }


        private clsProductReview(int ProductReviewID,
            int UserID, byte Rating, int ProductID, DateTime RatingDate,
            string ReviewComment)
        {
            this.ProductReviewID = ProductReviewID;
            this.UserID = UserID;
            this.Rating = Rating;
            this.ProductID = ProductID;
            this.RatingDate = RatingDate;
            this.ReviewComment = ReviewComment;
            mode = Mode.eUpdate;
        }


        bool _AddNewProductReview()
        {
            ProductReviewID = clsProductReviewsDataAccess.AddNewProductReview(UserID, Rating,
                ProductID, RatingDate, ReviewComment);
            return ProductReviewID != -1;
        }

        bool _UpdateProductReview()
        {
            return (clsProductReviewsDataAccess.UpdateProductReviewInfo(ProductReviewID, UserID, Rating,
                ProductID, RatingDate, ReviewComment));
        }


        public static clsProductReview Find(int ProductReviewID)
        {
            string ReviewComment = "";
            byte Rating = 0;
            int UserID = -1, ProductID = -1;
            DateTime RatingDate = DateTime.Now;

            if (clsProductReviewsDataAccess.GetProductReviewInfoByID(ProductReviewID, ref UserID, ref Rating,
                ref ProductID, ref RatingDate, ref ReviewComment))
            {
                return new clsProductReview(ProductReviewID, UserID, Rating,
                ProductID, RatingDate, ReviewComment);
            }
            else
                return null;
        }

        public static clsProductReview Find(int UserID, int ProductID)
        {
            string ReviewComment = "";
            byte Rating = 0;
            int ProductReviewID = -1;
            DateTime RatingDate = DateTime.Now;

            if (clsProductReviewsDataAccess.GetProductReviewInfo(ref ProductReviewID, UserID, ref Rating,
                ProductID, ref RatingDate, ref ReviewComment))
            {
                return new clsProductReview(ProductReviewID, UserID, Rating,
                ProductID, RatingDate, ReviewComment);
            }
            else
                return null;
        }

        public static DataTable GetAllProductReviews()
        {
            DataTable DT = clsProductReviewsDataAccess.GetAllProductReviews();
            return DT;
        }

        public static DataTable GetAllProductReviewsByProductID(int ProductID)
        {
            DataTable DT = clsProductReviewsDataAccess.GetAllProductReviewsByProductID(ProductID);
            return DT;
        }

        public static DataTable GetAllProductReviewsByUserID(int UserID)
        {
            DataTable DT = clsProductReviewsDataAccess.GetAllProductReviewsByUserID(UserID);
            return DT;
        }

        public static int GetNumberOfProductReviews(int ProductID)
        {
            return clsProductReviewsDataAccess.GetNumberOfProductReviews(ProductID);
        }

        public static int GetAvrgProductReviewsByProduct(int ProductID)
        {
            return clsProductReviewsDataAccess.GetAvrgProductReviewsByProduct(ProductID);
        }

        public bool Like(int UserID, bool Like)
        {
            if (clsProductReviewsLikesDataAccess.DoesProductReviewLikeExist(ProductReviewID, UserID))
            {
                return clsProductReviewsLikesDataAccess.LikeUnlikeProductReview(
                    ProductReviewID, UserID, Like);
            }
            else
            {
                clsProductReviewLike productReviewLike = new clsProductReviewLike();
                productReviewLike.UserID = UserID;
                productReviewLike.Like = Like;
                productReviewLike.ProductReviewID = ProductReviewID;
                return productReviewLike.Save();

            }
        }

        public static bool DoesProductReviewExist(int ProductID, int UserID)
        {
            return (clsProductReviewsDataAccess.DoesProductReviewExist(ProductID, UserID));
        }

        public static bool DeleteProductReview(int ProductReviewID)
        {
            clsProductReviewsLikesDataAccess.DeleteProductReviewsLikes(ProductReviewID);
            return clsProductReviewsDataAccess.DeleteProductReview(ProductReviewID);
        }



        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewProductReview())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateProductReview();

            }

            return false;
        }






    }
}
