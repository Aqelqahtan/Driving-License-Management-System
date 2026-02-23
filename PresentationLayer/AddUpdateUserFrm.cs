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
    public partial class AddUpdateUserFrm : Form
    {
        
        private ClsPeople _Person;
        private ClsUsers _User ;
        public AddUpdateUserFrm()
        {
            InitializeComponent();
            _Discharge();
        }

       
        private void _FillDataPerson()
        {
        
            if (_Person == null)
            {
                MessageBox.Show("There is no Person");
                this.Close();
                return;

            }
            ManagePeopleLbl.Text = "Update User";
            PersonIDResultLbl.Text = _Person.PersonID.ToString();
            NameResultLbl.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            NationalNOResultLbl.Text = _Person.NationalNO;
            GendorResultLbl.Text = _Person.Gendor == 0 ? " Male" : "Female";
            EmailResultLbl.Text = _Person.Email;
            AddressResultLbl.Text = _Person.Address;
            DateOfBirthResultLbl.Text = _Person.DateOfBirth.ToString();
            PhoneResultLbl.Text = _Person.Phone;
            CountryResultLbl.Text = _Person.NationalityCountryID.ToString();
            if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))
            {
                PersonPictureBox.Load(_Person.ImagePath);
            }
            else
                PersonPictureBox.Image = (_Person.Gendor == 0) ? Resources.Male_512 : Resources.Female_512;


        }

        private void _CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            SearchTextBox.Clear();

        }
        private void FilterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void AddNewUserFrm_Load(object sender, EventArgs e)
        {
            FilterByComboBox.SelectedIndex = 0;
            _Discharge();
        }

        private void EditPersinInfoBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            AddUpdatePersonFrm frm = new AddUpdatePersonFrm(_User.PersonID);
            frm.ShowDialog();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindUserPictureBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Enter the NationalNo First !");
                return;

            }
            _Person = ClsPeople.Find(SearchTextBox.Text);
            if (_Person != null)
            {
                _FillDataPerson();
            }
            else
            {
                MessageBox.Show("The Person is not in the system");
            }


        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (_Person == null)
            {
                MessageBox.Show("Please Select a Person first,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ClsUsers.IsUserExist(_Person.PersonID))
            {
                MessageBox.Show("Selected Person Already has a user , choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabControl1.SelectedIndex = 1;

            }
        }

        private void UserNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameTextBox.Text))
            {
                e.Cancel = true;
                UserNameTextBox.Focus();
                errorProvider1.SetError(UserNameTextBox, "Username can not be blank !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(UserNameTextBox, "");

            }
        }

        private void ConfrimPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (PasswordTextBox.Text != ConfrimPasswordTextBox.Text)
            {
                //  e.Cancel = true;

                errorProvider1.SetError(ConfrimPasswordTextBox, "Password Confirmation does not match Password!");
            }
            else
            {

                errorProvider1.SetError(ConfrimPasswordTextBox, "");

            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                if (_Person == null)
                {
                    e.Cancel = true;
                    MessageBox.Show("Please Select a Person First", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {


            if (_Person == null)
            {
                MessageBox.Show("Please Select a Person First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (string.IsNullOrEmpty(UserNameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text) || string.IsNullOrEmpty(ConfrimPasswordTextBox.Text))
            {
                MessageBox.Show("Can not add user in the system you should enter all of Data!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PasswordTextBox.Text != ConfrimPasswordTextBox.Text)
            {
                MessageBox.Show("you must write the correct confirm password and the same password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClsUsers.IsUserExist(UserNameTextBox.Text))
            {
                MessageBox.Show("The username that you insert already in the system choose differnt username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _User.PersonID = _Person.PersonID;
            _User.UserName = UserNameTextBox.Text;
            _User.Password = PasswordTextBox.Text;
            _User.IsActive = IsActiveCheckBox.Checked;

            if (_User.Save())
            {
                MessageBox.Show("Saving New User Pass");
                UserIDLbl.Text = _User.UserID.ToString();
                UserNameTextBox.Enabled = false;
                PasswordTextBox.Enabled = false;
                ConfrimPasswordTextBox.Enabled = false;
                IsActiveCheckBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Saving Failed !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void AddUserPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

