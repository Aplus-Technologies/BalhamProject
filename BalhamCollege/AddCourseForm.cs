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
            BindControls();
           
           
        }

        public void BindControls()
        {
            txtProgrammeID.DataBindings.Add("Text", dsBalhamCollegeAzure, "Programme.ProgrammeID");
            txtLevel.DataBindings.Add("Text", dsBalhamCollegeAzure, "PROGRAMME.ProgrammeLevel");
            cboProgramme.DataSource = dsBalhamCollegeAzure;
            cboProgramme.DisplayMember = "PROGRAMME.ProgrammeName";
            cboProgramme.ValueMember = "PROGRAMME.ProgrammeName";
           
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
          
            
        }

       

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // closes form

            this.Close();
            frmProgramAdmin.Show(); // show Program Administrator menu 
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
           
            txtProgrammeID.Visible = false;
            txtPlaceHolder2.Visible = true;
            txtPlaceHolder.Visible = true; 
            ClearFields(); 
           
          //  LoadProgrammes();
        }

        

       
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            programmeID = Convert.ToInt32(txtProgrammeID.Text); 

            // check if required fields are blank 
            if ((txtCourseName.Text == "") || (cboStatus.Text == "") || (cboProgramme.SelectedItem == null))
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
                txtPlaceHolder2.Visible = true;
               
                
            }
        }

        

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            if((txtCourseName.Text != ""))
            {
                txtPlaceHolder.Visible = false;
                txtPlaceHolder2.Visible = false; 
            }
            else
            {
                txtPlaceHolder.Visible = true;
                txtPlaceHolder2.Visible = true;
            }
        }
    }
}
