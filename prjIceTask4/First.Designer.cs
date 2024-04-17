namespace prjIceTask4
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcom = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblWelcom
            // 
            lblWelcom.AutoSize = true;
            lblWelcom.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcom.ForeColor = Color.FromArgb(54, 57, 70);
            lblWelcom.Location = new Point(168, 9);
            lblWelcom.Name = "lblWelcom";
            lblWelcom.Size = new Size(192, 27);
            lblWelcom.TabIndex = 0;
            lblWelcom.Text = "Welcome to ...";
            lblWelcom.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(182, 54);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(182, 103);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(143, 23);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button2_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 167, 44);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(526, 154);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblWelcom);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMenu";
            Text = "...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcom;
        private Button btnLogin;
        private Button btnRegister;
    }
}
