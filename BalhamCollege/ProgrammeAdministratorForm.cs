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
    public partial class ProgrammeAdministratorForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private UpdateCourseForm frmUpdateCourse; // the reference to the Update Course form

        public ProgrammeAdministratorForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            // show Update Course form upon click
            if (frmUpdateCourse == null)
            {
                frmUpdateCourse = new UpdateCourseForm(DC, this);
            }
            frmUpdateCourse.ShowDialog();

        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnProduceCoursesReport_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveLecturer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProgramme_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProgramme_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProgramme_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }
    }
}
