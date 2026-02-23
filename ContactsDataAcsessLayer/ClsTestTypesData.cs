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
    public class ClsTestTypesData
    {
        public static DataTable GetAllTestType()
        {
            DataTable dtTestType = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "select *from TestTypes"; 
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtTestType.Load(reader);
                }
                reader.Close(); ;
            }
            catch (Exception ex) { Console.WriteLine("Error , Failed Operation !", ex.Message); }

            finally { connection.Close();  } 

            return dtTestType;      

        }

        public static int CountTestType()
        {
            int TotalTestCount = 0; 
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select count(*) from TestTypes";
            SqlCommand command = new SqlCommand(query,connection);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString() , out int TestTypeID ))
                {
                   TotalTestCount = TestTypeID;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error , Failed Operation !" , ex.Message); 
            }
            finally { connection.Close(); }
            return TotalTestCount;
        }
        public static bool GetTestTypeByTestID(int TestTypeID , ref string TestTypeTitle , ref string TestTypeDescription , ref decimal TestTypeFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString) ;
            string query = "select *from TestTypes where TestTypeID = @TestTypeID"; 
            SqlCommand command = new SqlCommand (query,connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound =  true;
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = (decimal)reader["TestTypeFees"]; 

                }
                reader.Close(); 

            }

            catch (Exception ex) { Console.WriteLine("Error , Failed Operation !", ex.Message); return false; }

            finally { connection.Close(); }

            return IsFound ; 


        }
        public static bool UpdateTestType(int TestTypeID , string TestTypeTitle , string TestTypeDescription , decimal TestTypeFees)
        {
            int rowaffected = 0; 
            SqlConnection connection = new SqlConnection (ClsDataAccessSetting.ConnectionString) ;
            string query = @"Update TestTypes set
                             TestTypeTitle = @TestTypeTitle ,
                             TestTypeDescription = @TestTypeDescription ,
                             TestTypeFees = @TestTypeFees
                             Where TestTypeID = @TestTypeID "; 
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID); 
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);


            try
            {
                connection.Open();
             rowaffected = command.ExecuteNonQuery();
                   
                
            }

            catch (Exception ex) { Console.WriteLine("Error , Failed Operation !"); return false; }

            finally { connection.Close(); }

            return rowaffected > 0; 

        }

    }
}
