using DataAcsessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer
{
    public class ClsLocalDrivingLicenseApplicationData
    {
        public static DataTable GetAllLocalDrivingLicenseApplicationData()
        {
            DataTable LocalDrivingLicenseApplication = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "SELECT *from vw_LocalDrivingLicenseApplications "; 
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    LocalDrivingLicenseApplication.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error , Failed Operation !", ex.Message); }

            finally { connection.Close(); } 

            return LocalDrivingLicenseApplication;

           

        }
        public static bool GetLocalDrivingLicenseApplicationDataByID(int LDLAppID, ref string DrivingClass, ref string NationalNo, ref string FullName, ref DateTime ApplicationDate, ref int PassedTests, ref string Status)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "SELECT *from vw_LocalDrivingLicenseApplications where [L.D.L.AppID] = @LDLAppID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsFound = true;
                    DrivingClass = (string)reader["DrivingClass"];
                    NationalNo = (string)reader["NationalNo"];
                    FullName = (string)reader["FullName"];
                    NationalNo = (string)reader["NationalNo"];
                    FullName = (string)reader["FullName"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    PassedTests = (int)reader["PassedTests"];
                    Status = (string)reader["Status"]; 

                } else
                {
                    IsFound = false;
                }
                    reader.Close();

            }
            catch (Exception ex) { Console.WriteLine("Error , Failed Opeartion !", ex.Message); return false; }
            finally { connection.Close(); }
            return IsFound;
        }
        public static int AddLocalDrivingLicenseApplicationData( string DrivingClass,  string NationalNo,  string FullName,  DateTime ApplicationDate,  int PassedTests,  string Status)
        {

            int LDLApp10 = -1; 
       
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Insert INTO vw_LocalDrivingLicenseApplications 
                             (DrivingClass, NationalNo,FullName,ApplicationDate,PassedTests ,Status)values (@DrivingClass,@NationalNo,@FullName,@ApplicationDate,@PassedTests ,@Status);
                              Select Scope_Identity(); ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DrivingClass", DrivingClass);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@PassedTests", PassedTests);
            command.Parameters.AddWithValue("@Status", Status);

            try
            {
                connection.Open();
                 object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int InsertID))
                {
                    result = InsertID; 
                }
                
            
            
            }
            catch (Exception ex) { Console.WriteLine("Error :" + ex.Message); }
            finally { connection.Close(); }

            return LDLApp10;


        }
        public static bool UpdateLocalDrivingLicenseApplicationData(int LDLAppID , string DrivingClass, string NationalNo, string FullName, DateTime ApplicationDate, int PassedTests, string Status)
        {
            int rowaffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Update vw_LocalDrivingLicenseApplications
                             set DrivingClass = @DrivingClass ,
                                 NationalNo = @NationalNo  , 
                                 FullName = @FullName , 
                                 ApplicationDate = @ApplicationDate , 
                                 PassedTests = @PassedTests  , 
                                 Status = @Status  
                                 where LDLAppID = @LDLAppID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DrivingClass", DrivingClass);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@PassedTests", PassedTests);
            command.Parameters.AddWithValue("@Status", Status);

            try
            {
                connection.Open();
                rowaffected = command.ExecuteNonQuery(); 
               
            }
            catch (Exception ex) { Console.WriteLine("Error , Operation Failed !" , ex.Message); return false; }
            finally { connection.Close(); }

            return rowaffected > 0;

        }
        public static bool DeleteLocalDrivingLicenseApplicationData(int LDLAppID)
        {
            int rowAffected = 0; 
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Delete from vw_LocalDrivingLicenseApplications where LDLAppID = @LDLAppID"; 
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID); 
            try
            {
                connection.Open();  
                rowAffected = command.ExecuteNonQuery(); 

            }
            catch (Exception ex) { Console.WriteLine("Error , Operation Failed !", ex.Message); return false; }
            finally { connection.Close(); }

            return rowAffected > 0;

        }
        public static int CountLocalDrivingLicenseApplicationData()
        {
            int total = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "select count(*) from vw_LocalDrivingLicenseApplications"; 
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();  
               object result =  command.ExecuteScalar(); 
                if (result != null && int.TryParse(result.ToString(),out int count))
                    {
                    total = count;
                    }
            }
            catch (Exception ex) { Console.WriteLine("Error , Operation Failed !", ex.Message); }
            finally { connection.Close(); }

            return total;

        }
    }
}
