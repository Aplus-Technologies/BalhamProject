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
    public partial class UpdateStudentForm : Form
    {
        //declare global variables
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolmentsClerk; // reference to Enrolment Clerk Form
        private CurrencyManager cmStudent;

        private DataTable dtStudent2;
        private DataView studentView2;

        public UpdateStudentForm(DataController dc, EnrolmentsClerkForm enrolmentsClerk)
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
            // create updated instances for Student table and dataview for student table 
            dtStudent2 = dsBalhamCollegeAzure.STUDENT;
            studentView2 = new DataView(dtStudent2);
            studentView2.Sort = "StudentID"; 
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmStudent = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Student"];
        }

        private void LoadStudents()
        {
            // To load all students
            lstStudents.Items.Clear();
            foreach (DataRow drStudent in dtStudent2.Rows)
            {
                lstStudents.Items.Add(drStudent);
            }
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
            txtEmailAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            cboStatus.Text = string.Empty;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); // prevents 'cannot accessed disposed object error' upon producing report 
            frmEnrolmentsClerk.Show();
        }

        private void lstStudents_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRow studentRow = (DataRow)e.ListItem;
            e.Value = studentRow["StudentID"] + " " + studentRow["LastName"] + ", " + studentRow["FirstName"];
        }
    
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            DataRow updateStudentRow = dtStudent2.Rows[cmStudent.Position];

            // Validate the entries in the fields
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") ||
                (txtCity.Text == "") || (txtEmailAddress.Text == "") || (txtPhoneNumber.Text == "") || (cboStatus.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change the student's details?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Save changes
                    updateStudentRow["LastName"] = txtLastName.Text;
                    updateStudentRow["FirstName"] = txtFirstName.Text;
                    updateStudentRow["StreetAddress"] = txtStreetAddress.Text;
                    updateStudentRow["Suburb"] = txtSuburb.Text;
                    updateStudentRow["City"] = txtCity.Text;
                    updateStudentRow["EmailAddress"] = txtEmailAddress.Text;
                    updateStudentRow["PhoneNumber"] = txtPhoneNumber.Text;
                    updateStudentRow["Status"] = cboStatus.Text;

                    this.sTUDENTTableAdapter.Update(updateStudentRow);

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
                    this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

                    LoadStudents();
                    MessageBox.Show("Student updated successfully", "Success");
                    ClearFields();
                }
                else
                {
                    // Cancel changes
                    LoadStudents();
                    ClearFields();
                }
            }
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

            LoadStudents();
            ClearFields();
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
            txtEmailAddress.Text = drStudent["EmailAddress"].ToString();
            txtPhoneNumber.Text = drStudent["PhoneNumber"].ToString();
            cboStatus.Text = drStudent["Status"].ToString();
        }

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }
    }
}
