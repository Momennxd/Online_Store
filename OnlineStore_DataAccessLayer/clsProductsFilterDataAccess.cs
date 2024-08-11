using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_DataAccessLayer
{
    public  class clsProductsFilterDataAccess
    {

       // public static DataTable GetAllProductReviewsByPriceFilter(int Min, int Max)
       // {
       //     DataTable DT = new DataTable();

       //     SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

       //     string Query = $@"select ProductID from Products where Price >= @Min and price <= @Max";

       //     SqlCommand Command = new SqlCommand(Query, connection);

       //     Command.Parameters.AddWithValue("@Min", Min);
       //     Command.Parameters.AddWithValue("@Max", Max);

       //     try
       //     {
       //         connection.Open();
       //         SqlDataReader Reader = Command.ExecuteReader();

       //         while (Reader.HasRows)
       //         {
       //             DT.Load(Reader);
       //         }

       //         Reader.Close();


       //     }
       //     catch (Exception ex)
       //     {
       //         //
       //     }
       //     finally
       //     {
       //         connection.Close();
       //     }

       //     return DT;
       // }

       // public static DataTable GetAllProductReviewsByAvrgReviewsFilter(int AvrgReviews)
       // {
       //     DataTable DT = new DataTable();

       //     SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

       //     string Query = $@"select ProductID from Products where (
       //            select sum(Rating)  / count(*)  from ProductReviews 
       //              where Products.ProductID = ProductReviews.ProductID) = @AvrgReviews 
       //              group by Products.ProductID";

       //     SqlCommand Command = new SqlCommand(Query, connection);

       //     Command.Parameters.AddWithValue("@AvrgReviews", AvrgReviews);

       //     try
       //     {
       //         connection.Open();
       //         SqlDataReader Reader = Command.ExecuteReader();

       //         while (Reader.HasRows)
       //         {
       //             DT.Load(Reader);
       //         }

       //         Reader.Close();


       //     }
       //     catch (Exception ex)
       //     {
       //         //
       //     }
       //     finally
       //     {
       //         connection.Close();
       //     }

       //     return DT;
       // }

       // public static DataTable GetAllProductReviewsBySearchFilter(int SearchInput)
       // {
       //     DataTable DT = new DataTable();

       //     SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

       //     string Query = $@"SELECT        Products.ProductID
       //                  FROM            Products INNER JOIN
       //                  Categories ON Products.CategoryID = Categories.CategoryID INNER JOIN
       //                  Sellers ON Products.SellerID = Sellers.SellerID INNER JOIN
       //                  Users ON Sellers.UserID = Users.UserID 

						 //where ProductName like '%@SearchInput%' or Description like '%@SearchInput%' or
						 //Brand like '%@SearchInput%' or UserName like '%@SearchInput%' or CategoryName like '%@SearchInput%'";

       //     SqlCommand Command = new SqlCommand(Query, connection);

       //     Command.Parameters.AddWithValue("@SearchInput", SearchInput);

       //     try
       //     {
       //         connection.Open();
       //         SqlDataReader Reader = Command.ExecuteReader();

       //         while (Reader.HasRows)
       //         {
       //             DT.Load(Reader);
       //         }

       //         Reader.Close();


       //     }
       //     catch (Exception ex)
       //     {
       //         //
       //     }
       //     finally
       //     {
       //         connection.Close();
       //     }

       //     return DT;
       // }


        public static DataTable GetAllProductsByFilter(int Min, int Max, int? CategoryID,
            string SearchFilter, int AvrgRating)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "";

            if (CategoryID == null)
            {
                if (AvrgRating == -1)
                {
                    //excuted when there is NO category and the avrg rating is FULL:
                    Query = $@"SELECT        Products.ProductID
                         FROM            Products INNER JOIN
                         Categories ON Products.CategoryID = Categories.CategoryID INNER JOIN
                         Sellers ON Products.SellerID = Sellers.SellerID INNER JOIN
                         Users ON Sellers.UserID = Users.UserID 

						 where (ProductName like '%{SearchFilter}%' or Description like '%{SearchFilter}%' or
						 Brand like '%{SearchFilter}%' or UserName like '%{SearchFilter}%' or
                                  CategoryName like '%{SearchFilter}%') and

				    	 (Price >= @Min and price <= @Max) and
                                                
                         (select sum(Rating)  / count(*)  from ProductReviews where
                         Products.ProductID = ProductReviews.ProductID)  in (0,1,2,3,4,5)
                         group by Products.ProductID";
                }
                else if (AvrgRating == 3)
                {
                    Query = $@"SELECT        Products.ProductID
                         FROM            Products INNER JOIN
                         Categories ON Products.CategoryID = Categories.CategoryID INNER JOIN
                         Sellers ON Products.SellerID = Sellers.SellerID INNER JOIN
                         Users ON Sellers.UserID = Users.UserID 

						 where (ProductName like '%{SearchFilter}%' or Description like '%{SearchFilter}%' or
						 Brand like '%{SearchFilter}%' or UserName like '%{SearchFilter}%' or
                                  CategoryName like '%{SearchFilter}%') and

				    	 (Price >= @Min and price <= @Max) and
                                                
                         (select sum(Rating)  / count(*)  from ProductReviews where
                         Products.ProductID = ProductReviews.ProductID)  in (0,1,2,3)
                         group by Products.ProductID";

                }
                else
                {
                    //excuted when there is NO category and the avrg rating is NOT full:
                    Query = $@"SELECT        Products.ProductID
                         FROM            Products INNER JOIN
                         Categories ON Products.CategoryID = Categories.CategoryID INNER JOIN
                         Sellers ON Products.SellerID = Sellers.SellerID INNER JOIN
                         Users ON Sellers.UserID = Users.UserID 

						 where (ProductName like '%{SearchFilter}%' or Description like '%{SearchFilter}%' or
						 Brand like '%{SearchFilter}%' or UserName like '%{SearchFilter}%' or
                                  CategoryName like '%{SearchFilter}%') and

				    	 (Price >= @Min and price <= @Max) and
                                                
                         (select sum(Rating)  / count(*)  from ProductReviews where
                         Products.ProductID = ProductReviews.ProductID) = @AvrgRating
                         group by Products.ProductID";

                }
            }
            else
            {
                if (AvrgRating == -1)
                {
                    //excuted when there IS category and the avrg rating is FULL:
                    Query = $@"SELECT        Products.ProductID
                         FROM            Products INNER JOIN
                         Categories ON Products.CategoryID = Categories.CategoryID INNER JOIN
                         Sellers ON Products.SellerID = Sellers.SellerID INNER JOIN
                         Users ON Sellers.UserID = Users.UserID 

						where (ProductName like '%{SearchFilter}%' or Description like '%{SearchFilter}%' or
						 Brand like '%{SearchFilter}%' or UserName like '%{SearchFilter}%' or
                                  CategoryName like '%{SearchFilter}%') and

				    	 (Price >= @Min and price <= @Max) and

						 Categories.CategoryID = @CategoryID and
                                                
                         (select sum(Rating)  / count(*)  from ProductReviews where
                         Products.ProductID = ProductReviews.ProductID)  in (0,1,2,3,4,5)
                         group by Products.ProductID";
                }
                else if (AvrgRating == 3)
                {
                    Query = $@"SELECT        Products.ProductID
                         FROM            Products INNER JOIN
                         Categories ON Products.CategoryID = Categories.CategoryID INNER JOIN
                         Sellers ON Products.SellerID = Sellers.SellerID INNER JOIN
                         Users ON Sellers.UserID = Users.UserID 

						where (ProductName like '%{SearchFilter}%' or Description like '%{SearchFilter}%' or
						 Brand like '%{SearchFilter}%' or UserName like '%{SearchFilter}%' or
                                  CategoryName like '%{SearchFilter}%') and

				    	 (Price >= @Min and price <= @Max) and

						 Categories.CategoryID = @CategoryID and
                                                
                         (select sum(Rating)  / count(*)  from ProductReviews where
                         Products.ProductID = ProductReviews.ProductID)  in (0,1,2,3)
                         group by Products.ProductID";

                }
                else
                {
                    //excuted when there IS category and the avrg rating is NOT full:
                    Query = $@"SELECT        Products.ProductID
                         FROM            Products INNER JOIN
                         Categories ON Products.CategoryID = Categories.CategoryID INNER JOIN
                         Sellers ON Products.SellerID = Sellers.SellerID INNER JOIN
                         Users ON Sellers.UserID = Users.UserID 

						 where (ProductName like '%{SearchFilter}%' or Description like '%{SearchFilter}%' or
						 Brand like '%{SearchFilter}%' or UserName like '%{SearchFilter}%' or
                                  CategoryName like '%{SearchFilter}%') and

				    	 (Price >= @Min and price <= @Max) and

						 Categories.CategoryID = @CategoryID and
                                                
                         (select sum(Rating)  / count(*)  from ProductReviews where
                         Products.ProductID = ProductReviews.ProductID) = @AvrgRating
                         group by Products.ProductID";

                }

            }

            SqlCommand Command = new SqlCommand(Query, connection);

            if (Min != 0 && Max != 0)
            {
                Command.Parameters.AddWithValue("@Min", Min);

                Command.Parameters.AddWithValue("@Max", Max);
            }
            else
            {
                Command.Parameters.AddWithValue("@Min", 0);

                Command.Parameters.AddWithValue("@Max", clsProductsDataAccess.GetHightProductPrice());
            }
           

            if (CategoryID != null)
            {
                Command.Parameters.AddWithValue("@CategoryID", CategoryID);

            }

            if (AvrgRating != -1)
            {
                Command.Parameters.AddWithValue("@AvrgRating", AvrgRating);

            }

            //Command.Parameters.AddWithValue("@SearchFilter", SearchFilter);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return DT;
        }


    }
}
