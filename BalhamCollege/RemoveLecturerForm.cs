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
    public partial class RemoveLecturerForm : Form
    {
        private DataController DC;
        private ProgrammeAdministratorForm frmProgMnu;
        private CurrencyManager cmCourse;
        private CurrencyManager cmLecturer;
        private CurrencyManager cmAssignment;
        private CurrencyManager cmProgramme;

        private DataTable dtCourse2;
        private DataTable dtAssignment2;
        private DataTable dtProgramme2;
        private DataTable dtLecturer2;

        private DataView courseView2;
        private DataView assignmentView2;
        private DataView programmeView2;
        private DataView lecturerView2;

        private int courseID;
        private int aLecturerID; 

        string courseText;
        string lecturerText;
        public RemoveLecturerForm(DataController dc, ProgrammeAdministratorForm progmnu)
        {
            InitializeComponent();
            DC = dc;
            frmProgMnu = progmnu;
            frmProgMnu.Hide();
            TableAndView(); 

            cmAssignment = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "ASSIGNMENT"];
            cmCourse = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "COURSE"];
            cmProgramme = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "PROGRAMME"];
            cmLecturer = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "LECTURER"];

            ClearFields();

        }

        private void TableAndView()
        {
            dtCourse2 = dsBalhamCollegeAzure.COURSE;
            dtAssignment2 = dsBalhamCollegeAzure.ASSIGNMENT;
            dtProgramme2 = dsBalhamCollegeAzure.PROGRAMME;
            dtLecturer2 = dsBalhamCollegeAzure.LECTURER;

            courseView2 = new DataView(dtCourse2);
            courseView2.Sort = "CourseID";

            assignmentView2 = new DataView(dtAssignment2);
            assignmentView2.Sort = "CourseID,LecturerID";

            programmeView2 = new DataView(dtProgramme2);
            programmeView2.Sort = "ProgrammeID";

            lecturerView2 = new DataView(dtLecturer2);
            lecturerView2.Sort = "LecturerID"; 
        }
    
        private void ClearFields()
        {
            txtCourseID.Text = String.Empty;
            txtCourseName.Text = String.Empty;
            txtStatus.Text = String.Empty;
            txtProgrammeName.Text = String.Empty;
            txtLecturerID.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtRole.Text = String.Empty;         
        }

        private void cOURSEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOURSEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void RemoveLecturerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSIGNMENT' table. You can move, or remove it, as needed.
            this.aSSIGNMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSIGNMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);

            lstCourses.Items.Clear();
            lstLecturers.Items.Clear();
            ClearFields();
            LoadCourses();
        }

        private void LoadCourses()
        {
            foreach (DataRow drCourse in dtCourse2.Rows)
            {
                DataRow[] drAssignments = drCourse.GetChildRows(dtCourse2.ChildRelations["ASSIGNMENT$COURSEASSIGNMENT"]);
                if (drAssignments.Length != 0)
                {
                    courseText = "";
                    courseText += drCourse["CourseID"] + ", ";

                    courseText += drCourse["CourseName"] + "\r\n";

                    lstCourses.Items.Add(courseText);
                }
            }
        }
        private void Return_Click(object sender, EventArgs e)
        {
            Application.OpenForms["ProgrammeBackgroundForm"].Close();
            this.Close();
            frmProgMnu.Show();
        }

        private void btnRemoveLecturer_Click(object sender, EventArgs e)
        {

            if (lstLecturers.SelectedItem != null)
            {
                DataRow deleteAssignmentRow = dtAssignment2.Rows[cmAssignment.Position];
                if (MessageBox.Show("Are you sure you want to remove this Lecturer?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string lecturer;
                    lecturer = lstLecturers.SelectedItem.ToString();
                    string[] parts = lecturer.Split(',');
                    string[] IDstring = parts[0].Split(' ');
                    aLecturerID = Convert.ToInt32(IDstring[1]);
                    object[] primaryKey = new object[2];
                    courseID = Convert.ToInt32(txtCourseID.Text);
                    cmCourse.Position = courseView2.Find(courseID);
                    DataRow drCourse = dtCourse2.Rows[cmCourse.Position];
                    primaryKey[0] = courseID;
                    primaryKey[1] = aLecturerID;
                    cmAssignment.Position = assignmentView2.Find(primaryKey);

                    this.aSSIGNMENTTableAdapter.Delete(courseID, aLecturerID, txtRole.Text);
                    this.dsBalhamCollegeAzure.AcceptChanges(); // prevent system exception error 

                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
                    this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
                    this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSIGNMENT' table. You can move, or remove it, as needed.
                    this.aSSIGNMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSIGNMENT);
                    // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
                    this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);


                    DC.UpdateAssignment();

                    MessageBox.Show("Lecturer removed successfully", "Acknowledgement", MessageBoxButtons.OK);
             
                    lstLecturers.Items.Clear();
                    ClearFields();
                    }           

            }
           
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedItem != null)
            {
                string course = "";
                lstLecturers.Items.Clear();
                ClearFields();
                course = lstCourses.SelectedItem.ToString();
                string[] parts = course.Split(',');
                int courseID = Convert.ToInt32(parts[0]);
                cmCourse.Position = courseView2.Find(courseID);
                DataRow drCourse = dtCourse2.Rows[cmCourse.Position];
                txtCourseID.Text = drCourse["CourseID"].ToString();
                txtCourseName.Text = drCourse["CourseName"].ToString();
                txtStatus.Text = drCourse["Status"].ToString();

                int programmeID = Convert.ToInt32(parts[0]);
                cmProgramme.Position = programmeView2.Find(programmeID);
                DataRow drProgramme =dtProgramme2.Rows[cmProgramme.Position];
                txtProgrammeName.Text = drProgramme["ProgrammeName"].ToString();

                DataRow[] drAssignments = drCourse.GetChildRows(dtCourse2.ChildRelations["ASSIGNMENT$COURSEASSIGNMENT"]);
                foreach (DataRow drAssignment in drAssignments)
                {
                    int aLecturerID = Convert.ToInt32(drAssignment["LecturerID"].ToString());

                    cmLecturer.Position = lecturerView2.Find(aLecturerID);
                    DataRow drLecturer = dtLecturer2.Rows[cmLecturer.Position];
                    lecturerText = "ID: " + drAssignment["LecturerID"] + ", " + drLecturer["LastName"] + ", " + drLecturer["FirstName"];

                    lstLecturers.Items.Add(lecturerText);
                }
            }
        }

        private void lstLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstLecturers.SelectedItem != null)
            {
                string lecturer = "";
                lecturer = lstLecturers.SelectedItem.ToString();
                string[] parts = lecturer.Split(',');
                string[] IDstring = parts[0].Split(' ');
                int aLecturerID = Convert.ToInt32(IDstring[1]);
                cmLecturer.Position = lecturerView2.Find(aLecturerID);
                DataRow drLecturer = dtLecturer2.Rows[cmLecturer.Position];
                txtLecturerID.Text = drLecturer["LecturerID"].ToString();
                txtLastName.Text = drLecturer["LastName"].ToString();
                txtFirstName.Text = drLecturer["FirstName"].ToString();
           
                //Find composite primary key for Assignment
                object[] primarykey = new object[2];
                int courseID = Convert.ToInt32(txtCourseID.Text);
                cmCourse.Position = courseView2.Find(courseID);
                DataRow drCourse = dtCourse2.Rows[cmCourse.Position];
                primarykey[0] = courseID;
                primarykey[1] = aLecturerID;
                cmAssignment.Position = assignmentView2.Find(primarykey);

                DataRow drAssignment = dtAssignment2.Rows[cmAssignment.Position];
                txtRole.Text = drAssignment["Role"].ToString();
            }
        }       

    }
}
