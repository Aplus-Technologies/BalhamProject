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



        string courseText;
        string lecturerText;
        public RemoveLecturerForm(DataController dc, ProgrammeAdministratorForm progmnu)
        {
            InitializeComponent();
            DC = dc;
            frmProgMnu = progmnu;
            frmProgMnu.Hide();

            cmAssignment = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "ASSIGNMENT"];
            cmCourse = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "COURSE"];
            cmProgramme = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "PROGRAMME"];
            cmLecturer = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "LECTURER"];

            ClearFields();

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

            ClearFields();
            LoadCourses();
        }

        private void LoadCourses()
        {
            foreach (DataRow drCourse in DC.dtCourse.Rows)
            {
                DataRow[] drAssignments = drCourse.GetChildRows(DC.dtCourse.ChildRelations["ASSIGNMENT$COURSEASSIGNMENT"]);
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
            this.Close();
            frmProgMnu.Show();
        }

        private void btnRemoveLecturer_Click(object sender, EventArgs e)
        {
            DataRow deleteAssignmentRow = DC.dtAssignment.Rows[cmAssignment.Position];
            if (MessageBox.Show("Are you sure you want to remove this Lecturer?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string lecturer;
                lecturer = lstLecturers.SelectedItem.ToString();
                string[] parts = lecturer.Split(',');
                string[] IDstring = parts[0].Split(' ');
                int aLecturerID = Convert.ToInt32(IDstring[2]);
                object[] primaryKey = new object[2];
                int courseID = Convert.ToInt32(txtCourseID.Text);
                cmCourse.Position = DC.courseView.Find(courseID);
                DataRow drCourse = DC.dtCourse.Rows[cmCourse.Position];
                primaryKey[0] = courseID;
                primaryKey[1] = aLecturerID;
                cmAssignment.Position = DC.assignmentView.Find(primaryKey);

                deleteAssignmentRow.Delete();
                DC.UpdateAssignment();

                MessageBox.Show("Lecturer removed successfully", "Acknowledgement", MessageBoxButtons.OK);
                cmAssignment.EndCurrentEdit();
                lstLecturers.Items.Clear();
                ClearFields();
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
                cmCourse.Position = DC.courseView.Find(courseID);
                DataRow drCourse = DC.dtCourse.Rows[cmCourse.Position];
                txtCourseID.Text = drCourse["CourseID"].ToString();
                txtCourseName.Text = drCourse["CourseName"].ToString();
                txtStatus.Text = drCourse["Status"].ToString();

                int programmeID = Convert.ToInt32(parts[0]);
                cmProgramme.Position = DC.programmeView.Find(programmeID);
                DataRow drProgramme = DC.dtProgramme.Rows[cmProgramme.Position];
                txtProgrammeName.Text = drProgramme["ProgrammeName"].ToString();

                DataRow[] drAssignments = drCourse.GetChildRows(DC.dtCourse.ChildRelations["ASSIGNMENT$COURSEASSIGNMENT"]);
                foreach (DataRow drAssignment in drAssignments)
                {
                    int aLecturerID = Convert.ToInt32(drAssignment["LecturerID"].ToString());
                    cmLecturer.Position = DC.lecturerView.Find(aLecturerID);
                    DataRow drLecturer = DC.dtLecturer.Rows[cmLecturer.Position];
                    lecturerText = "Lecturer ID: " + drAssignment["LecturerID"] + ", " + drLecturer["LastName"] + ", " + drLecturer["FirstName"];
                    lstLecturers.Items.Add(lecturerText);
                }
            }
        }

        private void lstLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lecturer = "";
            lecturer = lstLecturers.SelectedItem.ToString();
            string[] parts = lecturer.Split(',');
            string[] IDstring = parts[0].Split(' ');
            int aLecturerID = Convert.ToInt32(IDstring[2]);
            cmLecturer.Position = DC.lecturerView.Find(aLecturerID);
            DataRow drLecturer = DC.dtLecturer.Rows[cmLecturer.Position];
            txtLecturerID.Text = drLecturer["LecturerID"].ToString();
            txtLastName.Text = drLecturer["LastName"].ToString();
            txtFirstName.Text = drLecturer["FirstName"].ToString();
           
            //Find composite primary key for Assignment
            object[] primarykey = new object[2];
            int courseID = Convert.ToInt32(txtCourseID.Text);
            cmCourse.Position = DC.courseView.Find(courseID);
            DataRow drCourse = DC.dtCourse.Rows[cmCourse.Position];
            primarykey[0] = courseID;
            primarykey[1] = aLecturerID;
            cmAssignment.Position = DC.assignmentView.Find(primarykey);

            DataRow drAssignment = DC.dtAssignment.Rows[cmAssignment.Position];
            txtRole.Text = drAssignment["Role"].ToString();
        }
    }
}
