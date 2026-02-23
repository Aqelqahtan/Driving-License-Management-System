using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace DataAcsessLayer
{
    public class PersonData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName,
          ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone,
          ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "select *From People Where PersonID = @PersonID  ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (reader["SecondName"] == DBNull.Value) ? "" : (string)reader["SecondName"];
                    ThirdName = (reader["ThirdName"] == DBNull.Value) ? "" : (string)reader["ThirdName"] ;
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToByte(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value) // focus here 
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else { ImagePath = ""; }
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }

            catch (Exception ex) { Console.WriteLine("Error :" + ex.Message);
                isFound = false; }
            finally { connection.Close(); }
            return isFound;
        }

        public static bool GetPersonInfoByNationalNo (string NationalNo , ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName,
          ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone,
          ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "select *From People Where NationalNo = @NationalNo  ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (reader["SecondName"] == DBNull.Value) ? "" : (string)reader["SecondName"];
                    ThirdName = (reader["ThirdName"] == DBNull.Value) ? "" : (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToByte(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value) // focus here 
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else { ImagePath = ""; }
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
                isFound = false;
            }
            finally { connection.Close(); }
            return isFound;
        }
        public static int AddNewPerson(string NationalNo , string FirstName , string SecondName , string ThirdName  , string LastName  ,
           DateTime DateOfBirth , byte Gendor , string Address ,  string Phone , string Email , int NationalityCountryID , string ImagePath)
        {
            int PersonID = -1; 
            SqlConnection connection = new SqlConnection (ClsDataAccessSetting.ConnectionString);
            string query = @"Insert INTO People (NationalNo , FirstName , SecondName , ThirdName , LastName , DateOfBirth , Gendor , Address , Phone , Email , NationalityCountryID , ImagePath )
                          Values (@NationalNo , @FirstName , @SecondName , @ThirdName , @LastName , @DateOfBirth , @Gendor , @Address , @Phone , @Email , @NationalityCountryID , @ImagePath ) ; 
                          SELECT SCOPE_IDENTITY();"; 
            SqlCommand command = new SqlCommand (query, connection);
            
            command.Parameters.AddWithValue("@NationalNo", NationalNo); 
            command.Parameters.AddWithValue("@FirstName", FirstName); 
            command.Parameters.AddWithValue("@SecondName", SecondName); 
            command.Parameters.AddWithValue("@ThirdName", ThirdName); 
            command.Parameters.AddWithValue("@LastName", LastName); 
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth); 
            command.Parameters.AddWithValue("@Gendor", Gendor); 
            command.Parameters.AddWithValue("@Address", Address); 
            command.Parameters.AddWithValue("@Phone", Phone); 
            command.Parameters.AddWithValue("@Email", Email); 
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            } else
            {
                command.Parameters.AddWithValue("@ImagePath",System.DBNull.Value);
            }

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    PersonID = insertID;
                }
            }

            catch (Exception ex) { Console.WriteLine("Error :" + ex.Message); }
            finally { connection.Close(); } 


          return PersonID; 
            
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Update People
                           set NationalNo = @NationalNo ,
                               FirstName = @FirstName ,
                               SecondName = @SecondName, 
                               ThirdName = @ThirdName ,
                               LastName  = @LastName,
                               DateOfBirth = @DateOfBirth , 
                               Gendor = @Gendor ,
                               Address = @Address ,  
                               Phone = @Phone , 
                               Email = @Email , 
                               NationalityCountryID = @NationalityCountryID ,  
                               ImagePath = @ImagePath
                               where PersonID = @PersonID ";
                              
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            } else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("Error :" + ex.Message);
                return false;  }

            finally { connection.Close(); } 
            return (rowsAffected > 0 ) ;

            
            }

        public static DataTable GetAllPeople()
        {
            DataTable tables = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Select People.PersonID , People.NationalNo , People.FirstName , People.SecondName
, People.ThirdName , People.LastName , People.DateOfBirth , 
case When People.Gendor = 0 then 'Male'
else 'Female'
End as Gendor , Countries.CountryName , 
People.Phone , People.Email 
from People 
inner join Countries on People.NationalityCountryID = Countries.CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
               

                if (reader.HasRows)
                {
                    tables.Load(reader);

                }
                reader.Close();
            }

            catch (Exception ex) { 
                //Console.WriteLine("Error:", ex.Message);
                 }
            finally { connection.Close(); }
            return tables;
        }
       
        public static bool DeletePersons(int PersonID)
        {
            int rowsAffected = 0; 
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString) ;
            string query = @"Delete People 
                        where PersonID = @PersonID"; 
            SqlCommand command = new SqlCommand (query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("Error :" + ex.Message); return false;  }
            finally { connection.Close(); }
            return rowsAffected > 0 ; 
        
        }

        public static bool isContactExist(int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select Found =1 From People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error :" + ex.Message); }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool isNationalNoExist(string NationalNo)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select Found =1 From People where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error :" + ex.Message); }
            finally { connection.Close(); }

            return isFound;
        }

        public static int CollectTotalPerson()
        {
            int TotalPerosn = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "select count(*) FROM People ";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    TotalPerosn = count;
                }

            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return TotalPerosn;
        }
 }
            

}
