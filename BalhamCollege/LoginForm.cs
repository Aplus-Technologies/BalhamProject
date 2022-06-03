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
    public partial class LoginForm : Form
    {
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolmentClerk;
        private HumanResourcesClerkForm frmHumanResourcesClerk;
        private ResearchAdministratorForm frmResearchAdministrator;
        private ProgrammeAdministratorForm frmProgramAdministrator;
        private CourseAdministratorForm frmCourseAdministrator;
        private StudentsSupportClerkForm frmStudentsSupportClerk;
        
        public LoginForm()
        {
            InitializeComponent();
            
        }

      
       
        private void LoginForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();
            
        }

        private void ClearFields()
        { // clear textboxes and check box
            txtPassword.Text = "";
            txtUsername.Text = "";
            chkBox_login.Checked = false;
        }


      // system checks username and password combination and takes user to matching page
        private void pbLoginButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "enrol" && txtPassword.Text == "enrol123")
            {
                if (frmEnrolmentClerk == null)
                {
                    frmEnrolmentClerk = new EnrolmentsClerkForm(DC, this);
                }
                ClearFields();
                frmEnrolmentClerk.ShowDialog();
            }
            else if (txtUsername.Text == "course" && txtPassword.Text == "course123")
            {
                if (frmCourseAdministrator == null)
                {
                    frmCourseAdministrator = new CourseAdministratorForm(DC, this);
                }
                ClearFields();
                frmCourseAdministrator.ShowDialog();
            }
            else if (txtUsername.Text == "human" && txtPassword.Text == "human123")
            {
                if (frmHumanResourcesClerk == null)
                {
                    frmHumanResourcesClerk = new HumanResourcesClerkForm(DC, this);
                }
                ClearFields();
                frmHumanResourcesClerk.ShowDialog();
            }
            else if (txtUsername.Text == "programme" && txtPassword.Text == "programme123")
            {
                if (frmProgramAdministrator == null)
                {
                    frmProgramAdministrator = new ProgrammeAdministratorForm(DC, this);
                }
                ClearFields();
                frmProgramAdministrator.ShowDialog();
            }
            else if (txtUsername.Text == "research" && txtPassword.Text == "research123")
            {
                if (frmResearchAdministrator == null)
                {
                    frmResearchAdministrator = new ResearchAdministratorForm(DC, this);
                }
                ClearFields();
                frmResearchAdministrator.ShowDialog();
            }
            else if (txtUsername.Text == "student" && txtPassword.Text == "student123")
            {
                if (frmStudentsSupportClerk == null)
                {
                    frmStudentsSupportClerk = new StudentsSupportClerkForm(DC, this);
                }
                ClearFields();
                frmStudentsSupportClerk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or Password invalid, please re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       
    }
}
