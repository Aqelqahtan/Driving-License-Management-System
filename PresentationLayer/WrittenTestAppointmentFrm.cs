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
    public partial class WrittenTestAppointmentFrm : Form
    {
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private ClsApplication _Application;
        private ClsApplicationTypes _ApplicationTypes;
        private ClsTestAppointment _TestAppointment;
        private int _ApplicationID;
        private ClsUsers _User;
        public WrittenTestAppointmentFrm(int ApplicationID)
        {
            _ApplicationID = ApplicationID;
            InitializeComponent();
            _LoadDrivingLicenseApplicationInfo();
            if (_LocalDrivingLicenseApplication != null)
            {
                _LoadPersonInfo();
            }
            _LoadAppointment();
        }

        private void _LoadAppointment()
        {
            DataTable AppointmentTestTable = ClsTestAppointment.GetApplicationTestAppoitmentPerTestType(_ApplicationID, 2);
            dataGridView1.DataSource = AppointmentTestTable;
            RecoredResultLbl.Text = AppointmentTestTable.Rows.Count.ToString();

            if (AppointmentTestTable.Rows.Count > 0)
            {
                int LastAppointmentID = (int)AppointmentTestTable.Rows[0]["TestAppointmentID"];
                _TestAppointment = ClsTestAppointment.Find(LastAppointmentID);

            }
            else
            {
                _TestAppointment = null;
            }

        }
        private void _LoadDrivingLicenseApplicationInfo()
        {
            _LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(_ApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                Console.WriteLine("There is no data !");
                this.Close();
                return;
            }
            DLAPPIDResultLbl.Text = _LocalDrivingLicenseApplication.LDLAppID.ToString();
            AppliedForLicenseResult.Text = _LocalDrivingLicenseApplication.DrivingClass.ToString();
            PassedTestsResult.Text = _LocalDrivingLicenseApplication.PassedTests.ToString() + "/3";

        }

        private void _LoadPersonInfo()
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
            this.Close();
        }

        private void AddPersonBtn_Click(object sender, EventArgs e)
        {
            bool alreadyPassed = ClsTests.Find(_LocalDrivingLicenseApplication.LDLAppID, 2);
            if (alreadyPassed)
            {
                MessageBox.Show("Person Already passed this test , You can not add new appointment", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_TestAppointment != null && _TestAppointment.IsLocked == false)
            {
                MessageBox.Show("Person Already have an active appointment for this test , You can not add new appointment", "Not Allowed",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(_ApplicationID);

            ScheduleTestFrm frm = new ScheduleTestFrm(_LocalDrivingLicenseApplication.LDLAppID, 2, -1);
            frm.ShowDialog();
            _LoadAppointment();
        }

        private void ViewPersinInfoBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int basedAppID = ClsLocalDrivingLicenseApplication.FindByLocalDrivingAppID(_ApplicationID);
            ClsApplication baseApp = ClsApplication.FindBaseApplication(basedAppID);

            if (baseApp != null)
            {
                PersonDetailsFrm frm = new PersonDetailsFrm(baseApp.ApplicantPersonID);
                frm.ShowDialog();
            }

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int AppointmentTestID = (int)dataGridView1.CurrentRow.Cells["TestAppointmentID"].Value;
                ScheduledTestFrm frm = new ScheduledTestFrm(_LocalDrivingLicenseApplication.LDLAppID, 2, AppointmentTestID);
                frm.ShowDialog();


                _LoadAppointment();
            }

        }

    

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int TestAppointmentID = (int)dataGridView1.CurrentRow.Cells["TestAppointmentID"].Value;

                ScheduleTestFrm frm = new ScheduleTestFrm(_LocalDrivingLicenseApplication.LDLAppID, 2, TestAppointmentID);
                frm.ShowDialog();
                _LoadAppointment();

            }
        }
    }
}
