using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL_v2.LOGIN
{
    public partial class SIGN_UP_FORM_EMAIL : Form
    {
        public SIGN_UP_FORM_EMAIL()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            using(SIGN_UP_FORM_LOGIN_INFO signUpForm = new SIGN_UP_FORM_LOGIN_INFO())
            {
                signUpForm.ShowDialog();
            }
            this.Close();
        }

        private void SIGN_UP_FORM_EMAIL_Load(object sender, EventArgs e)
        {

            this.DoubleBuffered = true;
        }
    }
}
