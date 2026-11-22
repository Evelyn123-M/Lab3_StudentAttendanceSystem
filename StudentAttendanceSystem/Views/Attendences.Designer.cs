namespace StudentAttendanceSystem
{
    partial class Attendences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Class = new Label();
            Date = new Label();
            YearcomboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            LoadStudent = new Button();
            SaveAttendance = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Class
            // 
            Class.AutoSize = true;
            Class.Location = new Point(2, 68);
            Class.Name = "Class";
            Class.Size = new Size(52, 25);
            Class.TabIndex = 0;
            Class.Text = "Class";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(269, 75);
            Date.Name = "Date";
            Date.Size = new Size(49, 25);
            Date.TabIndex = 1;
            Date.Text = "Date";
            // 
            // YearcomboBox1
            // 
            YearcomboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YearcomboBox1.FormattingEnabled = true;
            YearcomboBox1.Location = new Point(60, 68);
            YearcomboBox1.Name = "YearcomboBox1";
            YearcomboBox1.Size = new Size(182, 36);
            YearcomboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(333, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 4;
            // 
            // LoadStudent
            // 
            LoadStudent.BackColor = Color.Orange;
            LoadStudent.Location = new Point(655, 30);
            LoadStudent.Name = "LoadStudent";
            LoadStudent.Size = new Size(112, 34);
            LoadStudent.TabIndex = 5;
            LoadStudent.Text = "Load Student";
            LoadStudent.UseVisualStyleBackColor = false;
            // 
            // SaveAttendance
            // 
            SaveAttendance.BackColor = Color.Green;
            SaveAttendance.Location = new Point(655, 70);
            SaveAttendance.Name = "SaveAttendance";
            SaveAttendance.Size = new Size(112, 34);
            SaveAttendance.TabIndex = 6;
            SaveAttendance.Text = "Save";
            SaveAttendance.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, -5);
            label1.Name = "label1";
            label1.Size = new Size(313, 48);
            label1.TabIndex = 7;
            label1.Text = "Take Attendences";
            // 
            // Attendences
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(LoadStudent);
            Controls.Add(SaveAttendance);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(YearcomboBox1);
            Controls.Add(Date);
            Controls.Add(Class);
            Name = "Attendences";
            Text = "Attendences";
            Load += Attendences_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label Class;
        private Label Date;
        private ComboBox YearcomboBox1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button LoadStudent;
        private Button SaveAttendance;
        private Label label1;
    }
}