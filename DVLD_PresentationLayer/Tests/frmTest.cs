using DVLD_Business;
using DVLD_PresentationLayer.People;
using DVLD_PresentationLayer.Tests;
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


        private void frmBase_Load(object sender, EventArgs e)
        {
         }

        private void dgvApplicationTypes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         

        }

        private void ctrlPersonWithFilter1_OnPersonSelected(int obj)
        {
            MessageBox.Show(obj.ToString());
        }
    }
}