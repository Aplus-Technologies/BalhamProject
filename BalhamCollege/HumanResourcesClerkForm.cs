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
        private DataRow[] allLecturers;
        private DataRow[] lecturersForPrint;
        private int amountOfLecturersPrinted;
        private HumanBackgroundForm frmHuman;

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
            // show Delete Lecturer form and background upon click
            frmHuman = new HumanBackgroundForm(this);
            frmHuman.Show();
            frmDeleteLecturer = new DeleteLecturerForm(DC, this);
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
            amountOfLecturersPrinted = 0;
            string strSort = "LastName";
            string strFilter = null;/*
            DataRow[] allLecturers = dsBalhamCollegeAzure.Tables["LECTURER"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            string idsToPrint = "";
            foreach (DataRow drAllVets in allLecturers)
            {
                DataRow[] drVisitTrtments = drAllVets.GetChildRows(DC.dtVeterinarian.ChildRelations["Veterinarian_VISIT"]);
                if (drVisitTrtments.Length != 0)
                {
                    idsToPrint += Convert.ToString(drAllVets["VeterinarianID"]) + ", ";
                }
            }
            string strFilter2 = "VeterinarianID IN (" + idsToPrint.Remove(idsToPrint.Length - 2, 1) + ")";
            */
            string strFilter2 = strFilter;
            lecturersForPrint = dsBalhamCollegeAzure.Tables["LECTURER"].Select(strFilter2, strSort, DataViewRowState.CurrentRows);
            //pagesAmountExpected = veterinariansForPrint.Length;
            prvLecturers.Show();
        }

        private void printLecturers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFar = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font titleFont = new Font("Arial", 18, FontStyle.Regular);
            //DataRow drVeterinarian = lecturersForPrint[amountOfVeterinariansPrinted];
            
            Brush brush = new SolidBrush(Color.Black);
            // Margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            int subTitlesRightMargin = e.MarginBounds.Left + 500;
            double veterinarianCost = 0;

            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF title1Length = graphics.MeasureString("Lecturers Report", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));
                SizeF title2Length = graphics.MeasureString("Balhamc College", new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point));

                g.DrawString("Lecturers Report", titleFont, brush, (rightMargin + 100) / 2 - title1Length.Width / 2, topMargin);
                linesSoFar++;
                g.DrawString("Balhamc College", titleFont, brush, (rightMargin + 100) / 2 - title2Length.Width / 2, topMargin + (linesSoFar * titleFont.Height));
                linesSoFar = linesSoFar + 4;
            }
        }

        
    }
}
