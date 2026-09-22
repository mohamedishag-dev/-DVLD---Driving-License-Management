using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmAddLocalDrivingLicenseApplication : Form
    {
        clsLocalDrivingLicenseApplication L_D_L_App = new clsLocalDrivingLicenseApplication();
        clsApplication Application = new clsApplication();
        public frmAddLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void _ResetDefualtValues()
        {
            _FillLeceseClassInComoboBox();

            Application.ApplicationTypeID = 1;
            Application.PaidFees = clsApplicationType.Find(Application.ApplicationTypeID).Fees;
            Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            Application.ApplicationStatus = 1;


            btnSave.Enabled = false;
            lblFess.Text = ((int)Application.PaidFees).ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblApplicationDate.Text = Application.ApplicationDate.ToShortDateString();

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
                Application.ApplicantPersonID = ctrlPersonWithFilter1.PersonID;
                btnSave.Enabled = true;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (Application.Save())
            {
                L_D_L_App.ApplicationID = Application.ApplicationID;
                L_D_L_App.LicenseClassID = clsLecenseClass.Find(cbLecenseClass.Text.Trim()).LecenseClassID;

                if (L_D_L_App.Save())
                {
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

