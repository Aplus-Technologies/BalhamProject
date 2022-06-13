using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalhamCollege
{
    public partial class ResearchAdministratorForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private DeleteResearchTopicForm frmDeleteResearchTopic; // reference to delete research topic form
        private UpdateResearchTopicForm frmUpdateResearchTopic; // reference to update research topic form
        private AddResearchProject frmAddResearchProject; // reference to add research project form
        private RemoveResearchProjectForm frmRemoveResearchProject; // reference to remove research project form                                                  
        private AddResearchTopicForm frmAddResearchTopic; // reference to add research topic form

        private ResearchBackgroundForm frmResearch; //reference to research background form
        


        //Produce report variables
        private DataRow[] researchProjectsForPrint;
        private int researchProjectForNextPage;
        private int countOfProjects;
        private int PagePrinted;


        public ResearchAdministratorForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }

        private void btnAddResearchProject_Click(object sender, EventArgs e)
        {
            //show Add Research Project form upon click
            if (frmAddResearchProject == null)
            {
                frmAddResearchProject = new AddResearchProject(DC, this);
            }
            frmAddResearchProject.ShowDialog();

        }

        private void btnRemoveResearchProject_Click(object sender, EventArgs e)
        {
            //show Remove Research Project form and background form upon click
            frmResearch = new ResearchBackgroundForm(this);
            frmResearch.Show();
            frmRemoveResearchProject = new RemoveResearchProjectForm(DC, this);
            frmRemoveResearchProject.ShowDialog();
        }

        private void btnAddResearchTopic_Click(object sender, EventArgs e)
        {
            //show Add Research Topic form upon click
            if (frmAddResearchTopic == null)
            {
                frmAddResearchTopic = new AddResearchTopicForm(DC, this);
            }
            frmAddResearchTopic.ShowDialog();
        }

        private void btnDeleteResearchTopic_Click(object sender, EventArgs e)
        { 
            //show Delete Research Topic form and background form upon click
            frmResearch = new ResearchBackgroundForm(this);
            frmResearch.Show();
            frmDeleteResearchTopic = new DeleteResearchTopicForm(DC, this);
            frmDeleteResearchTopic.ShowDialog();
        }

        private void btnUpdateResearchTopic_Click(object sender, EventArgs e)
        {
            // show Update Research Topic form upon click
            if (frmUpdateResearchTopic == null)
            {
                frmUpdateResearchTopic = new UpdateResearchTopicForm(DC, this);
            }
            frmUpdateResearchTopic.ShowDialog();

        }
        private void rESEARCHPROJECTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rESEARCHPROJECTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);
        }

        private void ResearchAdministratorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
            this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHPROJECT' table. You can move, or remove it, as needed.
            this.rESEARCHPROJECTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHPROJECT);
        }
        private void btnProduceResearchReport_Click(object sender, EventArgs e)
        {
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
            this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);
            this.rESEARCHPROJECTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHPROJECT);

            string strSort = "ProjectDescription";
            string strFilter = null;

            string strFilter2 = strFilter;
            researchProjectsForPrint = dsBalhamCollegeAzure.Tables["ResearchProject"].Select(strFilter2, strSort, DataViewRowState.CurrentRows);

            researchProjectForNextPage = 0;
            countOfProjects = researchProjectsForPrint.Count();
            PagePrinted = 1;
            prvResearches.ShowDialog();
        }
        private float GetLength(string text)
        {
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF textLength = graphics.MeasureString(text, new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point));
                return textLength.Width;
            }
        }
        private void printResearch_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
                SizeF title1Length = graphics.MeasureString("Research Projects Report", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));
                SizeF title2Length = graphics.MeasureString("Balham College", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));

                g.DrawString("Research Projects Report", titleFont, brush, (rightMargin + 100) / 2 - title1Length.Width / 2, topMargin);
                linesSoFar++;
                g.DrawString("Balham College", titleFont, brush, (rightMargin + 100) / 2 - title2Length.Width / 2, topMargin + (linesSoFar * titleFont.Height));
                linesSoFar = linesSoFar + 6;
            }
            int i = researchProjectForNextPage;
            while (i < countOfProjects && linesSoFar < 55)
            {
                DataRow drProject = researchProjectsForPrint[i];
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
                {
                    string impact = "";
                    string topicDescription = "";

                    foreach (DataRow drTopic in dsBalhamCollegeAzure.RESEARCHTOPIC.Rows)
                    {
                        if (drTopic["TopicID"].ToString() == drProject["TopicID"].ToString())
                        {
                            impact = drTopic["impact"].ToString();
                            topicDescription = drTopic["TopicDescription"].ToString();
                        }
                    }
                    // LINE 1
                    g.DrawString("Project Description: ", labelsFont, brush, rightLabelsMargin - GetLength("Project Description: ") + 100, topMargin + (linesSoFar * labelsFont.Height));
                    int letterP = 1;
                    int letterMaxPlaceP = drProject["ProjectDescription"].ToString().Length;
                    int topicDescriptionBoundaryP = 1;
                    string topDesc1P;
                    string topDesc2P;

                    if ((GetLength(drProject["ProjectDescription"].ToString()) >= 410))
                    {
                        while (letterP <= drProject["ProjectDescription"].ToString().Length)
                        {
                            if ((GetLength(drProject["ProjectDescription"].ToString().Substring(0, letterP)) < 410) && (drProject["ProjectDescription"].ToString()[letterP - 1].ToString() == " "))
                            {
                                topicDescriptionBoundaryP = letterP;
                            }
                            letterP++;
                        }
                        topDesc1P = drProject["ProjectDescription"].ToString().Substring(0, topicDescriptionBoundaryP - 1);
                        topDesc2P = drProject["ProjectDescription"].ToString().Substring(topicDescriptionBoundaryP, drProject["ProjectDescription"].ToString().Length - topicDescriptionBoundaryP);
                    }
                    else
                    {
                        topDesc1P = drProject["ProjectDescription"].ToString();
                        topDesc2P = "";
                    }
                    g.DrawString(topDesc1P, textFont, brush, rightInfoMargin + 100, topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    // LINE 2

                    g.DrawString(topDesc2P, textFont, brush, rightInfoMargin + 100, 4 + topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    // LINE 3
                    g.DrawString("Lecturer Name: ", labelsFont, brush, rightLabelsMargin - GetLength("Lecturer Name: ") + 100, 8 + topMargin + (linesSoFar * labelsFont.Height));
                    string lecturerName = "";
                    foreach (DataRow drLecturer in dsBalhamCollegeAzure.LECTURER.Rows)
                    {
                        if (drLecturer["LecturerID"].ToString() == drProject["LecturerID"].ToString())
                        {
                            lecturerName = drLecturer["LastName"].ToString() + ", " + drLecturer["FirstName"].ToString();
                        }
                    }
                    g.DrawString(lecturerName, textFont, brush, rightInfoMargin + 100, topMargin + 8 + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    // LINE 4
                    g.DrawString("Impact: ", labelsFont, brush, rightLabelsMargin - GetLength("impact: ") + 100, 12 + topMargin + (linesSoFar * labelsFont.Height));

                    g.DrawString(impact, textFont, brush, rightInfoMargin + 100, 12 + topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Start Date: ", labelsFont, brush, rightLabelsMargin - GetLength("Start Date: ") + 350, 12 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToDateTime(drProject["StartDate"]).ToString("dd/MM/yyyy"), textFont, brush, rightInfoMargin + 350, 12 + topMargin + (linesSoFar * textFont.Height));

                    linesSoFar++;
                    //LINE 5
                    g.DrawString("Topic Description: ", labelsFont, brush, rightLabelsMargin - GetLength("Topic Description: ") + 100, 16 + topMargin + (linesSoFar * labelsFont.Height));
                    int letter = 1;
                    int letterMaxPlace = topicDescription.Length;
                    int topicDescriptionBoundary = 1;
                    string topDesc1;
                    string topDesc2;

                    if ((GetLength(topicDescription) >= 410))
                    {
                        while (letter <= topicDescription.Length)
                        {
                            if ((GetLength(topicDescription.Substring(0, letter)) < 410) && (topicDescription[letter - 1].ToString() == " "))
                            {
                                topicDescriptionBoundary = letter;
                            }
                            letter++;
                        }
                        topDesc1 = topicDescription.Substring(0, topicDescriptionBoundary - 1);
                        topDesc2 = topicDescription.Substring(topicDescriptionBoundary, topicDescription.Length - topicDescriptionBoundary);
                    }
                    else
                    {
                        topDesc1 = topicDescription;
                        topDesc2 = "";
                    }
                    g.DrawString(topDesc1, textFont, brush, rightInfoMargin + 100, 16 + topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    // LINE 6
                    g.DrawString(topDesc2, textFont, brush, rightInfoMargin + 100, 20 + +topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    // LINE 7
                    g.DrawString("Output: ", labelsFont, brush, rightLabelsMargin - GetLength("Output: ") + 100, 24 + topMargin + (linesSoFar * (labelsFont.Height)));
                    g.DrawString(Convert.ToString(drProject["Output"]), textFont, brush, rightInfoMargin + 100, 24 + topMargin + (linesSoFar * (textFont.Height)));
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
            researchProjectForNextPage = i;
            if ((researchProjectForNextPage < countOfProjects))
            {
                e.HasMorePages = true;
            }
            (prvResearches as Form).WindowState = FormWindowState.Maximized;
            prvResearches.PrintPreviewControl.Zoom = 1;
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
