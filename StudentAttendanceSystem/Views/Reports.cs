using System.Windows.Forms;
using AttendanceSystem.Controllers;

namespace StudentAttendanceSystem
{
    public partial class Reports : Form
    {
        private readonly AttendanceController _attendance = new();
        private readonly StudentController _students = new();

        public Reports()
        {
            InitializeComponent();
            Show.Click += ShowReport_Click;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            ClasscomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ClasscomboBox1.Items.Clear();
            ClasscomboBox1.Items.Add("All");
            foreach (var c in _students.GetClasses())
                ClasscomboBox1.Items.Add(c);
            ClasscomboBox1.SelectedIndex = 0;

            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Checked = false;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ShowReport();
        }

        private void ShowReport_Click(object? sender, EventArgs e)
        {
            ShowReport();
        }

        private void ShowReport()
        {
            string cls = ClasscomboBox1.SelectedItem?.ToString() ?? "All";

            if (dateTimePicker1.Checked)
                dataGridView1.DataSource = _attendance.GetRecords(cls, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            else
                dataGridView1.DataSource = _attendance.GetSummary(cls);
        }
    }
}