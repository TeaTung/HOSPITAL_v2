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
    }
}
