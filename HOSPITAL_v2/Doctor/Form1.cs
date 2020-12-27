using HOSPITAL_v2.Doctor.uCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectAAA
{
    public partial class Form1 : Form
    {
        #region my variables
        UserControl uCon;

        #endregion

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uCon = new uConPatientInfo();
            pnlMain.Controls.Add(uCon);
            uCon.Location = new Point(20, 100);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            ChangeBackground(sender);
        }

        /// <summary>
        ///  Change background and move the location of pnlbutton
        /// </summary>
        /// <param name="sender"></param>
        void ChangeBackground(object sender )
        {
            (sender as Guna.UI2.WinForms.Guna2Button).FillColor = Color.White;
            (sender as Guna.UI2.WinForms.Guna2Button).ForeColor = Color.Gray;
            Control tem = sender as Control;
            pnlButton.Location = new Point(tem.Location.X, tem.Location.Y + tem.Height);
            foreach(Control item in this.Controls)
            {
                if(item != sender && item is Guna.UI2.WinForms.Guna2Button)
                {
                    ((Guna.UI2.WinForms.Guna2Button)item).FillColor = Color.FromArgb(244, 245, 247);
                    ((Guna.UI2.WinForms.Guna2Button)item).ForeColor = Color.FromArgb(142, 154, 166);
                }
            }
        }
    }
}
