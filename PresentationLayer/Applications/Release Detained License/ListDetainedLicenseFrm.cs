using BusinessLayer;
using System;
using System.Buffers;
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
    public partial class ListDetainedLicenseFrm : Form
    {
        public ListDetainedLicenseFrm()
        {
            InitializeComponent();
            _LoadDetainedLicenseDataGrid();
            SearchTextBox.Visible = false;
            FilterByReleased.Visible = false;
        }
        private DataView _DVDetainedLicenses;
        private void _LoadDetainedLicenseDataGrid()
        {
            DataTable DtDetainedLicenses = ClsDetainedLicenses.getAllOfDetainedLisences();
            _DVDetainedLicenses = DtDetainedLicenses.DefaultView;
            RecoredResultLbl.Text = _DVDetainedLicenses.Count.ToString();
            DetainedLicenseDataGrid.DataSource = DtDetainedLicenses;
            DetainedLicenseDataGrid.AutoGenerateColumns = false;



        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = (string)DetainedLicenseDataGrid.CurrentRow.Cells["NationalNo"].Value;
            ClsPeople Person = ClsPeople.Find(NationalNo);
            if (Person != null)
            {
                PersonDetailsFrm frm = new PersonDetailsFrm(Person.PersonID);
                frm.ShowDialog();

            }


            _LoadDetainedLicenseDataGrid();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)DetainedLicenseDataGrid.CurrentRow.Cells["LicenseID"].Value;
            ClsLicense License = ClsLicense.Find(LicenseID);
            if (License != null)
            {
                LicenseInfoFrm frm = new LicenseInfoFrm(License);
                frm.ShowDialog();

            }

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)DetainedLicenseDataGrid.CurrentRow.Cells["LicenseID"].Value;
            ClsLicense License = ClsLicense.Find(LicenseID);
            if (License != null)
            {

                LicenseHistoryFrm frm = new LicenseHistoryFrm(License.ApplicationID);
                frm.ShowDialog();
            }


            _LoadDetainedLicenseDataGrid();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)DetainedLicenseDataGrid.CurrentRow.Cells["LicenseID"].Value;
            ReleaseDetainedLicenseFrm frm = new ReleaseDetainedLicenseFrm(LicenseID);
            frm.ShowDialog();


            _LoadDetainedLicenseDataGrid();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool IsReleased = (bool)DetainedLicenseDataGrid.CurrentRow.Cells["IsReleased"].Value;
            if (IsReleased == true)
            {
                releaseDetainedLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
                releaseDetainedLicenseToolStripMenuItem.Enabled = true;
            }
        }

        private void FilterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterByComboBox.Text == "None")
            {
                SearchTextBox.Visible = false;
                SearchTextBox.Clear();
                FilterByReleased.Visible = false;
                if (_DVDetainedLicenses != null)
                {
                    _DVDetainedLicenses.RowFilter = "";
                    RecoredResultLbl.Text = _DVDetainedLicenses.Count.ToString();
                }

            }
            else if (FilterByComboBox.Text == "Is Released")
            {
                SearchTextBox.Visible = false;
                SearchTextBox.Clear();
                FilterByReleased.Visible = true;
            }
            else
            {
                SearchTextBox.Visible = true;
                FilterByReleased.Visible = false;
                SearchTextBox.Clear();
                SearchTextBox.Focus();
            }
        }



        private void FilterByReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_DVDetainedLicenses == null)
                return;

            switch (FilterByReleased.SelectedIndex)
            {
                case 0:
                    _DVDetainedLicenses.RowFilter = "";
                    break;

                case 1:
                    _DVDetainedLicenses.RowFilter = "IsReleased = 1";
                    break;

                case 2:
                    _DVDetainedLicenses.RowFilter = "IsReleased = 0";
                    break;

            }
            RecoredResultLbl.Text = _DVDetainedLicenses.Count.ToString();

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_DVDetainedLicenses == null)
            {
                MessageBox.Show("Error There is no data !");
                return;
            }

            string FilterColumn = "";
            switch (FilterByComboBox.Text)
            {
                case "None": FilterColumn = "None"; break;
                case "Detain ID": FilterColumn = "DetainID"; break;
                case "Is Released": FilterColumn = "IsReleased"; break;
                case "National No.": FilterColumn = "NationalNo"; break;
                case "Full Name": FilterColumn = "FullName"; break;
                case "Release Application ID": FilterColumn = "ReleaseApplicationID"; break;
                default: FilterColumn = "None"; break;
            }
            string SearchValue = SearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(SearchValue) || FilterColumn == "None")
            {

                _DVDetainedLicenses.RowFilter = "";
                RecoredResultLbl.Text = _DVDetainedLicenses.Count.ToString();
                return;
            }
            try
            {
                if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                {
                    _DVDetainedLicenses.RowFilter = string.Format("[{0}] = {1}", FilterColumn, SearchValue);
                }
                else
                {
                    _DVDetainedLicenses.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, SearchValue);
                }
                RecoredResultLbl.Text = _DVDetainedLicenses.Count.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void DetainedBtn_Click(object sender, EventArgs e)
        {
            DetainLicenseFrm frm = new DetainLicenseFrm();
            frm.ShowDialog();


            _LoadDetainedLicenseDataGrid();
        }

        private void ReleaseBtn_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseFrm frm = new ReleaseDetainedLicenseFrm();
            frm.ShowDialog();


            _LoadDetainedLicenseDataGrid();
        }
    }
}
