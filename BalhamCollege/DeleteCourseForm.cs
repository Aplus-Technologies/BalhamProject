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
    public partial class DeleteCourseForm : Form
    {
        private DataController DC;
        private ProgrammeAdministratorForm frmProgMnu;
        private CurrencyManager cmAssessment;
        private CurrencyManager cmCourse;

        private DataTable dtAssessment2;
        private DataTable dtCourse2;

        private DataView assessmentView2;
        private DataView courseView2; 

        private string courseText;
        public DeleteCourseForm(DataController dc, ProgrammeAdministratorForm progmnu)
        {
            InitializeComponent();
            DC = dc;
            frmProgMnu = progmnu;
            frmProgMnu.Hide();
            BindControls();
            TableAndView(); 
        }

        private void TableAndView()
        {
            dtAssessment2 = dsBalhamCollegeAzure.ASSESSMENT;
            dtCourse2 = dsBalhamCollegeAzure.COURSE;

            assessmentView2 = new DataView(dtAssessment2);
            assessmentView2.Sort = "AssessmentID";

            courseView2 = new DataView(dtCourse2);
            courseView2.Sort = "CourseID"; 
        }
        public void BindControls()
        {
            cmAssessment = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "ASSESSMENT"];
            cmCourse = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "COURSE"];
        }

        private void LoadCourses()
        {
            foreach (DataRow drCourse in dtCourse2.Rows)
            {
                DataRow[] drEnrolments = drCourse.GetChildRows(dtCourse2.ChildRelations["ENROLMENT$COURSEENROLMENT"]);
                DataRow[] drAssignments = drCourse.GetChildRows(dtCourse2.ChildRelations["ASSIGNMENT$COURSEASSIGNMENT"]);
                DataRow[] drAssessments = drCourse.GetChildRows(dtCourse2.ChildRelations["ASSESSMENT$COURSEASSESSMENT"]);
                if (drEnrolments.Length == 0 && drAssignments.Length == 0 && drAssessments.Length == 0)
                {
                    courseText = "";
                    courseText += drCourse["CourseID"] + ", ";
                    courseText += drCourse["CourseName"] + "\r\n";

                    lstCourses.Items.Add(courseText);
                }
            }
        }

        private void ClearFields()
        { // clears the following controls 

            txtCourseID.Text = String.Empty;
            txtCourseName.Text = String.Empty;
            txtCredits.Text = String.Empty;
            txtStatus.Text = String.Empty;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["ProgrammeBackgroundForm"].Close();
            this.Close();
            frmProgMnu.Show();
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedItem != null)
            {
                string course = "";
                course = lstCourses.SelectedItem.ToString();
                string[] parts = course.Split(',');
                int courseID = Convert.ToInt32(parts[0]);
                cmCourse.Position = courseView2.Find(courseID);
                DataRow drCourse = dtCourse2.Rows[cmCourse.Position];
                txtCourseID.Text = drCourse["CourseID"].ToString();
                txtCourseName.Text = drCourse["CourseName"].ToString();
                txtCredits.Text = drCourse["Credits"].ToString();
                txtStatus.Text = drCourse["Status"].ToString();
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedItem != null)
            {

                DataRow deleteCourseRow = dtCourse2.Rows[cmCourse.Position];
                if (MessageBox.Show("Are you sure you want to delete this Course?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    // deleteCourseRow.Delete();
                    cOURSETableAdapter.Delete(Convert.ToInt32(txtCourseID.Text), txtCourseName.Text, Convert.ToInt32(txtCredits.Text), Convert.ToDecimal(deleteCourseRow["Fee"]), txtStatus.Text, Convert.ToInt32(deleteCourseRow["ProgrammeID"]));
                    dsBalhamCollegeAzure.AcceptChanges(); //prevent system exception error 


                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
                    this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
                    this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);

                    DC.UpdateCourse();
                    lstCourses.Items.Clear();
                    LoadCourses();
                    MessageBox.Show("Course deleted successfully", "Success", MessageBoxButtons.OK);

                    ClearFields();
                }              
            }
        }

        private void aSSESSMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aSSESSMENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void DeleteCourseForm_Load(object sender, EventArgs e)
        {            
                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSIGNMENT' table. You can move, or remove it, as needed.
                this.aSSIGNMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSIGNMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);

            lstCourses.Items.Clear(); 
            ClearFields();
            LoadCourses(); 
        }
    }
}
