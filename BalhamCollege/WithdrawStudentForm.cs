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
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolmentsClerk;
        private CurrencyManager cmCourse;
        private CurrencyManager cmEnrolment;
        private CurrencyManager cmStudentEnrolment;


        public WithdrawStudentForm(DataController dc, EnrolmentsClerkForm enrolmentsClerk)
        {
            InitializeComponent();
            DC = dc;
            frmEnrolmentsClerk = enrolmentsClerk;
            enrolmentsClerk.Hide();
            BindControls();
        }
        public void BindControls()
        {
            // Set up Currency Manager
            cmCourse = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Course"];
            cmEnrolment = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Enrolment"];
            cmStudentEnrolment = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Student.ENROLMENT$STUDENTENROLMENT"];

            // Bind DataGridView
            dgvEnrolments.DataSource = DC.dsBalhamCollegeAzure;
            dgvEnrolments.DataMember = "Student.ENROLMENT$STUDENTENROLMENT";

            // Bind list of students
            lstStudents.DataSource = DC.dsBalhamCollegeAzure;
            lstStudents.DisplayMember = "Student.StudentID";
            lstStudents.ValueMember = "Student.StudentID";

            // Bind controls at right
            txtStudentID.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Student.StudentID");
            txtLastName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Student.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Student.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Student.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Student.Suburb");
            txtCity.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Student.City");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); // prevents 'cannot accessed disposed object error' upon producing report 
            frmEnrolmentsClerk.Show();
        }

        private void lstStudents_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRowView studentRow = (DataRowView)e.ListItem;
            e.Value = studentRow.Row["StudentID"] + " " + studentRow.Row["LastName"] + ", " + studentRow.Row["FirstName"];
        }

        private void dgvEnrolments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Show "CourseName" instead of "CourseID" (3 - index of the "Course Name" column of the DGV)
            if (e.ColumnIndex == 3)
            {
                int courseID = Convert.ToInt32(dgvEnrolments[3, e.RowIndex].Value); // Get "CourseID" from the cell
                cmCourse.Position = DC.courseView.Find(courseID); // Move CurrencyManager to this course
                DataRow drCourse = DC.dtCourse.Rows[cmCourse.Position]; // Get "Course" row from the database
                e.Value = drCourse["CourseName"].ToString(); // Set "CourseName" to the cell
            }
        }

        private void btnWithdrawStudent_Click(object sender, EventArgs e)
        {
            // 0 - index of the "Enrolment ID" column of the DGV
            int enrolmentID = Convert.ToInt32(dgvEnrolments[0, cmStudentEnrolment.Position].Value);
            cmEnrolment.Position = DC.enrolmentView.Find(enrolmentID);
            DataRow deleteEnrolmentRow = DC.dtEnrolment.Rows[cmEnrolment.Position];

            deleteEnrolmentRow.Delete();
            DC.UpdateEnrolment();
            MessageBox.Show("Student withdrawn successfully", "Acknowledgement", MessageBoxButtons.OK);
        }

        private void WithdrawStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

        }
    }
}
