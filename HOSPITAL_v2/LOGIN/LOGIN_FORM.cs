using HOSPITAL_v2.LOGIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL_v2
{
    public partial class LOGIN_FORM : Form
    {
        public LOGIN_FORM()
        {
            InitializeComponent();
        }

        private void lbForgot_MouseEnter(object sender, EventArgs e)
        {
            lbForgot.ForeColor = Color.Indigo;
        }

        private void lbForgot_MouseLeave(object sender, EventArgs e)
        {
            lbForgot.ForeColor = Color.DarkGray;
        }

        private void lbForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FORGOT_PASSWORD_FORM_RESET_CODE resetForm = new FORGOT_PASSWORD_FORM_RESET_CODE())
            {
                resetForm.ShowDialog();                
            }
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            using (SIGN_UP_FORM_EMAIL signUpForm = new SIGN_UP_FORM_EMAIL())
            {
                signUpForm.ShowDialog();
            }
        }

        private void LOGIN_FORM_Load(object sender, EventArgs e)
        {

            this.DoubleBuffered = true;
        }
    }
}
