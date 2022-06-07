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
    public partial class AddCourseForm : Form
    {
        //declare global variables
        private DataController DC;
        private ProgrammeAdministratorForm frmProgramAdmin;
        private CurrencyManager cmProgramme;

        private DataTable dtProgramme2; // reference to programme table
        private DataView programmeView2; // reference to dataview of programme table 

        private int programmeID; 

        public AddCourseForm(DataController dc, ProgrammeAdministratorForm progAdmin)
        {
            InitializeComponent();
            DC = dc;
            frmProgramAdmin = progAdmin;
            frmProgramAdmin.Hide();
            TableAndView(); // generate updated table and views
           
        }

        private void TableAndView()
        { // generate table and view instances of programme table 
            dtProgramme2 = dsBalhamCollegeAzure.PROGRAMME;
            programmeView2 = new DataView(dtProgramme2);
            programmeView2.Sort = "ProgrammeID"; 
        }

        private void ClearFields()
        { // Clears all controls
            txtCourseName.Text = "";
            nudCredits.Value = 5;
            nudFee.Value = 200;
            cboStatus.Text = "Current";
            lstProgrammes.Items.Clear();
            
        }

        private void LoadProgrammes()
        {
            // To load all Programmes
            string programmeText;
            foreach (DataRow drProgramme in dtProgramme2.Rows)
            {
               programmeText = drProgramme["ProgrammeID"].ToString() + ", ";
               programmeText += drProgramme["ProgrammeLevel"].ToString();
              
                lstProgrammes.Items.Add(programmeText);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // closes form

            this.Close();
            frmProgramAdmin.Show(); // show Program Administrator menu 
        }

        private void CheckTextboxes()
        { // checks if the following fields are filled 
            while ((txtCourseName.Text == "") && (cboStatus.Text == "") )
            {
                txtPlaceHolder.Visible = true;
            }
            
        }

            

        private void pROGRAMMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROGRAMMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);

            txtPlaceHolder.Visible = true; 
            ClearFields(); 
            lstProgrammes.Items.Clear();
            LoadProgrammes();
        }

        

        private void lstProgrammes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstProgrammes.SelectedItem != null)
            {
                string programmeText;
                programmeText = lstProgrammes.SelectedItem.ToString();
                string[] parts = programmeText.Split(',');
                programmeID = Convert.ToInt32(parts[0]); 

            }
            
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // check if required fields are blank 
            if ((txtCourseName.Text == "") || (cboStatus.Text == "") || (lstProgrammes.SelectedItem == null))
            {// error message
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// create new Course record               
                this.cOURSETableAdapter.Insert(txtCourseName.Text, Convert.ToInt32(nudCredits.Value), Convert.ToDecimal(nudFee.Value), cboStatus.Text, programmeID);

                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
                this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
                this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);

                // success message  
                MessageBox.Show("Course added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // controls are reset to blank 
               
                ClearFields();
                txtPlaceHolder.Visible = true;        
               
                
            }
        }
    }
}
