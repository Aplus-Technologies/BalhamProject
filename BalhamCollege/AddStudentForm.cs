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
    public partial class AddStudentForm : Form
    {
        //declare global variables
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolMenu;

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

           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {// closes form
            
            this.Close();
            frmEnrolMenu.Show(); // show enrolments clerk menu 
        } 
        
        private void btnAddStudent_Click(object sender, EventArgs e)
        {// check if required fields are blank 
            if ((txtLastName.Text == "")|| (txtFirstName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (txtCity.Text == "") || (txtEmailAddress.Text == "") || (txtPhoneNumber.Text == "") || (cboStatus.Text == ""))
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

        }
    }
}
