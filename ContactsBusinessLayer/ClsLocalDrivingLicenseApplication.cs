using DataAccsessLayer;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClsLocalDrivingLicenseApplication : ClsApplication
    {
        public  int LDLAppID {  get; set; }
        public int LicenseClassID { get; set; }
        public string DrivingClass { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
        public int PassedTests { get; set; }


        public ClsLocalDrivingLicenseApplication()
        {
            this.LDLAppID = -1;
            this.LicenseClassID = -1; 
            
            Mode = enMode.AddNew; 
        }

        private ClsLocalDrivingLicenseApplication(int LDLAppID , int ApplicationID , int LicenseClassID , string DrivingClass, string NationalNo, string FullName,DateTime ApplicationDate, int PassedTests, string Status)
        {
            this.LDLAppID= LDLAppID;
            this.LicenseClassID= LicenseClassID;
            this.ApplicationID = ApplicationID;
            this.DrivingClass = DrivingClass;
            this.NationalNo = NationalNo;
            this.FullName = FullName;
            this.ApplicationDate = ApplicationDate;
            this.PassedTests = PassedTests;
            this.Status = Status;
            Mode = enMode.Update;
        }
        

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LDLAppID = ClsLocalDrivingLicenseApplicationData.AddLocalDrivingLicenseApplicationData(
                this.ApplicationID, this.LicenseClassID);

            return (this.LDLAppID != -1);
        }

        public override bool Save()
        {
            enMode currentMode = base.Mode;
            
            if (!base.Save()) return false;

            switch (currentMode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        base.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return true;
            }
            return false;
        }

        public static DataTable GetALLData()
        {
            return ClsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplicationData();
        }
        public static int FindByLocalDrivingAppID(int LDLAppID)
        {
            return ClsLocalDrivingLicenseApplicationData.GetApplicationIDByLocalDrivingAppID(LDLAppID);
        }
        public static bool IsApplicationExist(int PersonID, int LicenseClassID)
        {
            return ClsLocalDrivingLicenseApplicationData.IsApplicationExist(PersonID, LicenseClassID);
        }
        
        public static ClsLocalDrivingLicenseApplication Find (int LDLAppID)
        {
            int PassedTests = 0 , ApplicationID = -1 , LicenseClassID = -1 ;
            string DrivingClass = "", NationalNo = "", FullName = "", Status = "";
            DateTime ApplicationDate = DateTime.Now;

            bool isFoundData = ClsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationDataByID(LDLAppID, ref DrivingClass, ref NationalNo, ref FullName, ref ApplicationDate, ref PassedTests, ref Status); 

            if (isFoundData )
            {
                ApplicationID = ClsLocalDrivingLicenseApplicationData.GetApplicationIDByLocalDrivingAppID (LDLAppID);
                
                return new ClsLocalDrivingLicenseApplication(LDLAppID, ApplicationID ,LicenseClassID , DrivingClass, NationalNo, FullName, ApplicationDate, PassedTests, Status );
            }
            else
            {
                return null; 
            }
           
        }

        public static bool CancelByLocalDrivingLicenseAppID(int LDLAppID)
        {
            int ApplicationID = ClsLocalDrivingLicenseApplication.FindByLocalDrivingAppID(LDLAppID);
            if (ApplicationID != -1)
            {
                return ClsApplication.CancelApplication(ApplicationID,ClsApplication.enApplicationStatus.Cancelled);
            }

            return false; 
        }

        public static int CountLocalDrivingLicenseApplication()
        {
            return ClsLocalDrivingLicenseApplicationData.CountLocalDrivingLicenseApplicationData();
        }

        public  byte TotalTrialsPerTest (int TestTypeID)
        {
            return ClsLocalDrivingLicenseApplicationData.TotalTrialPerTest(this.LDLAppID,TestTypeID); 
        }
        public static int GetPassedNumber(int LDLAPPID)
        {
            return ClsLocalDrivingLicenseApplicationData.GetPassedTestNumbers(LDLAPPID);    
        }
    }
}
