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

        int _PersonIDE = -1;

        private void frmBase_Load(object sender, EventArgs e)
        {
            ctrlPersonWithFilter1.DataBack += butto_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clsPerson.Find(_PersonIDE).NationalNo);
        }

        private void butto_Click(object sender, int PersonID)
        {
            _PersonIDE = PersonID;
        }
       

    }
}