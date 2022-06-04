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
        public DeleteStudentForm(DataController dc, EnrolmentsClerkForm enrlmnu)
        {
            InitializeComponent();
            DC = dc;
            frmEnrolmnu = enrlmnu;
            frmEnrolmnu.Hide();
            LoadStudents();
            cmStudent = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure1, "Student"];

        }
        private void LoadStudents()
        {
            foreach (DataRow drStudent in DC.dtStudent.Rows)
            {
                DataRow[] drEnrolments = drStudent.GetChildRows(DC.dtStudent.ChildRelations["STUDENT$ENROLMENT"]);
                if (drEnrolments.Length == 0)
                {
                    studentText = "";
                    studentText += drStudent["StudentID"] + ", ";
                    studentText += drStudent["LastName"] + "\r\n";
                    studentText += drStudent["FirstName"] + "\r\n";
                    lstStudents.Items.Add(studentText);
                }
            }
        }
        private void ClearFields()
        { // clears the following controls 

            txtStudentID.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtStreetAddress.Text = String.Empty;
            txtSuburb.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtEmailAddress.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
            txtStatus.Text = String.Empty;
        }
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string student = "";
            student = lstStudents.SelectedItem.ToString();
            string[] parts = student.Split(',');
            int studentID = Convert.ToInt32(parts[0]);
            cmStudent.Position = DC.studentView.Find(studentID);
            DataRow drStudent = DC.dtStudent.Rows[cmStudent.Position];
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

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DataRow deleteStudentRow = DC.dtStudent.Rows[cmStudent.Position];
            if (MessageBox.Show("Are you sure you want to delete this Student?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteStudentRow.Delete();
                DC.UpdateStudent();
                lstStudents.Items.Clear();
                LoadStudents();
                MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK);

                ClearFields();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEnrolmnu.Show();
        }

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {
            ClearFields();
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

        }
        
    }
}
