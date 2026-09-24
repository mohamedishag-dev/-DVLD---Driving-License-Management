using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ApplicantPersonID = int.Parse(textBox1.Text.Trim());
            int LicenseClassID = int.Parse(textBox2.Text.Trim());

            //clsLocalDrivingLicenseApplication App = clsLocalDrivingLicenseApplication.Find(ApplicantPersonID, LicenseClassID);
            //if (App == null)
            //{
            //    MessageBox.Show("App is null!");
            //    return;
            //}
            //MessageBox.Show("L.D.L.Application ID =" + App.LocalDrivingLicenseApplicationID.ToString() + "\n LicenseClass ID =" + App.LicenseClassID.ToString());

            if (clsLocalDrivingLicenseApplication.IsApplicationExist(ApplicantPersonID, LicenseClassID))
            {
                MessageBox.Show("Yes, it is Exist!");
                return;
            }
            else
                MessageBox.Show("No, it is Exist!");

        }
    }
}
