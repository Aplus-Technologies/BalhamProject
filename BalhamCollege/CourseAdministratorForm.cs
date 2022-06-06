﻿using System;
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
        private DeleteAssessmentForm frmDeleteAssessment; // reference to delete assessment form
        public CourseAdministratorForm(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }

        private void btnAddAssessment_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateAssessment_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        { // show delete assessment form 
            if (frmDeleteAssessment == null)
            {
               frmDeleteAssessment = new DeleteAssessmentForm(DC, this);
            }
            frmDeleteAssessment.ShowDialog();
        }

        private void btnProduceAssessmentsReport_Click(object sender, EventArgs e)
        {

        }

        private void btnEnterResult_Click(object sender, EventArgs e)
        {
            if (frmEnterResult == null)
            {
                frmEnterResult = new EnterResultForm(DC, this);
            }
            frmEnterResult.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }
    }
}
