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
    public partial class SIGN_UP_FORM_USER_INFO_OTHER : Form
    {
        public SIGN_UP_FORM_USER_INFO_OTHER(string email, string username, string password)
        {
            InitializeComponent();
        }

        private void SIGN_UP_FORM_USER_INFO_OTHER_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
