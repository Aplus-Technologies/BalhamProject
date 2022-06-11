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
    public partial class ResearchBackgroundForm : Form
    {
        private ResearchAdministratorForm frmResearch;
        public ResearchBackgroundForm(ResearchAdministratorForm rsch)
        {
            InitializeComponent();
            frmResearch = rsch;
            frmResearch.Hide();
        }
    }
}
