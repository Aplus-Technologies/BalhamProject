﻿using System;
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
        private CurrencyManager cmAssessment;
        private CurrencyManager cmCourse;
        private CurrencyManager cmEnrolment;
        private CurrencyManager cmStudent;
        private int initCount = 0;
        DataTable assignments = new DataTable();
        
        string selectedCourseID = "";
        public EnterResultForm(DataController dc, CourseAdministratorForm couadm)
        {
            InitializeComponent();
            DC = dc;
            frmCourseAdministrator = couadm;
            frmCourseAdministrator.Hide();
            BindControls();
            LoadAssignments();
        }
        public void BindControls()
        {
            cmAssessment = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Assessment"];
            cmCourse = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Course"];
            cmEnrolment = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Enrolment"];
            cmStudent = (CurrencyManager)this.BindingContext[dsBalhamCollegeAzure, "Student"];
        }

        private void lECTURERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lECTURERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }
        private void LoadAssignments()
        {
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            
            assignments.Columns.Add("ID", typeof(int));
            assignments.Columns.Add("Number", typeof(string));
            assignments.Columns.Add("Name", typeof(string));
            assignments.Columns.Add("Course Name", typeof(string));
            assignments.Columns.Add("Maximum Mark", typeof(string));
            assignments.Columns.Add("CourseID", typeof(int));

            foreach (DataRow drAssess in dsBalhamCollegeAzure.ASSESSMENT.Rows)
            {
                
                DataRow drAssessToAdd;
                drAssessToAdd = assignments.NewRow();
                assignments.Rows.Add(drAssessToAdd);
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
            
            dgvAssessments.DataSource = assignments;
            dgvAssessments.Columns[0].Width = 65;
            dgvAssessments.Columns[1].Width = 65;
            dgvAssessments.Columns[2].Width = 200;
            dgvAssessments.Columns[3].Width = 300;
            dgvAssessments.Columns["Maximum Mark"].Visible = false;
            dgvAssessments.Columns["CourseID"].Visible = false;
            dgvAssessments.RowHeadersVisible = false;
            dgvAssessments.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvAssessments.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void EnterResultForm_Load(object sender, EventArgs e)
        {
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
            this.Close();
            frmCourseAdministrator.Show();
        }

        private void dgvAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAssessments.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvAssessments.DefaultCellStyle.SelectionForeColor = Color.White;

            //dgvTreatments.DefaultCellStyle.SelectionBackColor = Color.White;
            //dgvTreatments.DefaultCellStyle.SelectionForeColor = Color.Black;

            if (dgvAssessments.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAssessments.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAssessments.Rows[selectedrowindex];
                selectedCourseID = Convert.ToString(selectedRow.Cells["CourseID"].Value);
            }
            
            if (cmAssessment.Position != -1)
            {
                if (initCount == 0)
                {
                    BindFields();
                    initCount = 1;
                }

                //cmCat.Position = DC.catView.Find(txtCatID.Text);
                //DataRow drCat = DC.dtCat.Rows[cmCat.Position];
                //txtCatName.Text = drCat["CatName"].ToString();

                LoadEnrolments();

                //GetAllTreatments();

                //cmTreatment.Position = -1;

            }
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


                    foreach (DataRow drStudent in dsBalhamCollegeAzure.STUDENT.Rows)
                    {
                        if (drStudent[0].ToString() == drEnrol[4].ToString())
                        {
                            drEnrolToAdd[0] = drStudent[1].ToString()+ ", " + drStudent[2].ToString();
                        }
                    }
                }

                    
            }

            dgvEnrolments.DataSource = enrolments;
            dgvEnrolments.Columns[0].Width = 200;
            dgvEnrolments.Columns[1].Width = 65;
            dgvEnrolments.Columns[2].Width = 200;
            dgvEnrolments.Columns[3].Width = 300;
            dgvEnrolments.Columns["StudentID"].Visible = false;
            dgvEnrolments.RowHeadersVisible = false;
            dgvEnrolments.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvEnrolments.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void BindFields()
        {
            txtAssessmentNumber.DataBindings.Add("Text", assignments, "Number");
            txtCourseName.DataBindings.Add("Text", assignments, "Course Name");
            txtMaximumMark.DataBindings.Add("Text", assignments, "Maximum Mark");
            txtAssessmentName.DataBindings.Add("Text", assignments, "Name");
        }
        private void UnBindIt()
        {/*
            txtVisitID.DataBindings.Clear();
            txtVisitDescription.DataBindings.Clear();
            dtpDate.DataBindings.Clear();
            txtCatID.DataBindings.Clear();
            */
        }
    }
}
