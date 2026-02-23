using System;
using System.Data;
using DataAccsessLayer; 



namespace BusinessLayer
{
    public class ClsCountry
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string CountryName { set; get; }
        public string Code { set; get; }
        public string PhoneCode { set; get; }


        public ClsCountry()

        {
            this.ID = -1;
            this.CountryName = "";

            Mode = enMode.AddNew;

        }

        private ClsCountry(int ID, string CountryName, string Code, string PhoneCode)

        {
            this.ID = ID;
            this.CountryName = CountryName;
            this.Code = Code;
            this.PhoneCode = PhoneCode;

            Mode = enMode.Update;

        }

        private bool _AddNewCountry()
        {
            //call DataAccess Layer 

            this.ID = ClsCountryData.AddNewCountry(this.CountryName, this.Code, this.PhoneCode);

            return (this.ID != -1);
        }

        private bool _UpdateContact()
        {
            //call DataAccess Layer 

            return ClsCountryData.UpdateCountry(this.ID, this.CountryName, this.Code, this.PhoneCode);

        }

        public static ClsCountry Find(int ID)
        {

            string CountryName = "";
            string Code = "";
            string PhoneCode = "";


            int CountryID = -1;

            if (ClsCountryData.GetCountryInfoByID(ID, ref CountryName, ref Code, ref PhoneCode))

                return new ClsCountry(ID, CountryName, Code, PhoneCode);
            else
                return null;

        }

        public static ClsCountry Find(string CountryName)
        {

            int ID = -1;
            string Code = "";
            string PhoneCode = "";


            if (ClsCountryData.GetCountryInfoByName(CountryName, ref ID, ref Code, ref PhoneCode))

                return new ClsCountry(ID, CountryName, Code, PhoneCode);
            else
                return null;

        }


        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateContact();

            }




            return false;
        }

        public static DataTable GetAllCountries()
        {
            return ClsCountryData.GetAllCountries();

        }

        public static bool DeleteCountry(int ID)
        {
            return ClsCountryData.DeleteCountry(ID);
        }

        public static bool isCountryExist(int ID)
        {
            return ClsCountryData.IsCountryExist(ID);
        }

        public static bool isCountryExist(string CountryName)
        {
            return ClsCountryData.IsCountryExist(CountryName);
        }



    }



}

