namespace StudentAttendanceSystem
{
    partial class Main_Menu
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
            Students = new Button();
            Attendence = new Button();
            Reports = new Button();
            Logout = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Students
            // 
            Students.BackColor = Color.Yellow;
            Students.Location = new Point(185, 106);
            Students.Name = "Students";
            Students.Size = new Size(112, 34);
            Students.TabIndex = 0;
            Students.Text = "Students";
            Students.UseVisualStyleBackColor = false;
            // 
            // Attendence
            // 
            Attendence.BackColor = Color.Orange;
            Attendence.Location = new Point(185, 182);
            Attendence.Name = "Attendence";
            Attendence.Size = new Size(112, 34);
            Attendence.TabIndex = 1;
            Attendence.Text = "Attendence";
            Attendence.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            Reports.BackColor = Color.Green;
            Reports.Location = new Point(185, 246);
            Reports.Name = "Reports";
            Reports.Size = new Size(112, 34);
            Reports.TabIndex = 2;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = false;
            // 
            // Logout
            // 
            Logout.BackColor = Color.Red;
            Logout.Location = new Point(185, 303);
            Logout.Name = "Logout";
            Logout.Size = new Size(112, 34);
            Logout.TabIndex = 3;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 23);
            label1.Name = "label1";
            label1.Size = new Size(212, 48);
            label1.TabIndex = 4;
            label1.Text = "Main Menu";
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Logout);
            Controls.Add(Reports);
            Controls.Add(Attendence);
            Controls.Add(Students);
            Name = "Main_Menu";
            Text = "Main_Menu";
            Load += Main_Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button Students;
        private Button Reports;
        private Button Logout;
        private Button Attendence;
        private Label label1;
    }
}