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
        private DataController DC;
        private CourseAdministratorForm frmCourseAdministrator;
        private CurrencyManager cmAssessment;

        public UpdateAssessmentForm(DataController dc, CourseAdministratorForm courseAdministrator)
        {
            InitializeComponent();
            DC = dc;
            frmCourseAdministrator = courseAdministrator;
            courseAdministrator.Hide();
            BindControls();
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmAssessment = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Assessment"];

            // Bind list of students
            cboAssessments.DataSource = DC.dsBalhamCollegeAzure;
            cboAssessments.DisplayMember = "Assessment.AssessmentID";
            cboAssessments.ValueMember = "Assessment.AssessmentID";

            // Bind controls at right
            txtAssessmentID.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Assessment.AssessmentID");
            nudNumber.DataBindings.Add("Value", DC.dsBalhamCollegeAzure, "Assessment.AssessmentNumber");
            txtAssessmentName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Assessment.AssessmentName");
            cboType.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Assessment.Type");
            nudWeighting.DataBindings.Add("Value", DC.dsBalhamCollegeAzure, "Assessment.Weighting");
            nudMaximumMark.DataBindings.Add("Value", DC.dsBalhamCollegeAzure, "Assessment.MaximumMark");
            txtCourseName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Course.CourseName");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCourseAdministrator.Show();
        }

        private void cboAssessments_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is DataRowView)
            {
                // Convert database row into listitem text
                DataRowView assessmentRow = (DataRowView)e.ListItem;
                e.Value = assessmentRow.Row["AssessmentID"] + ", #" + assessmentRow.Row["AssessmentNumber"] + " " + assessmentRow.Row["AssessmentName"];
            }
        }

        private void btnUpdateAssessment_Click(object sender, EventArgs e)
        {
            DataRow updateAssessmentRow = DC.dtAssessment.Rows[cmAssessment.Position];

            // Validate the entries in the fields
            if ((nudNumber.Text == "") || (txtAssessmentName.Text == "") || (cboType.Text == "") || (nudWeighting.Text == "") || (nudMaximumMark.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change the assessment's's details?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Save changes
                    updateAssessmentRow["AssessmentNumber"] = nudNumber.Value;
                    updateAssessmentRow["AssessmentName"] = txtAssessmentName.Text;
                    updateAssessmentRow["Type"] = cboType.Text;
                    updateAssessmentRow["Weighting"] = nudWeighting.Value;
                    updateAssessmentRow["MaximumMark"] = nudMaximumMark.Value;


                    cmAssessment.EndCurrentEdit();
                    DC.UpdateAssessment();
                    MessageBox.Show("Assessment updated successfully", "Success");
                }
                else
                {
                    // Cancel changes
                    cmAssessment.CancelCurrentEdit();
                }
            }

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

        }
    }
}
