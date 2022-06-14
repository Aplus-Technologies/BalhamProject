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
    public partial class EnterResultForm : Form
    {
        private DataController DC;
        private CourseAdministratorForm frmCourseAdministrator;

        private int initCount = 0;
        public DataTable assessments = new DataTable();
        
        string selectedCourseID = "";
        int selectedAssessmentID;
        int selectedEnrolmentID;
        public EnterResultForm(DataController dc, CourseAdministratorForm couadm)
        {
            InitializeComponent();
            DC = dc;
            frmCourseAdministrator = couadm;
            frmCourseAdministrator.Hide();
            assessments.Columns.Add("ID", typeof(int));
            assessments.Columns.Add("Number", typeof(string));
            assessments.Columns.Add("Name", typeof(string));
            assessments.Columns.Add("Course Name", typeof(string));
            assessments.Columns.Add("Maximum Mark", typeof(string));
            assessments.Columns.Add("CourseID", typeof(int));
            GetAssessments();
            LoadAssessments();

        }

        private void lECTURERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lECTURERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }
        private void GetAssessments()
        {
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);


            assessments.Rows.Clear();
            foreach (DataRow drAssess in dsBalhamCollegeAzure.ASSESSMENT.Rows)
            {
                DataRow drAssessToAdd;
                drAssessToAdd = assessments.NewRow();
                assessments.Rows.Add(drAssessToAdd);
                drAssessToAdd[0] = drAssess[0];
                drAssessToAdd[1] = drAssess[1].ToString();
                drAssessToAdd[2] = drAssess[2].ToString();
                drAssessToAdd[4] = drAssess[5].ToString();
                drAssessToAdd[5] = drAssess[6].ToString();
                foreach (DataRow drCourse in dsBalhamCollegeAzure.COURSE.Rows)
                {
                    if (drCourse[0].ToString() == drAssess[6].ToString())
                    {
                        drAssessToAdd[3] = drCourse[1].ToString();
                    }
                }
            }
        }
        private void LoadAssessments()
        {
            dgvAssessments.ClearSelection();

            dgvAssessments.DataSource = assessments;
            dgvAssessments.Columns[0].Width = 66;
            dgvAssessments.Columns[1].Width = 66;
            dgvAssessments.Columns[2].Width = 299;
            dgvAssessments.Columns[3].Width = 299;
            dgvAssessments.Columns["Maximum Mark"].Visible = false;
            dgvAssessments.Columns["CourseID"].Visible = false;
            dgvAssessments.RowHeadersVisible = false;
            dgvAssessments.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvAssessments.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAssessments.Columns["Number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssessments.Columns["Number"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssessments.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssessments.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void EnterResultForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESULT' table. You can move, or remove it, as needed.
            this.rESULTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESULT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //closes course background form along with enter result form
            //Application.OpenForms["CourseBackgroundForm"].Close();
            this.Close();
            UnBindIt();
            ClearFields();
            LoadAssessments();
            initCount = 0;
            frmCourseAdministrator.Show();
        }

        private void dgvAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEnrolments.ClearSelection();
            dgvAssessments.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvAssessments.DefaultCellStyle.SelectionForeColor = Color.White;

            int selectedrowIndex = dgvAssessments.SelectedCells[0].RowIndex;
            dgvAssessments.Rows[selectedrowIndex].Selected = true;

            if (initCount == 0)
            {
                BindFields();
                initCount = 1;
            }

            if (dgvAssessments.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAssessments.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAssessments.Rows[selectedrowindex];
                selectedCourseID = Convert.ToString(selectedRow.Cells["CourseID"].Value);
                selectedAssessmentID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            }
            LoadEnrolments();

        }

        private void LoadEnrolments()
        {
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            this.studentTableAdapter1.Fill(this.dsBalhamCollegeAzure.STUDENT);
            DataTable enrolments = new DataTable();

            enrolments.Columns.Add("Student Name", typeof(string));
            enrolments.Columns.Add("Year", typeof(string));
            enrolments.Columns.Add("Semester", typeof(string));
            enrolments.Columns.Add("Status", typeof(string));
            enrolments.Columns.Add("StudentID", typeof(string));
            enrolments.Columns.Add("EnrolmentID", typeof(int));

            foreach (DataRow drEnrol in dsBalhamCollegeAzure.ENROLMENT.Rows)
            {
                if (selectedCourseID == drEnrol[5].ToString())
                {
                    DataRow drEnrolToAdd;
                    drEnrolToAdd = enrolments.NewRow();
                    enrolments.Rows.Add(drEnrolToAdd);
                    drEnrolToAdd[1] = drEnrol[1].ToString();
                    drEnrolToAdd[2] = drEnrol[2].ToString();
                    drEnrolToAdd[3] = drEnrol[3].ToString();
                    drEnrolToAdd[4] = drEnrol[4].ToString();
                    drEnrolToAdd[5] = drEnrol[0].ToString();

                    foreach (DataRow drStudent in dsBalhamCollegeAzure.STUDENT.Rows)
                    {
                        if (drStudent[0].ToString() == drEnrol[4].ToString())
                        {
                            drEnrolToAdd[0] = drStudent[1].ToString() + ", " + drStudent[2].ToString();
                        }
                    }
                }
            }

            dgvEnrolments.DataSource = enrolments;
            dgvEnrolments.Columns[0].Width = 370;
            dgvEnrolments.Columns[1].Width = 60;
            dgvEnrolments.Columns[2].Width = 150;
            dgvEnrolments.Columns[3].Width = 150;
            dgvEnrolments.Columns["StudentID"].Visible = false;
            dgvEnrolments.Columns["EnrolmentID"].Visible = false;
            dgvEnrolments.RowHeadersVisible = false;
            dgvEnrolments.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvEnrolments.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvEnrolments.Columns["Year"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Semester"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEnrolments.Columns["Year"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Semester"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEnrolments.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void BindFields()
        {
            txtAssessmentNumber.DataBindings.Add("Text", assessments, "Number");
            txtCourseName.DataBindings.Add("Text", assessments, "Course Name");
            txtMaximumMark.DataBindings.Add("Text", assessments, "Maximum Mark");
            txtAssessmentName.DataBindings.Add("Text", assessments, "Name");
        }
        private void UnBindIt()
        {
            txtAssessmentNumber.DataBindings.Clear();
            txtCourseName.DataBindings.Clear();
            txtMaximumMark.DataBindings.Clear();
            txtAssessmentName.DataBindings.Clear();
        }
        private void ClearFields()
        {
            dgvEnrolments.DataSource = null;
            dgvAssessments.DataSource = null;
            txtAssessmentName.Text = "";
            txtAssessmentNumber.Text = "";
            txtCourseName.Text = "";
            txtMaximumMark.Text = "";
            numMark.Value = 0;
            dtpDate.Text = "";
        }
        private void dgvEnrolments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEnrolments.DefaultCellStyle.SelectionBackColor = Color.Blue;

            dgvEnrolments.DefaultCellStyle.SelectionForeColor = Color.White;

            int selectedrowindex = dgvEnrolments.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvEnrolments.Rows[selectedrowindex];
            selectedEnrolmentID = Convert.ToInt32(selectedRow.Cells["EnrolmentID"].Value);
            dgvEnrolments.Rows[selectedrowindex].Selected = true;
        }

        private void btnEnterResult_Click(object sender, EventArgs e)
        {

            if ((dtpDate.Text == "") || (numMark.Text == "") || (selectedAssessmentID == 0) || (selectedEnrolmentID == 0))
            {
                MessageBox.Show("Please enter all the required information", "Error");
                return;
            }

            else
            {
                if (numMark.Value > (Convert.ToInt32(txtMaximumMark.Text)))
                {
                    MessageBox.Show("Please enter a valid mark", "Error");
                    return;
                }
                else
                {
                    try
                    {
                        this.rESULTTableAdapter.Insert(selectedAssessmentID, selectedEnrolmentID, Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd"), Convert.ToInt32(numMark.Text));
                        this.rESULTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESULT);

                        LoadEnrolments();
                        DialogResult dialogResult = MessageBox.Show("Result entered successfully!\n\nDo you want to enter another result?", "Balham College", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            UnBindIt();
                            ClearFields();
                            initCount = 0;
                            GetAssessments();
                            LoadAssessments();
                            initCount = 0;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Close();
                            UnBindIt();
                            ClearFields();
                            LoadAssessments();
                            initCount = 0;
                            frmCourseAdministrator.Show();
                        }
                    }
                    catch (System.Data.OleDb.OleDbException)
                    {
                        MessageBox.Show("This result has already been entered", "Error");
                    }
                }

            }
        }
    }
}
