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
    public partial class SIGN_UP_FORM_LOGIN_INFO : Form
    {
        public SIGN_UP_FORM_LOGIN_INFO()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(cbRole.Text == "Doctor")
            {
                using(SIGN_UP_FORM_USER_INFO_DOCTOR doctorSignUpForm = new SIGN_UP_FORM_USER_INFO_DOCTOR())
                {
                    doctorSignUpForm.ShowDialog();
                }
            }
        }
    }
}
