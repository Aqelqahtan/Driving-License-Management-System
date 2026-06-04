using BusinessLayer;
using PresentationLayer.User;
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
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class ReleaseDetainedLicenseFrm : Form
    {
        private ClsLicense _License;
        private ClsLicenseClass _LicenseClass;
        private ClsApplication _Application;
        private ClsPeople _Person;
        private ClsDetainedLicenses _DetainedLicenses;
        private ClsApplicationTypes _ApplicationTypes;

        public ReleaseDetainedLicenseFrm()
        {
            InitializeComponent();
        }
        public ReleaseDetainedLicenseFrm(int LicenseID)
        {
            InitializeComponent();
            LicenseIDTextBox.Text = LicenseID.ToString();
            LicenseIDBtnPictureBox_Click(null, null); 
            FilterGroupBox.Enabled = false;

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _LoadDriverLicenseInfo(int LicenseID)
        {
            _License = ClsLicense.Find(LicenseID);
            if (_License == null)
            {
                MessageBox.Show("There is no License ID with [ " + LicenseID + "] in the system", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LicenseClass = ClsLicenseClass.Find(_License.LicenseClass);
            if (_LicenseClass == null) return;

            ClassResultLbl.Text = _LicenseClass.ClassName;

            _Application = ClsApplication.FindBaseApplication(_License.ApplicationID);

            if (_Application == null) return;

            _Person = ClsPeople.Find(_Application.ApplicantPersonID);
            if (_Person == null) return;

            NameResultLbl.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            LicenseIDResultLbl.Text = _License.LicenseID.ToString();
            NationalNoResultLbl.Text = _Person.NationalNO;
            GendorResultLbl.Text = (_Person.Gendor == 0) ? "Male" : "Female";
            IssueDateLicenseResultLbl.Text = _License.IssueDate.ToString("dd/MMM/yyyy");
            switch (_License.IssueReason)
            {
                case 1:
                    IssueReasonResultLbl.Text = "New";
                    break;

                case 2:
                    IssueReasonResultLbl.Text = "Renew";
                    break;
                case 3:
                    IssueReasonResultLbl.Text = "Replacement For Lost";
                    break;
                case 4:
                    IssueReasonResultLbl.Text = "Replacement For Damaged";
                    break;
                case 5:
                    IssueReasonResultLbl.Text = "Release for Detained";
                    break;

                default:
                    IssueReasonResultLbl.Text = "Unknown";
                    break;
            }
            NoteResultLbl.Text = (string.IsNullOrEmpty(_License.Notes) ? "No Notes" : _License.Notes);
            if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))
            {
                PicturePersonPictureBox.Image = System.Drawing.Image.FromFile(_Person.ImagePath);
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
            IsActiveResultLbl.Text = (_License.IsActive == true) ? "Yes" : "No";
            DateOfBirthResultLbl.Text = _Person.DateOfBirth.ToString("dd/MMM/yyyy");
            DriverIDResultLbl.Text = _License.DriverID.ToString();
            ExpirationDateLocalResonResultLbl.Text = _License.ExpirationDate.ToString("dd/MMM/yyyy");
            IsDetainedResultLbl.Text = (_License.IsDetained == true) ? "Yes" : "No";

        }

        private void _LoadDetainInfo(int LicenseID)
        {
            _License = ClsLicense.Find(LicenseID);
            if (_License == null) return;
            _DetainedLicenses = ClsDetainedLicenses.FindByLicenseID(LicenseID);
            if (_DetainedLicenses == null) return;

            DetainIDResultLbl.Text = _DetainedLicenses.DetainID.ToString();
            DetainDateLicenseResultLbl.Text = _DetainedLicenses.DetainDate.ToString("dd/MMM/yyyy");
            DLicenseIDResultLbl.Text = _DetainedLicenses.LicenseID.ToString();
            CreatedByResultLbl.Text = ClsGlobal.CurrentUser.UserName;
            _ApplicationTypes = ClsApplicationTypes.Find(5);
            if (_ApplicationTypes == null) return;
            ApplicationFeesResultLbl.Text = _ApplicationTypes.ApplicationFees.ToString("0.##");
            TotalFeesResultLbl.Text = ((decimal)_DetainedLicenses.FineFees + _ApplicationTypes.ApplicationFees).ToString("0.##");
            FineFeesResultLbl.Text = _DetainedLicenses.FineFees.ToString();

            if (_License.IsDetained == false)
            {
                MessageBox.Show("Selected License [" + LicenseID + "] is not detained choose another one.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReleaseBtn.Enabled = true;

        }
        private void Discharge()
        {

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
            DetainIDResultLbl.Text = "[???]";
            DLicenseIDResultLbl.Text = "[???]";
            DetainDateLicenseResultLbl.Text = "[??/??/????]";
            ApplicationFeesResultLbl.Text = "[$$$$]";
            TotalFeesResultLbl.Text = "[$$$$]";
            CreatedByResultLbl.Text = ClsGlobal.CurrentUser.UserName;
            FineFeesResultLbl.Text = "[$$$$]";
            ApplicationIDResultLbl.Text = "[???]";




            ShowLicensesHistoryLinkLabel.Enabled = false;
            ShowNewLicensesInfoLinkLabel.Enabled = false;
            ReleaseBtn.Enabled = false;

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
                if (int.TryParse(SearchValue, out int LisenceID))
                {
                    _LoadDriverLicenseInfo(LisenceID);
                    _LoadDetainInfo(LisenceID);
                    ShowLicensesHistoryLinkLabel.Enabled = true;

                }
            }
        }

        private void LicenseIDBtnPictureBox_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LicenseIDTextBox.Text, out int LisenceID))
            {
                _LoadDriverLicenseInfo(LisenceID);
                _LoadDetainInfo(LisenceID);
                ShowLicensesHistoryLinkLabel.Enabled = true;

            }
        }

        private void ShowLicensesHistoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            LicenseHistoryFrm frm = new LicenseHistoryFrm(_License.ApplicationID);
            frm.ShowDialog();
        }

        private void ReleaseBtn_Click(object sender, EventArgs e)
        {
            if (_License == null || _License.IsDetained == false) return;
            if (MessageBox.Show("Are you sure you want to release this detained license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClsApplication NewApplication = new ClsApplication();
            NewApplication.ApplicantPersonID = _Person.PersonID;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.ApplicationTypeID = 5;
            NewApplication.ApplicationStatus = ClsApplication.enApplicationStatus.Completed;
            NewApplication.LastStatusDate = DateTime.Now;
            NewApplication.PaidFees = _ApplicationTypes.ApplicationFees;
            NewApplication.CreatedByUserID = ClsGlobal.CurrentUser.UserID;

            if (!NewApplication.Save())
            {
                MessageBox.Show("Failed Operation !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _DetainedLicenses = ClsDetainedLicenses.FindByLicenseID(_License.LicenseID);
            if (_DetainedLicenses == null) return;
            _DetainedLicenses.IsReleased = true;
            _DetainedLicenses.ReleaseDate = DateTime.Now;
            _DetainedLicenses.ReleasedByUserID = ClsGlobal.CurrentUser.UserID;
            _DetainedLicenses.ReleaseApplicationID = NewApplication.ApplicationID;

            if (_DetainedLicenses.Save())
            {
                MessageBox.Show("Saved Successfully ^_^");
                ReleaseBtn.Enabled = false;
                ShowNewLicensesInfoLinkLabel.Enabled = true;
                FilterGroupBox.Enabled = false;
                ApplicationIDResultLbl.Text = NewApplication.ApplicationID.ToString();

            }
            else
            {
                MessageBox.Show("Failed Operation !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void ShowNewLicensesInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoFrm frm = new LicenseInfoFrm(_License);
            frm.ShowDialog();
        }
    }
}
