using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using DataAcsessLayer;
using System.ComponentModel.Design;

namespace DataAccsessLayer
{
    public class ClsUserData
    {
        public static bool GetUserByUserID(int UserID,ref int PersonID,ref string UserName,ref string Password,ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select *From Users where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }

            finally {connection.Close();}

            return IsFound;


         }
        public static bool GetUserByUsername(string UserName , ref int UserID , ref int PersonID , ref string Password , ref bool IsActive)
        {
            bool IsFound = false; 
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString) ;
            string query = "select *from Users where Username = @Username"; 
            SqlCommand command = new SqlCommand (query, connection);
            command.Parameters.AddWithValue("@Username" , UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"]; 
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"]; 

                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error , Failed Operation !"); return false; }
            finally {connection.Close();}
            return IsFound;
            }

        public static DataTable GetALLUser()
        {
            DataTable dtUsers = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "SELECT Users.UserID ,Users.PersonID,People.FirstName + ' ' +People.SecondName+' '+People.ThirdName +' '+People.LastName As FullName   , Users.UserName , Users.IsActive  from users INNER join People on Users.PersonID = People.PersonID ";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
                }
                reader.Close();

            }

            catch (Exception ex) { }

            finally { connection.Close(); }

            return dtUsers;
        }

        public static int AddNewUser(int PersonID , string UserName, string Password, bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Insert INTO Users (PersonID,UserName , [Password] , IsActive) 
                            values (@PersonID,@UserName , @Password , @IsActive ) ; 
                            Select Scope_IDENTITY() ; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    UserID = insertID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally { connection.Close(); }


            return UserID;


        }
        public static int CalculateUsersData()
        {
            int TotalUser = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "select count(*) from Users";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != DBNull.Value && int.TryParse(Result.ToString(), out int Count))
                {
                    TotalUser = Count;
                }


            }
            catch (Exception ex) { Console.WriteLine(); }

            finally { connection.Close(); }

            return TotalUser;



        }
        public static bool UpdateUser(int UserID, string UserName, string Password , bool IsActive)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Update Users 
                           set UserName = @UserName
                          ,    Password = @Password 
                          ,    IsActive = @IsActive
                           where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive",IsActive);
            command.Parameters.AddWithValue("@UserID", UserID); 

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error", ex.Message);

                return false;
            }


            finally
            {
                connection.Close();

            }

            return (rowsAffected > 0);
        }

        public static bool DeleteUser(int UserID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Delete From Users 
                          where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex) { Console.WriteLine("Error", ex.Message); return false; }

            finally
            {
                connection.Close();
            }

            return rowAffected > 0;
        }

        public static bool ApplicateData(string UserName, string Password)
        {
            bool IsFound = false;
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string quary = "Select UserID From Users Where UserName = @UserName AND Password = @Password AND IsActive = 1";
            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@username", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {

                    IsFound = true;
                }
            }

            catch (Exception ex) { Console.WriteLine("Error", ex.Message); return false; }


            finally { connection.Close(); }

            return IsFound;


        }

        public static bool IsUserExist(int PersonID)
        {
            bool IsFound = false;
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select Found = 1 From Users where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsFound = true;
                }
            }

            catch (Exception ex) { Console.WriteLine("Error , Operation Failed !!"); return false; }

            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsUserExist(string UserName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select found = 1 from Users where UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsFound = true;
                }
                else
                    return false;
            }
            catch (Exception ex) { Console.WriteLine("Error Failed Operation !", ex.Message); return false; }


            finally { connection.Close(); }

            return IsFound;
        }
    }
         


}
    

