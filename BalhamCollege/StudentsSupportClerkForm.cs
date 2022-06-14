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
    public partial class StudentsSupportClerkForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private RecordIssueForm frmRecordIssue;
        private StudentBackgroundForm frmStud; // reference to Background Form
        //Produce report variables
        private DataRow[] issuesForPrint;
        private int issuesForNextPage;
        private int countOfIssues;
        private int PagePrinted;

        // variables to store control location and size    
        private Rectangle btnRecordIssueOriginalRect;
        private Rectangle btnProduceIssuesReportOriginalRect;       
        private Rectangle btnReturnOriginalRect;
        private Rectangle btnExitOriginalRect;

        private Size formOriginalSize;
        public StudentsSupportClerkForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();

            // keep track of original control size, for autoresizing (original location and size)
            formOriginalSize = this.Size;
            btnRecordIssueOriginalRect = new Rectangle(btnRecordIssue.Location.X, btnRecordIssue.Location.Y, btnRecordIssue.Width, btnRecordIssue.Height);
            btnProduceIssuesReportOriginalRect = new Rectangle(btnProduceIssuesReport.Location.X, btnProduceIssuesReport.Location.Y, btnProduceIssuesReport.Width, btnProduceIssuesReport.Height);            
            btnReturnOriginalRect = new Rectangle(btnReturn.Location.X, btnReturn.Location.Y, btnReturn.Width, btnReturn.Height);
            btnExitOriginalRect = new Rectangle(btnExit.Location.X, btnExit.Location.Y, btnExit.Width, btnExit.Height);
        }

        private void resizeChildrenControls()
        {// resize children controls 
            resizeControl(btnRecordIssueOriginalRect, btnRecordIssue);
            resizeControl(btnProduceIssuesReportOriginalRect, btnProduceIssuesReport);
            
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
                newX = (int)(OriginalControlRect.X * xRatio) + 5;
            }
            else
            { // X location when minimized 
                newX = (int)(OriginalControlRect.X * xRatio);
            }

            // Y location of controls when maximized
            int newY;
            if (this.WindowState == FormWindowState.Maximized)
            {
                newY = (int)(OriginalControlRect.Y * yRatio) + 15;
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
        private void StudentsSupportClerkForm_Resize(object sender, EventArgs e)
        {
            // autosize form controls upon window size change 
            resizeChildrenControls();

            if (this.WindowState == FormWindowState.Maximized)
            { // button font size upon maximize
                btnRecordIssue.Font = new Font("Arial", 10);
                btnProduceIssuesReport.Font = new Font("Arial", 10);             
                btnReturn.Font = new Font("Arial", 10);
                btnExit.Font = new Font("Arial", 10);
            }
            else
            {// button font size when not maximized
                btnRecordIssue.Font = new Font("Arial", 8);
                btnProduceIssuesReport.Font = new Font("Arial", 8);
                btnReturn.Font = new Font("Arial", 8);
                btnExit.Font = new Font("Arial", 8);

            }
        }

        private void btnRecordIssue_Click(object sender, EventArgs e)
        {
            frmStud = new StudentBackgroundForm(this);
            frmStud.Show();
            frmRecordIssue = new RecordIssueForm(DC, this);          
            frmRecordIssue.StartPosition = FormStartPosition.CenterScreen;
            frmRecordIssue.ShowDialog();
        }

        private void iSSUEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iSSUEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void StudentsSupportClerkForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ISSUE' table. You can move, or remove it, as needed.
            this.iSSUETableAdapter.Fill(this.dsBalhamCollegeAzure.ISSUE);

            // open form to maximize after 1 sec interval 
            if (this.WindowState == FormWindowState.Normal)
            {
                timer1.Interval = 1000;
                this.WindowState = FormWindowState.Maximized;
            }

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

        private void btnProduceIssuesReport_Click(object sender, EventArgs e)
        {
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            this.iSSUETableAdapter.Fill(this.dsBalhamCollegeAzure.ISSUE);

            string strSort = "IssueDate DESC,IssueID";
            string strFilter = null;

            string strFilter2 = strFilter;
            issuesForPrint = dsBalhamCollegeAzure.Tables["Issue"].Select(strFilter2, strSort, DataViewRowState.CurrentRows);

            issuesForNextPage = 0;
            countOfIssues = issuesForPrint.Count();
            PagePrinted = 1;
            prvIssues.ShowDialog();
        }
        private void printIssues_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            int position = 50;

            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF title1Length = graphics.MeasureString("Issues Report", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));
                SizeF title2Length = graphics.MeasureString("Balham College", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));

                g.DrawString("Issues Report", titleFont, brush, (rightMargin + 100) / 2 - title1Length.Width / 2, topMargin);
                linesSoFar++;
                g.DrawString("Balham College", titleFont, brush, (rightMargin + 100) / 2 - title2Length.Width / 2, topMargin + (linesSoFar * titleFont.Height));
                linesSoFar = linesSoFar + 6;
            }
            int i = issuesForNextPage;
            while (i < countOfIssues && linesSoFar < 55)
            {
                DataRow drIssues = issuesForPrint[i];
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
                {
                    string enrolmentFilter = "EnrolmentID=" + drIssues["EnrolmentID"].ToString();
                    DataRow drEnrolment = dsBalhamCollegeAzure.Tables["Enrolment"].Select(enrolmentFilter, null, DataViewRowState.CurrentRows)[0];

                    string studentFilter = "StudentID=" + drEnrolment["StudentID"].ToString();
                    DataRow drStudent = dsBalhamCollegeAzure.Tables["Student"].Select(studentFilter, null, DataViewRowState.CurrentRows)[0];
                    string studentName = drStudent["LastName"].ToString() + ", " + drStudent["FirstName"].ToString();



                    string courseFilter = "CourseID=" + drEnrolment["CourseID"].ToString();
                    DataRow drCourse = dsBalhamCollegeAzure.Tables["Course"].Select(courseFilter, null, DataViewRowState.CurrentRows)[0];
                    string courseName = drCourse["CourseName"].ToString();

                    // LINE 1
                    g.DrawString("Issue ID: ", labelsFont, brush, rightLabelsMargin - GetLength("Issue ID: ") + position, topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drIssues["IssueID"]), textFont, brush, rightInfoMargin + position, topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Issue Date: ", labelsFont, brush, rightLabelsMargin - GetLength("Issue Date: ") + position + 150, topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToDateTime(drIssues["IssueDate"]).ToString("dd/MM/yyyy"), textFont, brush, rightInfoMargin + position + 150, topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Enrolment ID: ", labelsFont, brush, rightLabelsMargin - GetLength("Enrolment ID: ") + position + 400, topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drIssues["EnrolmentID"]), textFont, brush, rightInfoMargin + position + 400, topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;
                    // LINE 2
                    g.DrawString("Issue Description: ", labelsFont, brush, rightLabelsMargin - GetLength("Issue Description: ") + position, 4 + topMargin + (linesSoFar * labelsFont.Height));

                    int letterP = 1;
                    int letterMaxPlaceP = drIssues["IssueDescription"].ToString().Length;
                    int topicDescriptionBoundaryP = 1;
                    string topDesc1P;
                    string topDesc2P;

                    if ((GetLength(drIssues["IssueDescription"].ToString()) >= 500))
                    {
                        while (letterP <= drIssues["IssueDescription"].ToString().Length)
                        {
                            if ((GetLength(drIssues["IssueDescription"].ToString().Substring(0, letterP)) < 500) && (drIssues["IssueDescription"].ToString()[letterP - 1].ToString() == " "))
                            {
                                topicDescriptionBoundaryP = letterP;
                            }
                            letterP++;
                        }
                        topDesc1P = drIssues["IssueDescription"].ToString().Substring(0, topicDescriptionBoundaryP - 1);
                        topDesc2P = drIssues["IssueDescription"].ToString().Substring(topicDescriptionBoundaryP, drIssues["IssueDescription"].ToString().Length - topicDescriptionBoundaryP);
                    }
                    else
                    {
                        topDesc1P = drIssues["IssueDescription"].ToString();
                        topDesc2P = "";
                    }
                    g.DrawString(topDesc1P, textFont, brush, rightInfoMargin + position, 4 + topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    // LINE 3
                    g.DrawString(topDesc2P, textFont, brush, rightInfoMargin + position, 8 + topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    //LINE 4
                    g.DrawString("Topic Description: ", labelsFont, brush, rightLabelsMargin - GetLength("Topic Description: ") + position, 12 + topMargin + (linesSoFar * labelsFont.Height));
                    int letter = 1;
                    int letterMaxPlace = drIssues["ActionTaken"].ToString().Length;
                    int topicDescriptionBoundary = 1;
                    string topDesc1;
                    string topDesc2;

                    if ((GetLength(drIssues["ActionTaken"].ToString()) >= 500))
                    {
                        while (letter <= drIssues["ActionTaken"].ToString().Length)
                        {
                            if ((GetLength(drIssues["ActionTaken"].ToString().Substring(0, letter)) < 500) && (drIssues["ActionTaken"].ToString()[letter - 1].ToString() == " "))
                            {
                                topicDescriptionBoundary = letter;
                            }
                            letter++;
                        }
                        topDesc1 = drIssues["ActionTaken"].ToString().Substring(0, topicDescriptionBoundary - 1);
                        topDesc2 = drIssues["ActionTaken"].ToString().Substring(topicDescriptionBoundary, drIssues["ActionTaken"].ToString().Length - topicDescriptionBoundary);
                    }
                    else
                    {
                        topDesc1 = drIssues["ActionTaken"].ToString();
                        topDesc2 = "";
                    }
                    g.DrawString(topDesc1, textFont, brush, rightInfoMargin + position, 12 + topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    // LINE 5
                    g.DrawString(topDesc2, textFont, brush, rightInfoMargin + position, 16 + +topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    // LINE 6
                    g.DrawString("Student Name: ", labelsFont, brush, rightLabelsMargin - GetLength("Student Name: ") + position, 20 + topMargin + (linesSoFar * labelsFont.Height));

                    g.DrawString(studentName, textFont, brush, rightInfoMargin + position, 20 + topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    // LINE 7
                    g.DrawString("Course Name: ", labelsFont, brush, rightLabelsMargin - GetLength("Course Name: ") + position, 24 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(courseName, textFont, brush, rightInfoMargin + position, 24 + topMargin + (linesSoFar * textFont.Height));

                    linesSoFar++;
                    linesSoFar++;
                    g.DrawString("__________________________________________________________________________________", textFont, brush, leftMargin, topMargin + (linesSoFar * textFont.Height));
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
            issuesForNextPage = i;
            if ((issuesForNextPage < countOfIssues))
            {
                e.HasMorePages = true;
            }
            (prvIssues as Form).WindowState = FormWindowState.Maximized;
            prvIssues.PrintPreviewControl.Zoom = 1;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // return user to login page 
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
