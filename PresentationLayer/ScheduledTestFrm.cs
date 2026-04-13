using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ScheduledTestFrm : Form
    {
        private int _LDLAPPID;
        private int _TestAppointmentID;
        private int _TestTypeID; 
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private ClsTestAppointment _TestAppointment;
        private ClsTests _Tests;
        private ClsUsers _User; 
        public ScheduledTestFrm(int LDLAPPID,int TestTypeID ,int TestAppointmentID)
        {
            InitializeComponent();
            _LDLAPPID = LDLAPPID;
            _TestTypeID = TestTypeID;
            _TestAppointmentID = TestAppointmentID;
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestTypeID)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Vision_512;
                    LocalDrivingLicenseApplicationsLbl.Text = "Vision Test";
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Written_Test_512;
                    LocalDrivingLicenseApplicationsLbl.Text = "Written Test";
                    break;

                case 3: 
                    pictureBox1.Image = Properties.Resources.driving_test_512;
                    LocalDrivingLicenseApplicationsLbl.Text = "Practical Test";
                    break;
            }
        }
        private void _LoadData()
        {
            _LoadTestTypeImageAndTitle();
            _LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(_LDLAPPID);
            _TestAppointment = ClsTestAppointment.Find(_TestAppointmentID);
            if (_LocalDrivingLicenseApplication != null && _TestAppointment != null)
            {
                DLAPPIDResultLbl.Text = _LocalDrivingLicenseApplication.LDLAppID.ToString();
                DClassResultLbl.Text = _LocalDrivingLicenseApplication.DrivingClass;
                NameResultLbl.Text = _LocalDrivingLicenseApplication.FullName;
                DateResultLbl.Text = _TestAppointment.AppointmentDate.ToShortDateString();
                FeesResultLbl.Text = _TestAppointment.PaidFees.ToString();
                int Trials = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID);
                if (_TestAppointment.IsLocked == false && Trials > 0)
                {
                    Trials = Trials - 1;
                }
                TrialResultLbl.Text = Trials.ToString(); 
                if (_TestAppointment.IsLocked == true)
                {
                   

                    TestIDResultLbl.Text = "Taken";

                    SaveBtn.Enabled = false;
                    PassRadioButton.Enabled = false; 
                    FailRadioButton.Enabled = false;
                    NoteTextBox.Enabled = false;
                }
                else
                {
                    TestIDResultLbl.Text = "Not Taken Yet";
                    SaveBtn.Enabled = true;
                }

            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScheduledTestFrm_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _Tests = new ClsTests();
            if (!PassRadioButton.Checked && !FailRadioButton.Checked)
            {
                MessageBox.Show("Please select a test result (Pass or Fail)!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Tests.TestAppointmentID = _TestAppointment.TestAppointmentID;
            if (PassRadioButton.Checked)
            {
                _Tests.TestResult = true;
            }
            else
            {
                _Tests.TestResult = false;
            }
            _Tests.Notes = NoteTextBox.Text; 
            _Tests.CreatedByUserID = ClsGlobal.CurrentUser.UserID;

            if (_Tests.Save())
            {
                _TestAppointment.IsLocked = true;
                _TestAppointment.Save();

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SaveBtn.Enabled = false;
                

            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     
    }
}
