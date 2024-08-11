using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.Properties;
using OnlineStore_PresentationLayer.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer.Products_List
{
    public partial class frmProductsList : Form
    {
        public frmProductsList()
        {
            InitializeComponent();
            clsGlobal.frmProductsList = this;
        }

        public int ? CurrentCatagory = null;

        public int CurrentReviewAvrgVal = -1;

        public int? PriceMinVal = null, PriceMaxVal = null;

        public string SearchInput = "";


        public ctrlProductsFilter ctrlProductsFilter_v = new ctrlProductsFilter();

        void ShowProductOnPanel(clsProduct Product)
        {
            ctrlProductThumbNail ctrlProduct = new ctrlProductThumbNail();

            //Here you should add the events
            ctrlProduct.OnProductClick += ProductClick;
            ctrlProduct.OnFavouritClick += FavouritClick;
            ctrlProduct.OnAddToCartClick += AddToCartClick;

            //adding to the Products panel
            ctrlProduct.DisplayProductData(Product);
            clsGlobal.ctrlProductThumbNailsList.Add(ctrlProduct);
            //FpnlProductsLoader.Controls.Add(ctrlProduct);
        }

        void ShowNoProductsHeader()
        {
            //showing no products header:
            if (FpnlProductsLoader.Controls.Count == 0)
            {
                lblEmptyProducts.Visible = true;
            }
            else
            {
                lblEmptyProducts.Visible = false;

            }
        }

        public void ResetPriceFilterVals()
        {
            PriceMinVal = null; PriceMaxVal = null;
        }


        public void DisplayProductThumbNailsFrstTime(DataTable Products)
        {
            FpnlProductsLoader.Controls.Clear();
            clsGlobal.ctrlProductThumbNailsList.Clear();
            //clsProductFilter.listAllProducts.Clear();
            //Repeating the products just for testing speed.
            //for (int i = 0; i < 30; i++)
            {
                foreach (DataRow Row in Products.Rows)
                {
                    ShowProductOnPanel(clsProduct.Find(Convert.ToInt16(Row["ProductID"])));
                    //clsProductFilter.listCurrentDisplayedProductsIDs.Add(Convert.ToInt16(Row["ProductID"]));                   
                    //clsProductFilter.listAllProducts.Add(Convert.ToInt16(Row["ProductID"]));


                }
            }

            ShowNoProductsHeader();


        }

        public void DisplayCustomProductsThums(int CategoryID)
        {
            FpnlProductsLoader.Controls.Clear();
            CurrentCatagory = CategoryID;

            if (string.IsNullOrEmpty(ctrlProductsFilter_v.txtMinValue.Text) ||
                string.IsNullOrEmpty(ctrlProductsFilter_v.txtMaxValue.Text))
            {
                for (int i = 0; i < clsGlobal.ctrlProductThumbNailsList.Count; i++)
                {
                    ctrlProductThumbNail Product = clsGlobal.ctrlProductThumbNailsList[i];
                    if (Product.CurrentProduct.CategoryID == CategoryID)
                    {
                        FpnlProductsLoader.Controls.Add(Product);
                    }
                }
            }
            else
            {
                DisplayCustomProductsThumsByPriceFilter(Convert.ToInt32(ctrlProductsFilter_v.txtMinValue.Text),
                    Convert.ToInt32(ctrlProductsFilter_v.txtMaxValue.Text));
            }

            


            ShowNoProductsHeader();

        }

        public void DisplayCustomProductsThums(DataTable Products)
        {
            FpnlProductsLoader.Controls.Clear();

            for (int j = 0; j < Products.Rows.Count; j++)
            {
                int ProductID = Convert.ToInt16(Products.Rows[j]["ProductID"]);


                for (int i = 0; i < clsGlobal.ctrlProductThumbNailsList.Count; i++)
                {
                    ctrlProductThumbNail ctrlProductInList = clsGlobal.ctrlProductThumbNailsList[i];


                    if (ctrlProductInList.CurrentProduct.ProductID == ProductID)
                    {
                        FpnlProductsLoader.Controls.Add(ctrlProductInList);
                    }



                }
            }







            if (FpnlProductsLoader.Controls.Count == 0)
            {
                lblEmptyProducts.Visible = true;
            }
            else
            {
                lblEmptyProducts.Visible = false;

            }
        }

        public void DisplayCustomProductsThums(List<int> ProductsIDs)
        {
            FpnlProductsLoader.Controls.Clear();

            for (int j = 0; j < ProductsIDs.Count; j++)
            {
                int ProductID = Convert.ToInt16(ProductsIDs[j]);


                for (int i = 0; i < clsGlobal.ctrlProductThumbNailsList.Count; i++)
                {
                    ctrlProductThumbNail ctrlProductInList = clsGlobal.ctrlProductThumbNailsList[i];


                    if (ctrlProductInList.CurrentProduct.ProductID == ProductID)
                    {
                        FpnlProductsLoader.Controls.Add(ctrlProductInList);
                    }



                }
            }







            if (FpnlProductsLoader.Controls.Count == 0)
            {
                lblEmptyProducts.Visible = true;
            }
            else
            {
                lblEmptyProducts.Visible = false;

            }
        }

        public void DisplayCustomProductsThumsByReviewsFilter(int ReviewAvrgVal)
        {

            /*
            FpnlProductsLoader.Controls.Clear();
            CurrentReviewAvrgVal = ReviewAvrgVal;

            //if (ReviewAvrgVal == -1)
            //{
            //    if (CurrentCatagory != null)                
            //        DisplayCustomProductsThums((int)CurrentCatagory);             
            //    else
            //        DisplayAllProductsThums();

            //    return;
            //}


            for (int i = 0; i < clsGlobal.ctrlProductThumbNailsList.Count; i++)
            {
                ctrlProductThumbNail ctrlProductInList = clsGlobal.ctrlProductThumbNailsList[i];

                if (CurrentCatagory != null &&
                    ctrlProductInList.CurrentProduct.CategoryID != CurrentCatagory)
                {
                    continue;
                }

                if (ReviewAvrgVal == -1)
                {
                    if (PriceMinVal != null && PriceMaxVal != null)
                    {
                        if (ctrlProductInList.CurrentProduct.Price >= PriceMinVal &&
                                ctrlProductInList.CurrentProduct.Price <= PriceMaxVal)
                        {
                            FpnlProductsLoader.Controls.Add(ctrlProductInList);
                        }
                    }
                    else
                    {
                        FpnlProductsLoader.Controls.Add(ctrlProductInList);
                    }
                }
                else if (ReviewAvrgVal == 3)
                {
                    if (ctrlProductInList.CurrentProduct.AvrgReviews <= ReviewAvrgVal)
                    {

                        if (PriceMinVal != null && PriceMaxVal != null)
                        {
                            if (ctrlProductInList.CurrentProduct.Price >= PriceMinVal &&
                                    ctrlProductInList.CurrentProduct.Price <= PriceMaxVal)
                            {
                                FpnlProductsLoader.Controls.Add(ctrlProductInList);
                            }
                        }
                        else
                        {
                            FpnlProductsLoader.Controls.Add(ctrlProductInList);
                        }

                    }
                }
                else
                {
                    if (ctrlProductInList.CurrentProduct.AvrgReviews == ReviewAvrgVal)
                    {
                        if (PriceMinVal != null && PriceMaxVal != null)
                        {
                            if (ctrlProductInList.CurrentProduct.Price >= PriceMinVal &&
                                    ctrlProductInList.CurrentProduct.Price <= PriceMaxVal)
                            {
                                FpnlProductsLoader.Controls.Add(ctrlProductInList);
                            }
                        }
                        else
                        {
                            FpnlProductsLoader.Controls.Add(ctrlProductInList);
                        }
                    }
                }



            }

            ShowNoProductsHeader();
            */

            CurrentReviewAvrgVal = ReviewAvrgVal;



            DisplayCustomProductsThums(
                clsProductFilter.GetAllProductsByFilter(
                    Convert.ToInt32(ctrlProductsFilter_v.txtMinValue.Text == "" ? null : ctrlProductsFilter_v.txtMinValue.Text),
                    Convert.ToInt32(ctrlProductsFilter_v.txtMaxValue.Text == "" ? null : ctrlProductsFilter_v.txtMaxValue.Text),
                    CurrentCatagory, this.SearchInput, ReviewAvrgVal));

        }

        public void DisplayCustomProductsThumsByPriceFilter(int Min, int Max)
        {
            /*
           FpnlProductsLoader.Controls.Clear();
           PriceMinVal = Min; PriceMaxVal = Max;

           for (int i = 0; i < clsGlobal.ctrlProductThumbNailsList.Count; i++)
           {
               ctrlProductThumbNail ctrlProductInList = clsGlobal.ctrlProductThumbNailsList[i];

               if (CurrentCatagory != null &&
                   ctrlProductInList.CurrentProduct.CategoryID != CurrentCatagory)
               {
                   continue;
               }

               if (CurrentReviewAvrgVal == -1)
               {
                   if (ctrlProductInList.CurrentProduct.Price >= Min &&
                                   ctrlProductInList.CurrentProduct.Price <= Max)
                   {
                       FpnlProductsLoader.Controls.Add(ctrlProductInList);
                   }
               }
               else if (CurrentReviewAvrgVal == 3)
               {
                   if (ctrlProductInList.CurrentProduct.AvrgReviews <= CurrentReviewAvrgVal &&
                       ctrlProductInList.CurrentProduct.Price >= Min &&
                                   ctrlProductInList.CurrentProduct.Price <= Max)
                   {
                       FpnlProductsLoader.Controls.Add(ctrlProductInList);
                   }
               }
               else
               {
                   if (ctrlProductInList.CurrentProduct.AvrgReviews == CurrentReviewAvrgVal &&
                       ctrlProductInList.CurrentProduct.Price >= Min &&
                                   ctrlProductInList.CurrentProduct.Price <= Max)
                   {
                       FpnlProductsLoader.Controls.Add(ctrlProductInList);
                   }
               }


           }


           ShowNoProductsHeader();
            */

            //clsProductFilter.ResetListProductsToFull();
            //clsProductFilter.AlterTableForProductReviewsByPriceFilter(Min, Max);
            //DisplayCustomProductsThums(clsProductFilter.listCurrentDisplayedProductsIDs);





            DisplayCustomProductsThums(
                clsProductFilter.GetAllProductsByFilter(Min, Max, CurrentCatagory, this.SearchInput, CurrentReviewAvrgVal));

        }

        public void DisplayCustomProductsThumsBySearchFilter(string SearchInput)
        {
            /*
           FpnlProductsLoader.Controls.Clear();
           PriceMinVal = Min; PriceMaxVal = Max;

           for (int i = 0; i < clsGlobal.ctrlProductThumbNailsList.Count; i++)
           {
               ctrlProductThumbNail ctrlProductInList = clsGlobal.ctrlProductThumbNailsList[i];

               if (CurrentCatagory != null &&
                   ctrlProductInList.CurrentProduct.CategoryID != CurrentCatagory)
               {
                   continue;
               }

               if (CurrentReviewAvrgVal == -1)
               {
                   if (ctrlProductInList.CurrentProduct.Price >= Min &&
                                   ctrlProductInList.CurrentProduct.Price <= Max)
                   {
                       FpnlProductsLoader.Controls.Add(ctrlProductInList);
                   }
               }
               else if (CurrentReviewAvrgVal == 3)
               {
                   if (ctrlProductInList.CurrentProduct.AvrgReviews <= CurrentReviewAvrgVal &&
                       ctrlProductInList.CurrentProduct.Price >= Min &&
                                   ctrlProductInList.CurrentProduct.Price <= Max)
                   {
                       FpnlProductsLoader.Controls.Add(ctrlProductInList);
                   }
               }
               else
               {
                   if (ctrlProductInList.CurrentProduct.AvrgReviews == CurrentReviewAvrgVal &&
                       ctrlProductInList.CurrentProduct.Price >= Min &&
                                   ctrlProductInList.CurrentProduct.Price <= Max)
                   {
                       FpnlProductsLoader.Controls.Add(ctrlProductInList);
                   }
               }


           }


           ShowNoProductsHeader();
            */

            //clsProductFilter.ResetListProductsToFull();
            //clsProductFilter.AlterTableForProductReviewsByPriceFilter(Min, Max);
            //DisplayCustomProductsThums(clsProductFilter.listCurrentDisplayedProductsIDs);




            this.SearchInput = SearchInput;
            DisplayCustomProductsThums(
                clsProductFilter.GetAllProductsByFilter(
                    Convert.ToInt32(ctrlProductsFilter_v.txtMinValue.Text == "" ? null : ctrlProductsFilter_v.txtMinValue.Text),
                    Convert.ToInt32(ctrlProductsFilter_v.txtMaxValue.Text == "" ? null : ctrlProductsFilter_v.txtMaxValue.Text),
                    CurrentCatagory, SearchInput, CurrentReviewAvrgVal));

        }


        public void DisplayAllProductsThums()
        {
            //resetting the products IDs container 
            //clsProductFilter.listCurrentDisplayedProductsIDs.Clear();
            //clsProductFilter.listAllProducts.Clear();

            FpnlProductsLoader.Controls.Clear();
            for (int i = 0; i < clsGlobal.ctrlProductThumbNailsList.Count; i++)
            {
                ctrlProductThumbNail Product = clsGlobal.ctrlProductThumbNailsList[i];
                FpnlProductsLoader.Controls.Add(Product);

                //clsProductFilter.listCurrentDisplayedProductsIDs.Add(Product.CurrentProduct.ProductID);
                //clsProductFilter.listAllProducts.Add(Product.CurrentProduct.ProductID);

            }

            ShowNoProductsHeader();

        }

        void ShowFilterForm()
        {
            ctrlProductsFilter_v.OnReviewFilterClick += DisplayCustomProductsThumsByReviewsFilter;
            ctrlProductsFilter_v.OnPriceFilterClick += DisplayCustomProductsThumsByPriceFilter;
            FpnlFilter.Controls.Add(ctrlProductsFilter_v);
        }

        









        public void ProductClick(object sender, clsProduct Product)
        {
            frmProductDetails frmProductDetails_v = new frmProductDetails(Product);
            clsGlobal.ShowFormInPanel(clsGlobal.MainScreenFormObj.pnlMainScreenFormsLoader, frmProductDetails_v);
        }

        public void FavouritClick(object sender, bool IsFav, clsProduct Product)
        {
            if (clsGlobal.CurrentUser == null)
                return;

            if (IsFav)
            {
                Product.AddToFavourit(clsGlobal.CurrentUser.UserID);
            }
            else
            {
                Product.RemoveFromFavourit(clsGlobal.CurrentUser.UserID);
            }

            //clsGlobal.PerfomTwoStatesButtonStyle(
            //    clsGlobal.ctrlProductThumbNailsList[clsGlobal.GetProductIndexInList(Product)].btnHeart,
            //    Resources.icons8_heart_48__1_, Resources.icons8_heart_50);
            
        }

        public void AddToCartClick(object sender, bool IsAddToCart, clsProduct Product)
        {
            if (clsGlobal.CurrentUser == null)
                return;

            if (IsAddToCart)
            {
                Product.AddToCart(clsGlobal.CurrentUser.UserID);
            }
            else
            {
                Product.RemoveFromCart(clsGlobal.CurrentUser.UserID);
            }

            //clsGlobal.ctrlProductThumbNailsList[clsGlobal.GetProductIndexInList(Product)].PerformAddToCartClick();
        }

        private void frmProductsList_Load(object sender, EventArgs e)
        {
            ShowFilterForm();
            //DisplayProductThumbNailsFrstTime(clsProduct.GetAllProducts());
        }

        
    }
}
