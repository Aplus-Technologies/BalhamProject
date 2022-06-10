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
    public partial class DeleteStudentForm : Form
    {
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolmnu;
        private CurrencyManager cmStudent;

        private string studentText;

        private DataTable dtStudent2; // reference to student table
        private DataView studentView2; // reference to dataview of student table 

        public DeleteStudentForm(DataController dc, EnrolmentsClerkForm enrlmnu)
        {
            InitializeComponent();
            DC = dc;
            frmEnrolmnu = enrlmnu;
            frmEnrolmnu.Hide();
            TableAndView(); // generate updated table and views
            BindControls();  // call bind controls
           
        }

        public void BindControls()
        { // Create currency manager instance
            cmStudent = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure1, "STUDENT"];
        }

        private void TableAndView()
        { // generate new instances of Student table and dataview for student table 
             dtStudent2 = dsBalhamCollegeAzure1.STUDENT; 
             studentView2 = new DataView(dtStudent2);
             studentView2.Sort = "StudentID"; 
        }
        private void LoadStudents()
        { // Load students that have no enrollments
            foreach (DataRow drStudent in dtStudent2.Rows)
            {
                DataRow[] drEnrolments = drStudent.GetChildRows(dtStudent2.ChildRelations["ENROLMENT$STUDENTENROLMENT"]);
                if (drEnrolments.Length == 0)
                {
                    studentText = "";
                    studentText += drStudent["StudentID"] + ", ";
                    studentText += drStudent["LastName"] + ", ";
                    studentText += drStudent["FirstName"] + "\r\n";
                    lstStudents.Items.Add(studentText);
                }
            }
        }
        private void ClearFields()
        { // clears the following controls 

            txtStudentID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtStatus.Text = "";
        }
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        { // populate the following controls based on what is selected in the list box 
            if (lstStudents.SelectedItem != null)
            {
                string student = "";
                student = lstStudents.SelectedItem.ToString();
                string[] parts = student.Split(',');
                int studentID = Convert.ToInt32(parts[0]);
                cmStudent.Position = studentView2.Find(studentID);
                DataRow drStudent = dtStudent2.Rows[cmStudent.Position];
                txtStudentID.Text = drStudent["StudentID"].ToString();
                txtLastName.Text = drStudent["LastName"].ToString();
                txtFirstName.Text = drStudent["FirstName"].ToString();
                txtStreetAddress.Text = drStudent["StreetAddress"].ToString();
                txtSuburb.Text = drStudent["Suburb"].ToString();
                txtCity.Text = drStudent["City"].ToString();
                txtPhoneNumber.Text = drStudent["PhoneNumber"].ToString();
                txtEmailAddress.Text = drStudent["EmailAddress"].ToString();
                txtStatus.Text = drStudent["Status"].ToString();
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {

                DataRow deleteStudentRow = dtStudent2.Rows[cmStudent.Position];

                if (MessageBox.Show("Are you sure you want to delete this Student?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    this.studentTableAdapter1.Delete(Convert.ToInt32(txtStudentID.Text), txtLastName.Text, txtFirstName.Text, txtStreetAddress.Text, txtSuburb.Text, txtCity.Text, txtEmailAddress.Text, txtPhoneNumber.Text, txtStatus.Text);
                    this.dsBalhamCollegeAzure1.AcceptChanges(); // prevent system exception error 

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure1.ENROLMENT' table. You can move, or remove it, as needed.
                    this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure1.ENROLMENT);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure1.STUDENT' table. You can move, or remove it, as needed.
                    this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure1.STUDENT);

                    DC.UpdateStudent();
                    lstStudents.Items.Clear();
                    LoadStudents();
                    MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK);

                    ClearFields();
                }            
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); // prevents exception 'cannot access a disposed object' being thrown upon clicking Print Veterinarians Report option on the Main Menu
            frmEnrolmnu.Show();
        }

      

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure1);

        }

        private void DeleteStudentForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure1.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure1.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure1.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure1.STUDENT);
           
            // clears fields upon form load
            ClearFields(); 
            // clear list upon form load
            lstStudents.Items.Clear();
            // load students 
            LoadStudents(); 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
