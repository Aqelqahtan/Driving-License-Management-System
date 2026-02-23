using BusinessLayer;
using DataAccsessLayer;
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
    public partial class CurrentUserInfofrm : Form
    {
       
        private ClsUsers _User;
        private ClsPeople _Person;
      
        public CurrentUserInfofrm()
        {
            InitializeComponent();
            

        }
        private void _LoadPersonData()
        {
          _Person = ClsPeople.Find(_User.PersonID);
            if (_Person == null)
            {
                MessageBox.Show("There is no person !");
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
        private void _LoadUserData()
        {
            _User = ClsGlobal.CurrentUser;
           
            if (_User == null)
            {
                MessageBox.Show("There is no User ");
                this.Close();
                return;
            }
            UserIDResultLbl.Text = _User.UserID.ToString();
            UsernameResultLbl.Text = _User.UserName;
            IsActiveResultLbl.Text = _User.IsActive == true ? "Yes" : "No";
        }
        private void CurrentUserInfofrm_Load(object sender, EventArgs e)
        {
            _LoadUserData();
            _LoadPersonData();
        }

       
    }
}
