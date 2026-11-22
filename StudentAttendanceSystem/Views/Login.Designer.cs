namespace StudentAttendanceSystem
{
    partial class Login
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
            Username = new Label();
            Password = new Label();
            PasswordtextBox1 = new TextBox();
            UsernametextBox2 = new TextBox();
            LoginButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Username.Location = new Point(12, 72);
            Username.Name = "Username";
            Username.Size = new Size(96, 25);
            Username.TabIndex = 4;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Password.Location = new Point(27, 175);
            Password.Name = "Password";
            Password.Size = new Size(92, 25);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // PasswordtextBox1
            // 
            PasswordtextBox1.Location = new Point(203, 169);
            PasswordtextBox1.Name = "PasswordtextBox1";
            PasswordtextBox1.Size = new Size(150, 31);
            PasswordtextBox1.TabIndex = 2;
            // 
            // UsernametextBox2
            // 
            UsernametextBox2.Location = new Point(203, 72);
            UsernametextBox2.Name = "UsernametextBox2";
            UsernametextBox2.Size = new Size(150, 31);
            UsernametextBox2.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Red;
            LoginButton.Location = new Point(220, 244);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 34);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 5;
            label1.Text = "User Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Controls.Add(UsernametextBox2);
            Controls.Add(PasswordtextBox1);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox PasswordtextBox1;
        private TextBox UsernametextBox2;
        private Button LoginButton;
        private Label label1;
    }
}