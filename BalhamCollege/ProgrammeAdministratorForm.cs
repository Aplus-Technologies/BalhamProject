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
        private AssignLecturerForm frmAssignLecturer; // the reference to the Assign Lecturer form
        private DeleteProgrammeForm frmDeleteProgramme; // reference to Delete Programme Form
        private DeleteCourseForm frmDeleteCourse; // reference to Delete Course Form


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
            // show Delete Course form upon click
            if (frmDeleteCourse == null)
            {
                frmDeleteCourse = new DeleteCourseForm(DC, this);
            }
            frmDeleteCourse.ShowDialog();

        }

        private void btnProduceCoursesReport_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {
            // show Assign Lecturer form upon click
            if (frmAssignLecturer == null)
            {
                frmAssignLecturer = new AssignLecturerForm(DC, this);
            }
            frmAssignLecturer.ShowDialog();
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
            // show Assign Lecturer form upon click
            if (frmDeleteProgramme == null)
            {
                frmDeleteProgramme = new DeleteProgrammeForm (DC, this);
            }
            frmDeleteProgramme.ShowDialog();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }
    }
}
