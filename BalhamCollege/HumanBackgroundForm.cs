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
    public partial class HumanBackgroundForm : Form
    {
        private HumanResourcesClerkForm frmHuman;
        public HumanBackgroundForm(HumanResourcesClerkForm hmn)
        {
            InitializeComponent();
            frmHuman = hmn;
            frmHuman.Hide();
        }
    }
}
