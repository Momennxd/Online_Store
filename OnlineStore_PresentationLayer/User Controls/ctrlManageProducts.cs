using DVLD_PresentationLayer;
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
    public partial class ctrlManageProducts : UserControl
    {
        public ctrlManageProducts()
        {
            InitializeComponent();
            RoundControls();
        }


        public event Action<object> OnAddProductClick;
        protected virtual void AddProduct_Click()
        {
            Action<object> handler = OnAddProductClick;
            if (handler != null)
            {
                handler(this); // Raise the event with the parameter
            }
        }

        void RoundControls()
        {
            Control[] C = { btnAddProduct};

            clsGlobal.RoundControlsByCustomElips(bunifuElipse1, C);
        }













        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OnAddProductClick?.Invoke(this);
        }


    }
}
