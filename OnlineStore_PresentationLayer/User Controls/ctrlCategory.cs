using OnlineStore_BusinessLayer;
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
    public partial class ctrlCategory : UserControl
    {
        public ctrlCategory()
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


        private clsCategory _Category = new clsCategory();

        public clsCategory Category { get { return _Category; } }

        public void DisplayCatagory(int CatagoryID)
        {
            _Category = clsCategory.Find(CatagoryID);

            btnCategoryName.Text = _Category.CategoryName;
        }

        public void DisplayCatagory(clsCategory Catagory)
        {
            _Category = Catagory;

            btnCategoryName.Text = _Category.CategoryName;
        }

        private void btnCategoryName_Click(object sender, EventArgs e)
        {
            OnCategoryClick?.Invoke(this, Category);
        }
    }
}
