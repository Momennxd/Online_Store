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
    public class clsDeliveryType
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int DeliveryTypeID { get; set; }

        public string DeliveryTypeName { get; set; }

        public decimal DeliveryFee { get; set; }

        public clsDeliveryType()
        {
            DeliveryTypeID = -1;
            DeliveryTypeName = "";
            DeliveryFee = 0;

            mode = Mode.eAddNew;
        }


        private clsDeliveryType(int DeliveryTypeID,
            string DeliveryTypeName, decimal DeliveryFee)
        {
            this.DeliveryTypeID = DeliveryTypeID;
            this.DeliveryTypeName = DeliveryTypeName;
            this.DeliveryFee = DeliveryFee;
            mode = Mode.eUpdate;
        }

        bool _AddNewDeliveringType()
        {
            DeliveryTypeID = clsDeliveringTypesDataAccess.AddNewDeliveringType(
                this.DeliveryTypeName, this.DeliveryFee);
            return DeliveryTypeID != -1;
        }

        bool _UpdateDeliveringType()
        {
            return (clsDeliveringTypesDataAccess.UpdateCategoryInfo(this.DeliveryTypeID, this.DeliveryTypeName, this.DeliveryFee));
        }

        public static clsDeliveryType Find(int DeliveryTypeID)
        {
            string DeliveryTypeName = "";
            decimal DeliveryFee = 0;

            if (clsDeliveringTypesDataAccess.GetDeliveringTypeInfoByID(DeliveryTypeID, ref DeliveryTypeName, ref DeliveryFee))
            {
                return new clsDeliveryType(DeliveryTypeID, DeliveryTypeName, DeliveryFee);
            }
            else
                return null;
        }

        public static clsDeliveryType Find(string DeliveryTypeName)
        {
            int DeliveryTypeID = -1;
            decimal DeliveryFee = 0;

            if (clsDeliveringTypesDataAccess.GetDeliveringTypeInfoByName(ref DeliveryTypeID, DeliveryTypeName, ref DeliveryFee))
            {
                return new clsDeliveryType(DeliveryTypeID, DeliveryTypeName, DeliveryFee);
            }
            else
                return null;
        }

        public static DataTable GetAllDeliveringTypes()
        {
            DataTable DT = clsDeliveringTypesDataAccess.GetAllDeliveringTypes();
            return DT;
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewDeliveringType())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateDeliveringType();

            }

            return false;
        }









    }
}
