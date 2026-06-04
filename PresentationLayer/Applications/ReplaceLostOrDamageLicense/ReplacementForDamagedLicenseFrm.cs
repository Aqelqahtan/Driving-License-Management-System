using BusinessLayer;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
    public partial class ReplacementForDamagedLicenseFrm : Form
    {
        private ClsLicense _NewLicense;
        private ClsLicense _License;
        private ClsApplication _Application;
        private ClsApplicationTypes _ApplicationType;
        private ClsLicenseClass _LicenseClass;
        private ClsPeople _Person;
        private ClsLicense NewLicense; 

        public ReplacementForDamagedLicenseFrm()
        {
            InitializeComponent();
            Discharge();
        }

        private void _LoadDriverLicenseInfo(int LicenseID)
        {
            _License = ClsLicense.Find(LicenseID);
            if (_License == null) { MessageBox.Show("There is no License ID with [ " + LicenseID + "] in the system", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

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
                    IssueReasonResultLbl.Text = "Release For Detained";
                    break;
                default:
                    IssueReasonResultLbl.Text = "Unknown"; 
                    break;
            }
            NoteResultLbl.Text = string.IsNullOrEmpty(_License.Notes) ? "No Notes" : _License.Notes;
            IsActiveResultLbl.Text = (_License.IsActive == true) ? "Yes" : "No";
            DriverIDResultLbl.Text = _License.DriverID.ToString();
            ExpirationDateLocalResonResultLbl.Text = _License.ExpirationDate.ToString("dd/MMM/yyyy");
            IsDetainedResultLbl.Text = (_License.IsDetained == true) ? "Yes" : "No";
            _LicenseClass = ClsLicenseClass.Find(_License.LicenseClass);
            if (_LicenseClass == null) { return; }
            ClassResultLbl.Text = _LicenseClass.ClassName.ToString();

            _Application = ClsApplication.FindBaseApplication(_License.ApplicationID);

            if (_Application == null) { return; }

            _Person = ClsPeople.Find(_Application.ApplicantPersonID);
            if (_Person == null) { return; }

            NameResultLbl.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            NationalNoResultLbl.Text = _Person.NationalNO.ToString();
            GendorResultLbl.Text = (_Person.Gendor == 0) ? "Male" : "Female";
            DateOfBirthResultLbl.Text = _Person.DateOfBirth.ToString();
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

        private void _LoadApplicationInfoForLicenseReplacement(int LicenseID)
        {
            _License = ClsLicense.Find(LicenseID);
            if (_License == null) { return; }

            LRApplicationIDResultLbl.Text = "[???]";
            ReplacedLicenseIDResultLbl.Text = "[???]";
            LRApplicationDateLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            OldLicenseIDResultLbl.Text = _License.LicenseID.ToString();
            CreatedByResultLbl.Text = ClsGlobal.CurrentUser.UserName;

            if (_License.IsActive == false)
            {
                MessageBox.Show("Selected license is not Active , choose an active license. ", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            IssueReplacementBtn.Enabled = true;

        }



        private void Discharge()
        {
            DamagedLicenseRadioButton.Checked = true;
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
            LRApplicationDateLicenseResultLbl.Text = "[???]";
            ReplacedLicenseIDResultLbl.Text = "[???]";
            LRApplicationDateLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            OldLicenseIDResultLbl.Text = "[???]";
            CreatedByResultLbl.Text = ClsGlobal.CurrentUser.UserName;




            ShowLicensesHistoryLinkLabel.Enabled = false;
            ShowNewLicensesInfoLinkLabel.Enabled = false;
            IssueReplacementBtn.Enabled = false;

        }

        private void LicenseIDTextBox_TextChanged(object sender, EventArgs e)
        {
            Discharge();
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
                    _LoadApplicationInfoForLicenseReplacement(LicenseID);
                    ShowLicensesHistoryLinkLabel.Enabled = true;
                }
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LicenseIDBtnPictureBox_Click(object sender, EventArgs e)
        {

            string SearchValue = LicenseIDTextBox.Text;

            if (int.TryParse(SearchValue, out int LicenseID))
            {
                _LoadDriverLicenseInfo(LicenseID);
                _LoadApplicationInfoForLicenseReplacement(LicenseID);
                ShowLicensesHistoryLinkLabel.Enabled = true;
            }

        }

        private void DamagedLicenseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _ApplicationType = ClsApplicationTypes.Find(4);
            if (_ApplicationType != null)
            {
                ApplicationFeesResultLbl.Text = Convert.ToInt32(_ApplicationType.ApplicationFees).ToString();
            }
        }

        private void LostLicenseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _ApplicationType = ClsApplicationTypes.Find(3);
            if (_ApplicationType != null)
            {
                ApplicationFeesResultLbl.Text = Convert.ToInt32(_ApplicationType.ApplicationFees).ToString();
            }
        }

        private void ShowNewLicensesInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoFrm frm  = new LicenseInfoFrm(NewLicense);
            frm.ShowDialog();
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
            }
        }

        private void IssueReplacementBtn_Click(object sender, EventArgs e)
        {

            if (_License.IsActive == false || _License == null) return;

            ClsApplication NewApplication = new ClsApplication();
            NewApplication.ApplicationStatus = ClsApplication.enApplicationStatus.Completed;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.LastStatusDate = DateTime.Now;
            NewApplication.ApplicantPersonID = _Person.PersonID;
            NewApplication.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            if (DamagedLicenseRadioButton.Checked == true)
            {
                _ApplicationType = ClsApplicationTypes.Find(4);
                if (_ApplicationType != null)
                {
                    NewApplication.PaidFees = _ApplicationType.ApplicationFees;
                    NewApplication.ApplicationTypeID = 4;
                }
            }
            else if (LostLicenseRadioButton.Checked == true)
            {

                _ApplicationType = ClsApplicationTypes.Find(3);
                if (_ApplicationType != null)
                {
                    NewApplication.PaidFees = _ApplicationType.ApplicationFees;
                    NewApplication.ApplicationTypeID = 3;


                }
            }
            if (!NewApplication.Save())
            {
                MessageBox.Show("Failed to create the application!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            NewLicense = new ClsLicense();
            NewLicense.ApplicationID = NewApplication.ApplicationID;
            NewLicense.DriverID = _License.DriverID;
            NewLicense.LicenseClass = _License.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = _License.ExpirationDate;
            NewLicense.Notes = _License.Notes;
            NewLicense.PaidFees = 0;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = (byte)NewApplication.ApplicationTypeID;
            NewLicense.CreatedByUserID = NewApplication.CreatedByUserID;

            if (NewLicense.Save())
            {
                MessageBox.Show("Saved Successfully ^_^"); 
                _License.IsActive = false;
                _License.Save();
                LRApplicationIDResultLbl.Text = NewLicense.ApplicationID.ToString();
                ReplacedLicenseIDResultLbl.Text = NewLicense.LicenseID.ToString();
                IssueReplacementBtn.Enabled = false;
                FilterGroupBox.Enabled = false;
                ReplacementForGroupBox.Enabled = false;
                ShowNewLicensesInfoLinkLabel.Enabled = true;

            }
            else
            {
                MessageBox.Show("Failed Operation !", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

            

        
    }
}

