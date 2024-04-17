namespace prjIceTask4
{
    partial class frmForgotPassword
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
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.FromArgb(54, 57, 70);
            lblForgotPassword.Location = new Point(142, 9);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(223, 27);
            lblForgotPassword.TabIndex = 2;
            lblForgotPassword.Text = "Forgot Password";
            lblForgotPassword.Click += this.lblWelcom_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(54, 57, 70);
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(206, 32);
            label2.TabIndex = 0;
            label2.Text = "Please enter your email: ";
            // 
            // button2
            // 
            button2.Location = new Point(211, 91);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 7;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 167, 44);
            ClientSize = new Size(526, 154);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(lblForgotPassword);
            Controls.Add(label2);
            Name = "frmForgotPassword";
            Text = "...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblForgotPassword;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
    }
}