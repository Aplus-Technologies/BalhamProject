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

        private DataTable dtLecturer2; // reference to lecturer table
        private DataView lecturerView2;  // reference to dataview of lecturer table 

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
           
        }

        private void TableAndView()
        { // generate instances of lecturer table and dataview of lecturer table 
            dtLecturer2 = dsBalhamCollegeAzure.LECTURER;
            lecturerView2 = new DataView(dtLecturer2);
            lecturerView2.Sort = "LecturerID"; 
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
            dgvResearchProjects.Rows.Clear();
            txtOutput.Text = "";
            dtpStartDate.Value = DateTime.Today;
            txtResearchPrjDesc.Text = "";
            
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

            dgvResearchTopics.DataSource = ""; 
            ClearFields(); 
            lstLecturers.Items.Clear();
            LoadLecturers();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            // closes form
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
    }
}
