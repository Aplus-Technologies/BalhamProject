using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // class to check for  regular expression pattern 

namespace BalhamCollege
{
    public partial class AddStudentForm : Form
    {
        //declare global variables
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolMenu;

        private bool resultMatch; // boolean to check if email pattern is valid 

        public AddStudentForm(DataController dc, EnrolmentsClerkForm enrolmnu)
        { // call the following functions upon form initialization 
            InitializeComponent();
            DC = dc;
            frmEnrolMenu = enrolmnu;
            frmEnrolMenu.Hide();
        }

        private void ClearFields()
        { // Clears all controls
            txtLastName.Text = "";
            txtFirstName.Text = "";
            cboStatus.Text = null;
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            errorProvider1.Clear(); 

           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {// closes form
            Application.OpenForms["BackgroundForm"].Close();
            this.Close();
            frmEnrolMenu.Show(); // show enrolments clerk menu 
        } 
        
        private void btnAddStudent_Click(object sender, EventArgs e)
        {// check if required fields are blank 
            if ((txtLastName.Text == "")|| (txtFirstName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (txtCity.Text == "") || (resultMatch == false)|| (txtPhoneNumber.Text == "") || (cboStatus.Text == ""))
            {// error message
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// create new student record
                this.sTUDENTTableAdapter.Insert(txtLastName.Text, txtFirstName.Text, txtStreetAddress.Text, txtSuburb.Text, txtCity.Text, txtEmailAddress.Text, txtPhoneNumber.Text, cboStatus.Text);
             // success message  
                MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             // controls are reset to blank 
                ClearFields();
            }
        }

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

            ClearFields(); 
        }

        
        private void txtEmailAddress_Leave(object sender, EventArgs e)
        { // flash error symbol beside Email address text box if pattern does not match 
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            resultMatch = false; 
           
            if (Regex.IsMatch(txtEmailAddress.Text, pattern))
            {
                errorProvider1.Clear();
                resultMatch = true;
                
            }
            else
            {
                errorProvider1.SetError(this.txtEmailAddress, "Please fill in all fields correctly");
                resultMatch = false;
                return;
            }
        }
    }
}
