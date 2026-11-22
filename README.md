# Student Attendance System

A Windows desktop application for recording and viewing student attendance. It is built with C# (Windows Forms) and a MySQL database (XAMPP), and follows the MVC architecture.

Made by **Mutuyimana Evelyne** (Student ID: 27701), Software Engineering, AUCA.

## What it does

- A teacher logs in with a username and password
- Add, edit, delete and search students (ID, full name, class)
- Take attendance for a class on a chosen date (Present or Absent)
- View reports: attendance for one day, or the total days present and absent for each student
- Logout

## Technologies

- C# and Windows Forms (.NET)
- MySQL through XAMPP
- MySqlConnector (NuGet package)
- Visual Studio

## Project structure (MVC)

- **Models**: `Student`, `AttendanceRecord` (the data)
- **Views**: the forms `Login`, `Main_Menu`, `Students`, `Attendences`, `Reports` (what the user sees)
- **Controllers**: `AuthController`, `StudentController`, `AttendanceController` (the database work)
- **Data**: `Database` (connection and table creation)

The forms never write SQL. They call the controllers, and the controllers talk to the database.

## Database

Database name: `attendance_db`

Tables:
- `Teachers` (Id, Username, Password)
- `Students` (StudentId, FullName, ClassName)
- `Attendance` (Id, StudentId, AttDate, Status)

The app creates the database and tables by itself the first time it runs.

## How to run

1. Install Visual Studio and XAMPP.
2. Open XAMPP Control Panel and start **MySQL**.
3. Open `StudentAttendanceSystem.slnx` in Visual Studio.
4. Install the NuGet package: `Install-Package MySqlConnector`
5. Press **F5** to run.
6. Log in with:
   - Username: `admin`
   - Password: `1234`

If your MySQL has a root password, change it in `Data/Database.cs` (the `Server` line).

## How to use

1. Open **Students** and add some students.
2. Open **Take Attendance**, choose a class and date, click **Load students**, set Present or Absent, then **Save**.
3. Open **Reports** to see the totals or one day's attendance.

## Author

Mutuyimana Evelyne, 27701
GitHub: [Evelyn123-M](https://github.com/Evelyn123-M)
