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
    public partial class ProgrammeBackgroundForm : Form
    {
        private ProgrammeAdministratorForm frmProg;
        public ProgrammeBackgroundForm(ProgrammeAdministratorForm prg)
        {
            InitializeComponent();
            frmProg = prg;
            frmProg.Hide();
        }

        private void ProgrammeBackgroundForm_Load(object sender, EventArgs e)
        {

        }
    }
}
