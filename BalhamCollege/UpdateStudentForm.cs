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
        { // create updated instances for Student table and dataview for student table 
            dtStudent2 = dsBalhamCollegeAzure.STUDENT;
            studentView2 = new DataView(dtStudent2);
            studentView2.Sort = "StudentID"; 
        }

        public void BindControls()
        {
          //  lstStudents.Items.Clear(); 
            // Set up Currency Manager
            cmStudent = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Student"];

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
                    
                    this.sTUDENTTableAdapter.Update(txtLastName.Text, txtFirstName.Text, txtStreetAddress.Text, txtSuburb.Text, txtCity.Text, txtEmailAddress.Text, txtPhoneNumber.Text, cboStatus.Text, Convert.ToInt32(updateStudentRow["StudentID"]), updateStudentRow["LastName"].ToString(), updateStudentRow["FirstName"].ToString(), updateStudentRow["StreetAddress"].ToString(), updateStudentRow["Suburb"].ToString(), updateStudentRow["City"].ToString(), updateStudentRow["EmailAddress"].ToString(), updateStudentRow["PhoneNumber"].ToString(), updateStudentRow["Status"].ToString());

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
                    this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);
      
                    MessageBox.Show("Student updated successfully", "Success");
                }
                else
                {
                    // Cancel changes
                    cmStudent.CancelCurrentEdit();
                }
            }
        }

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);
           
            lstStudents.Items.Clear();
            LoadStudents(); 
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            txtEmailAddress.Text = drStudent["EmailAddress"].ToString();
            txtPhoneNumber.Text = drStudent["PhoneNumber"].ToString();
            cboStatus.Text = drStudent["Status"].ToString(); 
        }
    }
}
