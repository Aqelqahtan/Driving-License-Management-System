using BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
                AddUpdatePersonFrm frm = new AddUpdatePersonFrm(BaseApp.ApplicantPersonID);
                frm.ShowDialog();
            }
        }
    }
}
