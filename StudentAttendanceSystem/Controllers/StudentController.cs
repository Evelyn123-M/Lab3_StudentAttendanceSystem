using AttendanceSystem.Data;
using AttendanceSystem.Models;
using System.Data;
using MySqlConnector;

namespace AttendanceSystem.Controllers;

public sealed class StudentController
{
    public DataTable GetAll(string search = "")
    {
        using var connection = Database.Open();
        using var command = connection.CreateCommand();
        command.CommandText = @"SELECT StudentId, FullName, ClassName
                                FROM Students
                                WHERE @search = '' OR StudentId LIKE @like OR FullName LIKE @like OR ClassName LIKE @like
                                ORDER BY StudentId";
        command.Parameters.AddWithValue("@search", search);
        command.Parameters.AddWithValue("@like", $"%{search}%");
        using var reader = command.ExecuteReader();
        var table = new DataTable();
        table.Load(reader);
        return table;
    }

    public List<string> GetClasses()
    {
        using var connection = Database.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT DISTINCT ClassName FROM Students ORDER BY ClassName";
        using var reader = command.ExecuteReader();
        var classes = new List<string>();
        while (reader.Read())
            classes.Add(reader.GetString(0));
        return classes;
    }

    public string? Add(Student student)
    {
        var error = Validate(student);
        if (error != null)
            return error;

        using var connection = Database.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Students(StudentId, FullName, ClassName) VALUES(@id, @name, @class)";
        AddParameters(command, student);
        try
        {
            command.ExecuteNonQuery();
            return null;
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            return "A student with that ID already exists.";
        }
    }

    public string? Update(Student student)
    {
        var error = Validate(student);
        if (error != null)
            return error;

        using var connection = Database.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "UPDATE Students SET FullName=@name, ClassName=@class WHERE StudentId=@id";
        AddParameters(command, student);
        if (command.ExecuteNonQuery() == 0)
            return "Student not found.";

        return null;
    }

    public string? Delete(string studentId)
    {
        if (string.IsNullOrWhiteSpace(studentId))
            return "Enter a student ID.";
        using var connection = Database.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Students WHERE StudentId=@id";
        command.Parameters.AddWithValue("@id", studentId.Trim());
        if (command.ExecuteNonQuery() == 0)
            return "Student not found.";

        return null;
    }

    private static string? Validate(Student student)
    {
        if (string.IsNullOrWhiteSpace(student.StudentId))
            return "Enter a student ID.";
        if (string.IsNullOrWhiteSpace(student.FullName))
            return "Enter the student's name.";
        if (string.IsNullOrWhiteSpace(student.ClassName))
            return "Enter the student's class.";

        return null;
    }

    private static void AddParameters(MySqlCommand command, Student student)
    {
        command.Parameters.AddWithValue("@id", student.StudentId.Trim());
        command.Parameters.AddWithValue("@name", student.FullName.Trim());
        command.Parameters.AddWithValue("@class", student.ClassName.Trim());
    }
}
