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
        private UpdateStudentForm frmUpdateStudent; // the reference to the Update Student form
        private EnrolStudentForm frmEnrolStudent; //the reference to the Enrol Student form
        private WithdrawStudentForm frmWithdrawStudent; //the reference to the Withdraw Student form
        private EnrolBackgroundForm frmBackground; //the reference to the Background form
        public EnrolmentsClerkForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();

        }



        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //show Background form on click
            frmBackground = new EnrolBackgroundForm(this);
            frmBackground.Show();
            //show Add Student form upon click
            frmAddStudent = new AddStudentForm(DC, this);
            frmAddStudent.ShowDialog();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            // show Update Student form upon click
            if (frmUpdateStudent == null)
            {
                frmUpdateStudent = new UpdateStudentForm(DC, this);
            }
            frmUpdateStudent.ShowDialog();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        { 
            // show Delete Student form and Background Form
            frmBackground = new EnrolBackgroundForm(this);
            frmBackground.Show();
            frmDeleteStudent = new DeleteStudentForm(DC, this);
            frmDeleteStudent.ShowDialog();
        }

        private void btnStudentsReport_Click(object sender, EventArgs e)
        {

        }

        private void btnEnrolStudent_Click(object sender, EventArgs e)
        {// show Enrol Student form 
            if (frmEnrolStudent == null)
            {
                frmEnrolStudent = new EnrolStudentForm(DC, this);
            }
            frmEnrolStudent.ShowDialog();
        }

        private void btnWithdrawStudent_Click(object sender, EventArgs e)
        {
            // show Withdraw Student form upon click
            if (frmWithdrawStudent == null)
            {
                frmWithdrawStudent = new WithdrawStudentForm(DC, this);
            }
            frmWithdrawStudent.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // returns user to login menu 
            this.Close();
            frmLogin.Show();
        }

        private void EnrolmentsClerkForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); // create the data controller and load the dataset
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // exit application 
        }
    }
}
