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
    public partial class HumanResourcesClerkForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private UpdateLecturerForm frmUpdateLecturer; // the reference to the Update Lecturer form
        private DeleteLecturerForm frmDeleteLecturer; // reference to Delete Lecturer Form
        private AddLecturerForm frmAddLecturer; // reference to Add Lecturer Form 
        //variables for producing the report
        private DataRow[] lecturersForPrint;
        private int lecturerForNextPage;
        private int countOfLecturers;
        private int PagePrinted;

        public HumanResourcesClerkForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }
       

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            // show Add Lecturer form upon click
            if (frmAddLecturer == null)
            {
                frmAddLecturer = new AddLecturerForm(DC, this);
            }
            frmAddLecturer.ShowDialog();

        }

        private void btnUpdateLecturer_Click(object sender, EventArgs e)
        {
            // show Update Lecturer form upon click
            if (frmUpdateLecturer == null)
            {
                frmUpdateLecturer = new UpdateLecturerForm(DC, this);
            }
            frmUpdateLecturer.ShowDialog();
        }

        

        private void btnDeleteLecturer_Click(object sender, EventArgs e)
        {
            // show Delete Lecturer form upon click
            if (frmDeleteLecturer == null)
            {
                frmDeleteLecturer = new DeleteLecturerForm(DC, this);
            }
            frmDeleteLecturer.ShowDialog();
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

        private void lECTURERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lECTURERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void HumanResourcesClerkForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSIGNMENT' table. You can move, or remove it, as needed.
            this.aSSIGNMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSIGNMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);

        }

        private void btnLecturerReport_Click(object sender, EventArgs e)
        {
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
            this.aSSIGNMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSIGNMENT);

            string strSort = "LastName,FirstName";
            string strFilter = null;

            string strFilter2 = strFilter;
            lecturersForPrint = dsBalhamCollegeAzure.Tables["LECTURER"].Select(strFilter2, strSort, DataViewRowState.CurrentRows);

            lecturerForNextPage = 0;
            countOfLecturers = lecturersForPrint.Count();
            PagePrinted = 1;
            prvLecturers.ShowDialog();
        }
        private float GetLength(string text)
        {
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF textLength = graphics.MeasureString(text, new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point));
                return textLength.Width;
            }
        }
        private void printLecturers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
                SizeF title1Length = graphics.MeasureString("Lecturers Report", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));
                SizeF title2Length = graphics.MeasureString("Balham College", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));

                g.DrawString("Lecturers Report", titleFont, brush, (rightMargin + 100) / 2 - title1Length.Width / 2, topMargin);
                linesSoFar++;
                g.DrawString("Balham College", titleFont, brush, (rightMargin + 100) / 2 - title2Length.Width / 2, topMargin + (linesSoFar * titleFont.Height));
                linesSoFar = linesSoFar + 6;
            }
            int i = lecturerForNextPage;
            while (i < countOfLecturers && linesSoFar < 55)
            {
                DataRow drLecturer = lecturersForPrint[i];
                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
                {
                    SizeF lectIDLength = graphics.MeasureString("Lecturer ID: ", new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point));
                    // LINE 1
                    g.DrawString("Lecturer ID: ", labelsFont, brush, rightLabelsMargin - lectIDLength.Width, topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(drLecturer["LecturerID"].ToString(), textFont, brush, rightInfoMargin, topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Name: ", labelsFont, brush, rightLabelsMargin - GetLength("Name: ") + 100, topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(drLecturer["LastName"] + ", " + drLecturer["FirstName"], textFont, brush, rightInfoMargin + 100, topMargin + (linesSoFar * textFont.Height));

                    linesSoFar++;
                    // LINE 2
                    g.DrawString("Street Address: ", labelsFont, brush, rightLabelsMargin - GetLength("Street Address: "), 4 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drLecturer["StreetAddress"]), textFont, brush, rightInfoMargin, topMargin + 4 + (linesSoFar * textFont.Height));
                    linesSoFar++;
                    // LINE 3
                    g.DrawString("Suburb: ", labelsFont, brush, rightLabelsMargin - GetLength("Suburb: "), 8 + topMargin + (linesSoFar * (labelsFont.Height)));
                    g.DrawString(Convert.ToString(drLecturer["Suburb"]), textFont, brush, rightInfoMargin, 8 + topMargin + (linesSoFar * (textFont.Height)));
                    g.DrawString("City: ", labelsFont, brush, rightLabelsMargin - GetLength("City: ") + 265, 8 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drLecturer["City"]), textFont, brush, rightInfoMargin + 265, 8 + topMargin + (linesSoFar * textFont.Height));


                    linesSoFar++;
                    // LINE 4
                    g.DrawString("Email Address: ", labelsFont, brush, rightLabelsMargin - GetLength("Email Address: "), 12 + topMargin + (linesSoFar * (labelsFont.Height)));
                    g.DrawString(Convert.ToString(drLecturer["EmailAddress"]), textFont, brush, rightInfoMargin, 12 + topMargin + (linesSoFar * (textFont.Height)));
                    g.DrawString("Ranking: ", labelsFont, brush, rightLabelsMargin - GetLength("Ranking: ") + 460, 12 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drLecturer["Ranking"]), textFont, brush, rightInfoMargin + 462, 12 + topMargin + (linesSoFar * textFont.Height));

                    linesSoFar++;
                    // LINE 5 
                    g.DrawString("Phone Number: ", labelsFont, brush, rightLabelsMargin - GetLength("Phone Number: "), 16 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drLecturer["PhoneNumber"]), textFont, brush, rightInfoMargin, 16 + topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Type: ", labelsFont, brush, rightLabelsMargin - GetLength("Type: ") + 265, 16 + topMargin + (linesSoFar * labelsFont.Height));
                    g.DrawString(Convert.ToString(drLecturer["Type"]), textFont, brush, rightInfoMargin + 265, 16 + topMargin + (linesSoFar * textFont.Height));
                    g.DrawString("Assignments: ", labelsFont, brush, rightLabelsMargin - GetLength("Assignments: ") + 460, 16 + topMargin + (linesSoFar * labelsFont.Height));
                    int assignmentsCount = 0;
                    foreach (DataRow drAssignment in dsBalhamCollegeAzure.ASSIGNMENT.Rows)
                    {
                        if (drAssignment["LecturerID"].ToString() == drLecturer["LecturerID"].ToString())
                        {
                            assignmentsCount++;
                        }
                    }

                    g.DrawString(assignmentsCount.ToString(), textFont, brush, rightInfoMargin + 462, 16 + topMargin + (linesSoFar * textFont.Height));
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
            lecturerForNextPage = i;
            if ((lecturerForNextPage < countOfLecturers))
            {
                e.HasMorePages = true;
            }
        }

        
    }
}
