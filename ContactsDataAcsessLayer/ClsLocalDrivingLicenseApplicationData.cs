using DataAcsessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            string query = "SELECT * from vw_LocalDrivingLicenseApplications where [L.D.L.AppID] = @LDLAppID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                IsFound = true;
                DrivingClass = (string)reader["Driving Class"];
                NationalNo = (string)reader["National No"];
                FullName = (string)reader["Full Name"];
                ApplicationDate = (DateTime)reader["Application Date"];
                PassedTests = reader["Passed Tests"] == DBNull.Value ? 0 : (int)reader["Passed Tests"];
                Status = (string)reader["Status"];
            }
            reader.Close();
            connection.Close();

            return IsFound;
        }
        public static int GetApplicationIDByLocalDrivingAppID(int LDLAppID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LDLAppID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                    ApplicationID = id;
            }
            catch (Exception ex) { Console.WriteLine("Error , Failed Operation ! ", ex.Message);  }
            finally { connection.Close(); }

            return ApplicationID;
        }
        public static int AddLocalDrivingLicenseApplicationData(int ApplicationID, int LicenseClassID)
        {

            int InsertID = -1; 
       
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                     VALUES (@ApplicationID, @LicenseClassID);
                     SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                 object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int NewID))
                {
                    InsertID = NewID ; 
                }
            }
            catch (Exception ex) { Console.WriteLine("Error :" + ex.Message); }
            finally { connection.Close(); }

            return InsertID;

        }
        public static bool UpdateLocalDrivingLicenseApplicationData(int LDLAppID , int LicenseClassID)
        {
            int rowaffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            string query = @"Update LocalDrivingLicenseApplications
                     set LicenseClassID = @LicenseClassID
                     where LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                rowaffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }

            return rowaffected > 0;
        }
        public static bool DeleteLocalDrivingLicenseApplicationData(int LDLAppID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            string query = @"Delete from LocalDrivingLicenseApplications where LDLAppID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
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
        public static bool IsApplicationExist (int PersonID , int LicenseClassID)
        {
            bool IsFound = false; 
            SqlConnection connection = new SqlConnection (ClsDataAccessSetting.ConnectionString);
            string query = @"SELECT top 1 Found = 1
                     FROM LocalDrivingLicenseApplications
                     INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                     WHERE Applications.ApplicantPersonID = @PersonID
                       AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                       AND Applications.ApplicationStatus IN (1, 3)"; // 1 = New, 3 = Completed
            SqlCommand command = new SqlCommand (query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID); 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
                if (reader.HasRows)
                {
                    IsFound = true; 
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Failed Operation !!" , ex.Message); return false;  }
            finally { connection.Close(); }

            return IsFound;
        }
        public static bool UpdateStatus(int ApplicationID, short NewStatus)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Update Applications 
                              set ApplicationStatus = @NewStatus , 
                                  LastStatusDate = @LastStatusDate 
                                  where ApplicationID = @ApplicationID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
            finally { connection.Close(); }
            return rowsAffected > 0;
        
        }
        public static byte TotalTrialPerTest (int LocalDrivingLicenseApplicationID , int TestTypeID)
        {
            byte TotalTrials = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString) ;
            string query = @"Select Count(TestAppointmentID)
                             From TestAppointments 
                             where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                             AND TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && byte.TryParse(result.ToString(), out byte count))
                {
                    TotalTrials = count;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return TotalTrials;

        }
        public  static int GetPassedTestNumbers (int LDLAppID)
        {
            int PassedNumber = 0;
            SqlConnection connection = new SqlConnection (ClsDataAccessSetting.ConnectionString) ;
            string query = "select [Passed Tests] from vw_LocalDrivingLicenseApplications where LDLAppID = @LDLAppID";
            SqlCommand command = new SqlCommand (query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    PassedNumber = count;
                }
            }
            catch (Exception ex) {  }
            finally {connection.Close(); }  

            return PassedNumber;
        }
    }
}
