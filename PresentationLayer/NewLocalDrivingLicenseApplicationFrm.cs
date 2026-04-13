using BusinessLayer;
using Microsoft.IdentityModel.Tokens;
using PresentationLayer.Properties;
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
    public partial class NewLocalDrivingLicenseApplicationFrm : Form
    {
        private ClsPeople _Person;
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication; 
        public NewLocalDrivingLicenseApplicationFrm()
        {
            InitializeComponent();
            _FillLicenseClassesInComboBox();
            _Discharge();
        }

        private void _LoadPersonData()
        {
            if (_Person == null)
            {
                MessageBox.Show("There is no Person");
                this.Close();
                return;

            }
            PersonIDResultLbl.Text = _Person.PersonID.ToString();
            NameResultLbl.Text = _Person.FirstName + _Person.SecondName + _Person.ThirdName + _Person.LastName;
            NationalNOResultLbl.Text = _Person.NationalNO;
            GendorResultLbl.Text = _Person.Gendor == 0 ? "Male" : "Female";
            EmailResultLbl.Text = _Person.Email;
            AddressResultLbl.Text = _Person.Address;
            DateOfBirthResultLbl.Text = _Person.DateOfBirth.ToShortDateString();
            PhoneResultLbl.Text = _Person.Phone;
            CountryResultLbl.Text = _Person.NationalityCountryID.ToString();
            if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))
                PersonPictureBox.Load(_Person.ImagePath);
            else
                PersonPictureBox.Image = (_Person.Gendor == 0) ? Resources.Male_512 : Resources.Female_512;



        }
        private void _LoadApplicationInfo()
        {
            CreatedByResultLbl.Text = ClsGlobal.CurrentUser.UserName.ToString();
            ApplicationDateResultLbl.Text = DateTime.Now.ToString();
            if (LicenseClassComboBox.SelectedValue != null)
            {
                int selectedClassID;
                if (int.TryParse(LicenseClassComboBox.SelectedValue.ToString(), out selectedClassID))
                {
                    ClsLicenseClass SelectClass = ClsLicenseClass.Find(selectedClassID);
                    if (SelectClass != null)

                    {
                        ApplicationFeesResultLbl.Text = SelectClass.ClassFees.ToString();

                    }


                }

            }
        }
        private void _Discharge()
        {
            PersonIDResultLbl.Text = "[????]";
            NameResultLbl.Text = "[????]";
            NationalNOResultLbl.Text = "[????]";
            GendorResultLbl.Text = "[????]";
            EmailResultLbl.Text = "[????]";
            AddressResultLbl.Text = "[????]";
            DateOfBirthResultLbl.Text = "[????]";
            PhoneResultLbl.Text = "[????]";
            CountryResultLbl.Text = "[????]";
            PersonPictureBox.Image = Resources.Male_512;
            FilterByComboBox.SelectedIndex = 0;
            SearchTextBox.Clear();
        }
        private void _FillLicenseClassesInComboBox()
        {
            DataTable dtClasses = ClsLicenseClass.GetAllLicenseClasses();

            if (dtClasses != null && dtClasses.Rows.Count > 0)
            {
                LicenseClassComboBox.DisplayMember = "ClassName";

                LicenseClassComboBox.ValueMember = "LicenseClassID";

                LicenseClassComboBox.DataSource = dtClasses;
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPersinInfoBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdatePersonFrm frm = new AddUpdatePersonFrm(_Person.PersonID);
            frm.ShowDialog();
        }

        private void FindUserPictureBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.IsNullOrEmpty())
            {
                if (FilterByComboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Enter the National No first !");
                }
                else
                {
                    MessageBox.Show("Enter the Person ID first !");
                }
                return;
            }

            if (FilterByComboBox.SelectedIndex == 0)
            {
                _Person = ClsPeople.Find(SearchTextBox.Text);

            }
            else if (FilterByComboBox.SelectedIndex == 1)
            {
                if (int.TryParse(SearchTextBox.Text, out int PersonID))
                {
                    _Person = ClsPeople.Find(PersonID);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Person ID (numbers only)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            if (_Person != null)
            {
                _LoadPersonData();
            }
            else
            {
                if (FilterByComboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("There is no person with National No [" + SearchTextBox.Text + "] in the system !");
                }
                else
                {
                    MessageBox.Show("There is no person with Person ID [" + SearchTextBox.Text + "] in the system !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _Discharge();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (_Person == null)
            {
                MessageBox.Show("Please Select a Person first,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApplicationInfoTabPage.SelectedIndex = 1;
            _LoadApplicationInfo();

        }

        private void AddUserPictureBox_Click(object sender, EventArgs e)
        {
            AddUpdatePersonFrm frm = new AddUpdatePersonFrm(-1);
            frm.ShowDialog();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                {
                    _Discharge();
                    _Person = null;
                    return;
                }

                _Person = ClsPeople.Find(SearchTextBox.Text);
                if (_Person != null)
                {
                    _LoadPersonData();
                }
                else
                {
                    _Discharge();
                }
            }
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                FindUserPictureBox_Click(sender, e);
            }
        }

        private void PersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void LicenseClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadApplicationInfo();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            int selectedClassID = Convert.ToInt32(LicenseClassComboBox.SelectedValue);

            if (ClsLocalDrivingLicenseApplication.IsApplicationExist(_Person.PersonID,selectedClassID))
            {
                MessageBox.Show("This Person have the same class , Choose another class !", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (_LocalDrivingLicenseApplication == null)
            {
                _LocalDrivingLicenseApplication = new ClsLocalDrivingLicenseApplication();
            }
            _LocalDrivingLicenseApplication.ApplicantPersonID = _Person.PersonID; 
            _LocalDrivingLicenseApplication.NationalNo = _Person.NationalNO;
            _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplication.ApplicationStatus = ClsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.CreatedByUserID = 1; 
            _LocalDrivingLicenseApplication.FullName = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToDecimal(ApplicationFeesResultLbl.Text) ;
            _LocalDrivingLicenseApplication.LicenseClassID = Convert.ToInt32(LicenseClassComboBox.SelectedValue);
            _LocalDrivingLicenseApplication.Status = "New"; 

            if (_LocalDrivingLicenseApplication.Save())
            {
                MessageBox.Show("Saved Successfully");
                DLApplicationIDResultLbl.Text = _LocalDrivingLicenseApplication.LDLAppID.ToString();
                SaveBtn.Enabled = false; 
                return; 

            }else
            {
                MessageBox.Show("Error", "Failed Operation");
            }

        }
    }
}
