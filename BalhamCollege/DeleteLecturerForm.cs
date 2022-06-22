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
    public partial class DeleteLecturerForm : Form
    {
        private DataController DC;
        private HumanResourcesClerkForm frmHrMenu;
        private CurrencyManager cmLecturer;

        private DataTable dtLecturer2;
        private DataView lecturerView2;

        private string lecturerText;
        public DeleteLecturerForm(DataController dc, HumanResourcesClerkForm hrmnu)
        {
            InitializeComponent();
            DC = dc;
            frmHrMenu = hrmnu;
            frmHrMenu.Hide();
            BindControls();
            TableAndView(); 
                   
        }


        private void TableAndView()
        {
            dtLecturer2 = dsBalhamCollegeAzure.LECTURER;
            lecturerView2 = new DataView(dtLecturer2);
            lecturerView2.Sort = "LecturerID"; 
        }
        public void BindControls()
        {
            cmLecturer = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "LECTURER"];
        }

        private void LoadLecturers()
        {
            foreach (DataRow drLecturer in dtLecturer2.Rows)
            {
                DataRow[] drAssignments = drLecturer.GetChildRows(dtLecturer2.ChildRelations["ASSIGNMENT$LECTURERASSIGNMENT"]);
                if (drAssignments.Length == 0)
                {
                    lecturerText = "";
                    lecturerText += drLecturer["LecturerID"] + ", ";
                    lecturerText += drLecturer["LastName"] + ", ";
                    lecturerText += drLecturer["FirstName"] + "\r\n";
                    lstLecturers.Items.Add(lecturerText);
                }
            }
        }

        private void ClearFields()
        { // clears the following controls 
            txtLecturerID.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtStreetAddress.Text = String.Empty;
            txtSuburb.Text = String.Empty;
            txtCity.Text = String.Empty;

        }

        private void btnDeleteLecturer_Click(object sender, EventArgs e)
        {
            if (lstLecturers.SelectedItem != null)
            {

                DataRow deleteLecturerRow = dtLecturer2.Rows[cmLecturer.Position];
                if (MessageBox.Show("Are you sure you want to delete this Lecturer?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    
                    // deleteLecturerRow.Delete();
                    lECTURERTableAdapter.Delete(Convert.ToInt32(txtLecturerID.Text), txtLastName.Text, txtFirstName.Text, txtStreetAddress.Text, txtSuburb.Text, txtCity.Text, deleteLecturerRow["EmailAddress"].ToString(), deleteLecturerRow["PhoneNumber"].ToString(), deleteLecturerRow["Ranking"].ToString(), deleteLecturerRow["Type"].ToString());
                    this.dsBalhamCollegeAzure.AcceptChanges(); 


                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
                    this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);

                    DC.UpdateLecturer();
                    lstLecturers.Items.Clear();
                    LoadLecturers();
                    MessageBox.Show("Lecturer deleted successfully", "Success", MessageBoxButtons.OK);

                    ClearFields();
                }
                else
                {
                    ClearFields();
                }
            }
        }

        private void lstLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLecturers.SelectedItem != null)
            {
                string lecturer = "";
                lecturer = lstLecturers.SelectedItem.ToString();
                string[] parts = lecturer.Split(',');
                int LecturerID = Convert.ToInt32(parts[0]);
                cmLecturer.Position = lecturerView2.Find(LecturerID);
                DataRow drLecturer = dtLecturer2.Rows[cmLecturer.Position];
                txtLecturerID.Text = drLecturer["LecturerID"].ToString();
                txtLastName.Text = drLecturer["LastName"].ToString();
                txtFirstName.Text = drLecturer["FirstName"].ToString();
                txtStreetAddress.Text = drLecturer["StreetAddress"].ToString();
                txtSuburb.Text = drLecturer["Suburb"].ToString();
                txtCity.Text = drLecturer["City"].ToString();
            }
        }

        private void lECTURERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lECTURERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void DeleteLecturerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSIGNMENT' table. You can move, or remove it, as needed.
            this.aSSIGNMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSIGNMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);

            lstLecturers.Items.Clear(); 
            ClearFields();
            LoadLecturers(); 

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["HumanBackgroundForm"].Close();
            this.Close();
            frmHrMenu.Show();
        }
    }


}
