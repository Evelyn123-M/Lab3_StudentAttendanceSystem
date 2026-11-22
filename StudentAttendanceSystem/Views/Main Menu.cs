using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class Main_Menu : Form
    {
        public bool LoggedOut { get; private set; }

        public Main_Menu()
        {
            InitializeComponent();
            Students.Click += Students_Click;
            Attendence.Click += Attendance_Click;
            Reports.Click += Reports_Click;
            Logout.Click += Logout_Click;
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Students_Click(object? sender, EventArgs e)
        {
            new Students().ShowDialog();
        }

        private void Attendance_Click(object? sender, EventArgs e)
        {
            new Attendences().ShowDialog();
        }

        private void Reports_Click(object? sender, EventArgs e)
        {
            new Reports().ShowDialog();
        }

        private void Logout_Click(object? sender, EventArgs e)
        {
            LoggedOut = true;
            Close();
        }
    }
}