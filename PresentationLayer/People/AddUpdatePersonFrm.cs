using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.IO; // for put photos in file 
namespace PresentationLayer
{
    public partial class AddUpdatePersonFrm : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };
        public enMode _Mode;

        private int _PersonID;
        private ClsPeople _Person;
        public AddUpdatePersonFrm(int PersonID)
        {
            InitializeComponent();
            enMode _Mode = enMode.Update;
            _PersonID = PersonID;


        }
        private AddUpdatePersonFrm()
        {
            InitializeComponent();
            enMode _Mode = enMode.AddNew;

        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();
            if (_Mode == enMode.AddNew)
            {

                ModeLbl.Text = "Add New User";
                _Person = new ClsPeople();

            }
            else
            {
                ModeLbl.Text = "Update Person";
            }

            if (MaleButton.Checked)
            {
                PersonGendorPicture.Image = Properties.Resources.Male_512;
            }
            else PersonGendorPicture.Image = Properties.Resources.Female_512;

            RemoveLinkLabel.Visible = PersonGendorPicture.Image != null;
            FirstNametextBox.Text = string.Empty;
            DateOfBirthPaker.MaxDate = DateTime.Now.AddYears(-18); 
            DateOfBirthPaker.Value = DateTime.Now.AddYears(-18);
            DateOfBirthPaker.MinDate = DateTime.Now.AddYears(-100); 
            SecondNametextBox.Text = string.Empty;
            ThirdNametextBox.Text = string.Empty;
            LastNametextBox.Text = string.Empty;
            NationalNOtextBox.Text = string.Empty;
            DateOfBirthPaker.Text = string.Empty;
            PhonetextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            AddresstextBox.Text = string.Empty;
            CountrycomboBox.SelectedIndex = CountrycomboBox.FindString("Jordan");
            MaleButton.Text = string.Empty;
            FemaleButton.Text = string.Empty;
            SetImageLinkLbl.Text = string.Empty;
            RemoveLinkLabel.Text = string.Empty;
            SaveBtn.Enabled = false;

        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = ClsCountry.GetAllCountries();

            if (dtCountries.Rows.Count > 0)
            {
                CountrycomboBox.DataSource = dtCountries;

                CountrycomboBox.DisplayMember = "CountryName";

                CountrycomboBox.ValueMember = "CountryID";
            }
        }



        private void _LoadData()
        {

            _Person = ClsPeople.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("There is no Person" + _PersonID.ToString());
                this.Close();
                return;
            }

            PersonIDResultLbl.Text = _PersonID.ToString();
            FirstNametextBox.Text = _Person.FirstName;
            SecondNametextBox.Text = _Person.SecondName;
            ThirdNametextBox.Text = _Person.ThirdName;
            LastNametextBox.Text = _Person.LastName;
            NationalNOtextBox.Text = _Person.NationalNO;
            DateOfBirthPaker.Value = _Person.DateOfBirth;
            PhonetextBox.Text = _Person.Phone;
            EmailtextBox.Text = _Person.Email;
            AddresstextBox.Text = _Person.Address;
            CountrycomboBox.SelectedValue = _Person.NationalityCountryID;

            if (_Person.Gendor == 0)
                MaleButton.Checked = true;
            else
                FemaleButton.Checked = true;

            if (_Person.ImagePath != "" && _Person.ImagePath != null)
            {
                if (System.IO.File.Exists(_Person.ImagePath))
                {
                    PersonGendorPicture.Load(_Person.ImagePath);
                    RemoveLinkLabel.Visible = true;
                }
            }
            else
            {
                if (_Person.Gendor == 0)

                    PersonGendorPicture.Image = Properties.Resources.Male_512;
                else

                    PersonGendorPicture.Image = Properties.Resources.Female_512;

            }

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleButton.Checked)
            {
                PersonGendorPicture.Image = Properties.Resources.Male_512;
            }
        }

        private void FemaleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleButton.Checked)
            {
                PersonGendorPicture.Image = Properties.Resources.Female_512;
            }
        }
        private void _DisableAllControls()
        {
            FirstNametextBox.Enabled = false;
            SecondNametextBox.Enabled = false;
            ThirdNametextBox.Enabled = false;
            LastNametextBox.Enabled = false;
            NationalNOtextBox.Enabled = false;
            DateOfBirthPaker.Enabled = false;
            PhonetextBox.Enabled = false;
            EmailtextBox.Enabled = false;
            AddresstextBox.Enabled = false;
            CountrycomboBox.Enabled = false;
            MaleButton.Enabled = false;
            FemaleButton.Enabled = false;
            SetImageLinkLbl.Enabled = false;
            RemoveLinkLabel.Enabled = false;
            SaveBtn.Enabled = false;
        }
        private string _CopyImageToProjectFolder(string SourceImagePath)
        {
            if (string.IsNullOrEmpty(SourceImagePath))
            {
                return "";
            }

            try
            {
                string ImageFolder = @"C:\PersonImages\";
                if (!System.IO.Directory.Exists(ImageFolder))
                {
                    System.IO.Directory.CreateDirectory(ImageFolder);
                }

                string extension = System.IO.Path.GetExtension(SourceImagePath);
                string newFileName = $"Person_{Guid.NewGuid()}{extension}";
                string destinationPath = System.IO.Path.Combine(ImageFolder, newFileName);
                System.IO.File.Copy(SourceImagePath, destinationPath, true);
                return destinationPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying image: " + ex.Message);
                return "";
            }
        }
       // private bool Validate
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            _Person.FirstName = FirstNametextBox.Text;
            _Person.SecondName = SecondNametextBox.Text;
            _Person.ThirdName = ThirdNametextBox.Text;
            _Person.LastName = LastNametextBox.Text;
            _Person.NationalNO = NationalNOtextBox.Text;
            _Person.DateOfBirth = DateOfBirthPaker.Value;
            if (MaleButton.Checked)
            {
                _Person.Gendor = 0;
            }
            else
            {
                _Person.Gendor = 1;
            }
            _Person.NationalityCountryID = (int)CountrycomboBox.SelectedValue;
            _Person.Phone = PhonetextBox.Text;
            _Person.Email = EmailtextBox.Text;
            _Person.Address = AddresstextBox.Text;
            if (PersonGendorPicture.ImageLocation != _Person.ImagePath)
            {
                if (PersonGendorPicture.ImageLocation != null)

                    _Person.ImagePath = _CopyImageToProjectFolder(PersonGendorPicture.ImageLocation);
                else
                    _Person.ImagePath = "";
            }

            if (_Person.Save())
            {

                PersonIDResultLbl.Text = _Person.PersonID.ToString();
                MessageBox.Show("Saved Succsessfully");
                _DisableAllControls();
            }
            else
            {
                MessageBox.Show("Error Failed Save Operation !!");
            }


        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode == enMode.Update)
            {
                _LoadData(); 
            }
        }

    

        private void NationalNOtextBox_Validating(object sender, CancelEventArgs e)
        {

            if (_Mode == enMode.AddNew && ClsPeople.isNationalNoExist(NationalNOtextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(NationalNOtextBox, "This National NO already in the system");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void EmailtextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
                return;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(EmailtextBox.Text, emailPattern))
            {
                e.Cancel = true;
                errorProvider1.SetError(EmailtextBox, "Invailed Email Address Format!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();

            }

        }

        private void AddresstextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddresstextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(AddresstextBox, "Address Can't Be Empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void SetImageLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PersonGendorPicture.ImageLocation = openFileDialog1.FileName;
                RemoveLinkLabel.Visible = true;
            }

        }

      

        private void RemoveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}



