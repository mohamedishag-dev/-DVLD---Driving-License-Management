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
            MessageBox.Show("This is a sample Driver for demonstration purposes.");
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
    }
}
