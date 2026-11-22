using AttendanceSystem.Controllers;
using AttendanceSystem.Models;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class Students : Form
    {
        private readonly StudentController _students = new();

        public Students()
        {
            InitializeComponent();
            Add.Click += Add_Click;
            Update.Click += Update_Click;
            Delete.Click += Delete_Click;
            Clear.Click += Clear_Click;
            SearchtextBox1.TextChanged += SearchTextChanged;
            StudentsdataGridView1.CellClick += StudentSelected;
        }

        private void Students_Load(object sender, EventArgs e)
        {
            StudentsdataGridView1.ReadOnly = true;
            StudentsdataGridView1.AllowUserToAddRows = false;
            StudentsdataGridView1.MultiSelect = false;
            StudentsdataGridView1.RowHeadersVisible = false;
            StudentsdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentsdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadGrid();
        }

        private void StudentSelected(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = StudentsdataGridView1.Rows[e.RowIndex];
            StudIdtextBox1.Text = row.Cells["StudentId"].Value?.ToString() ?? "";
            NametextBox2.Text = row.Cells["FullName"].Value?.ToString() ?? "";
            ClasstextBox3.Text = row.Cells["ClassName"].Value?.ToString() ?? "";
            StudIdtextBox1.ReadOnly = true;
        }

        private void LoadGrid()
        {
            StudentsdataGridView1.DataSource = _students.GetAll(SearchtextBox1.Text.Trim());
            StudentsdataGridView1.ClearSelection();
        }

        private void SearchTextChanged(object? sender, EventArgs e) => LoadGrid();

        private Student ReadFields()
        {
            return new Student
            {
                StudentId = StudIdtextBox1.Text,
                FullName = NametextBox2.Text,
                ClassName = ClasstextBox3.Text
            };
        }

        private void ClearFields()
        {
            StudIdtextBox1.Clear();
            NametextBox2.Clear();
            ClasstextBox3.Clear();
            StudIdtextBox1.ReadOnly = false;
            StudIdtextBox1.Focus();
        }

        private void Add_Click(object? sender, EventArgs e)
        {
            var error = _students.Add(ReadFields());
            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }
            ClearFields();
            LoadGrid();
        }

        private void Update_Click(object? sender, EventArgs e)
        {
            var error = _students.Update(ReadFields());
            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }
            ClearFields();
            LoadGrid();
        }

        private void Delete_Click(object? sender, EventArgs e)
        {
            var error = _students.Delete(StudIdtextBox1.Text);
            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            ClearFields();
            LoadGrid();
        }

        private void Clear_Click(object? sender, EventArgs e) => ClearFields();
    }
}
