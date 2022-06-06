using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BalhamCollege
{
    public partial class EnrolStudentForm : Form
    {
        // To create global variables
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolMenu;
        private CurrencyManager cmStudent; // reference to currency manager for Student table
        private CurrencyManager cmEnrolment; // reference to currency manager for Enrolment table
        private CurrencyManager cmCourse; // reference to currency manager for Course table
        private CurrencyManager cmProgramme; // reference to currency manager for Programme Table
       
        private DataTable dtStudent2; // reference to Student table
        private DataTable dtEnrolment2; // reference to Enrolment table
        private DataTable dtCourse2; // reference to Course table
        private DataTable dtProgramme2; // reference to Programme table;

        private DataView studentView2; // reference to dataview for Student table
        private DataView enrolmentView2; // reference to dataview for Enrolment table
        private DataView courseView2;  // reference to dataview for course table
        private DataView programmeView2; // reference to dataview for programme table

        

        public EnrolStudentForm(DataController dc, EnrolmentsClerkForm enrolmnu)
        {
            InitializeComponent();
            // call the following functions upon form initialization 
            DC = dc;
            frmEnrolMenu = enrolmnu;
            frmEnrolMenu.Hide();
            BindControls(); // bind the controls 
            TableAndView();  // generate updated table and views
            
        }

        private void TableAndView()
        { // create instances of Student, enrolment and course tables with their views
            dtStudent2 = dsBalhamCollegeAzure.STUDENT;
            dtEnrolment2 = dsBalhamCollegeAzure.ENROLMENT;
            dtCourse2 = dsBalhamCollegeAzure.COURSE;
            dtProgramme2 = dsBalhamCollegeAzure.PROGRAMME;

            studentView2 = new DataView(dtStudent2);
            studentView2.Sort = "StudentID";
           
            enrolmentView2 = new DataView(dtEnrolment2);
            enrolmentView2.Sort = "EnrolmentID";
            
            courseView2 = new DataView(dtCourse2);
            courseView2.Sort = "CourseID";

            programmeView2 = new DataView(dtProgramme2);
            programmeView2.Sort = "ProgrammeID"; 
        }


        public void BindControls()
        { // To create instances of the Currency Manager class 
            cmStudent = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "STUDENT"];
            cmEnrolment = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "ENROLMENT"];
            cmCourse = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "COURSE"];
            cmProgramme = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "PROGRAMME"]; 
        }

        private void LoadStudents()
        {
            // To load all students
            string studentText;
            foreach (DataRow drStudent in dtStudent2.Rows)
            {
                studentText = drStudent["StudentID"].ToString() + ", ";
                studentText += drStudent["LastName"].ToString() + ", ";
                studentText += drStudent["FirstName"].ToString();
                lstStudents.Items.Add(studentText);
                
               
            }
        } 
        
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                lstCourses.Items.Clear();
                lstEnrolments.Items.Clear();
                LoadCourses();
                string student;
                // Converts the selected item in the Student listbox to a string
                // using index 0 of the string, which is the StudentID to find the row it belongs to in the Student Table using Currency Manager
                student = lstStudents.SelectedItem.ToString();
                string[] parts = student.Split(',');
                int studentID = Convert.ToInt32(parts[0]);
                cmStudent.Position = studentView2.Find(studentID);
                DataRow drStudent = dtStudent2.Rows[cmStudent.Position];

                //To populate the following controls with their corresponding values; from Student Table 
                txtLastName.Text = drStudent["LastName"].ToString();
                txtFirstName.Text = drStudent["FirstName"].ToString();
                txtStudentID.Text = drStudent["StudentID"].ToString();
                txtStreetAddress.Text = drStudent["StreetAddress"].ToString();
                txtSuburb.Text = drStudent["Suburb"].ToString();
                txtCity.Text = drStudent["City"].ToString();

                // Displays all the enrolments of the selected student

                string studentEnrolmentText;
                DataRow[] drStudentEnrolments = drStudent.GetChildRows(dtStudent2.ChildRelations["ENROLMENT$STUDENTENROLMENT"]);
                foreach (DataRow drStudentEnrolled in drStudentEnrolments)
                {
                    int courseID = Convert.ToInt32(drStudentEnrolled["CourseID"]);
                    cmCourse.Position = courseView2.Find(courseID);
                    DataRow drCourse = dtCourse2.Rows[cmCourse.Position];

                    studentEnrolmentText = drStudentEnrolled["EnrolmentID"].ToString() + ", " + drCourse["CourseName"].ToString() + ", Year " + drStudentEnrolled["Year"].ToString() + ", Semester " + drStudentEnrolled["Semester"].ToString();
                    lstEnrolments.Items.Add(studentEnrolmentText);
                }
            }

        }

        private void LoadCourses()
        {
            // To load all courses
            string courseText;
            foreach (DataRow drCourse in dtCourse2.Rows)
            {
                courseText = drCourse["CourseID"].ToString() + ", ";
                courseText += drCourse["CourseName"].ToString() + ", ";
               
                lstCourses.Items.Add(courseText);


            }
        }
        
        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedItem != null)
            {
                string course;
                // Converts the selected item in the Course listbox to a string
                // using index 0 of the string, which is the CourseID to find the row it belongs to in the Course Table using Currency Manager
                course = lstCourses.SelectedItem.ToString();
                string[] parts = course.Split(',');
                int courseID = Convert.ToInt32(parts[0]);
                cmCourse.Position = courseView2.Find(courseID);
                DataRow drCourse = dtCourse2.Rows[cmCourse.Position];

               // added programme table adapter in design view to make this accesible 
                int programmeID = Convert.ToInt32(drCourse["ProgrammeID"]);
                cmProgramme.Position = programmeView2.Find(programmeID);
                DataRow drProgramme = dtProgramme2.Rows[cmProgramme.Position];

                //To populate the following controls with their corresponding values; from Course Table 
                txtCourseID.Text = drCourse["CourseID"].ToString();
                txtCourseName.Text = drCourse["CourseName"].ToString();
                txtCredits.Text = drCourse["Credits"].ToString();
                txtProgrammeName.Text = drProgramme["ProgrammeName"].ToString();

            }
           

        }

        private void ClearFields()
        {
            lstStudents.SelectedItem = null;
            txtStudentID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            lstEnrolments.Items.Clear();
            txtCourseID.Text = "";
            txtCourseName.Text = "";
            txtCredits.Text = "";
            txtProgrammeName.Text = "";

            
            lstCourses.SelectedItem = null;
            nudYear.Value = 2020;
            nudSemester.Value = 1;
            cboStatus.Text = "Pending"; 
        } 
        
        private void btnEnrolStudent_Click(object sender, EventArgs e)
        {
            int studentID2 = Convert.ToInt32(txtStudentID.Text);
            cmStudent.Position = studentView2.Find(studentID2);
            DataRow drStudent = dtStudent2.Rows[cmStudent.Position];
            DataRow[] drStudentEnrolments = drStudent.GetChildRows(dtStudent2.ChildRelations["ENROLMENT$STUDENTENROLMENT"]);


            if ((cboStatus.Text == "") || (txtStudentID.Text == "") || (txtCourseID.Text == ""))
            { // checking if any required fields are null
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// check if there is student and enrolment relation 
                if (drStudentEnrolments.Length != 0)
                {   int count = 0;
                    foreach (DataRow drStudentEnrolment in drStudentEnrolments)
                    {
                        // count how many times the following condition is fulfilled: student enrolled in same year, same semester and same course
                        if ((txtStudentID.Text == drStudentEnrolment["StudentID"].ToString()) && (nudYear.Value == Convert.ToDecimal(drStudentEnrolment["Year"])) && (nudSemester.Value == Convert.ToDecimal(drStudentEnrolment["Semester"])) && (txtCourseID.Text == drStudentEnrolment["CourseID"].ToString()))
                        {
                            count += 1;
                        }
                       
                    }

                    if (count > 0 )
                    {// error message if the same student has already been enrolled in the same course, same year and semester

                        MessageBox.Show("Student already enrolled in that course this semester and year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields(); // reset the fields that can be filled in to blank or to their default values
                        lstCourses.Items.Clear();
                        lstStudents.Items.Clear();
                        LoadStudents();
                    }
                    else
                    {
                        // adding a new row to Enrolment table and display a success message if no student has no enrolments yet

                        this.eNROLMENTTableAdapter.Insert(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudSemester.Value), cboStatus.Text, Convert.ToInt32(txtStudentID.Text), Convert.ToInt32(txtCourseID.Text));

                        // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
                        this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
                        // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
                        this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
                        // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
                        this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
                        // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
                        this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);


                        MessageBox.Show("Enrolment added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // reset the fields that can be filled in to blank or to their default values
                        lstCourses.Items.Clear();
                        lstStudents.Items.Clear();
                        LoadStudents();
                    }
                }
                else
                {
                    // adding a new row to Enrolment table and display a success message if no student has no enrolments yet

                    this.eNROLMENTTableAdapter.Insert(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudSemester.Value), cboStatus.Text, Convert.ToInt32(txtStudentID.Text), Convert.ToInt32(txtCourseID.Text));

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
                    this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
                    this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
                    this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
                    this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);


                    MessageBox.Show("Enrolment added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); // reset the fields that can be filled in to blank or to their default values
                    lstCourses.Items.Clear();
                    lstStudents.Items.Clear();
                    LoadStudents();
                }
                
            }
          
            
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // closes the form
            this.Close();
            frmEnrolMenu.Show(); // show enrolments clerk menu

        }
        
      

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void EnrolStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

            ClearFields(); 
           lstEnrolments.Items.Clear(); 
           lstStudents.Items.Clear(); // clear student list 
           LoadStudents();  
        }

       
    }
}
