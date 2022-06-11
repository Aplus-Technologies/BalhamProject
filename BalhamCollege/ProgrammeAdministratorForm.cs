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
    public partial class ProgrammeAdministratorForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private UpdateCourseForm frmUpdateCourse; // the reference to the Update Course form
        private AssignLecturerForm frmAssignLecturer; // the reference to the Assign Lecturer form
        private DeleteProgrammeForm frmDeleteProgramme; // reference to Delete Programme Form
        private DeleteCourseForm frmDeleteCourse; // reference to Delete Course Form
        private UpdateProgrammeForm frmUpdateProgramme; // reference to Update Programme Form

        private RemoveLecturerForm frmRemoveLecturer; // reference to Remove Lecturer Form

        private AddCourseForm frmAddCourse; // reference to Add Course Form
        private AddProgrammeForm frmAddProgramme; // reference to Add Programme Form
        //Produce report variables
        private DataRow[] coursesForPrint;
        private int courseForNextPage;
        private int countOfCourses;
        private int PagePrinted;
        private DataTable dtlecturersForPrint = new DataTable();

        public ProgrammeAdministratorForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // show Add Course form upon click
            if (frmAddCourse == null)
            {
                frmAddCourse = new AddCourseForm(DC, this);
            }
            frmAddCourse.ShowDialog();

        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            // show Update Course form upon click
            if (frmUpdateCourse == null)
            {
                frmUpdateCourse = new UpdateCourseForm(DC, this);
            }
            frmUpdateCourse.ShowDialog();

        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            // show Delete Course form upon click
            if (frmDeleteCourse == null)
            {
                frmDeleteCourse = new DeleteCourseForm(DC, this);
            }
            frmDeleteCourse.ShowDialog();

        }
        private void cOURSEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOURSEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void ProgrammeAdministratorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);

        }
        private void btnProduceCoursesReport_Click(object sender, EventArgs e)
        {
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);

            string strSort = "CourseName";
            string strFilter = null;

            string strFilter2 = strFilter;
            coursesForPrint = dsBalhamCollegeAzure.Tables["Course"].Select(strFilter2, strSort, DataViewRowState.CurrentRows);

            courseForNextPage = 0;
            countOfCourses = coursesForPrint.Count();
            PagePrinted = 1;
            prvCourses.ShowDialog();
        }
        // Get text lenght
        private float GetLength(string text)
        {
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF textLength = graphics.MeasureString(text, new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point));
                return textLength.Width;
            }
        }
        private void printCourses_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFar = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font labelsFont = new Font("Arial", 10, FontStyle.Bold);
            Font emptyLine = new Font("Arial", 2, FontStyle.Regular);
            Font titleFont = new Font("Arial", 18, FontStyle.Regular);


            Brush brush = new SolidBrush(Color.Black);
            // Margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int bottomMargin = e.MarginBounds.Bottom;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            int rightLabelsMargin = e.MarginBounds.Right - 520;
            int rightInfoMargin = e.MarginBounds.Left + 110;
            int subTitlesRightMargin = e.MarginBounds.Left + 500;

            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF title1Length = graphics.MeasureString("Courses Report", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));
                SizeF title2Length = graphics.MeasureString("Balham College", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));

                g.DrawString("Courses Report", titleFont, brush, (rightMargin + 100) / 2 - title1Length.Width / 2, topMargin);
                linesSoFar++;
                g.DrawString("Balham College", titleFont, brush, (rightMargin + 100) / 2 - title2Length.Width / 2, topMargin + (linesSoFar * titleFont.Height));
                linesSoFar = linesSoFar + 6;
            }
            int i = courseForNextPage;
            while (i < countOfCourses && linesSoFar < 62)
            {
                DataRow drCourse = coursesForPrint[i];
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
                {

                    // LINE 1
                    g.DrawString("Course ID: ", labelsFont, brush, rightLabelsMargin - GetLength("Course ID: "), topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(drCourse["CourseID"].ToString(), textFont, brush, rightInfoMargin, topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Course Name: ", labelsFont, brush, rightLabelsMargin - GetLength("Course Name: ") + 220, topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(drCourse["CourseName"].ToString(), textFont, brush, rightInfoMargin + 220, topMargin + (linesSoFar * textFont.Height));

                    linesSoFar++;
                    // LINE 2
                    g.DrawString("Credits: ", labelsFont, brush, rightLabelsMargin - GetLength("Credits: "), 4 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drCourse["Credits"]), textFont, brush, rightInfoMargin, topMargin + 4 + (linesSoFar * textFont.Height));
                    g.DrawString("Status: ", labelsFont, brush, rightLabelsMargin - GetLength("Status: ") + 220, 4 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drCourse["Status"]), textFont, brush, rightInfoMargin + 220, 4 + topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;
                    // LINE 3
                    g.DrawString("Fee: ", labelsFont, brush, rightLabelsMargin - GetLength("Fee: "), 8 + topMargin + (linesSoFar * (labelsFont.Height)));
                    g.DrawString("$" + Convert.ToString(drCourse["Fee"]), textFont, brush, rightInfoMargin, 8 + topMargin + (linesSoFar * (textFont.Height)));
                    g.DrawString("Programme Name: ", labelsFont, brush, rightLabelsMargin - GetLength("Programme Name: ") + 220, 8 + topMargin + (linesSoFar * labelsFont.Height));
                    string programmeName = "";
                    foreach (DataRow drProgramme in dsBalhamCollegeAzure.PROGRAMME.Rows)
                    {
                        if (drProgramme["ProgrammeID"].ToString() == drCourse["ProgrammeID"].ToString())
                        {
                            programmeName = drProgramme["ProgrammeName"].ToString();
                        }
                    }

                    g.DrawString(programmeName, textFont, brush, rightInfoMargin + 220, 8 + topMargin + (linesSoFar * textFont.Height));


                    linesSoFar++;
                    // LINE 4
                    g.DrawString("Assessments: ", labelsFont, brush, rightLabelsMargin - GetLength("Assessments: "), 12 + topMargin + (linesSoFar * (labelsFont.Height)));
                    int assessmentsCount = 0;
                    foreach (DataRow drAssessments in dsBalhamCollegeAzure.ASSESSMENT.Rows)
                    {
                        if (drAssessments["CourseID"].ToString() == drCourse["CourseID"].ToString())
                        {
                            assessmentsCount++;
                        }
                    }
                    g.DrawString(assessmentsCount.ToString(), textFont, brush, rightInfoMargin, 12 + topMargin + (linesSoFar * (textFont.Height)));
                    g.DrawString("Enrolments: ", labelsFont, brush, rightLabelsMargin - GetLength("Enrolments: ") + 220, 12 + topMargin + (linesSoFar * labelsFont.Height));
                    int enrolmentsCount = 0;
                    foreach (DataRow drEnrolments in dsBalhamCollegeAzure.ENROLMENT.Rows)
                    {
                        if (drEnrolments["CourseID"].ToString() == drCourse["CourseID"].ToString())
                        {
                            enrolmentsCount++;
                        }
                    }
                    g.DrawString(enrolmentsCount.ToString(), textFont, brush, rightInfoMargin + 220, 12 + topMargin + (linesSoFar * textFont.Height));


                    linesSoFar++;
                    linesSoFar++;

                    g.DrawString("__________________________________________________________________________________", textFont, brush, leftMargin, topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;
                    linesSoFar++;
                    linesSoFar++;
                }
                i++;
            }
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                g.DrawString("Page " + PagePrinted.ToString(), textFont, brush, rightInfoMargin + 500, bottomMargin + 20);
            }
            PagePrinted++;
            courseForNextPage = i;
            if ((courseForNextPage < countOfCourses))
            {
                e.HasMorePages = true;
            }
        }
        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {
            // show Assign Lecturer form upon click
            if (frmAssignLecturer == null)
            {
                frmAssignLecturer = new AssignLecturerForm(DC, this);
            }
            frmAssignLecturer.ShowDialog();
        }

        private void btnRemoveLecturer_Click(object sender, EventArgs e)
        {
            // show Remove Lecturer form upon click
            if (frmRemoveLecturer == null)
            {
                frmRemoveLecturer = new RemoveLecturerForm(DC, this);
            }
            frmRemoveLecturer.ShowDialog();
        }

        private void btnAddProgramme_Click(object sender, EventArgs e)
        {
            // show Add Programme form upon click
            if (frmAddProgramme == null)
            {
                frmAddProgramme = new AddProgrammeForm(DC, this);
            }
            frmAddProgramme.ShowDialog();
        }

        private void btnUpdateProgramme_Click(object sender, EventArgs e)
        {
            // show Update Programme form upon click
            if (frmUpdateProgramme == null)
            {
                frmUpdateProgramme = new UpdateProgrammeForm(DC, this);
            }
            frmUpdateProgramme.ShowDialog();

        }

        private void btnDeleteProgramme_Click(object sender, EventArgs e)
        {
            // show Assign Lecturer form upon click
            if (frmDeleteProgramme == null)
            {
                frmDeleteProgramme = new DeleteProgrammeForm (DC, this);
            }
            frmDeleteProgramme.ShowDialog();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // returns user back to login menu 
            this.Close();
            frmLogin.Show();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // closes application
        }
    }
}
