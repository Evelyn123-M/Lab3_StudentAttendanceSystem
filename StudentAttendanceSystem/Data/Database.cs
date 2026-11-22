using MySqlConnector;

namespace AttendanceSystem.Data;

public static class Database
{
    private const string Server = "server=localhost;port=3306;user=root;password=;";
    private const string DbName = "attendance_db";

    public static MySqlConnection Open()
    {
        var connection = new MySqlConnection($"{Server}database={DbName};");
        connection.Open();
        return connection;
    }

    public static void Init()
    {
        using (var c = new MySqlConnection(Server))
        {
            c.Open();
            Run(c, $"CREATE DATABASE IF NOT EXISTS {DbName}");
        }

        using var conn = Open();
        Run(conn, @"CREATE TABLE IF NOT EXISTS Teachers(
            Id INT AUTO_INCREMENT PRIMARY KEY,
            Username VARCHAR(50) UNIQUE NOT NULL,
            Password VARCHAR(100) NOT NULL) ENGINE=InnoDB");

        Run(conn, @"CREATE TABLE IF NOT EXISTS Students(
            StudentId VARCHAR(30) PRIMARY KEY,
            FullName VARCHAR(100) NOT NULL,
            ClassName VARCHAR(50) NOT NULL) ENGINE=InnoDB");

        Run(conn, @"CREATE TABLE IF NOT EXISTS Attendance(
            Id INT AUTO_INCREMENT PRIMARY KEY,
            StudentId VARCHAR(30) NOT NULL,
            AttDate DATE NOT NULL,
            Status VARCHAR(10) NOT NULL,
            UNIQUE KEY uq_student_date (StudentId, AttDate),
            FOREIGN KEY (StudentId) REFERENCES Students(StudentId) ON DELETE CASCADE) ENGINE=InnoDB");

        Run(conn, "INSERT IGNORE INTO Teachers(Username, Password) VALUES('admin', '1234')");
    }

    private static void Run(MySqlConnection c, string sql)
    {
        using var cmd = c.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
}