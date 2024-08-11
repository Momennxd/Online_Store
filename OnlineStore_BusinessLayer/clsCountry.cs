using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsCountry
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int ID { get; set; }

        public string CountryName { get; set; }

        public clsCountry()
        {
            ID = -1;
            CountryName = "";           
            mode = Mode.eAddNew;
        }

        private clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;         
            mode = Mode.eUpdate;
        }

        bool _AddNewCountry()
        {
            return (clsCountriesDataAccess.AddNewCountry(this.CountryName) > -1);
        }

        bool _UpdateCountry()
        {
            return (clsCountriesDataAccess.UpdateCountryInfo(this.ID, this.CountryName));
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";


            if (clsCountriesDataAccess.GetCountryInfoByID(CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
                return null;
        }

        public static clsCountry Find(string CountyName)
        {
            int ID = -1;


            if (clsCountriesDataAccess.GetCountryInfoByName(ref ID, CountyName))
            {
                return new clsCountry(ID, CountyName);
            }
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            DataTable DT = clsCountriesDataAccess.GetAllCountries();
            return DT;
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewCountry())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateCountry();

            }

            return false;
        }


    }
}
