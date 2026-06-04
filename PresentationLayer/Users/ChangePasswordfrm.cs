using BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ChangePasswordfrm : Form
    {
        private int _PersonID;
        private int _UserID;
        private ClsPeople _Person;
        private ClsUsers _User;
        public ChangePasswordfrm(int PersonID, int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _PersonID = PersonID;

        }
        private void _LoadDataPerson()
        {
            _Person = ClsPeople.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("There is no Person with" + _PersonID);
                this.Close();
                return;
            }

            PersonIDResultLbl.Text = _Person.PersonID.ToString();
            NationalNOResultLbl.Text = _Person.NationalNO;
            GendorResultLbl.Text = _Person.Gendor == 0 ? "Male" : "Female";
            EmailResultLbl.Text = _Person.Email;
            AddressResultLbl.Text = _Person.Address;
            DateOfBirthResultLbl.Text = _Person.DateOfBirth.ToShortDateString();
            PhoneResultLbl.Text = _Person.Phone;
            CountryResultLbl.Text = _Person.NationalityCountryID.ToString();
            NameResultLbl.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))
                PersonPictureBox.Load(_Person.ImagePath);
            else
                PersonPictureBox.Image = (_Person.Gendor == 0) ? Resources.Male_512 : Resources.Female_512;

        }
        private void _LoadDataUser()
        {
            _User = ClsUsers.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("There is no User with" + _UserID);
                this.Close();
                return;
            }
            UserIDResultLbl.Text = _User.UserID.ToString();
            UsernameResultLbl.Text = _User.UserName;
            IsActiveResultLbl.Text = _User.IsActive == true ? "Yes" : "No";
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePasswordfrm_Load(object sender, EventArgs e)
        {
            _LoadDataPerson();
            _LoadDataUser();
        }

        private void CurrentPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            
            if (_User.Password != CurrentPasswordTextBox.Text)
            {
                e.Cancel = true;
                CurrentPasswordTextBox.Focus();
                errorProvider1.SetError(CurrentPasswordTextBox, "The current password is wrong !");

            }
            else
            {
                errorProvider1.SetError(CurrentPasswordTextBox, "");
                e.Cancel = false;
            }
        }

        private void ConfirmPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (ConfirmPasswordTextBox.Text != NewPasswordTextBox.Text)
            {
                errorProvider1.SetError(ConfirmPasswordTextBox, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(ConfirmPasswordTextBox, "");
                
                e.Cancel = false;
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (_User == null)
            {

                MessageBox.Show("Error Failed Operation !");
                return;
            }

            if (string.IsNullOrEmpty(CurrentPasswordTextBox.Text) || string.IsNullOrEmpty(NewPasswordTextBox.Text) || string.IsNullOrEmpty(ConfirmPasswordTextBox.Text))
            {
                MessageBox.Show("You should enter your old password after that enter your new password with confirming !!");
                return;
            }

            if (ConfirmPasswordTextBox.Text != NewPasswordTextBox.Text)
            {
                MessageBox.Show("you can not update the password because the new password not the same current password", "Error Updating Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = ConfirmPasswordTextBox.Text;

            if (_User.Save())
            {
                MessageBox.Show("Updating Succsess");
                CurrentPasswordTextBox.Enabled = false;
                NewPasswordTextBox.Enabled = false;
                ConfirmPasswordTextBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Updating Failed !");
            }

        }

        private void NewPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (CurrentPasswordTextBox.Text == NewPasswordTextBox.Text)
            {
                errorProvider1.SetError(NewPasswordTextBox, "The password should be new ");
               
            }
            else
            {
                errorProvider1.SetError(NewPasswordTextBox, ""); 

            }


        }
    }
}
