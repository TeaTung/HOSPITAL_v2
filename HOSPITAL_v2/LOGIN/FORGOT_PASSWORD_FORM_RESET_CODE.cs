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
    public partial class FORGOT_PASSWORD_FORM_RESET_CODE : Form
    {
        public FORGOT_PASSWORD_FORM_RESET_CODE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            using(FORGOT_PASSWORD_FORM_NEW_PASSWORD newPassForm = new FORGOT_PASSWORD_FORM_NEW_PASSWORD(tbEmail.Text))
            {
                newPassForm.ShowDialog();
            }
            this.Close();
        }

        private void FORGOT_PASSWORD_FORM_RESET_CODE_Load(object sender, EventArgs e)
        {

        }
    }
}
