using System.Collections.Generic;
using System.Windows.Forms;
using AttendanceSystem.Controllers;
using AttendanceSystem.Models;

namespace StudentAttendanceSystem
{
    public partial class Attendences : Form
    {
        private readonly AttendanceController _attendance = new();
        private readonly StudentController _students = new();

        public Attendences()
        {
            InitializeComponent();
            LoadStudent.Click += LoadAttendance_Click;
            SaveAttendance.Click += SaveAttendance_Click;
        }

        private void Attendences_Load(object sender, EventArgs e)
        {
            YearcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            YearcomboBox1.DataSource = _students.GetClasses();

            dateTimePicker1.Format = DateTimePickerFormat.Short;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("StudentId", "Student ID");
            dataGridView1.Columns.Add("FullName", "Full Name");
            var status = new DataGridViewComboBoxColumn();
            status.Name = "Status";
            status.HeaderText = "Status";
            status.Items.Add("Present");
            status.Items.Add("Absent");
            dataGridView1.Columns.Add(status);

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private string DateText => dateTimePicker1.Value.ToString("yyyy-MM-dd");

        private void LoadAttendance_Click(object? sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string? cls = YearcomboBox1.SelectedItem as string;
            if (cls == null)
            {
                MessageBox.Show("Add students and choose a class first.");
                return;
            }

            foreach (var record in _attendance.GetList(cls, DateText))
                dataGridView1.Rows.Add(record.StudentId, record.FullName, record.Status);
        }

        private void SaveAttendance_Click(object? sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Load a class first.");
                return;
            }

            var records = new List<AttendanceRecord>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                records.Add(new AttendanceRecord
                {
                    StudentId = row.Cells[0].Value?.ToString() ?? "",
                    FullName = row.Cells[1].Value?.ToString() ?? "",
                    Status = row.Cells[2].Value?.ToString() ?? "Present"
                });
            }

            _attendance.Save(DateText, records);
            MessageBox.Show("Attendance saved.");
        }
    }
}