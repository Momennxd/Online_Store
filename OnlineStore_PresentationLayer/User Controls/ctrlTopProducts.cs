using DVLD_PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer.User_Controls
{
    public partial class ctrlTopProducts : UserControl
    {
        public ctrlTopProducts()
        {
            InitializeComponent();
        }

       public  void DisplayCustomProductsThums(DataTable Products)
        {
            FpnlHotProductsLoader.Controls.Clear();

            for (int j = 0; j < Products.Rows.Count; j++)
            {
                int ProductID = Convert.ToInt16(Products.Rows[j]["ProductID"]);


                for (int i = 0; i < clsGlobal.ctrlProductThumbNailsList.Count; i++)
                {
                    ctrlProductThumbNail ctrlProductInList = clsGlobal.ctrlProductThumbNailsList[i];


                    if (ctrlProductInList.CurrentProduct.ProductID == ProductID)
                    {
                        FpnlHotProductsLoader.Controls.Add(ctrlProductInList);
                    }

                }
            }

        }














    }
}
