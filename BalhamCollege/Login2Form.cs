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
    public partial class Login2Form : Form
    {
        public Login2Form()
        {
            InitializeComponent();
        }

        private void pbQuitLogin_Click(object sender, EventArgs e)
        {
            // Close form upon click
            Close(); 
        }
    }
}
