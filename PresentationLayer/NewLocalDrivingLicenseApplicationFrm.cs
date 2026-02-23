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
        public NewLocalDrivingLicenseApplicationFrm()
        {
            InitializeComponent();
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
                int selectedClassID = Convert.ToInt32(LicenseClassComboBox.SelectedValue);
                ClsLicenseClass SelectClass = ClsLicenseClass.Find(selectedClassID);
                if (SelectClass != null)
                {
                    {
                        ApplicationFeesResultLbl.Text = SelectClass.ClassName.ToString();
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
                MessageBox.Show("Enter the National No first !");
                return;
            }

            _Person = ClsPeople.Find(SearchTextBox.Text);
            if (_Person != null)
            {
                _LoadPersonData();
            }
            else
            {
                MessageBox.Show("There is no person with [" + SearchTextBox.Text + "] in the system !");
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
    }
}
