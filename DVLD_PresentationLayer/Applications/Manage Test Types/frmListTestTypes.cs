using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Tests;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Manage_Test_Types
{
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));

            dgvTestTypes.DataSource = clsTestType.GetAllTestTypes();
            dgvTestTypes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTestTypes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lblRecordsCount.Text = dgvTestTypes.RowCount.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateTestType((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            //revrsh
            dgvTestTypes.DataSource = clsTestType.GetAllTestTypes();
            lblRecordsCount.Text = dgvTestTypes.Rows.Count.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
