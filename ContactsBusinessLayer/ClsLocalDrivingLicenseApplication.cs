using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClsLocalDrivingLicenseApplication
    {
        public  int LDLAppID {  get; set; }
        public  string DrivingClass { get; set; }
        public  string NationalNo { get; set; }
        public  string FullName { get; set; } 
        public  DateTime ApplicationDate { get; set; }
        public  int PassedTests { get; set; } 
        public  string Status { get; set;}

        private enum enMode { AddNewLocalDrivingLicenseApplication  = 0 , UpdateLocalDrivingLicenseApplication =1 }; 
        enMode Mode = enMode.AddNewLocalDrivingLicenseApplication;

        public ClsLocalDrivingLicenseApplication()
        {
            this.LDLAppID = -1;
            this.DrivingClass = "";
            this.NationalNo = "";
            this.FullName = "";
            this.ApplicationDate = new DateTime(); 
            this.PassedTests = 0;
            this.Status = "";
            Mode = enMode.AddNewLocalDrivingLicenseApplication; 
        }

        private ClsLocalDrivingLicenseApplication(int LDLAppID ,string DrivingClass , string NationalNo ,string FullName , DateTime ApplicationDate ,int PassedTests ,string Status)
        {
            this.LDLAppID= LDLAppID;
            this.DrivingClass = DrivingClass;
            this.NationalNo = NationalNo;
            this.FullName = FullName;
            this.ApplicationDate = ApplicationDate;
            this.PassedTests = PassedTests;
            this.Status = Status;

            Mode = enMode.UpdateLocalDrivingLicenseApplication; 
        }

        public  bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNewLocalDrivingLicenseApplication:
                    if (Add())
                    {
                        Mode  = enMode.UpdateLocalDrivingLicenseApplication;
                       return true;
                    } else { return false; }

                case enMode.UpdateLocalDrivingLicenseApplication:
                    return Update();
                       
            }return false; 
        }

        public static ClsLocalDrivingLicenseApplication Find (int LDLAppID)
        {
            string DrivingClass = "", NationalNo = "", FullName = "", Status = ""; 
            DateTime ApplicationDate = new DateTime();
            int PassedTests = 0; 
            if (ClsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationDataByID( LDLAppID , ref DrivingClass , ref NationalNo ,ref FullName ,ref ApplicationDate ,ref PassedTests ,ref Status ))
            {
                return new ClsLocalDrivingLicenseApplication(LDLAppID, DrivingClass, NationalNo, FullName, ApplicationDate, PassedTests, Status); 
            }
            else
            {
                return null;
            }
        }
        public  bool Add()
        {
            this.LDLAppID = ClsLocalDrivingLicenseApplicationData.AddLocalDrivingLicenseApplicationData(this.DrivingClass, this.NationalNo, this.FullName, this.ApplicationDate, this.PassedTests, this.Status);

            return (this.LDLAppID != -1);
          
        }
        public static bool Delete(int LDLAppID)
        {
            return ClsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplicationData(LDLAppID);
        }

        public  bool Update()
        {
            return ClsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplicationData(this.LDLAppID,this.DrivingClass,this.NationalNo,this.FullName,this.ApplicationDate,this.PassedTests,this.Status);
        }

        public static int Count()
        {
            return ClsLocalDrivingLicenseApplicationData.CountLocalDrivingLicenseApplicationData();
        }

        public static DataTable GetALLData ()
        {
            return ClsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplicationData(); 
        }
    }
}
