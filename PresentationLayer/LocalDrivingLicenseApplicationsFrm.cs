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
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class LocalDrivingLicenseApplicationsFrm : Form
    {
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        public LocalDrivingLicenseApplicationsFrm()
        {
            InitializeComponent();
            _RefreashLocalDrivingLicense();
            SearchTextBox.Visible = false;
            FilterByComboBox.SelectedIndex = 0;
        }
        private DataView _dvLocalDrivingLicense;
        private int _SelectedLDLAppID
        {
            get
            {
                if (dataGridView1.CurrentRow != null)
                {
                    return (int)dataGridView1.CurrentRow.Cells["LDLAppID"].Value;
                }

                return -1;
            }
        }
        private void _RefreashLocalDrivingLicense()
        {
            DataTable dtLocalDrivingLicense = ClsLocalDrivingLicenseApplication.GetALLData();
            _dvLocalDrivingLicense = dtLocalDrivingLicense.DefaultView;
            dataGridView1.DataSource = _dvLocalDrivingLicense;
            RecoredLocalDrivingResultLbl.Text = _dvLocalDrivingLicense.Count.ToString();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPersonBtn_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplicationFrm frm = new NewLocalDrivingLicenseApplicationFrm();
            frm.ShowDialog();
            _RefreashLocalDrivingLicense();
        }

        private void FilterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterByComboBox.Text == "None")
            {
                SearchTextBox.Visible = false;
                SearchTextBox.Clear();
                if (_dvLocalDrivingLicense != null)
                {
                    {
                        _dvLocalDrivingLicense.RowFilter = "";
                        RecoredLocalDrivingResultLbl.Text = _dvLocalDrivingLicense.Count.ToString();
                    }
                }
            }
            else
            {
                SearchTextBox.Visible = true;
                SearchTextBox.Clear();
                SearchTextBox.Focus();
            }

        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_dvLocalDrivingLicense == null)
            {
                MessageBox.Show("Error There is no data !");
                return;
            }

            string FilterColumn = "";
            switch (FilterByComboBox.Text)
            {
                case "L.D.L.AppID": FilterColumn = "L.D.L.AppID"; break;
                case "Driving Class": FilterColumn = "DrivingClass"; break;
                case "National No": FilterColumn = "National No"; break;
                case "Full Name": FilterColumn = "Full Name"; break;
                case "Status": FilterColumn = "Status"; break;
                default: FilterColumn = "None"; break;
            }


            if (string.IsNullOrWhiteSpace(FilterByComboBox.Text) || FilterColumn == "None")
            {
                _dvLocalDrivingLicense.RowFilter = "";
                RecoredLocalDrivingResultLbl.Text = _dvLocalDrivingLicense.Count.ToString();
                return;
            }

            try
            {
                string SearchValue = SearchTextBox.Text.Trim();

                if (FilterByComboBox.Text == "L.D.L.AppID")
                {
                    _dvLocalDrivingLicense.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", FilterColumn, SearchValue);
                }
                else if (FilterByComboBox.Text == "National No")
                {
                    _dvLocalDrivingLicense.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, SearchValue);
                }
                else
                {
                    SearchValue = SearchTextBox.Text.Trim().Replace("'", "''");
                    _dvLocalDrivingLicense.RowFilter = string.Format(" [{0}] LIKE '{1}%' ", FilterColumn, SearchValue);
                }
                RecoredLocalDrivingResultLbl.Text = _dvLocalDrivingLicense.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int ApplicationID = _SelectedLDLAppID;
            if (ClsLocalDrivingLicenseApplication.CancelByLocalDrivingLicenseAppID(ApplicationID))
            {
                MessageBox.Show("Application Cancelled Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreashLocalDrivingLicense();
            }
            else
            {
                MessageBox.Show("Error: Could not cancel application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            string ApplicationStatus = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();
            int LDLAppID = _SelectedLDLAppID;
            int PassTests = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PassedTests"].Value);

            issueDrivingLicenseFirstTimToolStripMenuItem.Enabled = false;

            if (ApplicationStatus == "Cancelled" || ApplicationStatus == "Completed" || PassTests == 3)
            {
                cancelApplicationToolStripMenuItem.Enabled = false;
                scheduleWritenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                scheduleTestToolStripMenuItem.Enabled = false;

            }
            else
            {
                cancelApplicationToolStripMenuItem.Enabled = true;

            }
            if (ApplicationStatus == "New")
            {
                scheduleTestToolStripMenuItem.Enabled = false;
                scheduleWritenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;

                if (PassTests == 0)
                {
                    scheduleTestToolStripMenuItem.Enabled = true;
                }
                else if (PassTests == 1)
                {
                    scheduleWritenTestToolStripMenuItem.Enabled = true;
                }
                else if (PassTests == 2)
                {
                    scheduleStreetTestToolStripMenuItem.Enabled = true;
                }
                else if (PassTests == 3)
                {
                    issueDrivingLicenseFirstTimToolStripMenuItem.Enabled = true;
                }


            }

        }

        private void scheduleTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = _SelectedLDLAppID;
            VisionTestAppointmentsFrm frm = new VisionTestAppointmentsFrm(ApplicationID);
            frm.ShowDialog();
            _RefreashLocalDrivingLicense();

        }

        private void scheduleWritenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = _SelectedLDLAppID;
            WrittenTestAppointmentFrm frm = new WrittenTestAppointmentFrm(ApplicationID);
            frm.ShowDialog();
            _RefreashLocalDrivingLicense();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = _SelectedLDLAppID;

            StreetTestAppointmentFrm frm = new StreetTestAppointmentFrm(ApplicationID);
            frm.ShowDialog();
            _RefreashLocalDrivingLicense();


        }

        private void issueDrivingLicenseFirstTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = _SelectedLDLAppID;
            IssueDriverLicenseForTheFirstTimeFrm frm = new IssueDriverLicenseForTheFirstTimeFrm(ApplicationID);
            frm.ShowDialog();
            _RefreashLocalDrivingLicense();
        }
    }
}
