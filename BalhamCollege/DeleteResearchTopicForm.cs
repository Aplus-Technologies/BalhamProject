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
    public partial class DeleteResearchTopicForm : Form
    {
        private DataController DC;
        private ResearchAdministratorForm frmResearchMnu;
        private CurrencyManager cmResearchTopic;

        private DataTable dtResearchTopic2; // reference to research topic table
        private DataView researchTopicView2; // reference to dataview for research topic table 

        private string researchtopicText;
        public DeleteResearchTopicForm(DataController dc, ResearchAdministratorForm rtmnu)
        {
            InitializeComponent();
            DC = dc;
            frmResearchMnu = rtmnu;
            frmResearchMnu.Hide();
            BindControls();
            TableAndView(); // generate updated view and table 
            
        }

        private void TableAndView()
        { // generate instances of table and view for RESEARCHTOPIC table 
            dtResearchTopic2 = dsBalhamCollegeAzure.RESEARCHTOPIC;
            researchTopicView2 = new DataView(dtResearchTopic2);
            researchTopicView2.Sort = "TopicID"; 
        }

        public void BindControls()
        { // create instance of currency manager 
            cmResearchTopic = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "RESEARCHTOPIC"];
        }

        private void LoadResearchTopics()
        {
            foreach (DataRow drResearchTopic in dtResearchTopic2.Rows)
            { // list only research topics with an associated research project
                DataRow[] drResearchProjects = drResearchTopic.GetChildRows(dtResearchTopic2.ChildRelations["RESEARCHPROJECT$RESEARCHTOPICRESEARCHPROJECT"]);
                
                if (drResearchProjects.Length == 0)
                {
                    researchtopicText = "";
                    researchtopicText += drResearchTopic["TopicID"] + ", ";
                    researchtopicText += drResearchTopic["TopicDescription"] + "\r\n";

                    lstResearchTopics.Items.Add(researchtopicText);
                }
            }
        }
        private void ClearFields()
        { // clears the following controls 
            txtResearchTopicID.Text = String.Empty;
            txtTopicDescription.Text = String.Empty;
            txtImpact.Text = String.Empty;
        }

        private void btnDeleteResearchTopic_Click(object sender, EventArgs e)
        { 
            DataRow deleteResearchTopicRow = dtResearchTopic2.Rows[cmResearchTopic.Position];
            if (MessageBox.Show("Are you sure you want to delete this Research Topic?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                rESEARCHTOPICTableAdapter.Delete(Convert.ToInt32(txtResearchTopicID.Text), txtTopicDescription.Text, txtImpact.Text);
              
               this.dsBalhamCollegeAzure.AcceptChanges();

                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHPROJECT' table. You can move, or remove it, as needed.
                this.rESEARCHPROJECTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHPROJECT);
                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
                this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);

                DC.UpdateResearchTopic();
                lstResearchTopics.Items.Clear();
                LoadResearchTopics();
                MessageBox.Show("Research Topic deleted successfully", "Success", MessageBoxButtons.OK);

                ClearFields();
            }

        }

        private void lstResearchTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResearchTopics.SelectedItem != null)
            {
                string researchtopic = "";
                researchtopic = lstResearchTopics.SelectedItem.ToString();
                string[] parts = researchtopic.Split(',');
                int topicID = Convert.ToInt32(parts[0]);
                cmResearchTopic.Position = researchTopicView2.Find(topicID);
                DataRow drResearchTopic = dtResearchTopic2.Rows[cmResearchTopic.Position];
                txtResearchTopicID.Text = drResearchTopic["TopicID"].ToString();
                txtTopicDescription.Text = drResearchTopic["TopicDescription"].ToString();
                txtImpact.Text = drResearchTopic["Impact"].ToString();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmResearchMnu.Show();
        }

        private void rESEARCHTOPICBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rESEARCHTOPICBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void DeleteResearchTopicForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHPROJECT' table. You can move, or remove it, as needed.
            this.rESEARCHPROJECTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHPROJECT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
            this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);
          
            ClearFields();
            lstResearchTopics.Items.Clear(); 
            LoadResearchTopics();
        }
    }
}
