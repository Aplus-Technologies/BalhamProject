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
    public partial class AddProgrammeForm : Form
    {
        //declare global variables
        private DataController DC;
        private ProgrammeAdministratorForm frmProgramAdmin; // reference to Program Administrator Form
        public AddProgrammeForm(DataController dc, ProgrammeAdministratorForm progAdmin)
        {
            InitializeComponent();
            // call the following functions upon form initialization 
            DC = dc;
           frmProgramAdmin = progAdmin;
           frmProgramAdmin.Hide();
        }
    }
}
