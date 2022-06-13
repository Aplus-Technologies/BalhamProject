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
        //declare global variables
        private DataController DC;
        private HumanResourcesClerkForm frmHumanResourcesClerk;
        private CurrencyManager cmLecturer;

        private DataTable dtLecturer2;
        private DataView lecturerView2;

        public UpdateLecturerForm(DataController dc, HumanResourcesClerkForm humanResourcesClerk)
        {
            InitializeComponent();
            DC = dc;
            frmHumanResourcesClerk = humanResourcesClerk;
            humanResourcesClerk.Hide();
            BindControls();
            TableAndView(); // generate updated table and views
        }

        private void TableAndView()
        {
            // create updated instances for Lecturer table and dataview for lecturer table 
            dtLecturer2 = dsBalhamCollegeAzure.LECTURER;
            lecturerView2 = new DataView(dtLecturer2);
            lecturerView2.Sort = "LecturerID";
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmLecturer = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Lecturer"];
        }

        private void LoadLecturers()
        {
            // To load all lecturers
            lstLecturers.Items.Clear();
            foreach (DataRow drLecturer in dtLecturer2.Rows)
            {
                lstLecturers.Items.Add(drLecturer);
            }
        }

        private void ClearFields()
        {
            // Clear all fields
            txtLecturerID.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtStreetAddress.Text = string.Empty;
            txtSuburb.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmailAddress.Text = string.Empty;
            cboRanking.Text = string.Empty;
            cboType.Text = string.Empty;
        }
        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); // prevents 'cannot accessed disposed object error' upon producing report 
            frmHumanResourcesClerk.Show();
        }

        private void lstLecturers_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRow lecturerRow = (DataRow)e.ListItem;
            if (lecturerRow.RowState != DataRowState.Detached)
            {
                e.Value = lecturerRow["LecturerID"] + " " + lecturerRow["LastName"] + ", " + lecturerRow["FirstName"];
            }
        }

        private void btnUpdateLecturer_Click(object sender, EventArgs e)
        {
            DataRow updateLecturerRow = dtLecturer2.Rows[cmLecturer.Position];

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

                    this.lECTURERTableAdapter.Update(updateLecturerRow);

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
                    this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);

                    LoadLecturers();
                    MessageBox.Show("Lecturer updated successfully", "Success");
                    ClearFields();
                }
                else
                {
                    // Cancel changes
                    LoadLecturers();
                    ClearFields();
                }
            }
        }

        private void UpdateLecturerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);

            LoadLecturers();
            ClearFields();
        }

        private void lstLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow drLecturer = (DataRow)lstLecturers.SelectedItem;
            cmLecturer.Position = lecturerView2.Find(drLecturer["LecturerID"]);

            // To populate the following controls with their corresponding values; from Lecturer Table 
            txtLecturerID.Text = drLecturer["LecturerID"].ToString();
            txtLastName.Text = drLecturer["LastName"].ToString();
            txtFirstName.Text = drLecturer["FirstName"].ToString();
            txtStreetAddress.Text = drLecturer["StreetAddress"].ToString();
            txtSuburb.Text = drLecturer["Suburb"].ToString();
            txtCity.Text = drLecturer["City"].ToString();
            txtEmailAddress.Text = drLecturer["EmailAddress"].ToString();
            txtPhoneNumber.Text = drLecturer["PhoneNumber"].ToString();
            cboRanking.Text = drLecturer["Ranking"].ToString();
            cboType.Text = drLecturer["Type"].ToString();
        }
        private void lECTURERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lECTURERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }
    }
}
