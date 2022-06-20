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
    public partial class UpdateProgrammeForm : Form
    {
        //declare global variables
        private DataController DC;
        private ProgrammeAdministratorForm frmProgrammeAdministrator; // reference to Enrolment Clerk Form
        private CurrencyManager cmProgramme;

        private DataTable dtProgramme2;
        private DataView programmeView2;

        public UpdateProgrammeForm(DataController dc, ProgrammeAdministratorForm programmeAdministrator)
        {
            InitializeComponent();
            DC = dc;
            frmProgrammeAdministrator = programmeAdministrator;
            programmeAdministrator.Hide();
            BindControls();
            TableAndView(); // generate updated table and views
        }

        private void TableAndView()
        {
            // create updated instances for Student table and dataview for student table 
            dtProgramme2 = dsBalhamCollegeAzure.PROGRAMME;
            programmeView2 = new DataView(dtProgramme2);
            programmeView2.Sort = "ProgrammeID";
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmProgramme = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Programme"];
        }

        private void LoadProgrammes()
        {
            // To load all students
            lstProgrammes.Items.Clear();
            foreach (DataRow drProgramme in dtProgramme2.Rows)
            {
                lstProgrammes.Items.Add(drProgramme);
            }
        }

        private void ClearFields()
        {
            // Clear all fields
            txtProgrammeID.Text = string.Empty;
            txtProgrammeName.Text = string.Empty;
            nudLevel.Text = string.Empty;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["ProgrammeBackgroundForm"].Close(); // closes background along with form
            this.Close(); // prevents 'cannot accessed disposed object error' upon producing report 
            frmProgrammeAdministrator.Show();
        }

        private void lstProgrammes_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRow programmeRow = (DataRow)e.ListItem;
            if (programmeRow.RowState != DataRowState.Detached)
            {
                e.Value = programmeRow["ProgrammeID"] + " " + programmeRow["ProgrammeName"];
            }
        }

        private void btnUpdateProgramme_Click(object sender, EventArgs e)
        {
            DataRow updateProgrammeRow = dtProgramme2.Rows[cmProgramme.Position];


            // Validate the entries in the fields
            if ((lstProgrammes.SelectedItem == null) || (txtProgrammeName.Text == "") || (nudLevel.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change the programme's details?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    // Save changes
                    updateProgrammeRow["ProgrammeName"] = txtProgrammeName.Text;
                    updateProgrammeRow["ProgrammeLevel"] = nudLevel.Value;
                    
                    this.pROGRAMMETableAdapter.Update(updateProgrammeRow);

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
                    this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);

                    LoadProgrammes();
                    MessageBox.Show("Programme updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    // Cancel changes
                    LoadProgrammes();
                    ClearFields();
                }
            }
        }


        private void UpdateProgrammeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);

            LoadProgrammes();
            ClearFields();
        }

        private void lstProgrammes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow drProgramme = (DataRow)lstProgrammes.SelectedItem;
            cmProgramme.Position = programmeView2.Find(drProgramme["ProgrammeID"]);

            // To populate the following controls with their corresponding values; from Programme Table 
            txtProgrammeID.Text = drProgramme["ProgrammeID"].ToString();
            txtProgrammeName.Text = drProgramme["ProgrammeName"].ToString();
            nudLevel.Text = drProgramme["ProgrammeLevel"].ToString();
        }
        private void pROGRAMMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROGRAMMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }
    }
}
