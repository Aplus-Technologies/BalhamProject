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
    public partial class UpdateResearchTopicForm : Form
    {
        //declare global variables
        private DataController DC;
        private ResearchAdministratorForm frmResearchAdministrator;
        private CurrencyManager cmResearchTopic;

        private DataTable dtResearchTopic2;
        private DataView researchTopicView2;

        public UpdateResearchTopicForm(DataController dc, ResearchAdministratorForm researchAdministrator)
        {
            InitializeComponent();
            DC = dc;
            frmResearchAdministrator = researchAdministrator;
            researchAdministrator.Hide();
            BindControls();
            TableAndView(); // generate updated table and views
        }
        private void TableAndView()
        {
            // create updated instances for ResearchTopic table and dataview for researchTopic table 
            dtResearchTopic2 = dsBalhamCollegeAzure.RESEARCHTOPIC;
            researchTopicView2 = new DataView(dtResearchTopic2);
            researchTopicView2.Sort = "TopicID";
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmResearchTopic = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "ResearchTopic"];
        }
        private void LoadResearchTopics()
        {
            // To load all research topics
            lstResearchTopics.Items.Clear();
            foreach (DataRow drResearchTopic in dtResearchTopic2.Rows)
            {
                lstResearchTopics.Items.Add(drResearchTopic);
            }
        }
        private void ClearFields()
        {
            // Clear all fields
            txtTopicID.Text = string.Empty;
            txtTopicDescription.Text = string.Empty;
            cboImpact.Text = string.Empty;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["ResearchBackgroundForm"].Close(); // closes background along with form
            this.Close(); // prevents 'cannot accessed disposed object error' upon producing report 
            frmResearchAdministrator.Show();
        }

        private void lstResearchTopics_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text

            DataRow researchTopicRow = (DataRow)e.ListItem;
            if (researchTopicRow.RowState != DataRowState.Detached)
            {
                e.Value = researchTopicRow["TopicID"] + " " + researchTopicRow["TopicDescription"];
            }
        }

        private void btnUpdateTopic_Click(object sender, EventArgs e)
        {
            DataRow updateResearchTopicRow = dtResearchTopic2.Rows[cmResearchTopic.Position];

            // Validate the entries in the fields
            if ((lstResearchTopics.SelectedItem == null) || (txtTopicDescription.Text == "") || (cboImpact.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change the research topic's details?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    // Save changes
                    updateResearchTopicRow["TopicDescription"] = txtTopicDescription.Text;
                    updateResearchTopicRow["Impact"] = cboImpact.Text;

                    this.rESEARCHTOPICTableAdapter.Update(updateResearchTopicRow);

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
                    this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);

                    LoadResearchTopics();
                    MessageBox.Show("Research topic updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    // Cancel changes
                    LoadResearchTopics();
                    ClearFields();
                }
            }
        }

        private void UpdateResearchTopicForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
            this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);

            LoadResearchTopics();
            ClearFields();
        }

        private void lstResearchTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow drResearchTopic = (DataRow)lstResearchTopics.SelectedItem;
            cmResearchTopic.Position = researchTopicView2.Find(drResearchTopic["TopicID"]);

            // To populate the following controls with their corresponding values; from ResearchTopic Table 
            txtTopicID.Text = drResearchTopic["TopicID"].ToString();
            txtTopicDescription.Text = drResearchTopic["TopicDescription"].ToString();
            cboImpact.Text = drResearchTopic["Impact"].ToString();
        }

        private void rESEARCHTOPICBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rESEARCHTOPICBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }
    }
}
