using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Tests;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmListManageApplicationType : Form
    {
        public frmListManageApplicationType()
        {
            InitializeComponent();
        }

        private void dgvApplicationTypes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frm = new frmUpdateApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            dgvApplicationTypes.DataSource = clsApplicationType.GetAllApplicationTypes();
        }

        private void frmManageApplicationType_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));

            dgvApplicationTypes.DataSource = clsApplicationType.GetAllApplicationTypes();
            lblRecordsCount.Text = dgvApplicationTypes.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            dgvApplicationTypes.DataSource = clsApplicationType.GetAllApplicationTypes();
            lblRecordsCount.Text = dgvApplicationTypes.Rows.Count.ToString();
        }
    }
}
