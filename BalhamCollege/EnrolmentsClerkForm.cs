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
    public partial class EnrolmentsClerkForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private DeleteStudentForm frmDeleteStudent;
        private AddStudentForm frmAddStudent; // the reference to the Add Student form
        private UpdateStudentForm frmUpdateStudent; // the reference to the Update Student form
        private EnrolStudentForm frmEnrolStudent; //the reference to the Enrol Student form

        private WithdrawStudentForm frmWithdrawStudent; //the reference to the Withdraw Student form
        private EnrolBackgroundForm frmBackground; //the reference to the Background form

        // variables to store control location and size    
        private Rectangle btnAddStudentOriginalRect;
        private Rectangle btnUpdateStudentOriginalRect;
        private Rectangle btnDeleteStudentOriginalRect;
        private Rectangle btnEnrolStudentOriginalRect;
        private Rectangle btnWithdrawStudentReportOriginalRect;
        private Rectangle btnStudentsReportOriginalRect;
        private Rectangle btnReturnOriginalRect;
        private Rectangle btnExitOriginalRect;

        private Size formOriginalSize;

        // Variables to produce Report
        private DataRow[] studentssForPrint;
        private int studentForNextPage;
        private int countOfStudents;
        private int PagePrinted;


        public EnrolmentsClerkForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();

            // keep track of original control size, for autoresizing (original location and size)
            formOriginalSize = this.Size;
            btnAddStudentOriginalRect = new Rectangle(btnAddStudent.Location.X, btnAddStudent.Location.Y,btnAddStudent.Width, btnAddStudent.Height);
            btnUpdateStudentOriginalRect = new Rectangle(btnUpdateStudent.Location.X, btnUpdateStudent.Location.Y, btnUpdateStudent.Width, btnUpdateStudent.Height);
            btnDeleteStudentOriginalRect = new Rectangle(btnDeleteStudent.Location.X, btnDeleteStudent.Location.Y, btnDeleteStudent.Width, btnDeleteStudent.Height);
            btnEnrolStudentOriginalRect = new Rectangle(btnEnrolStudent.Location.X, btnEnrolStudent.Location.Y, btnEnrolStudent.Width, btnEnrolStudent.Height);
            btnWithdrawStudentReportOriginalRect = new Rectangle(btnWithdrawStudent.Location.X, btnWithdrawStudent.Location.Y, btnWithdrawStudent.Width, btnWithdrawStudent.Height);
            btnStudentsReportOriginalRect = new Rectangle(btnStudentsReport.Location.X, btnStudentsReport.Location.Y, btnStudentsReport.Width, btnStudentsReport.Height);
            btnReturnOriginalRect = new Rectangle(btnReturn.Location.X, btnReturn.Location.Y, btnReturn.Width, btnReturn.Height);
            btnExitOriginalRect = new Rectangle(btnExit.Location.X, btnExit.Location.Y, btnExit.Width, btnExit.Height);
        }

        private void resizeChildrenControls()
        {// resize children controls 
            resizeControl(btnAddStudentOriginalRect,btnAddStudent);
            resizeControl(btnUpdateStudentOriginalRect, btnUpdateStudent);
            resizeControl(btnDeleteStudentOriginalRect, btnDeleteStudent);
            resizeControl(btnEnrolStudentOriginalRect, btnEnrolStudent);
            resizeControl(btnWithdrawStudentReportOriginalRect, btnWithdrawStudent);
            resizeControl(btnStudentsReportOriginalRect, btnStudentsReport);
            resizeControl(btnReturnOriginalRect, btnReturn);
            resizeControl(btnExitOriginalRect, btnExit);

        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {// auto adjust control based on original location, height and width
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            // X location of controls when maximized
            int newX;
            if (this.WindowState == FormWindowState.Maximized)
            {
                newX = (int)(OriginalControlRect.X * xRatio) + 3;
            }
            else
            { // X location when minimized 
                newX = (int)(OriginalControlRect.X * xRatio);
            }

            // Y location of controls when maximized
            int newY;
            if (this.WindowState == FormWindowState.Maximized)
            {
                newY = (int)(OriginalControlRect.Y * yRatio) + 10;
            }
            else
            {// Y location when minimized
                newY = (int)(OriginalControlRect.Y * yRatio);
            }

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

        } 
        
        private void EnrolmentsClerkForm_Resize(object sender, EventArgs e)
        {
            // autosize form controls upon window size change 
            resizeChildrenControls();

            if (this.WindowState == FormWindowState.Maximized)
            { // button font size upon maximize
                btnAddStudent.Font = new Font("Arial", 12);
                btnUpdateStudent.Font = new Font("Arial", 12);
                btnDeleteStudent.Font = new Font("Arial", 12);
                btnEnrolStudent.Font = new Font("Arial", 12);
                btnWithdrawStudent.Font = new Font("Arial", 12);
                btnStudentsReport.Font = new Font("Arial", 12);
                btnReturn.Font = new Font("Arial", 12);
                btnExit.Font = new Font("Arial", 12);
            }
            else
            {// button font size when not maximized
                btnAddStudent.Font = new Font("Arial", 8);
                btnUpdateStudent.Font = new Font("Arial", 8);
                btnDeleteStudent.Font = new Font("Arial", 8);
                btnEnrolStudent.Font = new Font("Arial", 8);
                btnWithdrawStudent.Font = new Font("Arial", 8);
                btnStudentsReport.Font = new Font("Arial", 8);
                btnReturn.Font = new Font("Arial", 8);
                btnExit.Font = new Font("Arial", 8);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //show Background form on click
            frmBackground = new EnrolBackgroundForm(this);
            frmBackground.Show();
            //show Add Student form upon click
            frmAddStudent = new AddStudentForm(DC, this);
            frmAddStudent.ShowDialog();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            // show Update Student form upon click
            if (frmUpdateStudent == null)
            {
                frmUpdateStudent = new UpdateStudentForm(DC, this);
            }
            frmUpdateStudent.ShowDialog();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        { 
            // show Delete Student form and Background Form
            frmBackground = new EnrolBackgroundForm(this);
            frmBackground.Show();
            frmDeleteStudent = new DeleteStudentForm(DC, this);
            frmDeleteStudent.ShowDialog();
        }
        

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }
        private void btnStudentsReport_Click(object sender, EventArgs e)
        {
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

            string strSort = "LastName,FirstName";
            string strFilter = null;

            string strFilter2 = strFilter;
            studentssForPrint = dsBalhamCollegeAzure.Tables["STUDENT"].Select(strFilter2, strSort, DataViewRowState.CurrentRows);

            studentForNextPage = 0;
            countOfStudents = studentssForPrint.Count();
            PagePrinted = 1;
            prvStudents.ShowDialog();
        }
        private float GetLength(string text)
        {
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF textLength = graphics.MeasureString(text, new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point));
                return textLength.Width;
            }
        }
        private void printStudents_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFar = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font labelsFont = new Font("Arial", 10, FontStyle.Bold);
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
            string yearTit = "Year";
            string semesterTit = "Semester";
            string statusTit = "   Status   ";
            string courseTit = "Course Name";
            string progTit = "Programme Name";

            float bar = GetLength("|") / 2;
            float margin0 = leftMargin - 20;
            float margin1 = margin0 + GetLength(yearTit) + 4;
            float margin01 = margin0 + (margin1 - margin0) / 2 + bar;

            float margin2 = margin1 + GetLength(semesterTit) + 8;
            float margin12 = margin1 + (margin2 - margin1) / 2 + bar;
            float margin3 = margin2 + GetLength(statusTit) + 12;
            float margin23 = margin2 + (margin3 - margin2) / 2 + bar;
            float margin4 = margin3 + (rightMargin - margin3) / 2;
            float margin34 = margin3 + (margin4 - margin3) / 2 + bar;
            float margin5 = rightMargin + 10;
            float margin45 = margin4 + (margin5 - margin4) / 2 + bar;


            float yearMargin = rightLabelsMargin - GetLength(yearTit) / 2 - 60;
            float semesterMa = yearMargin + GetLength(yearTit);
            float statusMa = semesterMa + GetLength(semesterTit);
            float courseNameMa = statusMa + GetLength(statusTit);
            float progNameMa = courseNameMa + GetLength(courseTit);


            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF title1Length = graphics.MeasureString("Students Report", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));
                SizeF title2Length = graphics.MeasureString("Balham College", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));

                g.DrawString("Students Report", titleFont, brush, (rightMargin + 100) / 2 - title1Length.Width / 2, topMargin);
                linesSoFar++;
                g.DrawString("Balham College", titleFont, brush, (rightMargin + 100) / 2 - title2Length.Width / 2, topMargin + (linesSoFar * titleFont.Height));
                linesSoFar = linesSoFar + 6;
            }
            bool keepPrinting = true;
            int i = studentForNextPage;
            while (i < countOfStudents && keepPrinting)
            {
                int assessmentInitialLines;
                DataRow drStudent = studentssForPrint[i];
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
                {
                    // LINE 1
                    g.DrawString("Student ID: ", labelsFont, brush, rightLabelsMargin - GetLength("Student ID: "), topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(drStudent["StudentID"].ToString(), textFont, brush, rightInfoMargin, topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Name: ", labelsFont, brush, rightLabelsMargin - GetLength("Name: ") + 120, topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(drStudent["LastName"] + ", " + drStudent["FirstName"], textFont, brush, rightInfoMargin + 120, topMargin + (linesSoFar * textFont.Height));

                    linesSoFar++;
                    assessmentInitialLines = linesSoFar;
                    // LINE 2
                    g.DrawString("Street Address: ", labelsFont, brush, rightLabelsMargin - GetLength("Street Address: "), 4 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drStudent["StreetAddress"]), textFont, brush, rightInfoMargin, topMargin + 4 + (linesSoFar * textFont.Height));
                    linesSoFar++;
                    // LINE 3
                    g.DrawString("Suburb: ", labelsFont, brush, rightLabelsMargin - GetLength("Suburb: "), 8 + topMargin + (linesSoFar * (labelsFont.Height)));
                    g.DrawString(Convert.ToString(drStudent["Suburb"]), textFont, brush, rightInfoMargin, 8 + topMargin + (linesSoFar * (textFont.Height)));
                    g.DrawString("City: ", labelsFont, brush, rightLabelsMargin - GetLength("City: ") + 280, 8 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drStudent["City"]), textFont, brush, rightInfoMargin + 280, 8 + topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;
                    //LINE 4
                    g.DrawString("Phone Number: ", labelsFont, brush, rightLabelsMargin - GetLength("Phone Number: "), 12 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drStudent["PhoneNumber"]), textFont, brush, rightInfoMargin + 2, 12 + topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Status: ", labelsFont, brush, rightLabelsMargin - GetLength("Status: ") + 280, 12 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drStudent["Status"]), textFont, brush, rightInfoMargin + 282, 12 + topMargin + (linesSoFar * textFont.Height));

                    linesSoFar++;
                    // LINE 4
                    g.DrawString("Email Address: ", labelsFont, brush, rightLabelsMargin - GetLength("Email Address: "), 16 + topMargin + (linesSoFar * (labelsFont.Height)));
                    g.DrawString(Convert.ToString(drStudent["EmailAddress"]), textFont, brush, rightInfoMargin, 16 + topMargin + (linesSoFar * (textFont.Height)));


                    linesSoFar++;

                    //LINE 5


                    string strSort = "EnrolmentID";
                    string strFilter = "StudentID=" + drStudent["StudentID"].ToString();
                    DataRow[] enrolments = dsBalhamCollegeAzure.Tables["ENROLMENT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);

                    //LINE 6 Enrolments Titles
                    if (enrolments.Length > 0)
                    {
                        g.DrawString("Enrolments: ", labelsFont, brush, rightLabelsMargin - GetLength("Enrolments: "), 20 + topMargin + (linesSoFar * labelsFont.Height));
                        linesSoFar++;
                        g.DrawString("|", labelsFont, brush, margin0, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString(yearTit, labelsFont, brush, margin01 - GetLength(yearTit) / 2, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString("|", labelsFont, brush, margin1, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString(semesterTit, labelsFont, brush, margin12 - GetLength(semesterTit) / 2, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString("|", labelsFont, brush, margin2, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString(statusTit, labelsFont, brush, margin23 - GetLength(statusTit) / 2 - bar * 2, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString("|", labelsFont, brush, margin3, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString(courseTit, labelsFont, brush, margin34 - GetLength(courseTit) / 2 + bar, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString("|", labelsFont, brush, margin4, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString(progTit, labelsFont, brush, margin45 - GetLength(progTit) / 2, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString("|", labelsFont, brush, margin5, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString("____________________________________________________________________________________", textFont, brush, leftMargin - 19, topMargin + (linesSoFar * textFont.Height) + 26);
                        linesSoFar++;

                        //LINE 7

                        foreach (DataRow drEnrolment in enrolments)
                        {
                            string strSor = null;
                            string strFilt = "CourseID=" + drEnrolment["CourseID"].ToString();
                            DataRow drCourse = dsBalhamCollegeAzure.Tables["Course"].Select(strFilt, strSor, DataViewRowState.CurrentRows)[0];
                            string courseName = drCourse["CourseName"].ToString();

                            string strFilt2 = "ProgrammeID=" + drCourse["ProgrammeID"].ToString();
                            DataRow drProgramme = dsBalhamCollegeAzure.Tables["Programme"].Select(strFilt2, strSor, DataViewRowState.CurrentRows)[0];
                            string programmeName = drProgramme["ProgrammeName"].ToString();

                            if (GetLength(courseName) < (margin5 - margin4 - 5) && GetLength(programmeName) < (margin5 - margin4 - 5))
                            {
                                g.DrawString("|", labelsFont, brush, margin0, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(drEnrolment["Year"].ToString(), textFont, brush, margin01 - GetLength(drEnrolment["Year"].ToString()) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin1, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(drEnrolment["Semester"].ToString(), textFont, brush, margin12 - GetLength(drEnrolment["Semester"].ToString()) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin2, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(drEnrolment["Status"].ToString(), textFont, brush, margin23 - GetLength(drEnrolment["Status"].ToString()) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin3, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(courseName, textFont, brush, margin34 - GetLength(courseName) / 2 + bar, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin4, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(programmeName, textFont, brush, margin45 - GetLength(programmeName) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin5, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                linesSoFar++;
                            }
                            else
                            {
                                //SPLIT COURSE NAME
                                int letterP = 1;
                                int letterMaxPlaceP = courseName.Length;
                                int courseNameBoundaryP = 1;
                                string course1;
                                string course2;

                                if (GetLength(courseName) >= (margin5 - margin4 - 10))
                                {
                                    while (letterP <= courseName.Length)
                                    {
                                        if ((GetLength(courseName.Substring(0, letterP)) < (margin5 - margin4 - 10)) && (courseName[letterP - 1].ToString() == " "))
                                        {
                                            courseNameBoundaryP = letterP;
                                        }
                                        letterP++;
                                    }
                                    course1 = courseName.Substring(0, courseNameBoundaryP - 1);
                                    course2 = courseName.Substring(courseNameBoundaryP, courseName.Length - courseNameBoundaryP);
                                }
                                else
                                {
                                    course1 = courseName;
                                    course2 = "";
                                }
                                //SPLIT PROGRAMME NAME
                                int letter = 1;
                                int letterMaxPlace = programmeName.Length;
                                int programmeNameBoundary = 1;
                                string programme1;
                                string programme2;

                                if ((GetLength(programmeName) >= (margin5 - margin4 - 10)))
                                {
                                    while (letter <= programmeName.Length)
                                    {
                                        if ((GetLength(programmeName.Substring(0, letter)) < (margin5 - margin4 - 10)) && (programmeName[letter - 1].ToString() == " "))
                                        {
                                            programmeNameBoundary = letter;
                                        }
                                        letter++;
                                    }
                                    programme1 = programmeName.Substring(0, programmeNameBoundary - 1);
                                    programme2 = programmeName.Substring(programmeNameBoundary, programmeName.Length - programmeNameBoundary);
                                }
                                else
                                {
                                    programme1 = programmeName;
                                    programme2 = "";
                                }

                                g.DrawString("|", labelsFont, brush, margin0, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(drEnrolment["Year"].ToString(), textFont, brush, margin01 - GetLength(drEnrolment["Year"].ToString()) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin1, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(drEnrolment["Semester"].ToString(), textFont, brush, margin12 - GetLength(drEnrolment["Semester"].ToString()) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin2, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(drEnrolment["Status"].ToString(), textFont, brush, margin23 - GetLength(drEnrolment["Status"].ToString()) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin3, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(course1, textFont, brush, margin34 - GetLength(course1) / 2 + bar, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin4, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(programme1, textFont, brush, margin45 - GetLength(programme1) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin5, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                linesSoFar++;
                                g.DrawString("|", labelsFont, brush, margin0, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString("|", labelsFont, brush, margin1, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString("|", labelsFont, brush, margin2, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString("|", labelsFont, brush, margin3, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(course2, textFont, brush, margin34 - GetLength(course2) / 2 + bar, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin4, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                g.DrawString(programme2, textFont, brush, margin45 - GetLength(programme2) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                                g.DrawString("|", labelsFont, brush, margin5, 28 + topMargin + (linesSoFar * labelsFont.Height));
                                linesSoFar++;
                            }
                        }
                        linesSoFar++;

                        g.DrawString("_______________________________________________________________________________________", textFont, brush, leftMargin - 30, topMargin + (linesSoFar * labelsFont.Height));
                    }
                    else
                    {
                        g.DrawString("Enrolments: None", labelsFont, brush, rightLabelsMargin - GetLength("Enrolments: "), 20 + topMargin + (linesSoFar * labelsFont.Height));
                        linesSoFar++;
                        linesSoFar++;
                        g.DrawString("_______________________________________________________________________________________", textFont, brush, leftMargin - 30, topMargin + (linesSoFar * textFont.Height));
                    }
                    linesSoFar++;
                    linesSoFar++;
                    linesSoFar++;
                }
                i++;
                if ((65 - linesSoFar) < (linesSoFar - assessmentInitialLines))
                {
                    keepPrinting = false;
                }
            }
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                g.DrawString("Page " + PagePrinted.ToString(), textFont, brush, rightInfoMargin + 500, bottomMargin + 20);
            }
            PagePrinted++;
            studentForNextPage = i;
            if ((studentForNextPage < countOfStudents))
            {
                e.HasMorePages = true;
            }
        }

        private void btnEnrolStudent_Click(object sender, EventArgs e)
        {// show Enrol Student form 
            if (frmEnrolStudent == null)
            {
                frmEnrolStudent = new EnrolStudentForm(DC, this);
            }
            frmEnrolStudent.ShowDialog();
        }

        private void btnWithdrawStudent_Click(object sender, EventArgs e)
        {
            // show Withdraw Student form upon click
            if (frmWithdrawStudent == null)
            {
                frmWithdrawStudent = new WithdrawStudentForm(DC, this);
            }
            frmWithdrawStudent.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // returns user to login menu 
            this.Close();
            frmLogin.Show();
        }

        private void EnrolmentsClerkForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); // create the data controller and load the dataset
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);
            DC = new DataController(); // create the data controller and load the dataset
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // exit application 
        }

       
    }
}
