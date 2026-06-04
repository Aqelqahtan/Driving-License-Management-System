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

    public partial class ListInternationalLicenseApplicationsFrm : Form
    {
        private ClsInternationalLicense _InternationalLicense;
        private DataView _dvInternationalLicense;
        public ListInternationalLicenseApplicationsFrm()
        {
            InitializeComponent();
            _LoadData();
        }
        private void _LoadData()
        {
            DataTable dtInternationalLicense = ClsInternationalLicense.GetAllInternationalLicenses();
            dataGridView1.DataSource = dtInternationalLicense;
            _dvInternationalLicense = dtInternationalLicense.DefaultView;
            RecoredResultLbl.Text = dataGridView1.RowCount.ToString();
            SearchTextBox.Visible = false;
            FilterByActive.Visible = false;
            FilterByComboBox.SelectedIndex = 0;
            FilterByActive.SelectedIndex = 0;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ApplicationID = (int)dataGridView1.CurrentRow.Cells["ApplicationID"].Value;
            LicenseHistoryFrm frm = new LicenseHistoryFrm(ApplicationID);
            frm.ShowDialog();
        }

        private void FilterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            SearchTextBox.Visible = false;
            FilterByActive.Visible = false;
            SearchTextBox.Clear();
            if (FilterByComboBox.Text == "None")
            {
                if (_dvInternationalLicense != null)
                {
                    _dvInternationalLicense.RowFilter = "";
                    RecoredResultLbl.Text = _dvInternationalLicense.Count.ToString();
                }
            }
            else if (FilterByComboBox.Text == "Is Active")
            {
                FilterByActive.Visible = true;
                SearchTextBox.Clear();

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
            if (_dvInternationalLicense == null)
            {
                MessageBox.Show("Error There Is No Data !");
                return;
            }

            string FilterColumn = "";
            switch (FilterByComboBox.Text.Trim())
            {
                case "Int License ID": FilterColumn = "InternationalLicenseID"; break;
                case "Application ID": FilterColumn = "ApplicationID"; break;
                case "L License ID": FilterColumn = "IssuedUsingLocalLicenseID"; break;
                case "Driver ID": FilterColumn = "DriverID"; break;
                case "Is Active": FilterColumn = "IsActive"; break;
                default: FilterColumn = "None"; break;
            }

            string SearchValue = SearchTextBox.Text.Trim();
            if (FilterColumn == "None" || string.IsNullOrWhiteSpace(FilterByComboBox.Text))
            {
                _dvInternationalLicense.RowFilter = "";
                RecoredResultLbl.Text = _dvInternationalLicense.Count.ToString();
                return;
            }

            _dvInternationalLicense.RowFilter = string.Format("Convert([{0}] , 'System.String') LIKE '{1}%'", FilterColumn, SearchValue);





        }

        private void FilterByActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dvInternationalLicense == null) return;

            string FilterValue = FilterByActive.Text;
            switch (FilterValue)
            {
                case "All":
                    _dvInternationalLicense.RowFilter = "";
                    break;
                case "Active":
                    _dvInternationalLicense.RowFilter = "IsActive = 1";
                    break;

                default:
                    _dvInternationalLicense.RowFilter = "IsActive = 0";
                    break;

            }
            RecoredResultLbl.Text = _dvInternationalLicense.Count.ToString();

        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = (int)dataGridView1.CurrentRow.Cells["ApplicationID"].Value;
            ClsApplication Application = ClsApplication.FindBaseApplication(ApplicationID);
            if (Application == null) return;


            PersonDetailsFrm frm = new PersonDetailsFrm(Application.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dataGridView1.CurrentRow.Cells["IssuedUsingLocalLicenseID"].Value; 
            ClsLicense license = ClsLicense.Find(LicenseID);

            LicenseInfoFrm frm = new LicenseInfoFrm(license);
            frm.ShowDialog();
        }

    }
}
