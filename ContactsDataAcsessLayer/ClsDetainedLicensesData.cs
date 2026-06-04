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
    public class ClsDetainedLicensesData
    {
        // 1. Add a new detained license record
        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            int DetainID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses 
                             (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)
                             VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DetainID = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Log the exception here if needed
            }
            finally
            {
                connection.Close();
            }

            return DetainID;
        }

        // 2. Update detained license (Typically used when releasing a license)
        public static bool UpdateDetainedLicense(int DetainID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            string query = @"UPDATE DetainedLicenses
                             SET IsReleased = @IsReleased,
                                 ReleaseDate = @ReleaseDate,
                                 ReleasedByUserID = @ReleasedByUserID,
                                 ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        // 3. Get active detained license info by License ID (Includes safety checks for NULLs)
        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate,
            ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate,
            ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            // Retrieve the most recent unreleased detain record for this license
            string query = "SELECT top 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0 ORDER BY DetainID DESC;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    // Using Convert to safely cast values and prevent casting exceptions
                    DetainID = Convert.ToInt32(reader["DetainID"]);
                    DetainDate = Convert.ToDateTime(reader["DetainDate"]);
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    IsReleased = Convert.ToBoolean(reader["IsReleased"]);

                    // Handle potential Null values from the database safely
                    if (reader["ReleaseDate"] == DBNull.Value)
                        ReleaseDate = DateTime.MaxValue;
                    else
                        ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]);

                    if (reader["ReleasedByUserID"] == DBNull.Value)
                        ReleasedByUserID = -1;
                    else
                        ReleasedByUserID = Convert.ToInt32(reader["ReleasedByUserID"]);

                    if (reader["ReleaseApplicationID"] == DBNull.Value)
                        ReleaseApplicationID = -1;
                    else
                        ReleaseApplicationID = Convert.ToInt32(reader["ReleaseApplicationID"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        // 4. Check if a specific license is currently detained
        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isDetained = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            string query = "SELECT Found=1 FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    isDetained = true;
                }
            }
            catch (Exception ex)
            {
                isDetained = false;
            }
            finally
            {
                connection.Close();
            }

            return isDetained;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable DTDetainedLicenses = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "SELECT DetainedLicenses.DetainID ," +
                " DetainedLicenses.LicenseID ," +
                "  DetainedLicenses.DetainDate ," +
                "   DetainedLicenses.IsReleased ," +
                "   DetainedLicenses.FineFees ," +
                "    DetainedLicenses.ReleaseDate ," +
                "    People.NationalNo , " +
                " People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName as FullName  " +
                " , DetainedLicenses.ReleaseApplicationID " +
                "from DetainedLicenses " +
                " INNER join Licenses on DetainedLicenses.LicenseID = Licenses.LicenseID" +
                " INNER join Drivers on Licenses.DriverID  = Drivers.DriverID" +
                " INNER join People on Drivers.PersonID = People.PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DTDetainedLicenses.Load(reader);
                }

                reader.Close();     


            }
            catch (Exception ex) { }

            finally { connection.Close(); }
            return DTDetainedLicenses;
        }
    }
}
