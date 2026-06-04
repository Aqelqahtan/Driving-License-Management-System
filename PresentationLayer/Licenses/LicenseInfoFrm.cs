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
    public partial class LicenseInfoFrm : Form
    {
        private ClsDriver _Driver;
        private ClsLicense _License; 
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private ClsPeople _Person;
        private int _ApplicationID; 

        public LicenseInfoFrm(ClsLicense license)
        {
            InitializeComponent();
            _License = license;
            _LoadData();
        }

        private void _LoadData()
        {
            if (_License == null)
                return; 
            _Driver = ClsDriver.FindByDriverID(_License.DriverID);
            if (_Driver == null)
                return;
            _Person = ClsPeople.Find(_Driver.PersonID); 
            if (_Person == null)
                return;

            GendorResultLbl.Text = (_Person.Gendor == 0) ? "Male" : "Female";
            DateOfBirthResultLbl.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))

            {
                PicturePersonPictureBox.Image = Image.FromFile(_Person.ImagePath);
            }
            else
            {
                if (_Person.Gendor == 0)
                {
                    PicturePersonPictureBox.Image = Properties.Resources.Male_512;
                }
                else
                {
                    PicturePersonPictureBox.Image = Properties.Resources.Female_512;
                }
            }

            ClsLicenseClass licenseClass = ClsLicenseClass.Find(_License.LicenseClass);

            if (licenseClass != null)
            {
                ClassResultLbl.Text = licenseClass.ClassName;
            }
            NameResultLbl.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName +" " + _Person.LastName;
            NationalNoResultLbl.Text = _Person.NationalNO;
                
              
                
                    IssueDateResultLbl.Text = _License.IssueDate.ToString("dd/MM/yyyy");
                    ExpirationDateResultLbl.Text = _License.ExpirationDate.ToString("dd/MM/yyyy");
                    IsActiveResultLbl.Text = _License.IsActive ? "Yes" : "No";
                    switch(_License.IssueReason)
            {
                case 1:
                    IssueReasonResultLbl.Text = "First Time";
                    break;

                case 2:
                    IssueReasonResultLbl.Text = "Renew";
                    break;
                case 3:
                    IssueReasonResultLbl.Text = "Replacement For Lost";
                    break;

                case 4:
                    IssueReasonResultLbl.Text = "Replacement for Damage";
                    break;

                case 5:
                    IssueReasonResultLbl.Text = "Release for Detained";
                    break;
                default:
                    IssueReasonResultLbl.Text = "Unknown";
                    break;
            }
                    LicenseIDResultLbl.Text = _License.LicenseID.ToString();
                    IsDetainedResultLbl.Text = _License.IsDetained ? "Yes" : "No";
                    if (string.IsNullOrEmpty(_License.Notes))
                    {
                        NoteResultLbl.Text = "No Notes";
                    }
                    else
                    {
                        NoteResultLbl.Text = _License.Notes.ToString();
                    }



            DriverIDResultLbl.Text = _Driver.DriverID.ToString();



        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
