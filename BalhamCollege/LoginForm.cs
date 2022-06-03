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
        private trialLogin4 trialogin;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEnrolmentsClerk_Click(object sender, EventArgs e)
        {
            if (frmEnrolmentClerk == null)
            {
                frmEnrolmentClerk = new EnrolmentsClerkForm(DC, this);
            }
            frmEnrolmentClerk.ShowDialog();
        }
        private void btnHumanResourcesClerk_Click(object sender, EventArgs e)
        {
            if (frmHumanResourcesClerk == null)
            {
                frmHumanResourcesClerk = new HumanResourcesClerkForm(DC, this);
            }
            frmHumanResourcesClerk.ShowDialog();
        }

        private void btnResearchAdministrator_Click(object sender, EventArgs e)
        {
            if (frmResearchAdministrator == null)
            {
                frmResearchAdministrator = new ResearchAdministratorForm(DC, this);
            }
            frmResearchAdministrator.ShowDialog();
        }

        private void btnProgramAdministrator_Click(object sender, EventArgs e)
        {
            if (frmProgramAdministrator == null)
            {
                frmProgramAdministrator = new ProgrammeAdministratorForm(DC, this);
            }
            frmProgramAdministrator.ShowDialog();
        }

        private void btnCourseAdministrator_Click(object sender, EventArgs e)
        {
            if (frmCourseAdministrator == null)
            {
                frmCourseAdministrator = new CourseAdministratorForm(DC, this);
            }
            frmCourseAdministrator.ShowDialog();
        }

        private void btnStudentsSupportClerk_Click(object sender, EventArgs e)
        {
            if (frmStudentsSupportClerk == null)
            {
                frmStudentsSupportClerk = new StudentsSupportClerkForm(DC, this);
            }
            frmStudentsSupportClerk.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trialogin == null)
            {
                trialogin = new trialLogin4(DC, this);
            }
            trialogin.ShowDialog();
        }
    }
}
