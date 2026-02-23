using DataAcsessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DataAccsessLayer
{
    public class ClsLicenseClassesData
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable result = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "SELECT * FROM LicenseClasses";
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
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public static bool UpdateLicenseClasses(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            string query = @"UPDATE LicenseClasses 
                             SET ClassName = @ClassName, 
                                 ClassDescription = @ClassDescription,
                                 MinimumAllowedAge = @MinimumAllowedAge,
                                 DefaultValidityLength = @DefaultValidityLength,
                                 ClassFees = @ClassFees 
                             WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Failed Operation: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return rowAffected > 0;
        }

        public static bool GetLicenseClassInfoByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, Failed Operation! " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int CountLicenseClasses()
        {
            int TotalCount = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            string query = "SELECT COUNT(*) FROM LicenseClasses";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && int.TryParse(result.ToString(), out int count))
                {
                    TotalCount = count;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, Failed Operation: " + ex.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }

            return TotalCount;
        }

        public static int AddNewLicenseClass(string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            int LicenseClassID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO LicenseClasses 
                            (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees) 
                            VALUES 
                            (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees); 
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertID))
                {
                    LicenseClassID = InsertID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, Failed Operation! " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return LicenseClassID;
        }
    }
}