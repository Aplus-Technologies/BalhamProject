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
    public partial class AssignLecturerForm : Form
    {
        //declare global variables
        private DataController DC;
        private ProgrammeAdministratorForm frmProgrammeAdministrator;
        private CurrencyManager cmCourse;
        private CurrencyManager cmLecturer;

        private DataTable dtCourse2;
        private DataView courseView2;

        private DataTable dtLecturer2;
        private DataView lecturerView2;

        private DataTable dtAssignment2;
        private DataView assignmentView2;

        public AssignLecturerForm(DataController dc, ProgrammeAdministratorForm programmeAdministrator)
        {
            InitializeComponent();
            DC = dc;
            frmProgrammeAdministrator = programmeAdministrator;
            programmeAdministrator.Hide();
            BindControls();
            TableAndView(); // generate updated table and views
        }

        private void TableAndView()
        {
            // create updated instances for Course table and dataview for Course table 
            dtCourse2 = dsBalhamCollegeAzure.COURSE;
            courseView2 = new DataView(dtCourse2);
            courseView2.Sort = "CourseID";

            // create updated instances for Lecturer table and dataview for Lecturer table 
            dtLecturer2 = dsBalhamCollegeAzure.LECTURER;
            lecturerView2 = new DataView(dtLecturer2);
            lecturerView2.Sort = "LecturerID";

            // create updated instances for Assignment table and dataview for Assignment table 
            dtAssignment2 = dsBalhamCollegeAzure.ASSIGNMENT;
            assignmentView2 = new DataView(dtAssignment2);
            assignmentView2.Sort = "CourseID, LecturerID";
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmCourse = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Course"];
            cmLecturer = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Lecturer"];
        }

        private void LoadCourses()
        {
            // To load all courses
            lstCourses.Items.Clear();
            foreach (DataRow drCourse in dtCourse2.Rows)
            {
                lstCourses.Items.Add(drCourse);
            }
        }

        private void LoadLecturers()
        {
            // To load all lecturers
            lstLecturers.Items.Clear();
            foreach (DataRow drLecturer in dtLecturer2.Rows)
            {
                lstLecturers.Items.Add(drLecturer);
            }
        }

        private void ClearFields()
        {
            // Clear all fields
            lstLecturers.Items.Clear();
            txtCourseID.Text = string.Empty;
            txtCourseName.Text = string.Empty;
            txtCredits.Text = string.Empty;
            txtLecturerID.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtRanking.Text = string.Empty;
            cboRole.Text = string.Empty;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); // prevents 'cannot accessed disposed object error' upon producing report 
            frmProgrammeAdministrator.Show();
        }

        private void lstCourses_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text (for courses)
            DataRow courseRow = (DataRow)e.ListItem;
            e.Value = courseRow["CourseID"] + " " + courseRow["CourseName"];
        }

        private void lstLecturers_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text (for lecturers)
            DataRow lecturerRow = (DataRow)e.ListItem;
            e.Value = lecturerRow["LecturerID"] + " " + lecturerRow["LastName"] + ", " + lecturerRow["FirstName"];
        }

        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {
            // Validate the entries in the fields
            if (lstCourses.SelectedItem == null || lstLecturers.SelectedItem == null || cboRole.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                try
                {
                    // Get selected rows from the "COURSE" and "LECTURER" tables
                    DataRow courseRow = dtCourse2.Rows[cmCourse.Position];
                    DataRow lecturerRow = dtLecturer2.Rows[cmLecturer.Position];

                    // Create new row in the "ASSIGNMENT" table
                    this.aSSIGNMENTTableAdapter.Insert(Convert.ToInt32(courseRow["CourseID"]), Convert.ToInt32(lecturerRow["LecturerID"]), cboRole.Text);

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
                    this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
                    this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSIGNMENT' table. You can move, or remove it, as needed.
                    this.aSSIGNMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSIGNMENT);

                    LoadCourses();
                    MessageBox.Show("Lecturer assigned successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    // If an exception happened, then this lecturer is already assigned
                    MessageBox.Show("Lecturer already assigned to the course.", "Error");
                    LoadCourses();
                    ClearFields();
                }
            }
        }

        private void AssignLecturerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSIGNMENT' table. You can move, or remove it, as needed.
            this.aSSIGNMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSIGNMENT);

            LoadCourses();
            ClearFields();
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow drCourse = (DataRow)lstCourses.SelectedItem;
            cmCourse.Position = courseView2.Find(drCourse["CourseID"]);

            // To populate the following controls with their corresponding values; from Course Table 
            txtCourseID.Text = drCourse["CourseID"].ToString();
            txtCourseName.Text = drCourse["CourseName"].ToString();
            txtCredits.Text = drCourse["Credits"].ToString();

            LoadLecturers();
        }

        private void lstLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow drLecturer = (DataRow)lstLecturers.SelectedItem;
            cmLecturer.Position = lecturerView2.Find(drLecturer["LecturerID"]);

            // To populate the following controls with their corresponding values; from Lecturer Table 
            txtLecturerID.Text = drLecturer["LecturerID"].ToString();
            txtLastName.Text = drLecturer["LastName"].ToString();
            txtFirstName.Text = drLecturer["FirstName"].ToString();
            txtRanking.Text = drLecturer["Ranking"].ToString();
        }

        private void cOURSEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOURSEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }
    }
}
