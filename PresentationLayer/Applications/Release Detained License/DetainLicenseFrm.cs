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
    public partial class DetainLicenseFrm : Form
    {
        private ClsPeople _Person;
        private ClsLicense _License;
        private ClsApplication _Application;
        private ClsLicenseClass _LicenseClass;


        private ClsLicense NewLicense;
        public DetainLicenseFrm()
        {
            InitializeComponent();
            Discharge();
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
            DetainIDResultLbl.Text = "[???]";
            DetainDateLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            DLicenseIDResultLbl.Text = "[???]";
            CreatedByResultLbl.Text = ClsGlobal.CurrentUser.UserName;

            if (_License.IsDetained == true)
            {
                MessageBox.Show("Selected License [" + LicenseID + "] already detained choose another one.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DetainBtn.Enabled = true;
            /*  else if (_License.ExpirationDate < DateTime.Now)
              {

                  MessageBox.Show("Selected License [" + LicenseID + "] is Expired Renew it first.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;

              }
            */
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
            DetainDateLicenseResultLbl.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            FineFeesTextBox.Text = string.Empty;
            CreatedByResultLbl.Text = ClsGlobal.CurrentUser.UserName;




            ShowLicensesHistoryLinkLabel.Enabled = false;
            ShowNewLicensesInfoLinkLabel.Enabled = false;
            DetainBtn.Enabled = false;

        }

        private void LicenseIDTextBox_TextChanged(object sender, EventArgs e)
        {
            Discharge();
        }

        private void ShowNewLicensesInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoFrm frm = new LicenseInfoFrm(_License);
            frm.ShowDialog();
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
                    _LoadDetainInfo(LicenseID);
                    ShowLicensesHistoryLinkLabel.Enabled = true;

                }
            }
        }

        private void LicenseIDBtnPictureBox_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LicenseIDTextBox.Text, out int LicenseID))
            {
                _LoadDriverLicenseInfo(LicenseID);
                _LoadDetainInfo(LicenseID);
                ShowLicensesHistoryLinkLabel.Enabled = true;
            }
        }

        private void ShowLicensesHistoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _License = ClsLicense.Find(_License.LicenseID);
            if (_License != null)
            {

                LicenseHistoryFrm frm = new LicenseHistoryFrm(_License.ApplicationID);
                frm.ShowDialog();

            }
        }

        private void DetainBtn_Click(object sender, EventArgs e)
        {
            if (_License == null || _License.IsDetained == true)
                return;
            if (string.IsNullOrEmpty(FineFeesTextBox.Text))
            {
                MessageBox.Show("Please Enter The Fine Fees First !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to Detain this License?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)

            {
                return;

            }


            ClsDetainedLicenses DetainedLicense = new ClsDetainedLicenses();
            DetainedLicense.LicenseID = _License.LicenseID;
            DetainedLicense.DetainDate = DateTime.Now;
            DetainedLicense.FineFees = Convert.ToSingle(FineFeesTextBox.Text);
            DetainedLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;


            if (DetainedLicense.Save())
            {

                MessageBox.Show("License Detained Successfully with ID = " + _License.LicenseID, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DetainIDResultLbl.Text = DetainedLicense.DetainID.ToString();
                DLicenseIDResultLbl.Text = _License.LicenseID.ToString();
                ShowNewLicensesInfoLinkLabel.Enabled = true;
                DetainBtn.Enabled = false;
                FilterGroupBox.Enabled = false;

            }
            else
            {
                MessageBox.Show("Failed Operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FineFeesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       
    }
}


