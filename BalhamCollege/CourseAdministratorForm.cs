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
    public partial class CourseAdministratorForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private EnterResultForm frmEnterResult;
        private UpdateAssessmentForm frmUpdateAssessment; // the reference to the Update Assessment form
        private DeleteAssessmentForm frmDeleteAssessment; // reference to delete assessment form
        private AddAssessmentForm frmAddAssessment; // reference to add assessment form
        private CourseBackgroundForm frmCourse; // reference to course background form

        // variables to store control location and size    
        private Rectangle btnAddAssessmentOriginalRect;
        private Rectangle btnUpdateAssessmentOriginalRect;
        private Rectangle btnDeleteAssessmentOriginalRect;
        private Rectangle btnEnterResultOriginalRect;
        private Rectangle btnProduceAssessmentsReportOriginalRect;
        private Rectangle btnReturnOriginalRect;
        private Rectangle btnExitOriginalRect;

        private Size formOriginalSize;

        // Variables to produce Report
        private DataTable assessmentsForPrint;
        private DataRow[] assessmentsForPrintVAR;
        private int assessmentForNextPage;
        private int countOfAssessments;
        private int PagePrinted;

        public CourseAdministratorForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();

             // keep track of original control size, for autoresizing (original location and size)
            formOriginalSize = this.Size;
            btnAddAssessmentOriginalRect = new Rectangle(btnAddAssessment.Location.X, btnAddAssessment.Location.Y, btnAddAssessment.Width, btnAddAssessment.Height);
            btnUpdateAssessmentOriginalRect = new Rectangle(btnUpdateAssessment.Location.X, btnUpdateAssessment.Location.Y, btnUpdateAssessment.Width, btnUpdateAssessment.Height);
            btnDeleteAssessmentOriginalRect = new Rectangle(btnDeleteAssessment.Location.X, btnDeleteAssessment.Location.Y, btnDeleteAssessment.Width, btnDeleteAssessment.Height);
            btnEnterResultOriginalRect = new Rectangle(btnEnterResult.Location.X, btnEnterResult.Location.Y, btnEnterResult.Width, btnEnterResult.Height);
            btnProduceAssessmentsReportOriginalRect = new Rectangle(btnProduceAssessmentsReport.Location.X, btnProduceAssessmentsReport.Location.Y, btnProduceAssessmentsReport.Width, btnProduceAssessmentsReport.Height);
            btnReturnOriginalRect = new Rectangle(btnReturn.Location.X, btnReturn.Location.Y, btnReturn.Width, btnReturn.Height);
            btnExitOriginalRect = new Rectangle(btnExit.Location.X, btnExit.Location.Y, btnExit.Width, btnExit.Height);
          
           
        }

        private void resizeChildrenControls()
        {// resize children controls 
            resizeControl(btnAddAssessmentOriginalRect, btnAddAssessment);
            resizeControl(btnUpdateAssessmentOriginalRect, btnUpdateAssessment);
            resizeControl(btnDeleteAssessmentOriginalRect, btnDeleteAssessment);
            resizeControl(btnEnterResultOriginalRect, btnEnterResult);
            resizeControl(btnProduceAssessmentsReportOriginalRect, btnProduceAssessmentsReport);
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
                newX = (int)(OriginalControlRect.X * xRatio) + 10;
            }
            else 
            { // X location when minimized 
                newX = (int)(OriginalControlRect.X * xRatio);
            }

            // Y location of controls when maximized
            int newY;
            if (this.WindowState == FormWindowState.Maximized)
            {
                newY = (int)(OriginalControlRect.Y * yRatio) + 3;
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
        private void CourseAdministratorForm_Resize(object sender, EventArgs e)
        {
            // autosize form controls upon window size change 
            resizeChildrenControls();

            if (this.WindowState == FormWindowState.Maximized)
            { // button font size upon maximize
                btnAddAssessment.Font = new Font("Arial", 10);
                btnUpdateAssessment.Font = new Font("Arial", 10);
                btnDeleteAssessment.Font = new Font("Arial", 10);
                btnEnterResult.Font = new Font("Arial", 10);
                btnProduceAssessmentsReport.Font = new Font("Arial", 10);
                btnReturn.Font = new Font("Arial", 10);
                btnExit.Font = new Font("Arial", 10); 
            }
            else
            {// button font size when not maximized
                btnAddAssessment.Font = new Font("Arial", 8);
                btnUpdateAssessment.Font = new Font("Arial", 8);
                btnDeleteAssessment.Font = new Font("Arial", 8);
                btnEnterResult.Font = new Font("Arial", 8);
                btnProduceAssessmentsReport.Font = new Font("Arial", 8);
                btnReturn.Font = new Font("Arial", 8);
                btnExit.Font = new Font("Arial", 8);
            }
        }

            private void btnAddAssessment_Click(object sender, EventArgs e)
        {
            // show Add Assessment form and course background form upon click
            frmCourse = new CourseBackgroundForm(this);
            frmCourse.Show();
            frmAddAssessment = new AddAssessmentForm(DC, this);
            frmAddAssessment.ShowDialog();
        }

        private void btnUpdateAssessment_Click(object sender, EventArgs e)
        {
            // show Update Assessment form and course background form upon click
            frmCourse = new CourseBackgroundForm(this);
            frmCourse.Show();
            frmUpdateAssessment = new UpdateAssessmentForm(DC, this);            
            frmUpdateAssessment.ShowDialog();

        }

        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        {
            // show Delete Assessment form and course background form form upon click
            frmCourse = new CourseBackgroundForm(this);
            frmCourse.Show();
            frmDeleteAssessment = new DeleteAssessmentForm(DC, this);
            frmDeleteAssessment.ShowDialog();
        }

        private void aSSESSMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aSSESSMENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }

        private void CourseAdministratorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);
            this.rESULTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESULT);
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

            // open form to maximize after 1 sec interval 
            if (this.WindowState == FormWindowState.Normal)
            {
                timer1.Interval = 1000;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnProduceAssessmentsReport_Click(object sender, EventArgs e)
        {
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);
            this.rESULTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESULT);
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);

            string strSort = "";
            string strFilter = null;

            assessmentsForPrintVAR = dsBalhamCollegeAzure.Tables["ASSESSMENT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            assessmentsForPrint = new DataTable();

            assessmentsForPrint.Columns.Add("AssessmentID", typeof(string));
            assessmentsForPrint.Columns.Add("AssessmentNumber", typeof(string));
            assessmentsForPrint.Columns.Add("AssessmentName", typeof(string));
            assessmentsForPrint.Columns.Add("Type", typeof(string));
            assessmentsForPrint.Columns.Add("Weighting", typeof(string));
            assessmentsForPrint.Columns.Add("MaximumMark", typeof(string));
            assessmentsForPrint.Columns.Add("CourseID", typeof(string));
            assessmentsForPrint.Columns.Add("CourseName", typeof(string));
            foreach (DataRow drAssess in assessmentsForPrintVAR)
            {
                DataRow drAssessmentToAdd = assessmentsForPrint.NewRow();
                assessmentsForPrint.Rows.Add(drAssessmentToAdd);
                drAssessmentToAdd[0] = drAssess[0].ToString();
                drAssessmentToAdd[1] = drAssess[1].ToString();
                drAssessmentToAdd[2] = drAssess[2].ToString();
                drAssessmentToAdd[3] = drAssess[3].ToString();
                drAssessmentToAdd[4] = drAssess[4].ToString();
                drAssessmentToAdd[5] = drAssess[5].ToString();
                drAssessmentToAdd[6] = drAssess[6].ToString();
                string strSortt = "";
                string strFilt = "CourseID=" + drAssess["CourseID"];

                string coursename = dsBalhamCollegeAzure.Tables["COURSE"].Select(strFilt, strSortt, DataViewRowState.CurrentRows)[0]["CourseName"].ToString();
                drAssessmentToAdd[7] = coursename;
            }
            assessmentsForPrint.DefaultView.Sort = "CourseName,AssessmentName";
            assessmentsForPrint = assessmentsForPrint.DefaultView.ToTable();
            assessmentForNextPage = 0;
            countOfAssessments = assessmentsForPrint.Rows.Count;
            PagePrinted = 1;
            prvAssessments.ShowDialog();
        }
        private float GetLength(string text)
        {
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF textLength = graphics.MeasureString(text, new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point));
                return textLength.Width;
            }
        }

        private void printAssessments_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            string markTit = "  Mark  ";

            string resultDateTit = "   Result Date   ";
            string nameTit = "Student Name";


            float bar = GetLength("|") / 2;
            float margin0 = leftMargin - 20;
            float margin1 = margin0 + GetLength(markTit) + 4;
            float margin01 = margin0 + (margin1 - margin0) / 2 + bar;
            float margin2 = margin1 + GetLength(resultDateTit) + 8;
            float margin12 = margin1 + (margin2 - margin1) / 2 + bar;
            float margin3 = rightMargin + 20; ;
            float margin23 = margin2 + (margin3 - margin2) / 2 + bar;
            float yearMargin = rightLabelsMargin - GetLength(markTit) / 2 - 60;
            float semesterMa = yearMargin + GetLength(markTit);

            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF title1Length = graphics.MeasureString("Assessments Report", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));
                SizeF title2Length = graphics.MeasureString("Balham College", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));

                g.DrawString("Assessments Report", titleFont, brush, (rightMargin + 100) / 2 - title1Length.Width / 2, topMargin);
                linesSoFar++;
                g.DrawString("Balham College", titleFont, brush, (rightMargin + 100) / 2 - title2Length.Width / 2, topMargin + (linesSoFar * titleFont.Height));
                linesSoFar = linesSoFar + 6;
            }
            int i = assessmentForNextPage;
            bool keepPrinting = true;
            while (i < countOfAssessments && keepPrinting)
            {
                int assessmentInitialLines;
                DataRow drAssessment = assessmentsForPrint.Rows[i];
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
                {
                    // LINE 1
                    g.DrawString("Assessment ID: ", labelsFont, brush, rightLabelsMargin - GetLength("Assessment ID: "), topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(drAssessment["AssessmentID"].ToString(), textFont, brush, rightInfoMargin, topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Assessment Number: ", labelsFont, brush, rightLabelsMargin - GetLength("Assessment Number: ") + 220, topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(drAssessment["AssessmentNumber"].ToString(), textFont, brush, rightInfoMargin + 220, topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Type: ", labelsFont, brush, rightLabelsMargin - GetLength("Type: ") + 350, topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(drAssessment["Type"].ToString(), textFont, brush, rightInfoMargin + 350, topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;
                    assessmentInitialLines = linesSoFar;

                    // LINE 2
                    g.DrawString("Assessment Name: ", labelsFont, brush, rightLabelsMargin - GetLength("Assessment Name: "), 4 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drAssessment["AssessmentName"]), textFont, brush, rightInfoMargin, topMargin + 4 + (linesSoFar * textFont.Height));

                    linesSoFar++;
                    // LINE 3
                    g.DrawString("Course Name: ", labelsFont, brush, rightLabelsMargin - GetLength("Course Name: "), 8 + topMargin + (linesSoFar * (labelsFont.Height)));
                    g.DrawString(Convert.ToString(drAssessment["CourseName"]), textFont, brush, rightInfoMargin, 8 + topMargin + (linesSoFar * (textFont.Height)));

                    linesSoFar++;
                    //LINE 4
                    g.DrawString("Weighting: ", labelsFont, brush, rightLabelsMargin - GetLength("Weighting: "), 12 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drAssessment["Weighting"]), textFont, brush, rightInfoMargin, topMargin + 12 + (linesSoFar * textFont.Height));
                    g.DrawString("Maximum Mark: ", labelsFont, brush, rightLabelsMargin - GetLength("Maximum Mark: ") + 220, 12 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drAssessment["MaximumMark"]), textFont, brush, rightInfoMargin + 220, 12 + topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    //LINE 5
                    string strSort = "";
                    string strFilter = "AssessmentID=" + drAssessment["AssessmentID"].ToString();
                    DataRow[] results = dsBalhamCollegeAzure.Tables["RESULT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);

                    DataTable resultsForTable = new DataTable();

                    resultsForTable.Columns.Add("AssessmentID", typeof(string));
                    resultsForTable.Columns.Add("EnrolmentID", typeof(string));
                    resultsForTable.Columns.Add("ResultDate", typeof(string));
                    resultsForTable.Columns.Add("Mark", typeof(string));
                    resultsForTable.Columns.Add("StudentLastName", typeof(string));
                    resultsForTable.Columns.Add("StudentFirstName", typeof(string));
                    foreach (DataRow drResult in results)
                    {
                        DataRow drResultToAdd = resultsForTable.NewRow();
                        resultsForTable.Rows.Add(drResultToAdd);
                        drResultToAdd[0] = drResult[0].ToString();
                        drResultToAdd[1] = drResult[1].ToString();
                        drResultToAdd[2] = drResult[2].ToString();
                        drResultToAdd[3] = drResult[3].ToString();

                        string stuSort = "";
                        string stuFilt = "EnrolmentID=" + drResult["EnrolmentID"];
                        string studentID = dsBalhamCollegeAzure.Tables["Enrolment"].Select(stuFilt, stuSort, DataViewRowState.CurrentRows)[0]["StudentID"].ToString();
                        DataRow studentT = dsBalhamCollegeAzure.Tables["Student"].Select("StudentId=" + studentID, stuSort, DataViewRowState.CurrentRows)[0];
                        drResultToAdd[4] = studentT["LastName"].ToString();
                        drResultToAdd[5] = studentT["FirstName"].ToString();
                    }
                    resultsForTable.DefaultView.Sort = "StudentLastName,StudentFirstName";
                    resultsForTable = resultsForTable.DefaultView.ToTable();

                    //LINE 6 Enrolments Titles
                    if (resultsForTable.Rows.Count > 0)
                    {
                        g.DrawString("Results: ", labelsFont, brush, rightLabelsMargin - GetLength("Results: "), 20 + topMargin + (linesSoFar * labelsFont.Height));
                        linesSoFar++;
                        g.DrawString("|", labelsFont, brush, margin0, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString(markTit, labelsFont, brush, margin01 - GetLength(markTit) / 2 - bar, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString("|", labelsFont, brush, margin1, 24 + topMargin + (linesSoFar * labelsFont.Height));

                        g.DrawString(resultDateTit, labelsFont, brush, margin12 - GetLength(resultDateTit) / 2 - bar * 2, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString("|", labelsFont, brush, margin2, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString(nameTit, labelsFont, brush, margin23 - GetLength(nameTit) / 2, 24 + topMargin + (linesSoFar * labelsFont.Height));
                        g.DrawString("|", labelsFont, brush, margin3, 24 + topMargin + (linesSoFar * labelsFont.Height));

                        g.DrawString("_____________________________________________________________________________________", textFont, brush, leftMargin - 19, topMargin + (linesSoFar * textFont.Height) + 26);
                        linesSoFar++;

                        //LINE 7
                        foreach (DataRow drResults in resultsForTable.Rows)
                        {
                            g.DrawString("|", labelsFont, brush, margin0, 28 + topMargin + (linesSoFar * labelsFont.Height));
                            g.DrawString(drResults["Mark"].ToString(), textFont, brush, margin01 - GetLength(drResults["Mark"].ToString()) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                            g.DrawString("|", labelsFont, brush, margin1, 28 + topMargin + (linesSoFar * labelsFont.Height));
                            g.DrawString(Convert.ToDateTime(drResults["ResultDate"]).ToString("dd/MM/yyyy"), textFont, brush, margin12 - GetLength(Convert.ToDateTime(drResults["ResultDate"]).ToString("dd/MM/yyyy")) / 2, 28 + topMargin + (linesSoFar * textFont.Height));
                            g.DrawString("|", labelsFont, brush, margin2, 28 + topMargin + (linesSoFar * labelsFont.Height));
                            string studentName = drResults["StudentLastName"].ToString() + ", " + drResults["StudentFirstName"].ToString();
                            g.DrawString(studentName, textFont, brush, margin23 - GetLength(studentName) / 2 + bar, 28 + topMargin + (linesSoFar * textFont.Height));
                            g.DrawString("|", labelsFont, brush, margin3, 28 + topMargin + (linesSoFar * labelsFont.Height));
                            linesSoFar++;
                        }
                        linesSoFar++;

                        g.DrawString("_______________________________________________________________________________________", textFont, brush, leftMargin - 26, topMargin + (linesSoFar * labelsFont.Height));
                        linesSoFar++;
                    }
                    else
                    {
                        g.DrawString("Enrolments: None", labelsFont, brush, rightLabelsMargin - GetLength("Enrolments: "), 20 + topMargin + (linesSoFar * labelsFont.Height));
                        linesSoFar++;
                        linesSoFar++;
                        g.DrawString("_______________________________________________________________________________________", textFont, brush, leftMargin - 30, topMargin + (linesSoFar * textFont.Height));
                        linesSoFar++;
                    }
                    linesSoFar++;
                    linesSoFar++;
                    linesSoFar++;
                }
                i++;
                if ((60 - linesSoFar) < (linesSoFar - assessmentInitialLines))
                {
                    keepPrinting = false;
                }
            }
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                g.DrawString("Page " + PagePrinted.ToString(), textFont, brush, rightInfoMargin + 500, bottomMargin + 20);
            }
            PagePrinted++;
            assessmentForNextPage = i;
            if ((assessmentForNextPage < countOfAssessments))
            {
                e.HasMorePages = true;
            }
            (prvAssessments as Form).WindowState = FormWindowState.Maximized;
            prvAssessments.PrintPreviewControl.Zoom = 1;
        }

        private void btnEnterResult_Click(object sender, EventArgs e)

        {
            // show enter result form and course background form
            frmCourse = new CourseBackgroundForm(this);
            frmCourse.Show();
            frmEnterResult = new EnterResultForm(DC, this);           
            frmEnterResult.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        { 
            // return to login menu 
            this.Close();
            frmLogin.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // exit application 
        }

       
    }
}
