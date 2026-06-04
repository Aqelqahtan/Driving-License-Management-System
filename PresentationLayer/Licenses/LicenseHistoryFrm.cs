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
    public partial class LicenseHistoryFrm : Form
    {

        private ClsLicense _License;
        private ClsPeople _Person;
        private ClsApplication _Application;
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private ClsDriver _Driver;
        private int _ApplicationID;
        private ClsCountry _Country;
        public LicenseHistoryFrm(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
            _LoadPersonInformation();
            _LoadLocalDataGrid();
            _LoadInternationalGrid();
        }
        private void _LoadPersonInformation()
        {
            _Application = ClsApplication.FindBaseApplication(_ApplicationID);

            if (_Application == null) return;

            _Person = ClsPeople.Find(_Application.ApplicantPersonID);
            if (_Person == null) return;

            PersonIDResultLbl.Text = _Person.PersonID.ToString();
            NameResultLbl.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;

            NationalNOResultLbl.Text = _Person.NationalNO;
            GendorResultLbl.Text = (_Person.Gendor == 0) ? "Male" : "Female";
            EmailResultLbl.Text = _Person.Email;
            AddressResultLbl.Text = _Person.Address;
            DateOfBirthResultLbl.Text = _Person.DateOfBirth.ToString("dd/MMM/yyyy");
            PhoneResultLbl.Text = _Person.Phone;

            _Country = ClsCountry.Find(_Person.NationalityCountryID);
            if (_Country != null)
            {
                CountryResultLbl.Text = _Country.CountryName;
            }

            if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))
            {
                PersonPictureBox.ImageLocation = _Person.ImagePath;
            }

            FilterByComboBox.SelectedIndex = 1;
            SearchTextBox.Text = _Person.PersonID.ToString();
        }
        private void _LoadLocalDataGrid()
        {
            if (_Person == null) return;

            _Driver = ClsDriver.FindByPersonID(_Person.PersonID);

            if (_Driver == null)
            {
                MessageBox.Show("There is no Data!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LocalLicenseDataGridView.AutoGenerateColumns = false;

            DataTable dtLocalLicense = ClsLicense.GetDriverLicenses(_Driver.DriverID);

            LocalLicenseDataGridView.DataSource = dtLocalLicense;
            LocalRecordResultLbl.Text = dtLocalLicense.Rows.Count.ToString();
        }
        private void _LoadInternationalGrid()
        {
            if (_Driver == null) return;
            DataTable DtInternationalLic = ClsInternationalLicense.GetInternationalLicenseByApplicationID(_Driver.DriverID);
            InternationalLicenseDataGridView.DataSource = DtInternationalLic;
            InternationalRecordResultLbl.Text = DtInternationalLic.Rows.Count.ToString();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditPersinInfoBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (_Person == null) return;
            AddUpdatePersonFrm frm = new AddUpdatePersonFrm(_Person.PersonID);
            frm.ShowDialog();
            _LoadPersonInformation();

        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_Person == null) return; 
            PersonDetailsFrm frm = new PersonDetailsFrm(_Person.PersonID); 
            frm.ShowDialog();
        }
    }
}
