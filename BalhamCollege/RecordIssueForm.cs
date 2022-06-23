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
    public partial class RecordIssueForm : Form
    {
        private DataController DC;
        private StudentsSupportClerkForm frmStudentSupport;
        private int initCount = 0;
        public DataTable students = new DataTable();
        string selectedStudentID;
        int selectedEnrolmentID;
        public RecordIssueForm(DataController dc, StudentsSupportClerkForm stusup)
        {
            InitializeComponent();
            DC = dc;
            frmStudentSupport = stusup;
            //frmStudentSupport.Hide();
            students.Columns.Add("ID", typeof(int));
            students.Columns.Add("Last Name", typeof(string));
            students.Columns.Add("First Name", typeof(string));
            students.Columns.Add("Street Address", typeof(string));
            students.Columns.Add("Suburb", typeof(string));
            students.Columns.Add("City", typeof(string));
            GetStudents();
            LoadStudents();
        }

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }

        private void RecordIssueForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ISSUE' table. You can move, or remove it, as needed.
            this.iSSUETableAdapter.Fill(this.dsBalhamCollegeAzure.ISSUE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);
        }

        private void GetStudents()
        {
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);

            List<int> studentsEnroledIDs = new List<int>();
            foreach (DataRow drEnrolment in dsBalhamCollegeAzure.ENROLMENT.Rows)
            {
                int id = Convert.ToInt16(drEnrolment["StudentID"]);
                if (!studentsEnroledIDs.Contains(id))
                {
                    studentsEnroledIDs.Add(id);
                }
            }
            studentsEnroledIDs.Sort();
            students.Rows.Clear();

            foreach (DataRow drStudent in dsBalhamCollegeAzure.STUDENT.Rows)
            {
                if (studentsEnroledIDs.Contains(Convert.ToInt16(drStudent[0])))
                {
                    DataRow drStudentToAdd;
                    drStudentToAdd = students.NewRow();
                    students.Rows.Add(drStudentToAdd);
                    drStudentToAdd[0] = Convert.ToInt16(drStudent[0]);
                    drStudentToAdd[1] = drStudent[1].ToString();
                    drStudentToAdd[2] = drStudent[2].ToString();
                    drStudentToAdd[3] = drStudent[3].ToString();
                    drStudentToAdd[4] = drStudent[4].ToString();
                    drStudentToAdd[5] = drStudent[5].ToString();
                }
            }
        }
        private void LoadStudents()
        {
            dgvStudents.ClearSelection();

            dgvStudents.DataSource = students;
            dgvStudents.Columns[0].Width = 70;
            dgvStudents.Columns[1].Width = 330;
            dgvStudents.Columns[2].Width = 330;

            dgvStudents.Columns[3].Visible = false;
            dgvStudents.Columns[4].Visible = false;
            dgvStudents.Columns[5].Visible = false;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStudents.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudents.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvStudents.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudents.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvStudents.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudents.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEnrolments.ClearSelection();
            dgvStudents.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.White;

            int selectedrowIndex = dgvStudents.SelectedCells[0].RowIndex;
            dgvStudents.Rows[selectedrowIndex].Selected = true;

            if (initCount == 0)
            {
                BindFields();
                initCount = 1;
            }

            if (dgvStudents.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvStudents.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvStudents.Rows[selectedrowindex];
                selectedStudentID = Convert.ToString(selectedRow.Cells["ID"].Value);
                //selectedAssessmentID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            }
            LoadEnrolments();
        }
        private void LoadEnrolments()
        {
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            this.courseTableAdapter1.Fill(this.dsBalhamCollegeAzure.COURSE);

            DataTable enrolments = new DataTable();

            enrolments.Columns.Add("ID", typeof(string));
            enrolments.Columns.Add("Year", typeof(string));
            enrolments.Columns.Add("Semester", typeof(string));
            enrolments.Columns.Add("Course Name", typeof(string));
            enrolments.Columns.Add("Course ID", typeof(string));


            foreach (DataRow drEnrol in dsBalhamCollegeAzure.ENROLMENT.Rows)
            {
                if (selectedStudentID == Convert.ToString(drEnrol[4]))
                {
                    DataRow drEnrolToAdd;
                    drEnrolToAdd = enrolments.NewRow();
                    enrolments.Rows.Add(drEnrolToAdd);
                    drEnrolToAdd[0] = drEnrol[0].ToString();
                    drEnrolToAdd[1] = drEnrol[1].ToString();
                    drEnrolToAdd[2] = drEnrol[2].ToString();
                    drEnrolToAdd[4] = drEnrol[5].ToString();


                    foreach (DataRow drCourse in dsBalhamCollegeAzure.COURSE.Rows)
                    {
                        if (drCourse[0].ToString() == drEnrol[5].ToString())
                        {
                            drEnrolToAdd[3] = drCourse[1].ToString();
                        }
                    }
                }
            }

            dgvEnrolments.DataSource = enrolments;
            dgvEnrolments.Columns[0].Width = 70;
            dgvEnrolments.Columns[1].Width = 70;
            dgvEnrolments.Columns[2].Width = 70;
            dgvEnrolments.Columns[3].Width = 359;
            dgvEnrolments.Columns["Course ID"].Visible = false;

            dgvEnrolments.RowHeadersVisible = false;
            dgvEnrolments.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvEnrolments.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvEnrolments.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Year"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Semester"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Course Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEnrolments.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Year"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Semester"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Course Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            UnBindIt();
            ClearFields();
            LoadStudents();
            initCount = 0;
            Application.OpenForms["StudentBackgroundForm"].Close();
            frmStudentSupport.Show();
        }
        private void BindFields()
        {
            txtStudentID.DataBindings.Add("Text", students, "ID");
            txtStudentLastName.DataBindings.Add("Text", students, "Last Name");
            txtStudentFirstName.DataBindings.Add("Text", students, "First Name");
            txtStreetAddress.DataBindings.Add("Text", students, "Street Address");
            txtSuburb.DataBindings.Add("Text", students, "Suburb");
            txtcity.DataBindings.Add("Text", students, "City");
        }
        private void UnBindIt()
        {
            txtStudentID.DataBindings.Clear();
            txtStudentLastName.DataBindings.Clear();
            txtStudentFirstName.DataBindings.Clear();
            txtStreetAddress.DataBindings.Clear();
            txtSuburb.DataBindings.Clear();
            txtcity.DataBindings.Clear();
        }
        private void ClearFields()
        {
            dgvEnrolments.DataSource = null;
            dgvStudents.DataSource = null;
            txtStudentID.Text = "";
            txtStudentLastName.Text = "";
            txtStudentFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtcity.Text = "";
            txtActionTaken.Text = "";
            txtIssueDescription.Text = "";
            dtpIssueDate.Text = "";
        }

        private void dgvEnrolments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEnrolments.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvEnrolments.DefaultCellStyle.SelectionForeColor = Color.White;
            int selectedrowindex = dgvEnrolments.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvEnrolments.Rows[selectedrowindex];
            selectedEnrolmentID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            dgvEnrolments.Rows[selectedrowindex].Selected = true;
        }

        private void btnRecordIssue_Click(object sender, EventArgs e)
        {
            if ((dtpIssueDate.Text == "") || (txtActionTaken.Text == "") || (txtIssueDescription.Text == "") || (selectedEnrolmentID == 0))
            {
                MessageBox.Show("Please enter all the required information", "Error");
                return;
            }
            else
            {
                try
                {
                    this.iSSUETableAdapter.Insert(txtIssueDescription.Text, Convert.ToDateTime(dtpIssueDate.Text).ToString("yyyy-MM-dd"), txtActionTaken.Text, selectedEnrolmentID);
                    this.iSSUETableAdapter.Fill(this.dsBalhamCollegeAzure.ISSUE);

                    LoadEnrolments();
                    DialogResult dialogResult = MessageBox.Show("Issue recorded successfully!\n\nDo you want to record another issue?", "Balham College", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        UnBindIt();
                        ClearFields();
                        initCount = 0;
                        GetStudents();
                        LoadStudents();
                        initCount = 0;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                        UnBindIt();
                        ClearFields();
                        LoadStudents();
                        initCount = 0;
                        Application.OpenForms["StudentBackgroundForm"].Close();
                        frmStudentSupport.Show();
                    }
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MessageBox.Show("There has been an error please try again", "Error");
                }
            }
        }

        
    }
}
