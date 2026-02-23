using BusinessLayer;
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
    public partial class PersonDetailsFrm : Form
    {
        private int _PersonID;
        private ClsPeople _Person;
        public PersonDetailsFrm(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        private PersonDetailsFrm()
        {
            _LoadData();
        }
       
        private void _LoadData()
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
                PicturePersonPictureBox.Load(_Person.ImagePath);
            else
                PicturePersonPictureBox.Image = (_Person.Gendor == 0) ? Resources.Male_512 : Resources.Female_512;
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void EditPersinInfoBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AddUpdatePersonFrm frm = new AddUpdatePersonFrm(_Person.PersonID);
            frm.ShowDialog();

            _LoadData(); 
            

        }

        private void PersonDetailsFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
