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
    public partial class UpdateAssessmentForm : Form
    {
        //declare global variables
        private DataController DC;
        private CourseAdministratorForm frmCourseAdministrator; // reference to Course Administrator Form
        private CurrencyManager cmAssessment;
        private CurrencyManager cmCourse;

        private DataTable dtAssessment2;
        private DataView assessmentView2;

        private DataTable dtCourse2;
        private DataView courseView2;

        public UpdateAssessmentForm(DataController dc, CourseAdministratorForm courseAdministrator)
        {
            InitializeComponent();
            DC = dc;
            frmCourseAdministrator = courseAdministrator;
            courseAdministrator.Hide();
            BindControls();
            TableAndView(); // generate updated table and views
        }
        private void TableAndView()
        {
            // create updated instances for Assessment table and dataview for Assessment table 
            dtAssessment2 = dsBalhamCollegeAzure.ASSESSMENT;
            assessmentView2 = new DataView(dtAssessment2);
            assessmentView2.Sort = "AssessmentID";

            // create updated instances for Course table and dataview for Course table 
            dtCourse2 = dsBalhamCollegeAzure.COURSE;
            courseView2 = new DataView(dtCourse2);
            courseView2.Sort = "CourseID";
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmAssessment = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Assessment"];
            cmCourse = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Course"];
        }
        private void LoadAssessments()
        {
            // To load all assessments
            lstAssessments.Items.Clear();
            foreach (DataRow drAssessment in dtAssessment2.Rows)
            {
                lstAssessments.Items.Add(drAssessment);
            }
        }

        private void ClearFields()
        {
            // Clear all fields
            txtAssessmentID.Text = string.Empty;
            nudNumber.Text = string.Empty;
            txtAssessmentName.Text = string.Empty;
            cboType.Text = string.Empty;
            nudWeighting.Text = string.Empty;
            nudMaximumMark.Text = string.Empty;
            txtCourseName.Text = string.Empty;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["CourseBackgroundForm"].Close(); // closes background along with form
            this.Close(); // prevents 'cannot accessed disposed object error' upon producing report 
            frmCourseAdministrator.Show();
        }

        private void lstAssessments_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is DataRow)
            {
                // Convert database row into listitem text
                DataRow assessmentRow = (DataRow)e.ListItem;

                if (assessmentRow.RowState != DataRowState.Detached)
                {
                    e.Value = assessmentRow["AssessmentID"] + ", #" + assessmentRow["AssessmentNumber"] + " " + assessmentRow["AssessmentName"];
                }
            }
        }

        private void btnUpdateAssessment_Click(object sender, EventArgs e)
        {
            DataRow updateAssessmentRow = dtAssessment2.Rows[cmAssessment.Position];

            // Validate the entries in the fields
            if ((nudNumber.Text == "") || (txtAssessmentName.Text == "") || (cboType.Text == "") || (nudWeighting.Text == "") || (nudMaximumMark.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change the assessment's details?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Save changes
                    updateAssessmentRow["AssessmentNumber"] = nudNumber.Value;
                    updateAssessmentRow["AssessmentName"] = txtAssessmentName.Text;
                    updateAssessmentRow["Type"] = cboType.Text;
                    updateAssessmentRow["Weighting"] = nudWeighting.Value;
                    updateAssessmentRow["MaximumMark"] = nudMaximumMark.Value;

                    this.aSSESSMENTTableAdapter.Update(updateAssessmentRow);

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
                    this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);

                    LoadAssessments();
                    MessageBox.Show("Assessment updated successfully", "Success");
                    ClearFields();
                }
                else
                {
                    // Cancel changes
                    LoadAssessments();
                    ClearFields();
                }
            }
        }

        private void lstAssessments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get whole row from the "ASSESSMENT" table for the current assessment
            DataRow drAssessment = (DataRow)lstAssessments.SelectedItem;
            cmAssessment.Position = assessmentView2.Find(drAssessment["AssessmentID"]);

            // Select corresponding row in the "COURSE" table
            cmCourse.Position = courseView2.Find(drAssessment["CourseID"]);
            DataRow courseRow = dtCourse2.Rows[cmCourse.Position];

            // To populate the following controls with their corresponding values; from Assessment Table 
            txtAssessmentID.Text = drAssessment["AssessmentID"].ToString();
            nudNumber.Text = drAssessment["AssessmentNumber"].ToString();
            nudNumber.Value = Convert.ToInt32(drAssessment["AssessmentNumber"].ToString());
            txtAssessmentName.Text = drAssessment["AssessmentName"].ToString();
            cboType.Text = drAssessment["Type"].ToString();
            nudWeighting.Text = drAssessment["Weighting"].ToString();
            nudWeighting.Value = Convert.ToInt32(drAssessment["Weighting"].ToString());
            nudMaximumMark.Text = drAssessment["MaximumMark"].ToString();
            nudMaximumMark.Value = Convert.ToInt32(drAssessment["MaximumMark"].ToString());
            txtCourseName.Text = courseRow["CourseName"].ToString();
        }

        private void aSSESSMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aSSESSMENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }
        private void UpdateAssessmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);

            LoadAssessments();
            ClearFields();
        }
    }
}
