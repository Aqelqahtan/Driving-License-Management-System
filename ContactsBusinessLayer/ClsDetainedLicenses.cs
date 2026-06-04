using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClsDetainedLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        // The 9 properties matching the database table columns
        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }
        public float FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public int ReleaseApplicationID { set; get; }

        // Default constructor (Used when adding a new detain record)
        public ClsDetainedLicenses()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MaxValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            Mode = enMode.AddNew;
        }

        // Private constructor (Used internally when fetching an existing detain record)
        private ClsDetainedLicenses(int DetainID, int LicenseID, DateTime DetainDate,
            float FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate,
            int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            Mode = enMode.Update;
        }

        // --- Data Access Layer Communication Methods ---

        private bool _AddNewDetainedLicense()
        {
            // Call the Add method and pass the required 4 parameters
            this.DetainID = ClsDetainedLicensesData.AddNewDetainedLicense(this.LicenseID,
                this.DetainDate, this.FineFees, this.CreatedByUserID);

            return (this.DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            // Call the Update method (Typically used for releasing)
            return ClsDetainedLicensesData.UpdateDetainedLicense(this.DetainID,
                this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        // --- Public Methods (Used in the Presentation Layer) ---

        public static ClsDetainedLicenses FindByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (ClsDetainedLicensesData.GetDetainedLicenseInfoByLicenseID(LicenseID, ref DetainID, ref DetainDate,
                ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                // If found, return the object filled with data and set mode to Update
                return new ClsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                                              IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        Mode = enMode.Update; // Switch mode to Update after successful save
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDetainedLicense();
            }
            return false;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return ClsDetainedLicensesData.IsLicenseDetained(LicenseID);
        }

        // Helper method to release the license directly
        public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
            return ClsDetainedLicensesData.UpdateDetainedLicense(this.DetainID, true, DateTime.Now,
                ReleasedByUserID, ReleaseApplicationID);
        }

        public static DataTable getAllOfDetainedLisences()
        {
             return ClsDetainedLicensesData.GetAllDetainedLicenses();
        }
    }
}
