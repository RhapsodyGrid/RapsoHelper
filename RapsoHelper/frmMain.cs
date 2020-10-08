using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapsoHelper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tableUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.frmUserMain _frmuser = new user.frmUserMain();
            _frmuser.Show();
        }
    }
}
