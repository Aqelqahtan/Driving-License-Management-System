using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAcsessLayer; 

namespace BusinessLayer
{
    public class ClsPeople
    {
        public enum enMode { AddNew = 0, UpdateNew = 1 };
        public enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNO { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public ClsPeople()
        {
            this.PersonID = -1;
            this.NationalNO = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now.AddYears(-18);
            this.Gendor = 0 ;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            Mode = enMode.AddNew;
        }

        private ClsPeople(int PersonID, string NationalNO, string FirstName, string SecondName, string ThirdName,
          string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone,
          string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNO = NationalNO;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.UpdateNew;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = DataAcsessLayer.PersonData.AddNewPerson(this.NationalNO, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
           this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);

        }

        private bool _UpdateContact()
        {
            return DataAcsessLayer.PersonData.UpdatePerson(this.PersonID, this.NationalNO, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
            this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);


        }
        public static ClsPeople Find(int PersonID)
        {
            string NationalNo ="";
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",  Address = "", Phone = "", Email = "", ImagePath = "";
            int NationalityCountryID = -1;
            byte Gendor = 0; 
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);

            if (DataAcsessLayer.PersonData.GetPersonInfoByID(PersonID,ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
          ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone,
          ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new ClsPeople(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
                return null;

        }
        public static ClsPeople Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            int NationalityCountryID = -1;
            byte Gendor = 0;
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);

            if (DataAcsessLayer.PersonData.GetPersonInfoByNationalNo( NationalNo,  ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
          ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone,
          ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new ClsPeople(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.UpdateNew;
                        return true;
                    }

                    else { return false; }


                case enMode.UpdateNew:
                    return _UpdateContact();

            }
            return false;
        }

        public static DataTable GetAllPerson()
        {
            return DataAcsessLayer.PersonData.GetAllPeople();
        }

        public static bool DeletePerson(int PersonID)
        {
            return DataAcsessLayer.PersonData.DeletePersons(PersonID);
        }

        public static bool isContactExist(int PersonID)
        {
            return DataAcsessLayer.PersonData.isContactExist(PersonID);

        }

        public static bool isNationalNoExist(string NationalNo)
        {
            return DataAcsessLayer.PersonData.isNationalNoExist(NationalNo);
        }
        public static int GetTotalPerson()
        {
            return DataAcsessLayer.PersonData.CollectTotalPerson();
        }
    }
}
