namespace StudentAttendanceSystem
{
    partial class Students
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
            StuID = new Label();
            FullNameLabel = new Label();
            Class = new Label();
            StudIdtextBox1 = new TextBox();
            NametextBox2 = new TextBox();
            ClasstextBox3 = new TextBox();
            Add = new Button();
            Update = new Button();
            Delete = new Button();
            Clear = new Button();
            Search = new Label();
            SearchtextBox1 = new TextBox();
            StudentsdataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)StudentsdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // StuID
            // 
            StuID.AutoSize = true;
            StuID.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            StuID.Location = new Point(6, 65);
            StuID.Name = "StuID";
            StuID.Size = new Size(100, 25);
            StuID.TabIndex = 0;
            StuID.Text = "Student Id";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FullNameLabel.Location = new Point(12, 105);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(96, 25);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full name";
            // 
            // Class
            // 
            Class.AutoSize = true;
            Class.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Class.Location = new Point(12, 158);
            Class.Name = "Class";
            Class.Size = new Size(56, 25);
            Class.TabIndex = 2;
            Class.Text = "Class";
            // 
            // StudIdtextBox1
            // 
            StudIdtextBox1.Location = new Point(106, 65);
            StudIdtextBox1.Name = "StudIdtextBox1";
            StudIdtextBox1.Size = new Size(150, 31);
            StudIdtextBox1.TabIndex = 3;
            // 
            // NametextBox2
            // 
            NametextBox2.Location = new Point(106, 105);
            NametextBox2.Name = "NametextBox2";
            NametextBox2.Size = new Size(150, 31);
            NametextBox2.TabIndex = 4;
            // 
            // ClasstextBox3
            // 
            ClasstextBox3.Location = new Point(106, 152);
            ClasstextBox3.Name = "ClasstextBox3";
            ClasstextBox3.Size = new Size(150, 31);
            ClasstextBox3.TabIndex = 5;
            // 
            // Add
            // 
            Add.BackColor = Color.Orchid;
            Add.ForeColor = SystemColors.ControlText;
            Add.Location = new Point(274, 56);
            Add.Name = "Add";
            Add.Size = new Size(112, 34);
            Add.TabIndex = 6;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            Update.BackColor = Color.Cyan;
            Update.Location = new Point(435, 56);
            Update.Name = "Update";
            Update.Size = new Size(112, 34);
            Update.TabIndex = 7;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(255, 255, 128);
            Delete.Location = new Point(288, 105);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 34);
            Delete.TabIndex = 8;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            Clear.BackColor = Color.FromArgb(255, 192, 192);
            Clear.Location = new Point(435, 100);
            Clear.Name = "Clear";
            Clear.Size = new Size(112, 34);
            Clear.TabIndex = 9;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Search.Location = new Point(574, 56);
            Search.Name = "Search";
            Search.Size = new Size(68, 25);
            Search.TabIndex = 10;
            Search.Text = "Search";
            // 
            // SearchtextBox1
            // 
            SearchtextBox1.Location = new Point(644, 50);
            SearchtextBox1.Name = "SearchtextBox1";
            SearchtextBox1.Size = new Size(150, 31);
            SearchtextBox1.TabIndex = 11;
            // 
            // StudentsdataGridView1
            // 
            StudentsdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsdataGridView1.Location = new Point(306, 189);
            StudentsdataGridView1.Name = "StudentsdataGridView1";
            StudentsdataGridView1.RowHeadersWidth = 62;
            StudentsdataGridView1.Size = new Size(360, 225);
            StudentsdataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, -5);
            label1.Name = "label1";
            label1.Size = new Size(150, 45);
            label1.TabIndex = 13;
            label1.Text = "Students";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(StudentsdataGridView1);
            Controls.Add(SearchtextBox1);
            Controls.Add(Search);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Add);
            Controls.Add(ClasstextBox3);
            Controls.Add(NametextBox2);
            Controls.Add(StudIdtextBox1);
            Controls.Add(Class);
            Controls.Add(FullNameLabel);
            Controls.Add(StuID);
            base.Name = "Students";
            Text = "Students";
            Load += Students_Load;
            ((System.ComponentModel.ISupportInitialize)StudentsdataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label StuID;
        private Label Full;
        private Label Class;
        private Label FullNameLabel;
        private TextBox StudIdtextBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox NametextBox2;
        private TextBox ClasstextBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button Update;
        private Button Add;
        private Button Delete;
        private Button Clear;
        private Label Search;
        private TextBox SearchtextBox1;
        private DataGridView StudentsdataGridView1;
    }
}