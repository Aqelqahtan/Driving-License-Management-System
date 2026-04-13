using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

        public class ClsApplication
        {
            public enum enMode { AddNew = 0, Update = 1 };
            public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

            public enMode Mode = enMode.AddNew;

            public int ApplicationID { get; set; }
            public int ApplicantPersonID { get; set; }
            public DateTime ApplicationDate { get; set; }
            public int ApplicationTypeID { get; set; }
            public enApplicationStatus ApplicationStatus { get; set; }
            public DateTime LastStatusDate { get; set; }
            public decimal PaidFees { get; set; }
            public int CreatedByUserID { get; set; }

            public ClsApplication()
            {
                this.ApplicationID = -1;
                this.ApplicantPersonID = -1;
                this.ApplicationDate = DateTime.Now;
                this.ApplicationTypeID = -1;
                this.ApplicationStatus = enApplicationStatus.New;
                this.LastStatusDate = DateTime.Now;
                this.PaidFees = 0;
                this.CreatedByUserID = -1;
                Mode = enMode.AddNew;
            }

            protected ClsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
            {
                this.ApplicationID = ApplicationID;
                this.ApplicantPersonID = ApplicantPersonID;
                this.ApplicationDate = ApplicationDate;
                this.ApplicationTypeID = ApplicationTypeID;
                this.ApplicationStatus = ApplicationStatus;
                this.LastStatusDate = LastStatusDate;
                this.PaidFees = PaidFees;
                this.CreatedByUserID = CreatedByUserID;
                Mode = enMode.Update;
            }

            public static ClsApplication FindBaseApplication(int ApplicationID)
            {
                int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
                DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
                decimal PaidFees = 0;
                byte ApplicationStatus = 1;

                if (ClsApplicationsData.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
                {
                    return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, (enApplicationStatus)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
                }
                else
                {
                    return null;
                }
            }

            private bool _AddNewApplication()
            {
                this.ApplicationID = ClsApplicationsData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
                return (this.ApplicationID != -1);
            }

            private bool _UpdateApplication()
            {
                return ClsApplicationsData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            }

            public virtual bool Save()
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewApplication())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case enMode.Update:
                        return _UpdateApplication();
                }
                return false;
            }

            public static bool CancelApplication(int ApplicationID, enApplicationStatus NewStatus )
            {
            return (ClsLocalDrivingLicenseApplicationData.UpdateStatus(ApplicationID,(short)NewStatus));
            }

        }

}
