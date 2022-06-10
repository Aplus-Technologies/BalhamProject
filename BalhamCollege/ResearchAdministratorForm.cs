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
            //show Remove Research Project form upon click
            if (frmRemoveResearchProject == null)
            {
                frmRemoveResearchProject = new RemoveResearchProjectForm(DC, this);
            }
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
        { //show Delete Research Topic form upon click
            if (frmDeleteResearchTopic == null)
            {
                frmDeleteResearchTopic = new DeleteResearchTopicForm(DC, this);
            }
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

        private void btnProduceResearchReport_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.Show();
        }
    }
}
