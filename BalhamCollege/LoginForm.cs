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

        
        private Rectangle txtUserNameOriginalRect;
        private Rectangle txtPasswordOriginalRect;
        private Rectangle btnLoginOriginalRect;
        private Rectangle btnForgotOriginalRect;
        
        
        // will delete line 31-36 when testing is finished
        private Rectangle btnCourseAdminOriginalRect;
        private Rectangle btnStudentSupportOriginalRect;
        private Rectangle btnHumanResOriginalRect;
        private Rectangle btnProgAdminOriginalRect;
        private Rectangle btnResAdminOriginalRect;
        private Rectangle btnEnrolmentsClerkOriginalRect;

        private Size formOriginalSize;

        public LoginForm()
        {
            InitializeComponent();
            
        }

      
        private void LoginForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();

            // keep track of original control size, for autoresizing (original location and size)
            formOriginalSize = this.Size;
            txtUserNameOriginalRect = new Rectangle(txtUsername.Location.X, txtUsername.Location.Y, txtUsername.Width, txtUsername.Height);
            txtPasswordOriginalRect = new Rectangle(txtPassword.Location.X, txtPassword.Location.Y, txtPassword.Width, txtPassword.Height);
            btnLoginOriginalRect = new Rectangle(btnLogin.Location.X, btnLogin.Location.Y, btnLogin.Width, btnLogin.Height);
            btnForgotOriginalRect = new Rectangle(btnForgot.Location.X, btnForgot.Location.Y, btnForgot.Width, btnForgot.Height);
          
            // delete line 59-65 after testing is over (for autoresizing of buttons, original button location and size)
            btnCourseAdminOriginalRect = new Rectangle(btnCourseAdmin.Location.X, btnCourseAdmin.Location.Y, btnCourseAdmin.Width, btnCourseAdmin.Height);
            btnStudentSupportOriginalRect = new Rectangle(btnStudentSupport.Location.X, btnStudentSupport.Location.Y, btnStudentSupport.Width, btnStudentSupport.Height);
            btnHumanResOriginalRect = new Rectangle(btnHumanResources.Location.X, btnHumanResources.Location.Y, btnHumanResources.Width, btnHumanResources.Height);
            btnProgAdminOriginalRect = new Rectangle(btnProgrammeAdmin.Location.X, btnProgrammeAdmin.Location.Y, btnProgrammeAdmin.Width, btnProgrammeAdmin.Height);
            btnResAdminOriginalRect = new Rectangle(btnResearchAdmin.Location.X, btnResearchAdmin.Location.Y, btnResearchAdmin.Width, btnResearchAdmin.Height);
            btnEnrolmentsClerkOriginalRect = new Rectangle(btnEnrolmentsAdmin.Location.X, btnEnrolmentsAdmin.Location.Y, btnEnrolmentsAdmin.Width, btnEnrolmentsAdmin.Height);

        }

        private void resizeChildrenControls()
        {
            resizeControl(txtUserNameOriginalRect, txtUsername);
            resizeControl(txtPasswordOriginalRect, txtPassword);
            resizeControl(btnLoginOriginalRect, btnLogin);
            resizeControl(btnForgotOriginalRect, btnForgot);
           
            // delete line 77-82 after testing 
            resizeControl(btnCourseAdminOriginalRect, btnCourseAdmin);
            resizeControl(btnStudentSupportOriginalRect, btnStudentSupport);
            resizeControl(btnHumanResOriginalRect, btnHumanResources);
            resizeControl(btnProgAdminOriginalRect, btnProgrammeAdmin);
            resizeControl(btnResAdminOriginalRect, btnResearchAdmin);
            resizeControl(btnEnrolmentsClerkOriginalRect, btnEnrolmentsAdmin);

        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {// auto adjust control based on original location, height and width
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);


            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

        }

        private void LoginForm_Resize(object sender, EventArgs e)
        { // autosize form controls upon window size change 
            resizeChildrenControls();
        }

        private void ClearFields()
        { // clear textboxes and check box
            txtPassword.Text = "";
            txtUsername.Text = "";
            
        }



        private void btnCourseAdmin_Click(object sender, EventArgs e)
        {
            if (frmCourseAdministrator == null)
            {
                frmCourseAdministrator = new CourseAdministratorForm(DC, this);
            }
            ClearFields();
            frmCourseAdministrator.ShowDialog();
        }

        private void btnStudentSupport_Click(object sender, EventArgs e)
        {
            if (frmStudentsSupportClerk == null)
            {
                frmStudentsSupportClerk = new StudentsSupportClerkForm(DC, this);
            }
            ClearFields();
            frmStudentsSupportClerk.ShowDialog();
        }

        private void btnHumanResources_Click(object sender, EventArgs e)
        {
            if (frmHumanResourcesClerk == null)
            {
                frmHumanResourcesClerk = new HumanResourcesClerkForm(DC, this);
            }
            ClearFields();
            frmHumanResourcesClerk.ShowDialog();
        }

        private void btnProgrammeAdmin_Click(object sender, EventArgs e)
        {
            if (frmProgramAdministrator == null)
            {
                frmProgramAdministrator = new ProgrammeAdministratorForm(DC, this);
            }
            ClearFields();
            frmProgramAdministrator.ShowDialog();
        }

        private void btnResearchAdmin_Click(object sender, EventArgs e)
        {
            if (frmResearchAdministrator == null)
            {
                frmResearchAdministrator = new ResearchAdministratorForm(DC, this);
            }
            ClearFields();
            frmResearchAdministrator.ShowDialog();
        }

        private void btnEnrolmentsAdmin_Click(object sender, EventArgs e)
        {
            if (frmEnrolmentClerk == null)
            {
                frmEnrolmentClerk = new EnrolmentsClerkForm(DC, this);
            }
            ClearFields();
            frmEnrolmentClerk.ShowDialog();
        }

        // system checks username and password combination and takes user to matching page
        private void btnLogin_Click(object sender, EventArgs e)
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
            {  // error message if username and password combination are invalid
                MessageBox.Show("Username or Password invalid, please re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnForgot_Click(object sender, EventArgs e)
        {
            // error message that appears when user forgets username and password
            MessageBox.Show("Usernames and Passwords:\n\nCourse Administrator\nUser: course, Password: course123\n\nEnrolments Clerk\nUser: enrol, Password: enrol123\n\nHuman Resources Clerk\nUser: human, Password: human123\n\nProgramme Admin\nUser: programme, Password: programme123\n\nResearch Administrator\nUser: research, Password: research123\n\nStudent Support Clerk\nUser: student, Password: student123", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
