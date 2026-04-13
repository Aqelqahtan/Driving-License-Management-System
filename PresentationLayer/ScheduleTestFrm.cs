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
    public partial class ScheduleTestFrm : Form
    {
        private int _LDLAPPID;
        private int _TestAppointmentID;
        private int _TestTypeID;
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private ClsTestType _TestType;
        private ClsTestAppointment _TestAppointment;
        private ClsTests _Test;
       
        private enum enMode {AddNew = 0, Update = 1}
        private enMode _Mode = enMode.AddNew;
        public ScheduleTestFrm(int LDLAPPID , int TestTypeID ,int TestAppointmentID )
        {
            InitializeComponent();
            _LDLAPPID = LDLAPPID;
            _TestTypeID = TestTypeID;
            _TestAppointmentID = TestAppointmentID;

            if (_TestAppointmentID == -1)
            {
                _Mode = enMode.AddNew;
            } else
            {
                _Mode = enMode.Update;
            }
      

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
        private void _LoadRetakeTestInfo()
        {
            int Trials = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID);
            TrialResultLbl.Text = Trials.ToString();

            float TestFees = 15;
            FeesResultLbl.Text = TestFees.ToString();

            if (Trials == 0)
            {
                gbRetakeTestInfo.Enabled = false;
                RAppFeesResultLbl.Text = "0";
                TotalFeesResultLbl.Text = TestFees.ToString();
                RTestAppIDResultIbl.Text = "N/A";
            }
            else
            {
                float RetakeFees = 5;
                gbRetakeTestInfo.Enabled = true;
                RAppFeesResultLbl.Text = RetakeFees.ToString();
                TotalFeesResultLbl.Text = (RetakeFees + TestFees).ToString();
                RTestAppIDResultIbl.Text = "N/A";
            }
        }

        private void ScheduleTestFrm_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();
            _LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(_LDLAPPID);
            if (_LocalDrivingLicenseApplication != null)
            {
                DLAPPIDResultLbl.Text = _LocalDrivingLicenseApplication.LDLAppID.ToString();
                DClassResultLbl.Text = _LocalDrivingLicenseApplication.DrivingClass;
                NameResultLbl.Text = _LocalDrivingLicenseApplication.FullName;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker1.MinDate = DateTime.Now;
                _LoadRetakeTestInfo();
                if (_Mode == enMode.AddNew)
                {
                    _TestAppointment = new ClsTestAppointment();

                }
                else
                {
                    
                    _TestAppointment = ClsTestAppointment.Find(_TestAppointmentID);
                    if (_TestAppointment != null)
                    {
                        dateTimePicker1.Value = _TestAppointment.AppointmentDate;
                    }else
                    {
                        MessageBox.Show("Could not find Appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                }
            }
            CheckAppointmentStatus();

        }
        private void CheckAppointmentStatus ()
        {
            if (_Mode == enMode.Update && _TestAppointment != null && _TestAppointment.IsLocked )
            {
                
                    warningLBL.Text = "Person already sat for the test , appointment locked";
                    dateTimePicker1.Enabled = false;
                    SaveBtn.Enabled = false;
                    return;
                
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LDLAPPID;
            _TestAppointment.AppointmentDate = dateTimePicker1.Value; 
            _TestAppointment.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            _TestAppointment.IsLocked = false;

            if (gbRetakeTestInfo.Enabled == true)
            {
                _TestAppointment.PaidFees = Convert.ToSingle(TotalFeesResultLbl.Text); 
            }else
            {
                _TestAppointment.PaidFees = Convert.ToSingle(FeesResultLbl.Text); 
            }
            if (_TestAppointment.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                SaveBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}
