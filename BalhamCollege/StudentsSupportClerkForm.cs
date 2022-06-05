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
        public StudentsSupportClerkForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }

        private void btnRecordIssue_Click(object sender, EventArgs e)
        {
            if (frmRecordIssue == null)
            {
                frmRecordIssue = new RecordIssueForm(DC, this);
            }
            frmRecordIssue.ShowDialog();
        }

        private void btnProduceIssuesReport_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }
    }
}
