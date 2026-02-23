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
    public class ClsApplicationTypesData
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable result = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString); 
            string query = "select *from ApplicationTypes"; 
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    result.Load(reader);

                }
                reader.Close();
            }
            catch (Exception ex) {Console.WriteLine(ex.Message);   }

            finally { connection.Close(); } 
            return result;
        }

        public static bool UpdateApplicationFees(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Update ApplicationTypes 
                             set ApplicationTypeTitle = @ApplicationTypeTitle , 
                             ApplicationFees = @ApplicationFees 
                             where ApplicationTypeID =  @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("Error Failed Operation"); return false; } 

            finally { connection.Close(); }

            return rowAffected > 0;
            

            
        }
        public static bool GetApplicationTypeByApplicationTypeID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select *from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];  
                }
                reader.Close();

            }
            catch (Exception ex) { Console.WriteLine("Error , Failed Operation !", ex.Message); return false; }
            finally { connection.Close(); }

            return IsFound;

        }
        public static int CountApplicationTypes()
        {
            int TotalUser = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select count(*) from ApplicationTypes "; 
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && int.TryParse(result.ToString(), out int count))
                {
                    TotalUser = count;
                }

                

            }

            catch (Exception ex) { Console.WriteLine("Error , Faild Operation",ex.Message); return 0; }
            finally { connection.Close(); }

            return TotalUser;
        }
        public static int AddNewApplicationTypes( string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int ApplicationTypeID = -1; 
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = @"Insert into ApplicationTypes 
                          ( ApplicationTypeTitle  , ApplicationFees ) values (@ApplicationTypeTitle,@ApplicationFees) ; 
                            Select Scope_identity()";
            SqlCommand command = new SqlCommand(query , connection);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result !=  null && int.TryParse(result.ToString(),out int InsertID))
                {
                    ApplicationTypeID = InsertID; 
                }

            }

            catch (Exception ex) { Console.WriteLine("Error , Failed Operation !", ex.Message);  }
            finally { connection.Close(); }

            return ApplicationTypeID ;

            
            
      
        }

    }
}
