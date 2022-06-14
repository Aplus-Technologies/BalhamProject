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
    public partial class StudentBackgroundForm : Form
    {
        private StudentsSupportClerkForm frmStud;
        public StudentBackgroundForm(StudentsSupportClerkForm std)
        {
            InitializeComponent();
            frmStud = std;
            frmStud.Hide();
        }
    }
}
