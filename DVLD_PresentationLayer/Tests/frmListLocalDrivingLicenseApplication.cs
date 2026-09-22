using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmListLocalDrivingLicenseApplication : Form
    {
        public frmListLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            dgvLDL_Application.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplication();

            lblRecordsCount.Text = dgvLDL_Application.RowCount.ToString();
            if (dgvLDL_Application.RowCount > 0) 
            {
                dgvLDL_Application.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLDL_Application.Columns[0].Width = 100;

                dgvLDL_Application.Columns[1].HeaderText = "Driving Class";
                dgvLDL_Application.Columns[1].Width = 190;

                dgvLDL_Application.Columns[2].HeaderText = "National No.";
                dgvLDL_Application.Columns[2].Width = 100;

                dgvLDL_Application.Columns[3].HeaderText = "FullName";
                dgvLDL_Application.Columns[3].Width = 300;

                dgvLDL_Application.Columns[4].HeaderText = "Application Date Name";
                dgvLDL_Application.Columns[4].Width = 140;

                dgvLDL_Application.Columns[5].HeaderText = "Status";
                dgvLDL_Application.Columns[5].Width = 100;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Status")
            {
                txtFilterValue.Visible = false;
                cbStatus.Visible = true;
                cbStatus.SelectedIndex = 0;
                cbStatus.Focus();
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbStatus.Visible = false;
                txtFilterValue.Focus();
            }
       
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
