using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapsoHelper.user
{
    public partial class frmUserMain : Form
    {
        public frmUserMain()
        {
            InitializeComponent();
        }

        private void frmUserMain_Load(object sender, EventArgs e)
        {
            statusRelax();
        }

        private void btn_generalList_Click(object sender, EventArgs e)
        {
            statusAction();
            this.usr_userTableAdapter.Fill(this.rapsodyapp_dbDataSet.usr_user);
            lbl_vistaActual.Text = "General User List";
            statusRelax();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusAction();
            this.usr_userTableAdapter.fillOnMigration(this.rapsodyapp_dbDataSet.usr_user);
            lbl_vistaActual.Text = "On Migration User List";
            statusRelax();
        }

        private void statusRelax()
        {
            lbl_status.Text = "Relaxed System !";
            lbl_status.ForeColor = Color.Blue;
        }

        private void statusAction()
        {
            lbl_status.Text = "System Working wait !";
            lbl_status.ForeColor = Color.Green;
        }

        private void btn_migrateUserToPerson_Click(object sender, EventArgs e)
        {
            user.frmMigratorToPerson _migrateToPerson = new user.frmMigratorToPerson();
            _migrateToPerson.Show();
        }
    }
}
