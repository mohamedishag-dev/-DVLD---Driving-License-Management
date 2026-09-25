using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
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
            int LicenseAppID = int.Parse(textBox1.Text.Trim());

            ctrlLocalDrivingLicenseApplication1.LoadLicenseApplicationCard(LicenseAppID);
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void ctrlLocalDrivingLicenseApplication1_Load(object sender, EventArgs e)
        {

        }
    }
}
