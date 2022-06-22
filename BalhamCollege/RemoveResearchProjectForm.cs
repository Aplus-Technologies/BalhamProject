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
    public partial class RemoveResearchProjectForm : Form
    {
        private DataController DC;
        private ResearchAdministratorForm frmResearchMnu;
        private CurrencyManager cmLecturer;
        private CurrencyManager cmResearchProject;
        private CurrencyManager cmResearchTopic;

        private DataTable dtLecturer2;
        private DataTable dtResearchTopic2;
        private DataTable dtResearchProject2;

        private DataView lecturerView2;
        private DataView researchTopicView2;
        private DataView researchProjectView2;

        string lecturerText;
        string researchText;
        public RemoveResearchProjectForm(DataController dc, ResearchAdministratorForm researchmnu)
        {
            InitializeComponent();
            DC = dc;
            frmResearchMnu = researchmnu;
            frmResearchMnu.Hide();
           
            TableAndView(); 

            cmLecturer = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "LECTURER"];
            cmResearchProject = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "RESEARCHPROJECT"];
            cmResearchTopic = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "RESEARCHTOPIC"];
        }

        private void TableAndView()
        {
            dtLecturer2 = dsBalhamCollegeAzure.LECTURER;
            dtResearchProject2 = dsBalhamCollegeAzure.RESEARCHPROJECT;
            dtResearchTopic2 = dsBalhamCollegeAzure.RESEARCHTOPIC;

            lecturerView2 = new DataView(dtLecturer2);
            lecturerView2.Sort = "LecturerID";
            researchTopicView2 = new DataView(dtResearchTopic2);
            researchTopicView2.Sort = "TopicID";
            researchProjectView2 = new DataView(dtResearchProject2);
            researchProjectView2.Sort = "ResearchProjectID"; 
        }


        private void lECTURERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lECTURERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void RemoveResearchProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
            this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHPROJECT' table. You can move, or remove it, as needed.
            this.rESEARCHPROJECTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHPROJECT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
           
            lstLecturers.Items.Clear();
            lstResearchProjects.Items.Clear();
            LoadLecturers(); 
            ClearFields();

        }
        private void ClearFields()
        {
            txtLecturerID.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtType.Text = String.Empty;
            txtResearchProjectID.Text = String.Empty;
            txtOutput.Text = String.Empty;
            txtProjectDescription.Text = String.Empty;
            txtTopicDescription.Text = String.Empty;
        }
        private void LoadLecturers()
        {
            foreach (DataRow drLecturer in dtLecturer2.Rows)
            {
                DataRow[] drResearchProjects = drLecturer.GetChildRows(dtLecturer2.ChildRelations["RESEARCHPROJECT$LECTURERRESEARCHPROJECT"]);
                if (drResearchProjects.Length != 0)
                {
                    lecturerText = "";
                    lecturerText += drLecturer["LecturerID"] + ", ";

                    lecturerText += drLecturer["LastName"] + ", ";
                    lecturerText += drLecturer["FirstName"] + "\r\n";

                    lstLecturers.Items.Add(lecturerText);
                }
            }
        }
        private void lstLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLecturers.SelectedItem != null)
            {
                string lecturer = "";
                lstResearchProjects.Items.Clear();
                ClearFields();
                lecturer = lstLecturers.SelectedItem.ToString();
                string[] parts = lecturer.Split(',');
                int lecturerID = Convert.ToInt32(parts[0]);
                cmLecturer.Position = lecturerView2.Find(lecturerID);
                DataRow drLecturer = dtLecturer2.Rows[cmLecturer.Position];
                txtLecturerID.Text = drLecturer["LecturerID"].ToString();
                txtLastName.Text = drLecturer["LastName"].ToString();
                txtFirstName.Text = drLecturer["FirstName"].ToString();
                txtType.Text = drLecturer["Type"].ToString();

                DataRow[] drResearchProjects = drLecturer.GetChildRows(dtLecturer2.ChildRelations["RESEARCHPROJECT$LECTURERRESEARCHPROJECT"]);
                foreach (DataRow drResearchProject in drResearchProjects)
                {
                    int aResearchTopicID = Convert.ToInt32(drResearchProject["TopicID"].ToString());
                    cmResearchTopic.Position = researchTopicView2.Find(aResearchTopicID);
                    DataRow drResearchTopic = dtResearchTopic2.Rows[cmResearchTopic.Position];
                    researchText = "ID: " + drResearchProject["ResearchProjectID"] + ", " + drResearchProject["ProjectDescription"];
                    lstResearchProjects.Items.Add(researchText);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["ResearchBackgroundForm"].Close();
            this.Close();
            frmResearchMnu.Show();
        }

        private void lstResearchProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstResearchProjects.SelectedItem != null)
            {
                string researchProject = "";
                researchProject = lstResearchProjects.SelectedItem.ToString();
                string[] parts = researchProject.Split(',');
                string[] ResearchPIDstring = parts[0].Split(' ');
                int aResearchProjectID = Convert.ToInt32(ResearchPIDstring[1]);
                cmResearchProject.Position = researchProjectView2.Find(aResearchProjectID);
                DataRow drResearchProject = dtResearchProject2.Rows[cmResearchProject.Position];
                txtResearchProjectID.Text = drResearchProject["ResearchProjectID"].ToString();
                txtOutput.Text = drResearchProject["Output"].ToString();
                txtProjectDescription.Text = drResearchProject["ProjectDescription"].ToString();

                int aResearchTopicID = Convert.ToInt32(drResearchProject["TopicID"].ToString());
                cmResearchTopic.Position = researchTopicView2.Find(aResearchTopicID);
                DataRow drResearchTopic = dtResearchTopic2.Rows[cmResearchTopic.Position];
                txtTopicDescription.Text = drResearchTopic["TopicDescription"].ToString();
            }

        }

        private void btnRemoveResearchProject_Click(object sender, EventArgs e)
        {

            if (lstResearchProjects.SelectedItem != null)
            {
                DataRow deleteResearchProjectRow = dtResearchProject2.Rows[cmResearchProject.Position];
                if (MessageBox.Show("Are you sure you want to remove this Research Project?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string researchProject;
                    researchProject = lstResearchProjects.SelectedItem.ToString();
                    string[] parts = researchProject.Split(',');
                    string[] IDstring = parts[0].Split(' ');
                    int aResearchProjectID = Convert.ToInt32(IDstring[1]);
                    cmResearchProject.Position = researchProjectView2.Find(aResearchProjectID);

               
                    this.rESEARCHPROJECTTableAdapter.Delete(Convert.ToInt32(deleteResearchProjectRow["ResearchProjectID"]), deleteResearchProjectRow["ProjectDescription"].ToString(), deleteResearchProjectRow["StartDate"].ToString(), deleteResearchProjectRow["Output"].ToString(), Convert.ToInt32(deleteResearchProjectRow["LecturerID"]), Convert.ToInt32(deleteResearchProjectRow["TopicID"]));
                    this.dsBalhamCollegeAzure.AcceptChanges();

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
                    this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHPROJECT' table. You can move, or remove it, as needed.
                    this.rESEARCHPROJECTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHPROJECT);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
                    this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);

                    DC.UpdateResearchProject();

                    MessageBox.Show("Research Project removed successfully", "Acknowledgement", MessageBoxButtons.OK);
                    lstLecturers.Items.Clear();
                    LoadLecturers(); // refresh lecturer list, in case a lecturer has zero assigned research projects
                    lstResearchProjects.Items.Clear();
                    ClearFields();
                }
                else
                {
                    ClearFields();
                }
            }
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void txtLecturerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblLecturerID_Click(object sender, EventArgs e)
        {


        }
    }
}
