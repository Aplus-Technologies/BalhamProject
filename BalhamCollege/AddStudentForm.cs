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
    public partial class AddStudentForm : Form
    {
        //declare global variables
        private DataController DC;
        private EnrolmentsClerkForm frmEnrolMenu;
        public AddStudentForm(DataController dc, EnrolmentsClerkForm enrolmnu)
        {
            InitializeComponent();
            DC = dc;
            frmEnrolMenu = enrolmnu;
            frmEnrolMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {// closes form
            this.Close();
            frmEnrolMenu.Show(); 
        }
    }
}
