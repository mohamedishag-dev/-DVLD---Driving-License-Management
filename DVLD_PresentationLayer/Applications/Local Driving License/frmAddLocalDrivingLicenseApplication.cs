using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmAddLocalDrivingLicenseApplication : Form
    {
        clsLocalDrivingLicenseApplication L_D_L_App = new clsLocalDrivingLicenseApplication();
        public frmAddLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void _ResetDefualtValues()
        {
            _FillLeceseClassInComoboBox();

            L_D_L_App.ApplicationInfo.ApplicationTypeID = 1;
            L_D_L_App.ApplicationInfo.PaidFees = clsApplicationType.Find(L_D_L_App.ApplicationInfo.ApplicationTypeID).Fees;
            L_D_L_App.ApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            L_D_L_App.ApplicationInfo.Status = 1;


            btnSave.Enabled = false;
            lblFess.Text = ((int)L_D_L_App.ApplicationInfo.PaidFees).ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblApplicationDate.Text = L_D_L_App.ApplicationInfo.ApplicationDate.ToShortDateString();

        }

        private void _FillLeceseClassInComoboBox()
        {

            cbLecenseClass.DataSource = clsLecenseClass.GetAllLecenseClasss();
            cbLecenseClass.DisplayMember = "ClassName";
            cbLecenseClass.SelectedIndex = 2;
        }

        private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonWithFilter1_OnPersonSelected(int obj)
        {
            if (obj != -1)
            {
                L_D_L_App.ApplicationInfo.ApplicantPersonID = ctrlPersonWithFilter1.PersonID;
                btnSave.Enabled = true;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            L_D_L_App.LicenseClassID = clsLecenseClass.Find(cbLecenseClass.Text.Trim()).LecenseClassID;


            if (L_D_L_App.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDL_ApplicationID.Text = L_D_L_App.LocalDrivingLicenseApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbApplications.SelectedTab = tbApplications.TabPages["tpApplicatinInfo"];

        }
    }
}

