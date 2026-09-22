using DVLD_Business;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Manage_Test_Types
{
    public partial class frmUpdateTestType : Form
    {

        private int _TestTypeID = -1;
        private clsTestType _TestType ;
        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdtaeTestType_Load(object sender, EventArgs e)
        {

            _TestType = clsTestType.Find(_TestTypeID);
            lblApplicationTypeID.Text = _TestType.TestTypeID.ToString();
            txtTypeTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txtFees.Text = ((int)_TestType.TestTypeFees).ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.TestTypeTitle = txtTypeTitle.Text.Trim();
            _TestType.TestTypeDescription = txtDescription.Text.Trim();

            if (int.TryParse(txtFees.Text, out int Fess))
                _TestType.TestTypeFees = Fess;

            if (_TestType.Save())
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
