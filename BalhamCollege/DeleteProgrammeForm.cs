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
    public partial class DeleteProgrammeForm : Form
    {
        private DataController DC;
        private ProgrammeAdministratorForm frmProgMnu;
        private CurrencyManager cmProgramme;

        private DataTable dtProgramme2;
        private DataView programmeView2;

        private string programmeText;
        public DeleteProgrammeForm(DataController dc, ProgrammeAdministratorForm progmnu)
        {
            InitializeComponent();
            DC = dc;
            frmProgMnu = progmnu;
            frmProgMnu.Hide();
            BindControls();
            TableAndView(); 
            
        }

        private void TableAndView()
        {
            dtProgramme2 = dsBalhamCollegeAzure.PROGRAMME;
            programmeView2 = new DataView(dtProgramme2);
            programmeView2.Sort = "ProgrammeID"; 
        }

        public void BindControls()
        {
            cmProgramme = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "PROGRAMME"];
        }

        private void LoadProgrammes()
        {
            foreach (DataRow drProgramme in dtProgramme2.Rows)
            {
                DataRow[] drCourses = drProgramme.GetChildRows(dtProgramme2.ChildRelations["COURSE$PROGRAMMECOURSE"]);
                if (drCourses.Length == 0)
                {
                    programmeText = "";
                    programmeText += drProgramme["ProgrammeID"] + ", ";
                    programmeText += drProgramme["ProgrammeName"] + "\r\n";

                    lstProgrammes.Items.Add(programmeText);
                }
            }
        }

        private void ClearFields()
        { // clears the following controls 
            txtProgrammeID.Text = String.Empty;
            txtProgrammeName.Text = String.Empty;
            txtLevel.Text = String.Empty;
        }
        private void pROGRAMMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROGRAMMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void DeleteProgrammeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
            lstProgrammes.Items.Clear(); 
            LoadProgrammes(); 

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProgMnu.Show();
        }

        private void btnDeleteProgramme_Click(object sender, EventArgs e)
        {
            DataRow deleteProgrammeRow = dtProgramme2.Rows[cmProgramme.Position];
            if (MessageBox.Show("Are you sure you want to delete this Programme?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //deleteProgrammeRow.Delete();
                pROGRAMMETableAdapter.Delete(Convert.ToInt32(txtProgrammeID.Text), txtProgrammeName.Text, Convert.ToInt32(txtLevel.Text)); 

                // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
                this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);

                DC.UpdateProgramme();
                lstProgrammes.Items.Clear();
                LoadProgrammes();
                MessageBox.Show("Programme deleted successfully", "Success", MessageBoxButtons.OK);

                ClearFields();
            }
        }

        private void lstProgrammes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProgrammes.SelectedItem != null)
            {
                string programme = "";
                programme = lstProgrammes.SelectedItem.ToString();
                string[] parts = programme.Split(',');
                int programmeID = Convert.ToInt32(parts[0]);
                cmProgramme.Position =programmeView2.Find(programmeID);
                DataRow drProgramme = dtProgramme2.Rows[cmProgramme.Position];
                txtProgrammeID.Text = drProgramme["ProgrammeID"].ToString();
                txtProgrammeName.Text = drProgramme["ProgrammeName"].ToString();
                txtLevel.Text = drProgramme["ProgrammeLevel"].ToString(); 
            }
        }
    }
}
