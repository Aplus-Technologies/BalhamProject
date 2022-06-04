using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalhamCollege
{
    public partial class HumanResourcesClerkForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private UpdateLecturerForm frmUpdateLecturer; // the reference to the Update Lecturer form

        public HumanResourcesClerkForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateLecturer_Click(object sender, EventArgs e)
        {
            // show Update Lecturer form upon click
            if (frmUpdateLecturer == null)
            {
                frmUpdateLecturer = new UpdateLecturerForm(DC, this);
            }
            frmUpdateLecturer.ShowDialog();
        }

        private void btnLecturerReport_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteLecturer_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }
    }
}
