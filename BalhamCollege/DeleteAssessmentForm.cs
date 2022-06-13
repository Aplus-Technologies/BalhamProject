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
    public partial class DeleteAssessmentForm : Form
    {
        private DataController DC;
        private CourseAdministratorForm frmCoursemnu;
        private CurrencyManager cmAssessment;
        private CurrencyManager cmCourse;

        private DataTable dtAssessment2;
        private DataTable dtCourse2;

        private DataView assessmentView2;
        private DataView courseView2; 

        private string assessmentText;
        public DeleteAssessmentForm(DataController dc, CourseAdministratorForm coursemnu)
        {
            InitializeComponent();
          
            DC = dc;
            frmCoursemnu = coursemnu;
            frmCoursemnu.Hide();
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

        private void LoadAssessments()
        {
            foreach (DataRow drAssessment in dtAssessment2.Rows)
            {
                DataRow[] drResults = drAssessment.GetChildRows(dtAssessment2.ChildRelations["FK_ASSESSMENT_RESULT"]);
                if (drResults.Length == 0)
                {
                    assessmentText = "";
                    assessmentText += drAssessment["AssessmentID"] + ", ";
                    assessmentText += drAssessment["AssessmentName"] + "\r\n";
                    lstAssessments.Items.Add(assessmentText);
                }
            }
        }

        private void ClearFields()
        { // clears the following controls 
            txtAssessmentID.Text = String.Empty;
            txtAssessmentNumber.Text = String.Empty;
            txtAssessmentName.Text = String.Empty;
            txtType.Text = String.Empty;
            txtCourseName.Text = String.Empty;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["CourseBackgroundForm"].Close();
            this.Close();
            frmCoursemnu.Show();
        }

        private void lstAssessments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAssessments.SelectedItem != null)
            {
                string assessment = "";
                assessment = lstAssessments.SelectedItem.ToString();
                string[] parts = assessment.Split(',');
                int AssessmentID = Convert.ToInt32(parts[0]);
                cmAssessment.Position = assessmentView2.Find(AssessmentID);
                DataRow drAssessment = dtAssessment2.Rows[cmAssessment.Position];
                txtAssessmentID.Text = drAssessment["AssessmentID"].ToString();
                txtAssessmentName.Text = drAssessment["AssessmentName"].ToString();
                txtAssessmentNumber.Text = drAssessment["AssessmentNumber"].ToString();
                txtType.Text = drAssessment["Type"].ToString();


                int aCourseID = Convert.ToInt32(drAssessment["CourseID"].ToString());
                cmCourse.Position =courseView2.Find(aCourseID);
                DataRow drCourse = dtCourse2.Rows[cmCourse.Position];
                txtCourseName.Text = drCourse["CourseName"].ToString();
            }
        }
        
        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        {
            if (lstAssessments.SelectedItem != null)
            {
                DataRow deleteAssessmentRow = dtAssessment2.Rows[cmAssessment.Position];
                if (MessageBox.Show("Are you sure you want to delete this Assessment?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    // deleteAssessmentRow.Delete();


                   
                    aSSESSMENTTableAdapter.Delete(Convert.ToInt32(txtAssessmentID.Text), Convert.ToInt32(txtAssessmentNumber.Text), txtAssessmentName.Text, deleteAssessmentRow["Type"].ToString(), Convert.ToInt32(deleteAssessmentRow["Weighting"]), Convert.ToInt32(deleteAssessmentRow["MaximumMark"]), Convert.ToInt32(deleteAssessmentRow["CourseID"]));
                    this.dsBalhamCollegeAzure.AcceptChanges(); // prevent system exception error 



                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESULT' table. You can move, or remove it, as needed.
                    this.rESULTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESULT);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
                    this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
                    this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);

                    DC.UpdateAssessment();
                    lstAssessments.Items.Clear();
                    LoadAssessments();
                    MessageBox.Show("Assessment deleted successfully", "Success", MessageBoxButtons.OK);

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

        private void DeleteAssessmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESULT' table. You can move, or remove it, as needed.
            this.rESULTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESULT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);

            lstAssessments.Items.Clear(); 
            ClearFields();
            LoadAssessments();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
