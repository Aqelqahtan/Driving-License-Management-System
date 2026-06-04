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
    public partial class NewInternationalLicenseApplicationFrm : Form
    {
        private ClsDriver _Driver;
        private ClsApplication _Application;
        private ClsLicense _License;
        private ClsPeople _Person;
        private ClsUsers _User;
        private ClsApplicationTypes _ApplicationTypes;
        private ClsInternationalLicense _InternationalLicense;
        public NewInternationalLicenseApplicationFrm()
        {
            InitializeComponent();
        }

        private void _LoadDriverLicenseInfo(int LicenseID)
        {

            _License = ClsLicense.Find(LicenseID);
            if (_License == null)
            {
                MessageBox.Show("No license found with this ID!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClassResultLbl.Text = _License.LicenseClass.ToString();
            IsActiveResultLbl.Text = _License.IsActive ? "Yes" : "No";
            IssueDateLocalLicenseResultLbl.Text = _License.IssueDate.ToString("dd/MMM/yyyy");
            ExpirationDateLocalResonResultLbl.Text = _License.ExpirationDate.ToString("dd/MMM/yyyy");
            IsDetainedResultLbl.Text = _License.IsDetained ? "Yes" : "No";
            IssueReasonResultLbl.Text = _License.IssueReason.ToString();
            LicenseIDResultLbl.Text = _License.LicenseID.ToString();
            if (_License.Notes != null)
            {
                NoteResultLbl.Text = _License.Notes.ToString();
            }
            else { NoteResultLbl.Text = ""; }


            DriverIDResultLbl.Text = _License.DriverID.ToString();
            _Driver = ClsDriver.FindByDriverID(_License.DriverID);
            if (_Driver == null) return;

            _Person = ClsPeople.Find(_Driver.PersonID);

            if (_Person == null) return;
            NameResultLbl.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            GendorResultLbl.Text = _Person.Gendor == 0 ? "Male" : "Female";
            NationalNoResultLbl.Text = _Person.NationalNO.ToString();
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
        private void _LoadApplicationInfo(int LicenseID)
        {
            if (_License == null) return;
            ILApplicationIDResultLbl.Text = "[???]";
            IntLicenseIDResultLbl.Text = "[???]";

            LocalLicenseIDResultLbl.Text = LicenseID.ToString();
            ApplicationDateNationalLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lssueDateNationalLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            ExpirationNationalLicenseResultLbl.Text = DateTime.Now.AddYears(1).ToString("dd/MMM/yyyy");

            _Application = ClsApplication.FindBaseApplication(_License.ApplicationID);

            if (_Application == null) return;
            _ApplicationTypes = ClsApplicationTypes.Find(6);
            if (_ApplicationTypes == null) return;
            FeesResultLbl.Text = Convert.ToInt32(_ApplicationTypes.ApplicationFees).ToString();



            CreatedByResultLbl.Text = ClsGlobal.CurrentUser.UserName;

        }
        private void _ResetDefaultValues()
        {

            ShowLicensesInfoLinkLabel.Visible = false;
            _License = null;
            _Driver = null;
            _Person = null;
            _Application = null;
            _ApplicationTypes = null;

            ClassResultLbl.Text = "[????]";
            NameResultLbl.Text = "[????]";
            LicenseIDResultLbl.Text = "[????]";
            NationalNoResultLbl.Text = "[????]";
            GendorResultLbl.Text = "[????]";
            PicturePersonPictureBox.Image = null;
            IssueDateLocalLicenseResultLbl.Text = "[????]";
            IssueReasonResultLbl.Text = "[????]";
            NoteResultLbl.Text = "[????]";
            IsActiveResultLbl.Text = "[????]";
            DateOfBirthResultLbl.Text = "[????]";
            DriverIDResultLbl.Text = "[????]";
            ExpirationDateLocalResonResultLbl.Text = "[????]";
            IsDetainedResultLbl.Text = "[????]";

            ILApplicationIDResultLbl.Text = "[????]";
            IntLicenseIDResultLbl.Text = "[????]";
            LocalLicenseIDResultLbl.Text = "[????]";
            ApplicationDateNationalLicenseResultLbl.Text = "[????]";
            lssueDateNationalLicenseResultLbl.Text = "[????]";
            ExpirationNationalLicenseResultLbl.Text = "[????]";
            FeesResultLbl.Text = "[????]";
            CreatedByResultLbl.Text = "[????]";
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            if (_License == null)
            {
                MessageBox.Show("Please Find License Number First", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_License.IsActive == true && _License.LicenseClass == 3 &&
                _License.ExpirationDate > DateTime.Now)
            {
                int ActiveInternationalLicenseID = ClsInternationalLicense.GetInternationalLicenseIDByDriverID(_License.DriverID);
                if (ActiveInternationalLicenseID != -1)
                {

                    MessageBox.Show("This user already has an active international license with ID: " + ActiveInternationalLicenseID + "\nYou cannot issue a new one for this driver.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    return;
                }
                if (MessageBox.Show("Are You Sure To Issue International For This Driver ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                {
                    ClsInternationalLicense InternationalLicense = new ClsInternationalLicense();
                    InternationalLicense.ApplicantPersonID = _Person.PersonID;
                    InternationalLicense.ApplicationDate = DateTime.Now;
                    InternationalLicense.ApplicationStatus = ClsApplication.enApplicationStatus.New;
                    InternationalLicense.PaidFees = Convert.ToDecimal(FeesResultLbl.Text);
                    InternationalLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                    InternationalLicense.DriverID = _Driver.DriverID;
                    InternationalLicense.IssuedUsingLocalLicenseID = _License.LicenseID;
                    InternationalLicense.IssueDate = DateTime.Now;
                    InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
                    InternationalLicense.IsActive = true;
                    InternationalLicense.LastStatusDate = DateTime.Now;
                    InternationalLicense.ApplicationTypeID = 6;
                    if (InternationalLicense.Save())
                    {
                        MessageBox.Show("Issued Sucssessfully");
                        IssueBtn.Enabled = false;
                        ILApplicationIDResultLbl.Text = InternationalLicense.ApplicationID.ToString();
                        IntLicenseIDResultLbl.Text = InternationalLicense.InternationalLicenseID.ToString();
                        ShowLicensesInfoLinkLabel.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Failed Operation !", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error", "Requirment is not applicated ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string SearchValue = SearchTextBox.Text.Trim();
                if (int.TryParse(SearchValue, out int LicenseID))
                {
                    _LoadDriverLicenseInfo(LicenseID);
                    _LoadApplicationInfo(LicenseID);
                    int ActiveInternationalLicenseID = ClsInternationalLicense.GetInternationalLicenseIDByDriverID(_License.DriverID);
                    if (ActiveInternationalLicenseID != -1)
                    {

                        ShowLicensesInfoLinkLabel.Visible = true;
                    }

                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string SearchValue = SearchTextBox.Text.Trim();

            if (int.TryParse(SearchValue, out int LicenseID))
            {
                _LoadDriverLicenseInfo(LicenseID);
               
               
                _LoadApplicationInfo(LicenseID);
                int ActiveInternationalLicenseID = ClsInternationalLicense.GetInternationalLicenseIDByDriverID(_License.DriverID);
                if (ActiveInternationalLicenseID != -1)
                {

                    ShowLicensesInfoLinkLabel.Visible = true;
                    ShowLicensesInfoLinkLabel.Enabled = true;

                  
                    IntLicenseIDResultLbl.Text = ActiveInternationalLicenseID.ToString();
                   _InternationalLicense = ClsInternationalLicense.Find(ActiveInternationalLicenseID);
                    ILApplicationIDResultLbl.Text =  _InternationalLicense.ApplicationID.ToString();
                }
            }
        }
        

        private void ShowLicensesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (_License == null) return;
            LicenseHistoryFrm frm = new LicenseHistoryFrm(_License.ApplicationID);
            frm.ShowDialog();

        }

     
        private void ShowLicensesInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (int.TryParse(IntLicenseIDResultLbl.Text, out int InternationalLicenseID))
            {
                InternationalDriverInfoFrm frm = new InternationalDriverInfoFrm(InternationalLicenseID);
                frm.ShowDialog();
            }
        }
    }
}
