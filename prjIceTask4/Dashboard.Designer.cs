namespace prjIceTask4
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            lblForgotPassword = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.FromArgb(54, 57, 70);
            lblForgotPassword.Location = new Point(12, 9);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(157, 27);
            lblForgotPassword.TabIndex = 4;
            lblForgotPassword.Text = "Dashboard";
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "View Work";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 57, 70);
            label1.Location = new Point(206, 64);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(27, 86);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Add Work";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\kelly\\source\\repos\\prjIceTask4\\prjIceTask4\\Pictures\\download.png";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(212, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 124);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 167, 44);
            ClientSize = new Size(526, 154);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblForgotPassword);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblForgotPassword;
        private Button button1;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}