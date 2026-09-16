using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Manage_Test_Types
{
    public partial class frmUpdateTestType : Form
    {

        private int _TestTypeID = -1;
        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            this._TestTypeID = TestTypeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdtaeTestType_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));

            Image imgSave = Properties.Resources.Save_32;
            btnSave.Image = new Bitmap(imgSave, new Size(24, 24));

            clsTestType TestType = clsTestType.Find(_TestTypeID);
            lblApplicationTypeID.Text = TestType.TestTypeID.ToString();
            txtTypeTitle.Text = TestType.TestTypeTitle;
            txtDescription.Text = TestType.TestTypeDescription;
            txtFees.Text = ((int)TestType.TestTypeFees).ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTestType TestType = clsTestType.Find(_TestTypeID);
            TestType.TestTypeTitle = txtTypeTitle.Text.Trim();
            TestType.TestTypeDescription = txtDescription.Text.Trim();

            if (int.TryParse(txtFees.Text, out int Fess))
                TestType.TestTypeFees = Fess;

            if (TestType.UpdateTestType())
                this.Close();
        }

        private void ValidateEmptyTestBox(object sender, CancelEventArgs e)
        {

            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

    }
}
