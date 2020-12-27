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
    public partial class FORGOT_PASSWORD_FORM_NEW_PASSWORD : Form
    {
        public FORGOT_PASSWORD_FORM_NEW_PASSWORD(string email)
        {
            InitializeComponent();
        }

        private void FORGOT_PASSWORD_FORM_NEW_PASSWORD_Load(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
