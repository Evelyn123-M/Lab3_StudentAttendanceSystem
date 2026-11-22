using AttendanceSystem.Data;
using AttendanceSystem.Models;
using MySqlConnector;
using System.Data;

namespace AttendanceSystem.Controllers;

public sealed class AttendanceController
{
    public List<AttendanceRecord> GetList(string className, string date)
    {
        using var connection = Database.Open();
        using var command = connection.CreateCommand();
        command.CommandText = @"SELECT s.StudentId, s.FullName,
                                       COALESCE(a.Status, 'Present') AS Status
                                FROM Students s
                                LEFT JOIN Attendance a ON a.StudentId = s.StudentId AND a.AttDate = @date
                                WHERE s.ClassName = @class
                                ORDER BY s.StudentId";
        command.Parameters.AddWithValue("@class", className);
        command.Parameters.AddWithValue("@date", date);
        using var reader = command.ExecuteReader();
        var records = new List<AttendanceRecord>();
        while (reader.Read())
        {
            records.Add(new AttendanceRecord
            {
                StudentId = reader.GetString("StudentId"),
                FullName = reader.GetString("FullName"),
                Status = reader.GetString("Status")
            });
        }
        return records;
    }

    public void Save(string date, IEnumerable<AttendanceRecord> records)
    {
        using var connection = Database.Open();
        using var transaction = connection.BeginTransaction();
        foreach (var record in records)
        {
            using var command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = @"INSERT INTO Attendance(StudentId, AttDate, Status)
                                    VALUES(@studentId, @date, @status)
                                    ON DUPLICATE KEY UPDATE Status = VALUES(Status)";
            command.Parameters.AddWithValue("@studentId", record.StudentId);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@status", record.Status);
            command.ExecuteNonQuery();
        }
        transaction.Commit();
    }

    public DataTable GetRecords(string className, string date)
    {
        using var connection = Database.Open();
        using var command = connection.CreateCommand();
        command.CommandText = @"SELECT s.StudentId, s.FullName, s.ClassName, a.AttDate, a.Status
                                FROM Attendance a
                                INNER JOIN Students s ON s.StudentId = a.StudentId
                                WHERE (@class = 'All' OR s.ClassName = @class) AND a.AttDate = @date
                                ORDER BY s.StudentId";
        command.Parameters.AddWithValue("@class", className);
        command.Parameters.AddWithValue("@date", date);
        return LoadTable(command);
    }

    public DataTable GetSummary(string className)
    {
        using var connection = Database.Open();
        using var command = connection.CreateCommand();
        command.CommandText = @"SELECT s.StudentId, s.FullName, s.ClassName,
                                       SUM(a.Status = 'Present') AS Present,
                                       SUM(a.Status = 'Absent') AS Absent
                                FROM Students s
                                LEFT JOIN Attendance a ON a.StudentId = s.StudentId
                                WHERE @class = 'All' OR s.ClassName = @class
                                GROUP BY s.StudentId, s.FullName, s.ClassName
                                ORDER BY s.StudentId";
        command.Parameters.AddWithValue("@class", className);
        return LoadTable(command);
    }

    private static DataTable LoadTable(MySqlCommand command)
    {
        using var reader = command.ExecuteReader();
        var table = new DataTable();
        table.Load(reader);
        return table;
    }
}
