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
    public partial class VisionTestAppointmentsFrm : Form
    {
        private int _ApplicationID;
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private ClsApplication _Application;
        private ClsUsers _User;
        private ClsApplicationTypes _ApplicationTypes;
        private ClsTestAppointment _AppointmentTest;
        private ClsTests _Test;
        public VisionTestAppointmentsFrm(int applicationID)
        {
            InitializeComponent();
            _ApplicationID = applicationID;

            _LoadDrivingLicenseApplicationInfo();
            if (_LocalDrivingLicenseApplication != null)
            {
                _LoadApplicationBasicInfo();
            }
            _LoadAppointment();

        }
        private void _LoadDrivingLicenseApplicationInfo()
        {
            _LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(_ApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Erorr , There is no Data !");
                this.Close();
                return;
            }
            DLAPPIDResultLbl.Text = _LocalDrivingLicenseApplication.LDLAppID.ToString();
            AppliedForLicenseResult.Text = _LocalDrivingLicenseApplication.DrivingClass;
            PassedTestsResult.Text = _LocalDrivingLicenseApplication.PassedTests.ToString() + "/3";

        }
        private void _LoadApplicationBasicInfo()
        {
            _Application = ClsApplication.FindBaseApplication(_LocalDrivingLicenseApplication.ApplicationID);
            if (_Application == null)
            {
                MessageBox.Show("Erorr , There is no Data !");
                this.Close();
                return;
            }
            IDResultLbl.Text = _Application.ApplicationID.ToString();
            StatusResultLbl.Text = _Application.ApplicationStatus.ToString();
            FeesResultLbl.Text = _Application.PaidFees.ToString();
            _ApplicationTypes = ClsApplicationTypes.Find(_Application.ApplicationTypeID);
            if (_ApplicationTypes != null)
            {
                TypeResultLbl.Text = _ApplicationTypes.ApplicationTypeTitle;
            }
            DateResultLbl.Text = _Application.ApplicationDate.ToShortDateString();
            StatusDateResultLbl.Text = _Application.LastStatusDate.ToShortDateString();
            _User = ClsUsers.Find(_Application.CreatedByUserID);
            if (_User != null)
            {
                CreatedByResultLbl.Text = _User.UserName;
            }
            ApplicantResultLbl.Text = _LocalDrivingLicenseApplication.FullName.ToString();

        }
        private void _LoadAppointment()
        {
            DataTable AppointmentTestTable = ClsTestAppointment.GetApplicationTestAppoitmentPerTestType(_ApplicationID, 1);
            dataGridView1.DataSource = AppointmentTestTable;
            RecoredResultLbl.Text = AppointmentTestTable.Rows.Count.ToString();
            if (AppointmentTestTable.Rows.Count > 0)
            {
                int lastAppointmentID = (int)AppointmentTestTable.Rows[0]["TestAppointmentID"];
                _AppointmentTest = ClsTestAppointment.Find(lastAppointmentID);

            }
            else
            {
                _AppointmentTest = null;
                _Test = null;
            }

        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPersonBtn_Click(object sender, EventArgs e)
        {
            bool alreadyPassed = ClsTests.Find(_LocalDrivingLicenseApplication.LDLAppID, 1);

            if (alreadyPassed)
            {
                MessageBox.Show("Person already passed this test, you cannot add new vision exam!",
                 "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_AppointmentTest != null && _AppointmentTest.IsLocked == false)
            {
                MessageBox.Show("Person already has an active appointment!",
                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            ScheduleTestFrm frm = new ScheduleTestFrm(_LocalDrivingLicenseApplication.LDLAppID,1,-1);
            frm.ShowDialog();
            _LoadAppointment();
        }

        private void ViewPersinInfoBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int baseAppID = ClsLocalDrivingLicenseApplication.FindByLocalDrivingAppID(_ApplicationID);
            ClsApplication baseApp = ClsApplication.FindBaseApplication(baseAppID);
            if (baseApp != null)
            {
                PersonDetailsFrm frm = new PersonDetailsFrm(baseApp.ApplicantPersonID);
                frm.ShowDialog();
            }
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int TestAppointmentID = (int)dataGridView1.CurrentRow.Cells["TestAppointmentID"].Value;

                ScheduleTestFrm frm = new ScheduleTestFrm(_LocalDrivingLicenseApplication.LDLAppID,1, TestAppointmentID);
                frm.ShowDialog();
                _LoadAppointment();

            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int TestAppointmentID = (int)dataGridView1.CurrentRow.Cells["TestAppointmentID"].Value;

                ScheduledTestFrm frm = new ScheduledTestFrm(_LocalDrivingLicenseApplication.LDLAppID,1 ,TestAppointmentID);
                frm.ShowDialog();
                _LoadAppointment();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            bool IsLocked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["IsLocked"].Value);

            if ( IsLocked == true )
            {
                eToolStripMenuItem.Enabled = false;   
                takeTestToolStripMenuItem.Enabled = false;
            }
            else
            {
                eToolStripMenuItem.Enabled = true;     
                takeTestToolStripMenuItem.Enabled = true;
            }
        }
    }
}
