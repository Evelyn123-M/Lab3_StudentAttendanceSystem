namespace AttendanceSystem.Models;

public sealed class AttendanceRecord
{
    public string StudentId { get; set; } = "";
    public string FullName { get; set; } = "";
    public string ClassName { get; set; } = "";
    public string AttDate { get; set; } = "";
    public string Status { get; set; } = "Present";
}
