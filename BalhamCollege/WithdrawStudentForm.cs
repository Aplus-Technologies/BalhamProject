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
    public partial class WithdrawStudentForm : Form
    {
        //declare global variables
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolmentsClerk;
        private CurrencyManager cmStudent;
        private CurrencyManager cmCourse;
        private CurrencyManager cmEnrolment;

        private DataTable dtStudent2;
        private DataView studentView2;

        private DataTable dtCourse2;
        private DataView courseView2;

        private DataTable dtEnrolment2;
        private DataView enrolmentView2;

        public WithdrawStudentForm(DataController dc, EnrolmentsClerkForm enrolmentsClerk)
        {
            InitializeComponent();
            DC = dc;
            frmEnrolmentsClerk = enrolmentsClerk;
            enrolmentsClerk.Hide();
            BindControls();
            TableAndView(); // generate updated table and views
        }

        private void TableAndView()
        {
            // create updated instances for Student table and dataview for Student table 
            dtStudent2 = dsBalhamCollegeAzure.STUDENT;
            studentView2 = new DataView(dtStudent2);
            studentView2.Sort = "StudentID";

            // create updated instances for Course table and dataview for Course table 
            dtCourse2 = dsBalhamCollegeAzure.COURSE;
            courseView2 = new DataView(dtCourse2);
            courseView2.Sort = "CourseID";

            // create updated instances for Enrolment table and dataview for Enrolment table 
            dtEnrolment2 = dsBalhamCollegeAzure.ENROLMENT;
            enrolmentView2 = new DataView(dtEnrolment2);
            enrolmentView2.Sort = "EnrolmentID";
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmStudent = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Student"];
            cmCourse = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Course"];
            cmEnrolment = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Enrolment"];
        }

        private void LoadStudents()
        {
            lstStudents.Items.Clear();
            foreach (DataRow drStudent in dtStudent2.Rows)
            {
                // Get enrolments of this student
                DataRow[] drEnrolments = drStudent.GetChildRows(dtStudent2.ChildRelations["ENROLMENT$STUDENTENROLMENT"]);

                // Add student to listbox if they have any enrolment
                if (drEnrolments.Length != 0)
                {
                    lstStudents.Items.Add(drStudent);
                }
            }
        }

        // Gets all enrolments of the current student
        private void GetEnrolments()
        {
            DataTable enrolments = new DataTable();
            enrolments.Columns.Add("Enrolment ID", typeof(string));
            enrolments.Columns.Add("Year", typeof(string));
            enrolments.Columns.Add("Semester", typeof(string));
            enrolments.Columns.Add("Course Name", typeof(string));

            foreach (DataRow drEnrolment in this.dsBalhamCollegeAzure.ENROLMENT.Rows)
            {
                if (txtStudentID.Text == drEnrolment["StudentID"].ToString())
                {
                    // Create new row in the DataGrid
                    DataRow enrolmentRow;
                    enrolmentRow = enrolments.NewRow();
                    enrolments.Rows.Add(enrolmentRow);

                    // Fill row cells
                    enrolmentRow[0] = drEnrolment["EnrolmentID"].ToString();
                    enrolmentRow[1] = drEnrolment["Year"].ToString();
                    enrolmentRow[2] = drEnrolment["Semester"].ToString();

                    cmCourse.Position = courseView2.Find(drEnrolment["CourseID"]); // Move CurrencyManager to this course
                    DataRow drCourse = dtCourse2.Rows[cmCourse.Position]; // Get "Course" row from the database
                    enrolmentRow[3] = drCourse["CourseName"].ToString(); // Set "CourseName" to the cell
                }
            }

            dgvEnrolments.DataSource = enrolments;  // the data table created previously 
            dgvEnrolments.Columns[0].Width = 100;
            dgvEnrolments.Columns[1].Width = 50;
            dgvEnrolments.Columns[2].Width = 80;
            dgvEnrolments.Columns[3].Width = 234;
        }

        private void ClearFields()
        {
            // Clear all fields
            txtStudentID.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtStreetAddress.Text = string.Empty;
            txtSuburb.Text = string.Empty;
            txtCity.Text = string.Empty;
            dgvEnrolments.DataSource = "";
        }

        private void WithdrawStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

            LoadStudents();
            ClearFields();
        }

        private void lstStudents_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRow studentRow = (DataRow)e.ListItem;
            if (studentRow.RowState != DataRowState.Detached)
            {
                e.Value = studentRow["StudentID"] + " " + studentRow["LastName"] + ", " + studentRow["FirstName"];
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow drStudent = (DataRow)lstStudents.SelectedItem;
            cmStudent.Position = studentView2.Find(drStudent["StudentID"]);

            // To populate the following controls with their corresponding values; from Student Table 
            txtStudentID.Text = drStudent["StudentID"].ToString();
            txtLastName.Text = drStudent["LastName"].ToString();
            txtFirstName.Text = drStudent["FirstName"].ToString();
            txtStreetAddress.Text = drStudent["StreetAddress"].ToString();
            txtSuburb.Text = drStudent["Suburb"].ToString();
            txtCity.Text = drStudent["City"].ToString();

            // Load enrolments of this student
            GetEnrolments();
        }

        private void btnWithdrawStudent_Click(object sender, EventArgs e)
        {
            // 0 - index of the "Enrolment ID" column of the DGV
            object enrolmentID = dgvEnrolments.CurrentRow.Cells[0].Value;
            cmEnrolment.Position = enrolmentView2.Find(enrolmentID);
            DataRow deleteEnrolmentRow = dtEnrolment2.Rows[cmEnrolment.Position];

            this.eNROLMENTTableAdapter.Delete(
                Convert.ToInt32(deleteEnrolmentRow["EnrolmentID"]),
                Convert.ToInt32(deleteEnrolmentRow["Year"]),
                Convert.ToInt32(deleteEnrolmentRow["Semester"]),
                                deleteEnrolmentRow["Status"].ToString(),
                Convert.ToInt32(deleteEnrolmentRow["StudentID"]),
                Convert.ToInt32(deleteEnrolmentRow["CourseID"]));

            this.dsBalhamCollegeAzure.AcceptChanges(); // prevent system exception error 

            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

            // Refresh the DataGrid before the message
            GetEnrolments();

            MessageBox.Show("Student withdrawn successfully", "Acknowledgement", MessageBoxButtons.OK);
            LoadStudents();
            ClearFields();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEnrolmentsClerk.Show();
        }
    }
}
