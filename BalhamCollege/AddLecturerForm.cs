using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // // class to check for  regular expression pattern 

namespace BalhamCollege
{
    public partial class AddLecturerForm : Form
    {
        //declare global variables
        private DataController DC;
        private HumanResourcesClerkForm frmHumanResources; // reference to Human Resources Clerk Form

        private bool resultMatch; // boolean to check if email pattern is valid 
        public AddLecturerForm(DataController dc, HumanResourcesClerkForm humanRes)
        {
            InitializeComponent();
            // call the following functions upon form initialization 
            DC = dc;
            frmHumanResources = humanRes;
            frmHumanResources.Hide();
        }

        private void ClearFields()
        { // Clears all controls
            txtLastName.Text = "";
            txtFirstName.Text = "";
            cboRanking.Text = null;
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            cboType.Text = null;
            errorProvider2.Clear(); 


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {// returns user back to human resources clerk menu
            this.Close(); // close current form 
            frmHumanResources.Show(); // show human resources clerk menu 
        }

        private void lECTURERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lECTURERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void AddLecturerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);

            ClearFields(); // clears controls upon form opening 
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            
            // check if required fields are blank 
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (txtCity.Text == "") || (resultMatch == false) || (txtPhoneNumber.Text == "") || (cboRanking.Text == "") || (cboType.Text == ""))
            {// error message
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// create new lecturer record
        
             // success message  
                this.lECTURERTableAdapter.Insert(txtLastName.Text, txtFirstName.Text, txtStreetAddress.Text, txtSuburb.Text, txtCity.Text, txtEmailAddress.Text, txtPhoneNumber.Text, cboRanking.Text, cboType.Text);
                
                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
                this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
               
                MessageBox.Show("Lecturer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // controls are reset to blank 
                ClearFields();
            }
        }

        private void txtEmailAddress_Leave(object sender, EventArgs e)
        {
            // flash error symbol beside Email address text box if pattern does not match 
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            resultMatch = false;

            if (Regex.IsMatch(txtEmailAddress.Text, pattern))
            {
                errorProvider2.Clear();
                resultMatch = true; 
            }
            else
            {
                errorProvider2.SetError(this.txtEmailAddress, "Please fill in all fields correctly");
                resultMatch = false;
                return;
            }

          
        }
    }
}
