using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace OnlineStore_DataAccessLayer
{
    public class clsProductsDataAccess
    {

        public static bool GetProductInfoByID(int ProductID, ref string ProductName, ref string Description,
           ref int CategoryID, ref string Brand, ref decimal Price, ref int Quantity, ref bool InStock,
            ref int SellerID, ref DateTime CreationDate, ref string ImagePath, ref int DeliveringTypeID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT * FROM Products WHERE ProductID = @ProductID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductID", ProductID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    ProductName = (string)Reader["ProductName"];
                    Description = (string)Reader["Description"];
                    CategoryID = (int)Reader["CategoryID"];

                    if (Reader["Brand"] != DBNull.Value)
                    {
                        Brand = (string)Reader["Brand"];
                    }
                    else
                    {
                        Brand = "";
                    }

                    Price = (decimal)Reader["Price"];
                    Quantity = (int)Reader["Quantity"];
                    InStock = (bool)Reader["InStock"];
                    SellerID = (int)Reader["SellerID"];
                    CreationDate = (DateTime)Reader["CreationDate"];

                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    DeliveringTypeID = (int)Reader["DeliveringTypeID"];



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

            return IsFound;


        }


        public static int AddNewProduct(string ProductName, string Description,
           int CategoryID, string Brand, decimal Price, int Quantity, bool InStock,
            int SellerID, DateTime CreationDate, string ImagePath, int DeliveringTypeID)
        {
            int ProductID = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"INSERT INTO Products (ProductName, Description,
                             CategoryID, Brand, Price, Quantity, InStock, SellerID, CreationDate,
                             ImagePath, DeliveringTypeID)

                             VALUES (@ProductName, @Description,
                             @CategoryID, @Brand, @Price, @Quantity, @InStock, @SellerID, @CreationDate,
                             @ImagePath, @DeliveringTypeID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductName", ProductName);

            Command.Parameters.AddWithValue("@Description", Description);

            Command.Parameters.AddWithValue("@CategoryID", CategoryID);


            if (!string.IsNullOrEmpty(Brand))
                Command.Parameters.AddWithValue("@Brand", Brand);
            else
                Command.Parameters.AddWithValue("@Brand", DBNull.Value);

            Command.Parameters.AddWithValue("@Price", Price);

            Command.Parameters.AddWithValue("@Quantity", Quantity);

            Command.Parameters.AddWithValue("@InStock", InStock);

            Command.Parameters.AddWithValue("@SellerID", SellerID);

            Command.Parameters.AddWithValue("@CreationDate", CreationDate);

            if (!string.IsNullOrEmpty(ImagePath))
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            Command.Parameters.AddWithValue("@DeliveringTypeID", DeliveringTypeID);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ProductID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }


            return ProductID;

        }


        public static bool UpdateProductInfo(int ProductID, string ProductName, string Description,
           int CategoryID, string Brand, decimal Price, int Quantity, bool InStock,
            int SellerID, DateTime CreationDate, string ImagePath, int DeliveringTypeID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"UPDATE Products 
                             SET ProductName = @ProductName,
                                 Description = @Description,
                                 CategoryID = @CategoryID,
                                 Brand = @Brand,
                                 Quantity = @Quantity,
                                 InStock = @InStock,
                                 SellerID = @SellerID,
                                 CreationDate = @CreationDate,
                                 ImagePath = @ImagePath,
                                 DeliveringTypeID = @DeliveringTypeID                            
                                 WHERE ProductID = @ProductID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@ProductID", ProductID);

            Command.Parameters.AddWithValue("@ProductName", ProductName);

            Command.Parameters.AddWithValue("@Description", Description);

            Command.Parameters.AddWithValue("@CategoryID", CategoryID);


            if (!string.IsNullOrEmpty(Brand))
                Command.Parameters.AddWithValue("@Brand", Brand);
            else
                Command.Parameters.AddWithValue("@Brand", DBNull.Value);

            Command.Parameters.AddWithValue("@Price", Price);

            Command.Parameters.AddWithValue("@Quantity", Quantity);

            Command.Parameters.AddWithValue("@InStock", InStock);

            Command.Parameters.AddWithValue("@SellerID", SellerID);

            Command.Parameters.AddWithValue("@CreationDate", CreationDate);

            if (!string.IsNullOrEmpty(ImagePath))
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            Command.Parameters.AddWithValue("@DeliveringTypeID", DeliveringTypeID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }

        public static DataTable GetAllProducts()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = @"SELECT * FROM Products";

            SqlCommand Command = new SqlCommand(Query, connection);

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

        public static DataTable GetAllProducts(int CategoryID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = $@"SELECT * FROM Products Where CategoryID = {CategoryID}";

            SqlCommand Command = new SqlCommand(Query, connection);

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

        public static DataTable GetTop10RatedProducts()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = $@"select top 7 ProductID from Products order by (
                       select sum(Rating)  / count(*)  from
                       ProductReviews where Products.ProductID = ProductReviews.ProductID ) desc";

            SqlCommand Command = new SqlCommand(Query, connection);

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



        public static int GetNumberOfProducts()
        {
            int NumberOfProducts = -1;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM Products WHERE ProductID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfLicenseID))
                {
                    NumberOfProducts = AcualNumOfLicenseID;
                }


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return NumberOfProducts;
        }

        public static bool DoesProductExist(int ProductID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM Products WHERE ProductID = @ProductID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductID", ProductID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static decimal GetHightProductPrice()
        {
            decimal HightsPrice = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string HightsProductPriceQuery = "select top 1 Price  from Products order by price desc";

            SqlCommand Command = new SqlCommand(HightsProductPriceQuery, connection);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    HightsPrice = Convert.ToDecimal(Result);
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return HightsPrice;
        }


        public static bool DeleteProduct(int ProductID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsOnlineStoreDataSettings.ConnectionString);

            string Query = "DELETE Products WHERE ProductID = @ProductID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ProductID", ProductID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }



    }
}
