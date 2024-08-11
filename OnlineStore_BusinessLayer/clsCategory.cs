using DVLD_BusinessLayer;
using DVLD_DataAccessLayer;
using OnlineStore_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_BusinessLayer
{
    public class clsCategory
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public clsCategory()
        {
            CategoryID = -1;
            CategoryName = "";
            mode = Mode.eAddNew;
        }

        private clsCategory(int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            mode = Mode.eUpdate;
        }

        bool _AddNewCategory()
        {
            return (clsCategoriesDataAccess.AddNewCategory(this.CategoryName) > -1);
        }

        bool _UpdateCategory()
        {
            return (clsCategoriesDataAccess.UpdateCategoryInfo(this.CategoryID, this.CategoryName));
        }

        public static clsCategory Find(int CategoryID)
        {
            string CategoryName = "";


            if (clsCategoriesDataAccess.GetCategoryInfoByID(CategoryID, ref CategoryName))
            {
                return new clsCategory(CategoryID, CategoryName);
            }
            else
                return null;
        }

        public static clsCategory Find(string CategoryName)
        {
            int CategoryID = -1;


            if (clsCategoriesDataAccess.GetCategoryInfoByName(ref CategoryID, CategoryName))
            {
                return new clsCategory(CategoryID, CategoryName);
            }
            else
                return null;
        }

        public static DataTable GetAllCategories()
        {
            DataTable DT = clsCategoriesDataAccess.GetAllCategories();
            return DT;
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewCategory())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateCategory();

            }

            return false;
        }



    }
}
