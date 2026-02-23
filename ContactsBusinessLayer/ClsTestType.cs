using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClsTestType
    {
        public enum enMode { AddTestType = 0 , UpdateTestType = 1 }
        enMode Mode = enMode.AddTestType;
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set;}
        public string TestTypeDescription { get; set;}
        public decimal TestTypeFees { get; set;}

        public ClsTestType(int TestTypeID , string TestTypeTitle ,string TestTypeDescription ,decimal TestTypeFees) {
        this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees; 
            
            Mode = enMode.UpdateTestType;

        }

        private ClsTestType()
        {
            this.TestTypeID = -1;
            this.TestTypeTitle = "";
            this.TestTypeDescription = ""; 
            this.TestTypeFees = -1;
            Mode = enMode.AddTestType ;
        }
        public static DataTable GetAllTestType()
        {
            return ClsTestTypesData.GetAllTestType();   
        }
        public static ClsTestType Find(int TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestTypeFees = 0;
            if (ClsTestTypesData.GetTestTypeByTestID(TestTypeID,ref TestTypeTitle,ref TestTypeDescription, ref TestTypeFees))
            {
                return new ClsTestType(TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees);
            }
            else
            {
                return null; 
            }
        }
        public bool AddNewTestType()
        {
            return true;
        }
        public bool Save ()
        {
            switch (Mode)
            {
                case enMode.AddTestType:


                    if (AddNewTestType())
                    {
                        Mode = enMode.UpdateTestType;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateTestType:
                    return UpdateTestType();


            }                    return false;

        }
        public static int CountTestType()
        {
            return ClsTestTypesData.CountTestType();
        }

        public  bool UpdateTestType()
        {
            return ClsTestTypesData.UpdateTestType(this.TestTypeID,this.TestTypeTitle,this.TestTypeDescription,this.TestTypeFees); 
        }
    }
}
