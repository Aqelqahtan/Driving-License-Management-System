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
        public enMode _Mode;

        private int _PersonID;
        private ClsPeople _People;
        public AddUpdatePersonFrm(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;


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

        private AddUpdatePersonFrm()
        {
            InitializeComponent();
            _PersonID = -1;
        }

        private void _LoadData()
        {
            _FillCountriesInComboBox();
            CountrycomboBox.SelectedIndex = 0;
            if (_PersonID == -1)
            {
                ModeLbl.Text = "Add New User";
                _People = new ClsPeople();
                return;
            }

            _People = ClsPeople.Find(_PersonID);
            if (_People == null)
            {
                MessageBox.Show("There is no Person" + _PersonID.ToString());
                this.Close();
                return;
            }
            ModeLbl.Text = "Update Person";
            PersonIDResultLbl.Text = _PersonID.ToString();
            FirstNametextBox.Text = _People.FirstName;
            SecondNametextBox.Text = _People.SecondName;
            ThirdNametextBox.Text = _People.ThirdName;
            LastNametextBox.Text = _People.LastName;
            NationalNOtextBox.Text = _People.NationalNO;
            DateOfBirthPaker.Value = _People.DateOfBirth;
            PhonetextBox.Text = _People.Phone;
            EmailtextBox.Text = _People.Email;
            AddresstextBox.Text = _People.Address;
            CountrycomboBox.SelectedValue = _People.NationalityCountryID;

            if (_People.Gendor == 0)
                MaleButton.Checked = true;
            else
                FemaleButton.Checked = true;

            if (_People.ImagePath != "" && _People.ImagePath != null)
            {
                if (System.IO.File.Exists(_People.ImagePath))
                {
                    PersonGendorPicture.Load(_People.ImagePath);
                    RemoveLinkLabel.Visible = true;
                }
            }
            else
            {
                if (_People.Gendor == 0)

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
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            _People.FirstName = FirstNametextBox.Text;
            _People.SecondName = SecondNametextBox.Text;
            _People.ThirdName = ThirdNametextBox.Text;
            _People.LastName = LastNametextBox.Text;
            _People.NationalNO = NationalNOtextBox.Text;
            _People.DateOfBirth = DateOfBirthPaker.Value;
            if (MaleButton.Checked)
            {
                _People.Gendor = 0;
            }
            else
            {
                _People.Gendor = 1;
            }
            _People.NationalityCountryID = (int)CountrycomboBox.SelectedValue;
            _People.Phone = PhonetextBox.Text;
            _People.Email = EmailtextBox.Text;
            _People.Address = AddresstextBox.Text;
            if (PersonGendorPicture.ImageLocation != _People.ImagePath)
            {
                if (PersonGendorPicture.ImageLocation != null)

                    _People.ImagePath = _CopyImageToProjectFolder(PersonGendorPicture.ImageLocation);
                else
                    _People.ImagePath = "";
            }

            if (_People.Save())
            {

                PersonIDResultLbl.Text = _People.PersonID.ToString();
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
            _FillCountriesInComboBox();
            _LoadData();
        }

        private void AddNewUser_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Now.AddYears(-18) < DateOfBirthPaker.Value)
            {
                e.Cancel = true;
                MessageBox.Show("You Should Complete 18 Years exactly !!");
            }
            else
            {
                e.Cancel = false;
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

        private void RemoveLinkLabel_MouseClick(object sender, MouseEventArgs e)
        {
            PersonGendorPicture.Image = null;
            if (MaleButton.Checked) { PersonGendorPicture.Image = Properties.Resources.Male_512; }
            if (FemaleButton.Checked) { PersonGendorPicture.Image = Properties.Resources.Female_512; }

            RemoveLinkLabel.Visible = false;
        }

      
    }
}



