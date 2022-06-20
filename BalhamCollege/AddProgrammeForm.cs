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
    public partial class AddProgrammeForm : Form
    {
        //declare global variables
        private DataController DC;
        private ProgrammeAdministratorForm frmProgramAdmin; // reference to Program Administrator Form
        public AddProgrammeForm(DataController dc, ProgrammeAdministratorForm progAdmin)
        {
            InitializeComponent();
            // call the following functions upon form initialization 
            DC = dc;
           frmProgramAdmin = progAdmin;
           frmProgramAdmin.Hide(); // hide programme administrator menu 
        }

        private void ClearFields()
        { // reset fields to blank or their default values 
            txtProgrammeName.Text = "";
            nudLevel.Value = 1; 
        }

        private void pROGRAMMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {// functions of navigator bar
            this.Validate();
            this.pROGRAMMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void AddProgrammeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // returns user back to Programme Administrator menu
            Application.OpenForms["ProgrammeBackgroundForm"].Close(); // close background form 
            this.Close(); // close current form 
            frmProgramAdmin.Show(); // show Programme Administrator menu
        }

        private void btnAddProgramme_Click(object sender, EventArgs e)
        {
            // check if required fields are blank 
            if ((txtProgrammeName.Text == ""))
            {// error message
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// create new programme record

                // success message  
                //  this.lECTURERTableAdapter.Insert(txtLastName.Text, txtFirstName.Text, txtStreetAddress.Text, txtSuburb.Text, txtCity.Text, txtEmailAddress.Text, txtPhoneNumber.Text, cboRanking.Text, cboType.Text);
                this.pROGRAMMETableAdapter.Insert(txtProgrammeName.Text, Convert.ToInt32(nudLevel.Value));

                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
                this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);

                MessageBox.Show("Programme added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // controls are reset to blank 
                ClearFields();
            }
        }
    }
}
