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
        //declare global variables
        private DataController DC;
        private ProgrammeAdministratorForm frmProgrammeAdministrator;  // reference to Programme Administrator Form
        private CurrencyManager cmCourse;
        private CurrencyManager cmProgramme;

        private DataTable dtCourse2;
        private DataView courseView2;

        private DataTable dtProgramme2;
        private DataView programmeView2;


        public UpdateCourseForm(DataController dc, ProgrammeAdministratorForm programmeAdministrator)
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
            // create updated instances for Course table and dataview for course table 
            dtCourse2 = dsBalhamCollegeAzure.COURSE;
            courseView2 = new DataView(dtCourse2);
            courseView2.Sort = "CourseID";

            // create updated instances for Programme table and dataview for programme table 
            dtProgramme2= dsBalhamCollegeAzure.PROGRAMME;
            programmeView2 = new DataView(dtProgramme2);
            programmeView2.Sort = "ProgrammeID";
        }


        public void BindControls()
        {
            // Set up Currency Manager
            cmCourse = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Course"];
            cmProgramme = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Programme"];
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

        private void ClearFields()
        {
            // Clear all fields
            txtCourseID.Text = string.Empty;
            txtCourseName.Text = string.Empty;
            nudCredits.Text = string.Empty;
            cboStatus.Text = string.Empty;
            nudFee.Text = string.Empty;
            txtProgrammeName.Text = string.Empty;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); // prevents 'cannot accessed disposed object error' upon producing report 
            frmProgrammeAdministrator.Show();
        }

        private void lstCourses_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRow courseRow = (DataRow)e.ListItem;
            e.Value = courseRow["CourseID"] + " " + courseRow["CourseName"];
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            DataRow updateCourseRow = dtCourse2.Rows[cmCourse.Position];

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

                    this.cOURSETableAdapter.Update(updateCourseRow);

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
                    this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);

                    LoadCourses();
                    MessageBox.Show("Course updated successfully", "Success");
                    ClearFields();
                }
                else
                {
                    // Cancel changes
                    LoadCourses();
                    ClearFields();
                }
            }
        }

        // Get Programme Name for the current Course
        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get whole row from the "COURSE" table for the current course
            DataRow drCourse = (DataRow)lstCourses.SelectedItem;
            cmCourse.Position = courseView2.Find(drCourse["CourseID"]);

            // Select corresponding row in the "PROGRAMME" table
            cmProgramme.Position = programmeView2.Find(drCourse["ProgrammeID"]);
            DataRow programmeRow = dtProgramme2.Rows[cmProgramme.Position];

            // To populate the following controls with their corresponding values; from Course Table 
            txtCourseID.Text = drCourse["CourseID"].ToString();
            txtCourseName.Text = drCourse["CourseName"].ToString();
            nudCredits.Text = drCourse["Credits"].ToString();
            nudCredits.Value = Convert.ToInt32(drCourse["Credits"].ToString());
            cboStatus.Text = drCourse["Status"].ToString();
            nudFee.Text = drCourse["Fee"].ToString();
            nudFee.Value = Convert.ToDecimal(drCourse["Fee"].ToString());
            txtProgrammeName.Text = programmeRow["ProgrammeName"].ToString();
        }

        private void cOURSEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOURSEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }

        private void UpdateCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);

            LoadCourses();
            ClearFields();
        }
    }
}
