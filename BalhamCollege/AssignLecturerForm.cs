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
        private DataController DC;
        private ProgrammeAdministratorForm frmProgrammeAdministrator;
        private CurrencyManager cmCourse;
        private CurrencyManager cmLecturer;


        public AssignLecturerForm(DataController dc, ProgrammeAdministratorForm programmeAdministrator)
        {
            InitializeComponent();
            DC = dc;
            frmProgrammeAdministrator = programmeAdministrator;
            programmeAdministrator.Hide();
            BindControls();
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmCourse = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Course"];
            cmLecturer = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Lecturer"];

            // Bind list of courses
            lstCourses.DataSource = DC.dsBalhamCollegeAzure;
            lstCourses.DisplayMember = "Course.CourseID";
            lstCourses.ValueMember = "Course.CourseID";

            // Bind controls at right (for courses)
            txtCourseID.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Course.CourseID");
            txtCourseName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Course.CourseName");
            txtCredits.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Course.Credits");

            // Bind list of lecturers
            lstLecturers.DataSource = DC.dsBalhamCollegeAzure;
            lstLecturers.DisplayMember = "Lecturer.LecturerID";
            lstLecturers.ValueMember = "Lecturer.LecturerID";

            // Bind controls at right (for lecturers)
            txtLecturerID.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.LecturerID");
            txtLastName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.FirstName");
            txtRanking.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.Ranking");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProgrammeAdministrator.Show();
        }

        private void lstCourses_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text (for courses)
            DataRowView courseRow = (DataRowView)e.ListItem;
            e.Value = courseRow.Row["CourseID"] + " " + courseRow.Row["CourseName"];
        }

        private void lstLecturers_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text (for lecturers)
            DataRowView lecturerRow = (DataRowView)e.ListItem;
            e.Value = lecturerRow.Row["LecturerID"] + " " + lecturerRow.Row["LastName"] + ", " + lecturerRow.Row["FirstName"];
        }

        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {
            // Validate the entries in the fields
            if (cboRole.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                try
                {
                    // Create new row in the "ASSIGNMENT" table
                    DataRow newAssignmentRow = DC.dtAssignment.NewRow();

                    // Get selected rows from the "COURSE" and "LECTURER" tables
                    DataRow courseRow = DC.dtCourse.Rows[cmCourse.Position];
                    DataRow lecturerRow = DC.dtLecturer.Rows[cmLecturer.Position];

                    // Set values of the new row
                    newAssignmentRow["CourseID"] = courseRow["CourseID"];
                    newAssignmentRow["LecturerID"] = lecturerRow["LecturerID"];
                    newAssignmentRow["Role"] = cboRole.Text;

                    // Save new row in the "ASSIGNMENT" table
                    DC.dtAssignment.Rows.Add(newAssignmentRow);

                    DC.UpdateAssignment();
                    MessageBox.Show("Lecturer assigned successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Data.ConstraintException)
                {
                    // If an exception happened, then this lecturer is already assigned
                    MessageBox.Show("Lecturer already assigned to the course.", "Error");
                }
            }
        }

        private void cOURSEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOURSEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void AssignLecturerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);

        }
    }
}
