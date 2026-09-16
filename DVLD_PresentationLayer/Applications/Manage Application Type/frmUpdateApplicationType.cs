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
    public partial class frmUpdateApplicationType : Form
    {
        private int _ApplicationTypeID;
        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            this._ApplicationTypeID = ApplicationTypeID;
        }

        private void clsUpdate_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));

            Image imgSave = Properties.Resources.Save_32;
            btnSave.Image = new Bitmap(imgSave, new Size(24, 24));

            clsApplicationType applicationType = clsApplicationType.Find(_ApplicationTypeID);
            lblApplicationTypeID.Text = applicationType.ApplicationTypeID.ToString();
            txtTypeTitle.Text = applicationType.ApplicationTypeTitle.ToString();
            txtFees.Text = applicationType.ApplicationFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsApplicationType applicationType = clsApplicationType.Find(_ApplicationTypeID);
            if (!string.IsNullOrEmpty(txtTypeTitle.Text.Trim()))
                applicationType.ApplicationTypeTitle = txtTypeTitle.Text.Trim();
            else
                return;

            if (decimal.TryParse(txtFees.Text, out decimal Fess)) 
                applicationType.ApplicationFees = Fess;

            if (applicationType.UpdateApplicationType())
                this.Close();
        }
                
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}