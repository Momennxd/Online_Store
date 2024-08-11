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
    public partial class ctrlMainScreenHeader : UserControl
    {
        public ctrlMainScreenHeader()
        {
            InitializeComponent();
        }

        public event Action<object> OnCategoryClick;
        protected virtual void CategoryClick_Click()
        {
            Action<object> handler = OnCategoryClick;
            if (handler != null)
            {
                handler(this); // Raise the event with the parameter
            }
        }


        private void btnCategories_Click(object sender, EventArgs e)
        {
            OnCategoryClick?.Invoke(this);
        }
    }
}
