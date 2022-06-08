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
        private DataController DC;
        private ProgrammeAdministratorForm frmProgrammeAdministrator;
        private CurrencyManager cmProgramme;

        public UpdateProgrammeForm(DataController dc, ProgrammeAdministratorForm programmeAdministrator)
        {
            InitializeComponent();
            DC = dc;
            frmProgrammeAdministrator = programmeAdministrator;
            programmeAdministrator.Hide();
            BindControls();
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmProgramme = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "Programme"];

            // Bind list of programmes
            lstProgrammes.DataSource = DC.dsBalhamCollegeAzure;
            lstProgrammes.DisplayMember = "Programme.ProgrammeID";
            lstProgrammes.ValueMember = "Programme.ProgrammeID";

            // Bind controls
            txtProgrammeID.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Programme.ProgrammeID");
            txtProgrammeName.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "Programme.ProgrammeName");
            nudLevel.DataBindings.Add("Value", DC.dsBalhamCollegeAzure, "Programme.ProgrammeLevel");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProgrammeAdministrator.Show();
        }

        private void lstProgrammes_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRowView programmeRow = (DataRowView)e.ListItem;
            e.Value = programmeRow.Row["ProgrammeID"] + " " + programmeRow.Row["ProgrammeName"];
        }

        private void btnUpdateProgramme_Click(object sender, EventArgs e)
        {
            DataRow updateProgrammeRow = DC.dtProgramme.Rows[cmProgramme.Position];

            // Validate the entries in the fields
            if ((txtProgrammeName.Text == "") || (nudLevel.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change the programme's details?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Save changes
                    updateProgrammeRow["ProgrammeName"] = txtProgrammeName.Text;
                    updateProgrammeRow["ProgrammeLevel"] = nudLevel.Value;

                    cmProgramme.EndCurrentEdit();
                    DC.UpdateProgramme();
                    MessageBox.Show("Programme updated successfully", "Success");
                }
                else
                {
                    // Cancel changes
                    cmProgramme.CancelCurrentEdit();
                }
            }

        }

        private void pROGRAMMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROGRAMMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void UpdateProgrammeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);

        }
    }
}
