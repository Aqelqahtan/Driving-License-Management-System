using BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using PresentationLayer.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class IssueDriverLicenseForTheFirstTimeFrm : Form
    {
        private int _ApplicationID;
        private ClsTests _Tests;
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private ClsApplication _Application;
        private ClsApplicationTypes _ApplicationTypes;
        private ClsUsers _User;
        public IssueDriverLicenseForTheFirstTimeFrm(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
            _LoadDrivingLicenseApplicationInfo();
            if (_LocalDrivingLicenseApplication != null)
            {
               
                _LoadApplicationBasicInfo();

            }
        }
        private void _LoadDrivingLicenseApplicationInfo()
        {
            _LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(_ApplicationID);
            if (_LocalDrivingLicenseApplication != null)
            {
                DLAPPIDResultLbl.Text = _LocalDrivingLicenseApplication.LDLAppID.ToString();
                AppliedForLicenseResult.Text = _LocalDrivingLicenseApplication.DrivingClass.ToString();
                PassedTestsResult.Text = _LocalDrivingLicenseApplication.PassedTests.ToString() + "/3";
            }
        }

        private void _LoadApplicationBasicInfo()
        {
            _Application = ClsApplication.FindBaseApplication(_LocalDrivingLicenseApplication.ApplicationID);
            if (_Application == null)
            {
                Console.WriteLine("There is no data !");
                this.Close();
                return;
            }

            IDResultLbl.Text = _Application.ApplicationID.ToString();
            StatusResultLbl.Text = _Application.ApplicationStatus.ToString();
            FeesResultLbl.Text = _Application.PaidFees.ToString();
            _ApplicationTypes = ClsApplicationTypes.Find(_Application.ApplicationTypeID);
            if (_ApplicationTypes != null)
            {
                TypeResultLbl.Text = _ApplicationTypes.ApplicationTypeTitle.ToString();
            }
            _User = ClsUsers.Find(_Application.CreatedByUserID);
            if (_User != null)
            {
                CreatedByResultLbl.Text = _User.UserName;
            }

            StatusDateResultLbl.Text = _Application.LastStatusDate.ToShortDateString();
            DateResultLbl.Text = _Application.ApplicationDate.ToShortDateString();

            ApplicantResultLbl.Text = _LocalDrivingLicenseApplication.FullName.ToString();


        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewPersinInfoBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int BaseAppID = ClsLocalDrivingLicenseApplication.FindByLocalDrivingAppID(_ApplicationID);
            ClsApplication BaseApp = ClsApplication.FindBaseApplication(BaseAppID);
            if (BaseApp != null)
            {
                PersonDetailsFrm frm = new PersonDetailsFrm (BaseApp.ApplicantPersonID);
                frm.ShowDialog();
            }
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            ClsLocalDrivingLicenseApplication LocalApp = ClsLocalDrivingLicenseApplication.Find(_ApplicationID);
            if (LocalApp == null)
            {
                return;
            }
            ClsApplication BaseApp = ClsApplication.FindBaseApplication(LocalApp.ApplicationID);
            if (BaseApp == null)
            {
                return;
            }


            int CurrentDriverID = -1; 
            ClsDriver Driver = ClsDriver.FindByPersonID(BaseApp.ApplicantPersonID);
            if (Driver == null)
            {
                Driver = new ClsDriver();
                Driver.PersonID = BaseApp.ApplicantPersonID;
                if (ClsGlobal.CurrentUser != null)
                {
                    Driver.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                }else
                {
                    Driver.CreatedByUserID = 1;
                }
                    if(Driver.Save())
                {
                    CurrentDriverID = Driver.DriverID;
                    
                }
              
            }
            else
            {
                CurrentDriverID = Driver.DriverID;
            }

            ClsLicenseClass LicenseClassInfo = ClsLicenseClass.Find(LocalApp.LicenseClassID);
            if (LicenseClassInfo == null)
            {
                return;
            }

            ClsLicense NewLicense = new ClsLicense();
            NewLicense.ApplicationID = BaseApp.ApplicationID;
            NewLicense.DriverID = CurrentDriverID;
            NewLicense.LicenseClass = LocalApp.LicenseClassID; 
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(LicenseClassInfo.DefaultValidityLength);
            NewLicense.Notes = NoteTextBox.Text.Trim();
            NewLicense.PaidFees = (float)LicenseClassInfo.ClassFees;
            NewLicense.IsActive = true ;
            NewLicense.IssueReason = 1;
            if (ClsGlobal.CurrentUser != null)
            {
                NewLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            }
            else
            {
                NewLicense.CreatedByUserID = 1;
            }

            if (NewLicense.Save())
            {
                BaseApp.ApplicationStatus = ClsApplication.enApplicationStatus.Completed;
                BaseApp.Save();
                MessageBox.Show("License Luanched Succsessfully"); 
            }else

                MessageBox.Show("License Luanched Failed");



        }
    }
}
