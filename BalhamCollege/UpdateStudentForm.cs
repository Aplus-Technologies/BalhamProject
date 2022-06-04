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
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolmentsClerk;
        private CurrencyManager cmStudent;

        public UpdateStudentForm(DataController dc, EnrolmentsClerkForm enrolmentsClerk)
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
            cmStudent = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Student"];

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
            txtEmailAddress.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Student.EmailAddress");
            txtPhoneNumber.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Student.PhoneNumber");
            cboStatus.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Student.Status");
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEnrolmentsClerk.Show();
        }

        private void lstStudents_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRowView studentRow = (DataRowView)e.ListItem;
            e.Value = studentRow.Row["StudentID"] + " " + studentRow.Row["LastName"] + ", " + studentRow.Row["FirstName"];
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            DataRow updateStudentRow = DC.dtStudent.Rows[cmStudent.Position];

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

                    cmStudent.EndCurrentEdit();
                    DC.UpdateStudent();
                    MessageBox.Show("Student updated successfully", "Success");
                }
                else
                {
                    // Cancel changes
                    cmStudent.CancelCurrentEdit();
                }
            }
        }
    }
}
