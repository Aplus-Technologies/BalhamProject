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
        private DeleteLecturerForm frmDeleteLecturer; // reference to Delete Lecturer Form
        private AddLecturerForm frmAddLecturer; // reference to Add Lecturer Form 

        public HumanResourcesClerkForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            // show Add Lecturer form upon click
            if (frmAddLecturer == null)
            {
                frmAddLecturer = new AddLecturerForm(DC, this);
            }
            frmAddLecturer.ShowDialog();

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
            // show Delete Lecturer form upon click
            if (frmDeleteLecturer == null)
            {
                frmDeleteLecturer = new DeleteLecturerForm(DC, this);
            }
            frmDeleteLecturer.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }
    }
}
