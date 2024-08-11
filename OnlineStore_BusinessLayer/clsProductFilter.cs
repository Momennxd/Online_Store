using OnlineStore_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_BusinessLayer
{
    public static class clsProductFilter
    {

        public static DataTable GetAllProductsByFilter(int Min, int Max, int? CategoryID,
            string SearchFilter, int AvrgRating)
        {
            return clsProductsFilterDataAccess.GetAllProductsByFilter(Min , Max, CategoryID,
                SearchFilter, AvrgRating);
        }

    }
}
