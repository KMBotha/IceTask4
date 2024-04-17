namespace prjIceTask4
{
    partial class frmLogin
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
            lblLoginForm = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblLoginForm
            // 
            lblLoginForm.AutoSize = true;
            lblLoginForm.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginForm.ForeColor = Color.FromArgb(54, 57, 70);
            lblLoginForm.Location = new Point(212, 9);
            lblLoginForm.Name = "lblLoginForm";
            lblLoginForm.Size = new Size(82, 27);
            lblLoginForm.TabIndex = 1;
            lblLoginForm.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(54, 57, 70);
            lblUsername.Location = new Point(45, 42);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(94, 32);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(54, 57, 70);
            lblPassword.Location = new Point(45, 74);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 32);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(145, 119);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(293, 119);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 7;
            button3.Text = "Forgot Password";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 167, 44);
            ClientSize = new Size(526, 154);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLoginForm);
            Name = "frmLogin";
            Text = "...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginForm;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}