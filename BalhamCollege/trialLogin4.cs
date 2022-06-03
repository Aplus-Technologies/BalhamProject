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
    public partial class trialLogin4 : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        public trialLogin4(DataController dc, LoginForm lgin)
        {
            InitializeComponent();
            InitializeComponent();
            DC = dc;
            frmLogin = lgin;
            frmLogin.Hide();
        }
    }
}
