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
        private DataController DC;
        private ResearchAdministratorForm frmResearchAdministrator;
        private CurrencyManager cmResearchTopic;

        public UpdateResearchTopicForm(DataController dc, ResearchAdministratorForm researchAdministrator)
        {
            InitializeComponent();
            DC = dc;
            frmResearchAdministrator = researchAdministrator;
            researchAdministrator.Hide();
            BindControls();
        }

        public void BindControls()
        {
            // Set up Currency Manager
            cmResearchTopic = (CurrencyManager)this.BindingContext[DC.dsBalhamCollegeAzure, "ResearchTopic"];

            // Bind list of courses
            lstResearchTopics.DataSource = DC.dsBalhamCollegeAzure;
            lstResearchTopics.DisplayMember = "ResearchTopic.TopicID";
            lstResearchTopics.ValueMember = "ResearchTopic.TopicID";

            // Bind controls
            txtTopicID.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "ResearchTopic.TopicID");
            txtTopicDescription.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "ResearchTopic.TopicDescription");
            cboImpact.DataBindings.Add("Text", DC.dsBalhamCollegeAzure, "ResearchTopic.Impact");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResearchAdministrator.Show();
        }

        private void lstResearchTopics_Format(object sender, ListControlConvertEventArgs e)
        {
            // Convert database row into listitem text
            DataRowView researchTopicRow = (DataRowView)e.ListItem;
            e.Value = researchTopicRow.Row["TopicID"] + " " + researchTopicRow.Row["TopicDescription"];
        }

        private void btnUpdateTopic_Click(object sender, EventArgs e)
        {
            DataRow updateResearchTopicRow = DC.dtResearchTopic.Rows[cmResearchTopic.Position];

            // Validate the entries in the fields
            if ((txtTopicDescription.Text == "") || (cboImpact.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change the research topic's details?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Save changes
                    updateResearchTopicRow["TopicDescription"] = txtTopicDescription.Text;
                    updateResearchTopicRow["Impact"] = cboImpact.Text;

                    cmResearchTopic.EndCurrentEdit();
                    DC.UpdateResearchTopic();
                    MessageBox.Show("Research topic updated successfully", "Success");
                }
                else
                {
                    // Cancel changes
                    cmResearchTopic.CancelCurrentEdit();
                }
            }
        }
    }
}
