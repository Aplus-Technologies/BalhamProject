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
    public partial class AddResearchTopicForm : Form
    {
        //declare global variables
        private DataController DC;
        private ResearchAdministratorForm frmResearchAdmin; // reference to Research Administrator Form

        public AddResearchTopicForm(DataController dc, ResearchAdministratorForm resAdmin)
        {
            InitializeComponent();
            // call the following functions upon form initialization 
            DC = dc;
            frmResearchAdmin = resAdmin;
            frmResearchAdmin.Hide();
        }

        private void ClearFields()
        { // Clears all controls
            txtResearchTopicDesc.Text = "";
            cboImpact.Text = ""; 
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // returns user back to research administrator menu
            this.Close(); // close current form 
            frmResearchAdmin.Show(); // show research administrator menu 
        }

        private void rESEARCHTOPICBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rESEARCHTOPICBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void AddResearchTopicForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
            this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);
            ClearFields(); 
        }

        private void btnAddResearchTopic_Click(object sender, EventArgs e)
        {
            // check if required fields are blank 
            if ((txtResearchTopicDesc.Text == "") || (cboImpact.Text == ""))
            {// error message
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// create new research topic record

                // success message  

                this.rESEARCHTOPICTableAdapter.Insert(txtResearchTopicDesc.Text, cboImpact.Text);

                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
                this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);

                MessageBox.Show("Research topic added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // controls are reset to blank 
                ClearFields();

            }
        }    
    }
}
