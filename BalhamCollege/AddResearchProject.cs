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
    public partial class AddResearchProject : Form
    {
        //declare global variables
        private DataController DC;
        private ResearchAdministratorForm frmResearchAdminForm;
        private CurrencyManager cmLecturer;
        private CurrencyManager cmProject;
        private CurrencyManager cmTopic;

        private DataTable dtLecturer2; // reference to lecturer table
        private DataView lecturerView2;  // reference to dataview of lecturer table 
        private DataTable dtResearchProject2; // reference to the research project table
        private DataView researchProjectView2; // reference to dataview of research project table; 
        private DataTable dtResearchTopic2; // reference to Research Topic table
        private DataView researchTopicView2; // reference to dataview of research topic table

        private int topicID;

        public AddResearchProject(DataController dc, ResearchAdministratorForm resAdmin)
        {
            InitializeComponent();
            DC = dc;
            frmResearchAdminForm = resAdmin;
            frmResearchAdminForm.Hide();
            TableAndView(); // generate updated tables and views
            BindControls(); 

        }

        public void BindControls()
        { // create instance of currency manager for Lecturer table 
            cmLecturer = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "LECTURER"];
            cmProject = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "RESEARCHPROJECT"];
            cmTopic = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "RESEARCHTOPIC"];
        }

        private void TableAndView()
        { // generate instances of lecturer table and dataview of lecturer table 
            dtLecturer2 = dsBalhamCollegeAzure.LECTURER;
            lecturerView2 = new DataView(dtLecturer2);
            lecturerView2.Sort = "LecturerID";

            dtResearchProject2 = dsBalhamCollegeAzure.RESEARCHPROJECT;
            researchProjectView2 = new DataView(dtResearchProject2);
            researchProjectView2.Sort = "ResearchProjectID";

            dtResearchTopic2 = dsBalhamCollegeAzure.RESEARCHTOPIC;
            researchTopicView2 = new DataView(dtResearchTopic2);
            researchTopicView2.Sort = "TopicID"; 
        }

        private void LoadLecturers()
        {
            // To load all lecturers
            string lecturerText;
            foreach (DataRow drLecturer in dtLecturer2.Rows)
            {
                lecturerText = drLecturer["LecturerID"].ToString() + ", ";
                lecturerText += drLecturer["LastName"].ToString() + ", ";
                lecturerText += drLecturer["FirstName"].ToString();

                lstLecturers.Items.Add(lecturerText);


            }
        }

        private void ClearFields()
        { // Clears all controls
            txtLecturerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtType.Text = "";
           
            txtOutput.Text = "";
            dtpStartDate.Value = DateTime.Today;
            txtResearchPrjDesc.Text = "";
            
        } 

        private void GetProjects()
        {
            DataTable projectsA = new DataTable();
            projectsA.Columns.Add("Output", typeof(string));
            projectsA.Columns.Add("Research Project Description", typeof(string));
            projectsA.Columns.Add("Research Topic Description", typeof(string));

            foreach (DataRow drPT in this.dsBalhamCollegeAzure.RESEARCHPROJECT.Rows)
            {
                if (txtLecturerID.Text == drPT[4].ToString())
                {
                    DataRow aprojectRowID;
                    aprojectRowID = projectsA.NewRow();
                    projectsA.Rows.Add(aprojectRowID);
                    aprojectRowID[0] = drPT[3].ToString(); // get Output and place in first column of new table
                    aprojectRowID[1] = drPT[1].ToString(); // get project description and place in second column of new table
                    cmTopic.Position = researchTopicView2.Find(Convert.ToInt32(drPT[5]));
                    DataRow drTopic = dtResearchTopic2.Rows[cmTopic.Position];
                    aprojectRowID[2] = drTopic["TopicDescription"].ToString(); // get Research Topic description and set to third column of new table 
                   
                }
            }
          
           dgvResearchProjects.DataSource = projectsA;  // the data table created previously 
           dgvResearchProjects.Columns[0].Width = 100;
           dgvResearchProjects.Columns[1].Width = 350;
           dgvResearchProjects.Columns[2].Width = 350;

           dgvResearchProjects.DefaultCellStyle.SelectionBackColor = Color.White;
           dgvResearchProjects.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        
        private void lstLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstLecturers.SelectedItem != null)
            {
                string lecturer;
                // Converts the selected item in the lecturer listbox to a string
                // using index 0 of the string, which is the LecturerID to find the row it belongs to in the Lecturer Table using Currency Manager
                lecturer = lstLecturers.SelectedItem.ToString();
                string[] parts = lecturer.Split(',');
                int lecturerID = Convert.ToInt32(parts[0]);
                cmLecturer.Position = lecturerView2.Find(lecturerID);
                DataRow drLecturer = dtLecturer2.Rows[cmLecturer.Position];

                //To populate the following controls with their corresponding values; from Student Table 
                txtLecturerID.Text = drLecturer["LecturerID"].ToString();
                txtLastName.Text = drLecturer["LastName"].ToString();
                txtFirstName.Text = drLecturer["FirstName"].ToString();
                txtType.Text = drLecturer["Type"].ToString();

                //show list of topics in data grid view for Research Topics 
                dgvResearchTopics.DataSource = dsBalhamCollegeAzure.RESEARCHTOPIC;
                dgvResearchTopics.Columns[0].Width = 80; // set column[0] width
                dgvResearchTopics.Columns[1].Width = 420; // set column[300] width
                dgvResearchTopics.Columns[2].Width = 100;  // set column[100] width
               
               

                GetProjects();

            }
        }

        private void lECTURERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lECTURERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void AddResearchProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHPROJECT' table. You can move, or remove it, as needed.
            this.rESEARCHPROJECTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHPROJECT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
            this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);

            dgvResearchProjects.DataSource = "";
            dgvResearchTopics.DataSource = ""; 
            ClearFields(); 
            lstLecturers.Items.Clear();
            LoadLecturers();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            // closes form
            Application.OpenForms["ResearchBackgroundForm"].Close();
            this.Close();
            frmResearchAdminForm.Show(); // show Research Administrator menu 
        }

        private void dgvResearchTopics_SelectionChanged(object sender, EventArgs e)
        { // get the research topic ID of the selected row 
            dgvResearchTopics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvResearchTopics.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvResearchTopics.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvResearchTopics.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["TopicID"].Value);
                topicID = Convert.ToInt32(cellValue); 

            }
        }

        private void btnAddResearchProject_Click(object sender, EventArgs e)
        {
            // check if required fields are blank 
            if ((txtOutput.Text == "") || (txtResearchPrjDesc.Text == "") || (lstLecturers.SelectedItem == null) || (topicID == 0))
            {// error message
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// create new research project record
                // convert start date to format yyyy-MM-dd to be acceptable to SQL database 
                string date_format = Convert.ToDateTime(dtpStartDate.Text).ToString("yyyy-MM-dd");

                // success message  
                this.rESEARCHPROJECTTableAdapter.Insert(txtResearchPrjDesc.Text, date_format, txtOutput.Text, Convert.ToInt32(txtLecturerID.Text), topicID); 

                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHPROJECT' table. You can move, or remove it, as needed.
                this.rESEARCHPROJECTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHPROJECT);
                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
                this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);
                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
                this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);


                MessageBox.Show("Research project added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // controls are reset to blank 
               
                dgvResearchProjects.DataSource = "";
                dgvResearchTopics.DataSource = ""; 
                ClearFields();
            }
        }
    }
}
