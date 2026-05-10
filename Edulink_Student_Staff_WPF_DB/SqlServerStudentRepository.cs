using System.Data;
using Microsoft.Data.SqlClient;

namespace Edulink_Student_Staff_WPF_DB;

public class SqlServerStudentRepository
{
    // Method to get all students from the students table in the college database
    public List<Student> GetAll()
    {
        var students = new List<Student>();

        using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
        using var command = new SqlCommand(
        """
        SELECT StudentNO,Names, BirthDate,Gender,
                Email, Nationality, Course, CurrentSem
        FROM student
        ORDER BY studentno
        """,
        connection);

        connection.Open();

        using var reader = command.ExecuteReader();
        while (reader.Read())
            students.Add(MapStudent(reader));
        return students;
    }

    // Method to insert/add the student record/tuple/row to the Student table in the college database
    public void Add(Student student)
    {
        using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
        using var command = new SqlCommand(
            """
            INSERT INTO Student
            (
             StudentNo,Names,BirthDate,Gender,Email,Nationality,Course,CurrentSem
            )
            VALUES
            (
             @StudentNo,
             @Names,
             @BirthDate,
             @Gender,
             @Email,
             @Nationality,
             @Course,
             @CurrentSem
            );
            """
            , connection);
        AddParameters(command, student);
        connection.Open();
        command.ExecuteNonQuery();
    }

    // Method to update a student's record in the Student table in the college database
    public void Update(Student student)
    {
        using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
        using var command = new SqlCommand(
            """
            UPDATE Student
            SET
                Names = @Names,
                BirthDate = @BirthDate,
                Gender = @Gender,
                Email = @Email,
                Nationality = @Nationality,
                Course = @Course,
                CurrentSem = @CurrentSem
            WHERE StudentNo = @StudentNo;
            """
            , connection);
        AddParameters(command, student);
        connection.Open();
        command.ExecuteNonQuery();
    }

    // Method to delete a student's record from the Student table in the college database
    public void Delete(Student student)
    {
        using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
        using var command = new SqlCommand(
            "DELETE FROM Student " +
            "WHERE StudentNo = @StudentNo;",
            connection);
        command.Parameters.Add("@StudentNo", SqlDbType.NVarChar, 50).Value = student.StudentNo;
        connection.Open();
        command.ExecuteNonQuery();
    }
    private Student MapStudent(SqlDataReader reader)
    {
        var genderValue = reader["Gender"]?.ToString() ?? "M";

        return new Student
        {
            StudentNo = reader["StudentNo"]?.ToString() ?? "",
            Names = reader["Names"]?.ToString() ?? string.Empty,
            BirthDate = reader["BirthDate"] is DateTime birthate ? birthate : DateTime.MinValue,
            Gender = genderValue.Length > 0 ? genderValue[0] : 'M',
            Email = reader["Email"]?.ToString() ?? string.Empty,
            Nationality = reader["Nationality"]?.ToString() ?? string.Empty,
            Course = reader["Course"]?.ToString() ?? string.Empty,
            CurrentSem = reader["CurrentSem"] is byte semester ? semester : Convert.ToByte(reader["CurrentSem"])
        };
    }

    private static void AddParameters(SqlCommand command, Student student)
    {
        command.Parameters.Add("@StudentNo", System.Data.SqlDbType.NVarChar, 15).Value = student.StudentNo;
        command.Parameters.Add("@Names", System.Data.SqlDbType.NVarChar, 150).Value = student.Names;
        command.Parameters.Add("@BirthDate", System.Data.SqlDbType.Date).Value = student.BirthDate;
        command.Parameters.Add("@Gender", System.Data.SqlDbType.NChar, 1).Value = student.Gender.ToString();
        command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 80).Value = student.Email;
        command.Parameters.Add("@Nationality", System.Data.SqlDbType.NVarChar, 100).Value = student.Nationality;
        command.Parameters.Add("@Course", System.Data.SqlDbType.NVarChar, 100).Value = student.Course;
        command.Parameters.Add("@CurrentSem", System.Data.SqlDbType.TinyInt).Value = student.CurrentSem;
    }
}

//Congratulations  you've Successfully completed semester 2🎉🎊🎊✨!!!