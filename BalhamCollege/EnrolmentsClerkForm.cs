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
    public partial class EnrolmentsClerkForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private DeleteStudentForm frmDeleteStudent;
        private AddStudentForm frmAddStudent; // the reference to the Add Student form
        private UpdateStudentForm frmUpdateStudent;

        public EnrolmentsClerkForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();

        }



        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //show Add Student form upon click
            if (frmAddStudent == null)
            {
                frmAddStudent = new AddStudentForm(DC, this);
            }
            frmAddStudent.ShowDialog();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (frmUpdateStudent == null)
            {
                frmUpdateStudent = new UpdateStudentForm(DC, this);
            }
            frmUpdateStudent.ShowDialog();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (frmDeleteStudent == null)
            {
                frmDeleteStudent = new DeleteStudentForm(DC, this);
            }
            frmDeleteStudent.ShowDialog();
        }

        private void btnStudentsReport_Click(object sender, EventArgs e)
        {

        }

        private void btnEnrolStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdrawStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }

        private void EnrolmentsClerkForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); // create the data controller and load the dataset
        }
    }
}
