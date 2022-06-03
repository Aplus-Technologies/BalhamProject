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
    public partial class ResearchAdministratorForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        public ResearchAdministratorForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }

        private void btnAddResearchProject_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveResearchProject_Click(object sender, EventArgs e)
        {

        }

        private void btnAddResearchTopic_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteResearchTopic_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateResearchTopic_Click(object sender, EventArgs e)
        {

        }

        private void btnProduceResearchReport_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }
    }
}
