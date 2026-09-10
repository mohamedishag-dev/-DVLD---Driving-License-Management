using DVLD_PresentationLayer.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a sample Driver for demonstration purposes.");
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser users = new frmUser();
            users.MdiParent = this;
            users.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a sample Driver for demonstration purposes.");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            frmPerson frmPeople = new frmPerson();
            frmPeople.MdiParent = this;
            frmPeople.Show();
    
            }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chengPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmChangePassword changePassword = new frmChangePassword(GlolbalUser.CurrentUser.UserID);
            changePassword.MdiParent = this;
            changePassword.Show();
        }

        private void CrruentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDitels UserDetailsForm = new frmUserDitels(GlolbalUser.CurrentUser.UserID);
            UserDetailsForm.ShowDialog();

        }
    }
}
