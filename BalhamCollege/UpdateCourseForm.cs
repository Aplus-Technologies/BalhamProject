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
    public partial class UpdateCourseForm : Form
    {
        private DataController DC;
        private ProgrammeAdministratorForm frmProgrammeAdministrator;
        private CurrencyManager cmCourse;
        private CurrencyManager cmProgramme;


        public UpdateCourseForm(DataController dc, ProgrammeAdministratorForm programmeAdministrator)
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
            cmProgramme = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Programme"];

            // Bind list of courses
            lstCourses.DataSource = DC.dsBalhamCollegeAzure;
            lstCourses.DisplayMember = "Course.CourseID";
            lstCourses.ValueMember = "Course.CourseID";

            // Bind controls at right
            txtCourseID.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Course.CourseID");
            txtCourseName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Course.CourseName");
            nudCredits.DataBindings.Add("Value", DC.dsBalhamCollegeAzure, "Course.Credits");
            cboStatus.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Course.Status");
            nudFee.DataBindings.Add("Value", DC.dsBalhamCollegeAzure, "Course.Fee");
            txtProgrammeName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Programme.ProgrammeName");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProgrammeAdministrator.Show();
        }

        private void lstCourses_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRowView courseRow = (DataRowView)e.ListItem;
            e.Value = courseRow.Row["CourseID"] + " " + courseRow.Row["CourseName"];
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            DataRow updateCourseRow = DC.dtCourse.Rows[cmCourse.Position];

            // Validate the entries in the fields
            if ((txtCourseName.Text == "") || (nudCredits.Text == "") || (cboStatus.Text == "") || (nudFee.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change the course's details?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Save changes
                    updateCourseRow["CourseName"] = txtCourseName.Text;
                    updateCourseRow["Credits"] = nudCredits.Value;
                    updateCourseRow["Status"] = cboStatus.Text;
                    updateCourseRow["Fee"] = nudFee.Value;

                    cmCourse.EndCurrentEdit();
                    DC.UpdateCourse();
                    MessageBox.Show("Course updated successfully", "Success");
                }
                else
                {
                    // Cancel changes
                    cmCourse.CancelCurrentEdit();
                }
            }
        }

        // Get Programme Name for the current Course
        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmCourse != null)
            {
                // Get whole row from the "COURSE" table for the current course
                DataRow drCourse = DC.dtCourse.Rows[cmCourse.Position];

                // Select corresponding row in the "PROGRAMME" table
                cmProgramme.Position = DC.programmeView.Find(drCourse["ProgrammeID"]);
            }
        }
    }
}
