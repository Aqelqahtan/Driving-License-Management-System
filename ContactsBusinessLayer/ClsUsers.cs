using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccsessLayer;
using DataAcsessLayer;
namespace BusinessLayer
{
    public class ClsUsers
    {

        public enum enMode { AddNewUser = 0, UpdateUser = 1 };
        enMode Mode = enMode.AddNewUser;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public ClsUsers()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = false;
            Mode = enMode.AddNewUser;

        }

        private ClsUsers(int UserID,int PersonID, string UserName, string Password , bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.UpdateUser;
        }

        private bool _AddNewUser()
        {
            this.UserID = ClsUserData.AddNewUser(this.PersonID,this.UserName, this.Password, this.IsActive);
            return (this.UserID != -1);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewUser:
                    if (_AddNewUser())
                    {
                        Mode = enMode.UpdateUser;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateUser:
                    return UpdateUser();
            }

            return false;
        }

        public static ClsUsers Find(int UserID)
        {
            int PersonID = -1; 
            string UserName = "", Password = "" ;
            bool IsActive = false;
            if (ClsUserData.GetUserByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
                  {

                    return new ClsUsers(UserID, PersonID, UserName, Password, IsActive); 
                  }
            else
                return null; 


                
        }
        public static ClsUsers Find (string UserName)
        {
            int PersonID = -1 , UserID = -1;
            string Password = ""; 
            bool IsActive = false;

            if ((ClsUserData.GetUserByUsername(UserName,ref UserID ,ref PersonID, ref Password, ref IsActive)))
            {
                return new ClsUsers (UserID,PersonID,UserName ,Password , IsActive);
            }else
            {
                return null;
            }

        }
        public bool UpdateUser()
        {
            return ClsUserData.UpdateUser(this.UserID, this.UserName, this.Password , this.IsActive);
        }

        

        public static bool DeleteUser(int UserID)
        {
            return ClsUserData.DeleteUser(UserID);
        }

        public static bool IsLogInCorrect(string UserName, string Password)
        {
            return ClsUserData.ApplicateData(UserName, Password);
        }
        public static DataTable GetAllUsers()
        {
            return ClsUserData.GetALLUser();
        }

        public static int CalculateUsers()
        {
            return ClsUserData.CalculateUsersData();
        }

        public static bool IsUserExist(int PersonID)
        {
            return ClsUserData.IsUserExist(PersonID);
        }

        public static bool IsUserExist(string UserName)
        {
            {
                return ClsUserData.IsUserExist(UserName);
            }
        }


    }
}