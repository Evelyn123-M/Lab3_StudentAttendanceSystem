namespace StudentAttendanceSystem
{
    partial class Reports
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
            Class = new Label();
            Date = new Label();
            ClasscomboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            Show = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Class
            // 
            Class.AutoSize = true;
            Class.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Class.Location = new Point(28, 66);
            Class.Name = "Class";
            Class.Size = new Size(57, 25);
            Class.TabIndex = 0;
            Class.Text = "Class";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.Location = new Point(301, 74);
            Date.Name = "Date";
            Date.Size = new Size(54, 25);
            Date.TabIndex = 1;
            Date.Text = "Date";
            // 
            // ClasscomboBox1
            // 
            ClasscomboBox1.FormattingEnabled = true;
            ClasscomboBox1.Location = new Point(86, 66);
            ClasscomboBox1.Name = "ClasscomboBox1";
            ClasscomboBox1.Size = new Size(182, 33);
            ClasscomboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(361, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // Show
            // 
            Show.BackColor = Color.HotPink;
            Show.Location = new Point(686, 74);
            Show.Name = "Show";
            Show.Size = new Size(112, 34);
            Show.TabIndex = 4;
            Show.Text = "Show";
            Show.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, -6);
            label1.Name = "label1";
            label1.Size = new Size(151, 48);
            label1.TabIndex = 6;
            label1.Text = "Reports";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Show);
            Controls.Add(dateTimePicker1);
            Controls.Add(ClasscomboBox1);
            Controls.Add(Date);
            Controls.Add(Class);
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Class;
        private Label Date;
        private ComboBox ClasscomboBox1;
        private DateTimePicker dateTimePicker1;
        private Button Show;
        private DataGridView dataGridView1;
        private Label label1;
    }
}