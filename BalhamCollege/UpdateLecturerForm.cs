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
    public partial class UpdateLecturerForm : Form
    {
        private DataController DC;
        private HumanResourcesClerkForm frmHumanResourcesClerk;
        private CurrencyManager cmLecturer;

        public UpdateLecturerForm(DataController dc, HumanResourcesClerkForm humanResourcesClerk)
        {
            InitializeComponent();
            DC = dc;
            frmHumanResourcesClerk = humanResourcesClerk;
            humanResourcesClerk.Hide();
            BindControls();
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmLecturer = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Lecturer"];

            // Bind list of lecturers
            lstLecturers.DataSource = DC.dsBalhamCollegeAzure;
            lstLecturers.DisplayMember = "Lecturer.LecturerID";
            lstLecturers.ValueMember = "Lecturer.LecturerID";

            // Bind controls at right
            txtLecturerID.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.LecturerID");
            txtLastName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.Suburb");
            txtCity.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.City");
            txtPhoneNumber.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.PhoneNumber");
            txtEmailAddress.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.EmailAddress");
            cboRanking.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.Ranking");
            cboType.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Lecturer.Type");

        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHumanResourcesClerk.Show();
        }

        private void lstLecturers_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRowView lecturerRow = (DataRowView)e.ListItem;
            e.Value = lecturerRow.Row["LecturerID"] + " " + lecturerRow.Row["LastName"] + ", " + lecturerRow.Row["FirstName"];
        }

        private void btnUpdateLecturer_Click(object sender, EventArgs e)
        {
            DataRow updateLecturerRow = DC.dtLecturer.Rows[cmLecturer.Position];

            // Validate the entries in the fields
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") ||
                (txtCity.Text == "") || (txtPhoneNumber.Text == "") || (txtEmailAddress.Text == "") || (cboRanking.Text == "") || (cboType.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change the lecturer's details?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Save changes
                    updateLecturerRow["LastName"] = txtLastName.Text;
                    updateLecturerRow["FirstName"] = txtFirstName.Text;
                    updateLecturerRow["StreetAddress"] = txtStreetAddress.Text;
                    updateLecturerRow["Suburb"] = txtSuburb.Text;
                    updateLecturerRow["City"] = txtCity.Text;
                    updateLecturerRow["PhoneNumber"] = txtPhoneNumber.Text;
                    updateLecturerRow["EmailAddress"] = txtEmailAddress.Text;
                    updateLecturerRow["Ranking"] = cboRanking.Text;
                    updateLecturerRow["Type"] = cboType.Text;


                    cmLecturer.EndCurrentEdit();
                    DC.UpdateLecturer();
                    MessageBox.Show("Lecturer updated successfully", "Success");
                }
                else
                {
                    // Cancel changes
                    cmLecturer.CancelCurrentEdit();
                }
            }
        }
    }
}
