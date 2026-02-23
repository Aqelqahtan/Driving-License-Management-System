using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks; 

namespace BusinessLayer
{
    public class ClsApplicationTypes
    {
        public  enum enMode { Add = 0 , Update = 1}; 
        public enMode Mode = enMode.Add;
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        public ClsApplicationTypes() {
            ApplicationTypeID = -1;
            ApplicationFees = 0;
            ApplicationTypeTitle = ""; 
            Mode = enMode.Add;

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewApplicationTypes())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                        

                    case enMode.Update:
                    return UpdateApplicationTypes();
            
            } return false;
        }
        private ClsApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees) 
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            Mode = enMode.Update;

        }
        public static ClsApplicationTypes Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = -1;
            if (ClsApplicationTypesData.GetApplicationTypeByApplicationTypeID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new ClsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else  return null; 
        }
        public static DataTable GetAllApplicationTypes ()
        {
            return ClsApplicationTypesData.GetAllApplicationTypes();
        }
        public  bool UpdateApplicationTypes()
        {
            return ClsApplicationTypesData.UpdateApplicationFees(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees); 
        }
        private bool _AddNewApplicationTypes()
        {

            this.ApplicationTypeID =  ClsApplicationTypesData.AddNewApplicationTypes(this.ApplicationTypeTitle, this.ApplicationFees);
            return (this.ApplicationTypeID != -1);
        }
        public static int GetApplicationNumbers()
        {
            return ClsApplicationTypesData.CountApplicationTypes(); 
        }
    }
}
