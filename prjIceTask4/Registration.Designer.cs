namespace prjIceTask4
{
    partial class Registration
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
            lblForgotPassword = new Label();
            btnRegister = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            SuspendLayout();
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.FromArgb(54, 57, 70);
            lblForgotPassword.Location = new Point(198, 9);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(115, 27);
            lblForgotPassword.TabIndex = 3;
            lblForgotPassword.Text = "Register";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(130, 110);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(132, 23);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(54, 57, 70);
            lblPassword.Location = new Point(38, 68);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 32);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(54, 57, 70);
            lblUsername.Location = new Point(34, 33);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(94, 32);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 167, 44);
            ClientSize = new Size(526, 154);
            Controls.Add(btnRegister);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblForgotPassword);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblForgotPassword;
        private Button button3;
        private Button btnRegister;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblPassword;
        private Label lblUsername;
    }
}