using System.Runtime.ExceptionServices;

namespace prjIceTask4
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmForgotPassword frmForgotPassword = new frmForgotPassword();
            frmForgotPassword.Show();
            if(frmForgotPassword.Visible)
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            if(frmLogin.Visible)
            {
                this.Hide();
            }
        }
    }
}
