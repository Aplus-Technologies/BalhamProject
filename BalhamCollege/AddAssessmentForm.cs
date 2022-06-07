using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BalhamCollege
{
    public partial class AddAssessmentForm : Form
    {
        //declare global variables
        private DataController DC;
        private CourseAdministratorForm frmCourseAdminForm;

        private DataTable dtCourse2; // reference to course table
        private DataView courseView2; // reference to dataview of course table 

        private int courseID;

        public AddAssessmentForm(DataController dc, CourseAdministratorForm courseAdmin)
        {// call the following functions upon form initialization 
            InitializeComponent();
            DC = dc;
            frmCourseAdminForm = courseAdmin;
            frmCourseAdminForm.Hide();
            TableAndView(); // generate updated table and views of the Course table
        }

        private void TableAndView()
        {// create instances of course table and dataview of course table 
            dtCourse2 = dsBalhamCollegeAzure.COURSE;
            courseView2 = new DataView(dtCourse2);
            courseView2.Sort = "CourseID"; 
        }

        private void ClearFields()
        { // Clears all controls
            nudAsmntNumber.Value = 1;
            txtAssessmentName.Text = "";
            cboType.Text = "";
            nudWeighting.Value = 10;
            nudMaxMark.Value = 50; 


        }

        private void LoadCourses()
        {
            // To load all Courses
            string courseText;
            foreach (DataRow drCourse in dtCourse2.Rows)
            {
                courseText = drCourse["CourseID"].ToString() + ", ";
                courseText += drCourse["CourseName"].ToString(); 
                
                lstCourses.Items.Add(courseText);


            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {// closes form
            this.Close();
           frmCourseAdminForm.Show(); // show Course Administrator menu 
        }

        private void cOURSEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOURSEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void AddAssessmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);

            ClearFields(); 
            lstCourses.Items.Clear(); 
            LoadCourses(); // load courses upon form opening 
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedItem != null)
            {
                string course;
                // Converts the selected item in the Course listbox to a string
                // finds courseID of selected item 
                course = lstCourses.SelectedItem.ToString();
                string[] parts = course.Split(',');
                courseID = Convert.ToInt32(parts[0]); // get course ID
                

            }

        }

        private void btnAddAssessment_Click(object sender, EventArgs e)
        {
            // check if required fields are blank 
            if ((txtAssessmentName.Text == "") || (cboType.Text == ""))
            {// error message
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// create new assessment record

                // success message  
               
                this.aSSESSMENTTableAdapter.Insert(Convert.ToInt32(nudAsmntNumber.Value), txtAssessmentName.Text, cboType.Text, Convert.ToInt32(nudWeighting.Value), Convert.ToInt32(nudMaxMark.Value), courseID);
                
                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
                this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);
                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
                this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);

                MessageBox.Show("Assessment added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // controls are reset to blank 
                lstCourses.Items.Clear();
                LoadCourses(); 
                ClearFields();
            }
        }
    }
}
