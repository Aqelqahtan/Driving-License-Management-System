using BusinessLayer;
using PresentationLayer.User;
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
    public partial class RenewLocalDrivingLicenseFrm : Form
    {
        private ClsDriver _Driver;
        private ClsPeople _Person;
        private ClsLicense _License;
        private ClsLicenseClass _LicenseClass;
        private ClsApplication _Application;
        private ClsApplicationTypes _ApplicationTypes;
        private ClsLicense NewLicense; 
        public RenewLocalDrivingLicenseFrm()
        {
            InitializeComponent();
            DischargeData();
            ShowLicensesHistoryLinkLabel.Enabled = false;
            ShowNewLicensesInfoLinkLabel.Enabled = false;
            RenewBtn.Enabled = false;
        }

        private void _LoadDriverLicenseInfo(int LicenseID)
        {


            _License = ClsLicense.Find(LicenseID);
            if (_License == null)
            {
                MessageBox.Show("No license found with this ID [" + LicenseID + "] in the system!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _LicenseClass = ClsLicenseClass.Find(_License.LicenseClass);
            if (_LicenseClass == null) return;

            ClassResultLbl.Text = _LicenseClass.ClassName;
            LicenseIDResultLbl.Text = _License.LicenseID.ToString();
            IssueDateLicenseResultLbl.Text = _License.IssueDate.ToString("dd/MMM/yyyy");
            switch (_License.IssueReason)
            {
                case 1:
                    IssueReasonResultLbl.Text = "First Time";
                    break;
                case 2:
                    IssueReasonResultLbl.Text = "Renew";
                    break;
                case 3:
                    IssueReasonResultLbl.Text = "Replacement for Lost"; 
                    break;
                case 4:
                    IssueReasonResultLbl.Text = "Replacement for Damaged"; 
                    break;
                case 5:
                    IssueReasonResultLbl.Text = "Release for Detained";
                    break;
                default:
                    IssueReasonResultLbl.Text = "Unknown";
                    break;
            }
            NoteResultLbl.Text = string.IsNullOrEmpty(_License.Notes) ? "No Notes" : _License.Notes;
            IsActiveResultLbl.Text = (_License.IsActive == false) ? "NO" : "YES";
            ExpirationDateLocalResonResultLbl.Text = _License.ExpirationDate.ToString("dd/MMM/yyyy");
            IsDetainedResultLbl.Text = (_License.IsDetained == false) ? "No" : "Yes";

            _Driver = ClsDriver.FindByDriverID(_License.DriverID);
            if (_Driver == null) return;
            DriverIDResultLbl.Text = _Driver.DriverID.ToString();

            _Person = ClsPeople.Find(_Driver.PersonID);
            if (_Person == null) return;

            NameResultLbl.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            NationalNoResultLbl.Text = _Person.NationalNO;
            GendorResultLbl.Text = (_Person.Gendor == 0) ? "Male" : "Female";
            DateOfBirthResultLbl.Text = _Person.DateOfBirth.ToString("dd/MMM/yyyy");
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


        }

        private void _LoadApplicationNewLicenseInfo(int LicenseID)
        {
            _License = ClsLicense.Find(LicenseID);
            if (_License == null) return;

            RLApplicationIDResultLbl.Text = "[???]";
            RLApplicationDateLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            IssueDateRLLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");

            _Application = ClsApplication.FindBaseApplication(_License.ApplicationID);
            if (_Application == null) return;

            _ApplicationTypes = ClsApplicationTypes.Find(2);
            if (_ApplicationTypes == null) return;

            ApplicationFeesResultLbl.Text = Convert.ToInt32(_ApplicationTypes.ApplicationFees).ToString();
            LicenseFeesResultLbl.Text = _License.PaidFees.ToString();
            RenewedLicenseIDResultLbl.Text = "[???]";
            OldLicenseIDResultLbl.Text = _License.LicenseID.ToString();
            ExpirationDateNewResultLbl.Text = DateTime.Now.AddYears(10).ToString("dd/MMM/yyyy");

            ClsUsers User = ClsGlobal.CurrentUser;
            CreatedByResultLbl.Text = User.UserName;
            TotalFeesResultLbl.Text = (Convert.ToInt32(_ApplicationTypes.ApplicationFees) + Convert.ToInt32(_License.PaidFees)).ToString();
            NotesTextBox.Text = string.Empty;
            ShowLicensesHistoryLinkLabel.Enabled = true;


            if (( _License.IsActive == true) && _License.ExpirationDate > DateTime.Now)
            {
               
               MessageBox.Show("Selected License is not yet expiared , it will expire on :" + _License.ExpirationDate.ToString("dd/MMM/yyyy"), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               RenewBtn.Enabled = false;
            }else if ( _License.IsActive == true && _License.ExpirationDate < DateTime.Now)
            {
                RenewBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("This License is NOT active, you cannot renew it!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RenewBtn.Enabled = false;
            }
            
        }

        private void DischargeData()
        {
            _Driver = null;
            _Person = null;
            _License = null;
            _LicenseClass = null;
            _Application = null;
            ClassResultLbl.Text = "[???]";
            NameResultLbl.Text = "[???]";
            LicenseIDResultLbl.Text = "[???]";
            NationalNoResultLbl.Text = "[???]";
            GendorResultLbl.Text = "[???]";
            PicturePersonPictureBox.Image = null;
            IssueDateLicenseResultLbl.Text = "[???]";
            IssueReasonResultLbl.Text = "[???]";
            NoteResultLbl.Text = "[???]";
            IsActiveResultLbl.Text = "[???]";
            DateOfBirthResultLbl.Text = "[???]";
            DriverIDResultLbl.Text = "[???]";
            ExpirationDateLocalResonResultLbl.Text = "[???]";
            IsDetainedResultLbl.Text = "[???]";


            RLApplicationIDResultLbl.Text = "[???]";
            RLApplicationDateLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            IssueDateRLLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            ApplicationFeesResultLbl.Text = "5";
            LicenseFeesResultLbl.Text = "[???]";
            RenewedLicenseIDResultLbl.Text = "[???]";
            OldLicenseIDResultLbl.Text = "[???]";
            ExpirationDateNewResultLbl.Text = "[???]";
            ClsUsers User = ClsGlobal.CurrentUser;
            CreatedByResultLbl.Text = User.UserName.ToString();
            TotalFeesResultLbl.Text = "[???]";
            NotesTextBox.Text = string.Empty;
            ShowLicensesHistoryLinkLabel.Enabled = false;
            ShowNewLicensesInfoLinkLabel.Enabled = false;



        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenewBtn_Click(object sender, EventArgs e)
        {
            if (_License.IsActive == true && _License.ExpirationDate < DateTime.Now)
            {
                ClsApplication NewApplication = new ClsApplication();
                NewApplication.ApplicantPersonID = _Person.PersonID;
                NewApplication.ApplicationDate = DateTime.Now;
                NewApplication.ApplicationTypeID = 2;
                NewApplication.ApplicationStatus = ClsApplication.enApplicationStatus.Completed;
                NewApplication.LastStatusDate = DateTime.Now;
                NewApplication.PaidFees = _ApplicationTypes.ApplicationFees;
                NewApplication.CreatedByUserID = ClsGlobal.CurrentUser.UserID;

                NewApplication.Save();

                NewLicense = new ClsLicense();
                NewLicense.ApplicationID = NewApplication.ApplicationID;
                NewLicense.DriverID = _License.DriverID;
                NewLicense.LicenseClass = _License.LicenseClass;
                NewLicense.IssueDate = DateTime.Now;
                NewLicense.ExpirationDate = DateTime.Now.AddYears(10);
                NewLicense.Notes = NotesTextBox.Text;
                NewLicense.PaidFees = (float)_LicenseClass.ClassFees;
                NewLicense.IsActive = true;
                NewLicense.IssueReason = 2;
                NewLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;

                if (NewLicense.Save())
                {
                    _License.IsActive = false;
                    _License.Save();
                    MessageBox.Show("Saved Successfully");
                    RLApplicationIDResultLbl.Text = NewLicense.ApplicationID.ToString();
                    RenewedLicenseIDResultLbl.Text = NewLicense.LicenseID.ToString();
                    ShowNewLicensesInfoLinkLabel.Enabled = true;
                    RenewBtn.Enabled = false;
                    LicenseIDLbl.Enabled = false;
                    LicenseIDTextBox.Enabled = false;
                    LicenseIDBtnPictureBox.Enabled = false;
                    

                }
                else
                {
                    MessageBox.Show("Failed Operation !", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show("Error", "Requirment is not applicated ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LicenseIDTextBox_TextChanged(object sender, EventArgs e)
        {
            DischargeData();
        }

        private void LicenseIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string SearchValue = LicenseIDTextBox.Text;
                if (int.TryParse(SearchValue, out int LicenseID))
                {
                    _LoadDriverLicenseInfo(LicenseID);
                    _LoadApplicationNewLicenseInfo(LicenseID);

                }
            }


        }

        private void LicenseIDBtnPictureBox_Click(object sender, EventArgs e)
        {
            string SearchValue = LicenseIDTextBox.Text;
            if (int.TryParse(SearchValue, out int LicenseID))
            {
                _LoadDriverLicenseInfo(LicenseID);
                _LoadApplicationNewLicenseInfo(LicenseID);

            }
        }

        private void ShowLicensesHistoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (int.TryParse(LicenseIDTextBox.Text, out int LicenseID))
            {
                _License = ClsLicense.Find(LicenseID);
                if (_License != null)
                {
                    LicenseHistoryFrm frm = new LicenseHistoryFrm(_License.ApplicationID);
                    frm.ShowDialog();
                }
                else
                {
                    return;
                }
            }
        }

        private void ShowNewLicensesInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            LicenseInfoFrm frm = new LicenseInfoFrm(NewLicense); 
            frm.ShowDialog();
            
        }
    }
}
