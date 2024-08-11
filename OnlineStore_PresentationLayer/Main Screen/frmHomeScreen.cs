using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer.Main_Screen
{
    public partial class frmHomeScreen : Form
    {
        public frmHomeScreen()
        {
            InitializeComponent();
        }

        public event Action<object> OnFrmCategoryClick;
        protected virtual void CategoryClick_Click()
        {
            Action<object> handler = OnFrmCategoryClick;
            if (handler != null)
            {
                handler(this); // Raise the event with the parameter
            }
        }


        void ShowMainScreenHeader()
        {
            ctrlMainScreenHeader MainScreenHeader = new ctrlMainScreenHeader();
            //here you add the events
            MainScreenHeader.OnCategoryClick += this.OnFrmCategoryClick;
            FpnlMainScreenLoader.Controls.Add(MainScreenHeader);
        }

        public void ShowTopProductsSection()
        {
            ctrlTopProducts ctrlTopProducts = new ctrlTopProducts();
            //here you add the events
            ctrlTopProducts.DisplayCustomProductsThums(clsProduct.GetTop10RatedProducts());
            FpnlMainScreenLoader.Controls.Add(ctrlTopProducts);

        }















        private void frmHomeScreen_Load(object sender, EventArgs e)
        {
            ShowMainScreenHeader();
        }
    }
}
