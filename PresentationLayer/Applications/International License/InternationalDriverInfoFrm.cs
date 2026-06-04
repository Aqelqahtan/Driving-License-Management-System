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
    public partial class InternationalDriverInfoFrm : Form
    {
        private int _InternationalLicenseID; 
        private ClsInternationalLicense _InternationalLicense ; 
        private ClsDriver _Driver ;
        private ClsPeople _person ; 
  
        public InternationalDriverInfoFrm(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
            _LoadInternationalLicenseData();
        }

        private void _LoadInternationalLicenseData()
        {
            _InternationalLicense = ClsInternationalLicense.Find(_InternationalLicenseID);
            if (_InternationalLicense == null) return;
            IntLicenseIDResultLbl.Text = _InternationalLicense.InternationalLicenseID.ToString();
            ApplicationIDResultLbl.Text = _InternationalLicense.ApplicationID.ToString();
            IsActiveResultLbl.Text = _InternationalLicense.IsActive  ? "Yes" : "No";
            IssueDateNationalLicenseResultLbl.Text = _InternationalLicense.IssueDate.ToString("dd/MMM/yyyy");
            ExpirationDateNationalResonResultLbl.Text = _InternationalLicense.ExpirationDate.ToString("dd/MMM/yyyy"); 
            DriverIDResultLbl.Text = _InternationalLicense.DriverID.ToString();

            _Driver = ClsDriver.FindByDriverID(_InternationalLicense.DriverID);
            if (_Driver == null) return;

            _person = ClsPeople.Find(_Driver.PersonID);
            if (_person == null) return;

            NameResultLbl.Text = _person.FirstName + " " +_person.SecondName+ " " + _person.ThirdName + " "  +_person.LastName;
            GendorResultLbl.Text  = _person.Gendor == 0 ? "Male" : "Female";
            NationalNoResultLbl.Text = _person.NationalNO.ToString();
            DateOfBirthResultLbl.Text = _person.DateOfBirth.ToString("dd/MMM/yyyy") ; 
            LicenseIDResultLbl.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();

            if (!string.IsNullOrEmpty(_person.ImagePath) && System.IO.File.Exists(_person.ImagePath))

            {
                PicturePersonPictureBox.Image = Image.FromFile(_person.ImagePath);
            }
            else
            {
                if (_person.Gendor == 0)
                {
                    PicturePersonPictureBox.Image = Properties.Resources.Male_512;
                }
                else
                {
                    PicturePersonPictureBox.Image = Properties.Resources.Female_512;
                }
            }

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
