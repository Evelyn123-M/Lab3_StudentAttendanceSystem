using AttendanceSystem.Data;

namespace AttendanceSystem.Controllers;

public sealed class AuthController
{
    public bool Authenticate(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            return false;

        using var connection = Database.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT COUNT(*) FROM Teachers WHERE Username=@username AND Password=@password";
        command.Parameters.AddWithValue("@username", username.Trim());
        command.Parameters.AddWithValue("@password", password);
        return Convert.ToInt32(command.ExecuteScalar()) > 0;
    }
}
