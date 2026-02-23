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
    public partial class LocalDrivingLicenseApplicationsFrm : Form
    {
        public LocalDrivingLicenseApplicationsFrm()
        {
            InitializeComponent();
            _RefreashLocalDrivingLicense();
        }
        private DataView _dvLocalDrivingLicense;
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
                else
                {
                    SearchTextBox.Visible = true;
                    SearchTextBox.Clear();
                    SearchTextBox.Focus();
                }
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
                case "L.D.L.AppID": FilterColumn = "LDLAppID"; break;
                case "Driving Class": FilterColumn = "DrivingClass"; break;
                case "National No": FilterColumn = "NationalNo"; break;
                case "Full Name": FilterColumn = "FullName"; break;
                case "Application Date": FilterColumn = "ApplicationDate"; break;
                case "Passed Tests": FilterColumn = "PassedTests"; break;
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
                if (FilterColumn == "LDLAppID" || FilterColumn == "PassedTests")
                {
                    
                    if (int.TryParse(FilterByComboBox.Text.Trim(), out int ))
                }
            }
        }
    }
}
