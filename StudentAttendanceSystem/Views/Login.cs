using AttendanceSystem.Controllers;
using AttendanceSystem.Data;

namespace StudentAttendanceSystem
{
    public partial class Login : Form
    {
        private readonly AuthController _auth = new();

        public Login()
        {
            InitializeComponent();
            PasswordtextBox1.UseSystemPasswordChar = true;
            LoginButton.Click += LoginButton_Click;
            AcceptButton = LoginButton;
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            try
            {
                Database.Init();
                if (!_auth.Authenticate(UsernametextBox2.Text, PasswordtextBox1.Text))
                {
                    MessageBox.Show("Invalid username or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PasswordtextBox1.Clear();
                    PasswordtextBox1.Focus();
                    return;
                }

                Hide();
                using var menu = new Main_Menu();
                menu.ShowDialog(this);
                Show();

                if (!menu.LoggedOut)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to connect to the database. {ex.Message}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
