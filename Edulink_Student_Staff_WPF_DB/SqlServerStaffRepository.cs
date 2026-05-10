using System.Data;
using Microsoft.Data.SqlClient;

namespace Edulink_Student_Staff_WPF_DB;

public class SqlServerStaffRepository
{
    //Method to get all staff from the Staff table in the college database
    public List<Staff> GetAll()
    {
        var staffMembers = new List<Staff>();

        using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
        using var command = new SqlCommand(
            """
            SELECT StaffID,Names, BirthDate,Gender,
                    Email, Nationality, EmploymentDate, Designation,PhoneNo
            FROM staff
            ORDER BY StaffID
            """,
            connection);

        connection.Open();

        using var reader = command.ExecuteReader();
        while (reader.Read())
            staffMembers.Add(MapStaff(reader));
        return staffMembers;
    }

    // Method to insert/add the student record/tuple/row to the Staff table in the college database
    public void Add(Staff staff)
    {
        using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
        using var command = new SqlCommand(
            """
            INSERT INTO Staff
            (
             StaffID,Names, BirthDate,Gender,
            Email, Nationality, EmploymentDate, Designation,PhoneNo
            )
            VALUES
            (
             @StaffID,
             @Names, 
             @BirthDate,
             @Gender,
             @Email, 
             @Nationality, 
             @EmploymentDate, 
             @Designation,
             @PhoneNo
            );
            """
            , connection);
        AddParameters(command, staff);
        connection.Open();
        command.ExecuteNonQuery();
    }

    // Method to update a staff's record in the Staff table in the college database
    public void Update(Staff staff)
    {
        using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
        using var command = new SqlCommand(
            """
            UPDATE Staff
            SET
                Names = @Names,
                BirthDate = @BirthDate,
                Gender = @Gender,
                Email = @Email,
                Nationality = @Nationality,
                EmploymentDate = @EmploymentDate,
                Designation = @Designation,
                PhoneNo = @PhoneNo
            WHERE StaffID = @StaffID;
            """
            , connection);
        AddParameters(command, staff);
        connection.Open();
        command.ExecuteNonQuery();
    }

    // Method to delete a staff's record from the Staff table in the college database
    public void Delete(Staff staff)
    {
        using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
        using var command = new SqlCommand(
            "DELETE FROM Staff " +
            "WHERE StaffID = @StaffID;",
            connection);
        command.Parameters.Add("@StudentNo", SqlDbType.NVarChar, 50).Value = staff.StaffID;
        connection.Open();
        command.ExecuteNonQuery();

    }

    private Staff MapStaff(SqlDataReader reader)
    {
        var genderValue = reader["Gender"]?.ToString() ?? "M";

        return new Staff
        {
            StaffID = reader["StaffID"]?.ToString() ?? "",
            Names = reader["Names"]?.ToString() ?? string.Empty,
            BirthDate = reader["BirthDate"] is DateTime birthate ? birthate : DateTime.MinValue,
            Gender = genderValue.Length > 0 ? genderValue[0] : 'M',
            Email = reader["Email"]?.ToString() ?? string.Empty,
            Nationality = reader["Nationality"]?.ToString() ?? string.Empty,
            EmployementDate = reader["EmploymentDate"] is DateTime employmentDate ? employmentDate : DateTime.MinValue,
            Designation = reader["Designation"]?.ToString() ?? string.Empty,
            PhoneNo = reader["PhoneNo"]?.ToString() ?? string.Empty
        };
    }

    private static void AddParameters(SqlCommand command, Staff staff)
    {
        command.Parameters.Add("@StaffID", System.Data.SqlDbType.NVarChar, 15).Value = staff.StaffID;
        command.Parameters.Add("@Names", System.Data.SqlDbType.NVarChar, 150).Value = staff.Names;
        command.Parameters.Add("@BirthDate", System.Data.SqlDbType.Date).Value = staff.BirthDate;
        command.Parameters.Add("@Gender", System.Data.SqlDbType.NChar, 1).Value = staff.Gender.ToString();
        command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 80).Value = staff.Email;
        command.Parameters.Add("@Nationality", System.Data.SqlDbType.NVarChar, 100).Value = staff.Nationality;
        command.Parameters.Add("@EmploymentDate", System.Data.SqlDbType.Date).Value = staff.EmployementDate;
        command.Parameters.Add("@Designation", System.Data.SqlDbType.NVarChar, 100).Value = staff.Designation;
        command.Parameters.Add("@PhoneNo", System.Data.SqlDbType.NVarChar, 20).Value = staff.PhoneNo;
    }
}