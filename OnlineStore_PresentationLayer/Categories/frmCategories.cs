using DVLD_PresentationLayer;
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

namespace OnlineStore_PresentationLayer.Categories
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        public event Action<object, clsCategory> OnCategoryClick;
        protected virtual void Category_Click(clsCategory category)
        {
            Action<object, clsCategory> handler = OnCategoryClick;
            if (handler != null)
            {
                handler(this, category); // Raise the event with the parameter
            }
        }


        void ShowCategoryOnPanel(clsCategory Category)
        {
            ctrlCategory ctrlCategoryThumbNail = new ctrlCategory();

            //Here you should add the events
            ctrlCategoryThumbNail.OnCategoryClick += Category_Click;

            //adding to the Products panel
            ctrlCategoryThumbNail.DisplayCatagory(Category);
            FpnlCategories.Controls.Add(ctrlCategoryThumbNail);
        }

        void DisplayCategoriesThumbNails(DataTable Ctageries)
        {
            FpnlCategories.Controls.Clear();
            foreach (DataRow Row in Ctageries.Rows) 
            {
                ShowCategoryOnPanel(clsCategory.Find(Convert.ToInt16(Row["CategoryID"])));
            }
            
        }


        private void Category_Click(object sender, clsCategory category)
        {
            OnCategoryClick?.Invoke(this, category);
        }



        private void frmCategories_Load(object sender, EventArgs e)
        {
            DisplayCategoriesThumbNails(clsCategory.GetAllCategories());

        }
    }
}
