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

        // variables to store control location and size    
        private Rectangle txtUserNameOriginalRect;
        private Rectangle txtPasswordOriginalRect;
        private Rectangle btnLoginOriginalRect;
        private Rectangle btnForgotOriginalRect;
         
        
        private Size formOriginalSize;

        public LoginForm()
        {
            InitializeComponent();

        }

      
        private void LoginForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();
            Font LargeFont = new Font("Arial", 12);

            // keep track of original control size, for autoresizing (original location and size)
            formOriginalSize = this.Size;
            txtUserNameOriginalRect = new Rectangle(txtUsername.Location.X, txtUsername.Location.Y, txtUsername.Width, txtUsername.Height);
            txtPasswordOriginalRect = new Rectangle(txtPassword.Location.X, txtPassword.Location.Y, txtPassword.Width, txtPassword.Height);
            btnLoginOriginalRect = new Rectangle(btnLogin.Location.X, btnLogin.Location.Y, btnLogin.Width, btnLogin.Height);
            btnForgotOriginalRect = new Rectangle(btnForgot.Location.X, btnForgot.Location.Y, btnForgot.Width, btnForgot.Height);
                   
            //open form maximized 
            if (this.WindowState == FormWindowState.Normal)
            {  // open form to maximize after 1 sec interval 
                timer1.Interval = 1000;
                this.WindowState = FormWindowState.Maximized;
            }


        }


        private void resizeChildrenControls()
        {
            resizeControl(txtUserNameOriginalRect, txtUsername);
            resizeControl(txtPasswordOriginalRect, txtPassword);
            resizeControl(btnLoginOriginalRect, btnLogin);
            resizeControl(btnForgotOriginalRect, btnForgot);
           
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

            if (this.WindowState == FormWindowState.Maximized)
            {
                btnForgot.Font = new Font("Arial", 9, FontStyle.Underline);
                txtUsername.Font = new Font("Arial", 12);
                txtPassword.Font = new Font("Arial", 12);
                btnLogin.Font = new Font("Arial", 11);

                float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
                float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

                // new location of txtUsername upon form maximize
                int newX = (int)(txtUserNameOriginalRect.X * xRatio) ;
                int newY = (int)(txtUserNameOriginalRect.Y * yRatio) + 5;
                // new location of txtPassword upon form maximize
                int newX2 = (int)(txtPasswordOriginalRect.X * xRatio);
                int newY2 = (int)(txtPasswordOriginalRect.Y * yRatio) + 5;

                // new size of txtUsername upon form maximize
                int newWidth = (int)(txtUserNameOriginalRect.Width * xRatio);
                int newHeight = (int)(txtUserNameOriginalRect.Height * yRatio);
                // new size of txtPassword upon form maximize
                int newWidth2 = (int)(txtPasswordOriginalRect.Width * xRatio);
                int newHeight2 = (int)(txtPasswordOriginalRect.Height * yRatio);

                // set new location X,Y and size X,Y of txtUsername and txtPassword upon form maximization
                Control control1 = txtUsername;
                Control control2 = txtPassword;
                control1.Location = new Point(newX, newY);
                control1.Size = new Size(newWidth, newHeight);

                control2.Location = new Point(newX2, newY2);
                control2.Size = new Size(newWidth2, newHeight2);

            }
            else
            {
                btnForgot.Font = new Font("Arial", 6, FontStyle.Underline);                
                txtUsername.Font = new Font("Arial", 8);
                txtPassword.Font = new Font("Arial", 8);
                btnLogin.Font = new Font("Arial", 7);
            }
        }

        private void ClearFields()
        { // clear textboxes and check box
            txtPassword.Text = "";
            txtUsername.Text = "";
            
        }


        // system checks username and password combination and takes user to matching page
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // remove whitespace from input of username and password
            String txtUsernameTrim = String.Concat(txtUsername.Text.Where(c => !Char.IsWhiteSpace(c)));
            String txtPasswordTrim = String.Concat(txtPassword.Text.Where(c => !Char.IsWhiteSpace(c)));

            if (txtUsernameTrim == "enrol" && txtPasswordTrim == "enrol123")
            {
                if (frmEnrolmentClerk == null)
                {
                    frmEnrolmentClerk = new EnrolmentsClerkForm(DC, this);
                }
                ClearFields();
                frmEnrolmentClerk.ShowDialog();
            }
            else if (txtUsernameTrim == "course" && txtPasswordTrim == "course123")
            {
                if (frmCourseAdministrator == null)
                {
                    frmCourseAdministrator = new CourseAdministratorForm(DC, this);
                }
                ClearFields();
                frmCourseAdministrator.ShowDialog();
            }
            else if (txtUsernameTrim == "human" && txtPasswordTrim == "human123")
            {
                if (frmHumanResourcesClerk == null)
                {
                    frmHumanResourcesClerk = new HumanResourcesClerkForm(DC, this);
                }
                ClearFields();
                frmHumanResourcesClerk.ShowDialog();
            }
            else if (txtUsernameTrim == "programme" && txtPasswordTrim == "programme123")
            {
                if (frmProgramAdministrator == null)
                {
                    frmProgramAdministrator = new ProgrammeAdministratorForm(DC, this);
                }
                ClearFields();
                frmProgramAdministrator.ShowDialog();
            }
            else if (txtUsernameTrim == "research" && txtPasswordTrim == "research123")
            {
                if (frmResearchAdministrator == null)
                {
                    frmResearchAdministrator = new ResearchAdministratorForm(DC, this);
                }
                ClearFields();
                frmResearchAdministrator.ShowDialog();
            }
            else if (txtUsernameTrim == "student" && txtPasswordTrim == "student123")
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
