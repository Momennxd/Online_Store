using MaterialSkin.Controls;
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
    public partial class ctrlProductsFilter : UserControl
    {
        public ctrlProductsFilter()
        {
            InitializeComponent();
        }


        public event Action <int> OnReviewFilterClick;
        protected virtual void ReviewFilter_Click(int ReviewFilterValue)
        {
            Action<int> handler = OnReviewFilterClick;
            if (handler != null)
            {
                handler(ReviewFilterValue); // Raise the event with the parameter
            }
        }


        public event Action<int, int> OnPriceFilterClick;
        protected virtual void PriceFilter_Click(int Min, int Max)
        {
            Action<int, int> handler = OnPriceFilterClick;
            if (handler != null)
            {
                handler(Min, Max); // Raise the event with the parameter
            }
        }

        public void RestPriceFilterText()
        {
            txtMinValue.Text= string.Empty;
            txtMaxValue.Text = string.Empty;

        }



















        private void rbReviewFilterVal_CheckedChanged(object sender, EventArgs e)
        {
            switch (((MaterialRadioButton)sender).Name)
            {
                case "rb3StarsOrLess":
                    {
                        OnReviewFilterClick?.Invoke(3);
                        break;
                    }
                case "rb4Stars":
                    {
                        OnReviewFilterClick?.Invoke(4);
                        break;
                    }
                case "btn5Stars":
                    {
                        OnReviewFilterClick?.Invoke(5);
                        break;
                    }
                case "rbAll":
                    {
                        OnReviewFilterClick?.Invoke(-1);
                        break;
                    }
            }
        }

        private void btnConfirmSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaxValue.Text) || string.IsNullOrEmpty(txtMinValue.Text))
            {
                return;
            }

            OnPriceFilterClick?.Invoke(Convert.ToInt32(txtMinValue.Text),
                Convert.ToInt32(txtMaxValue.Text));
        }
    }
}
