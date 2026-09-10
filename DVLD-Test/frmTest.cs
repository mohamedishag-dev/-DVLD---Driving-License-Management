using DVLD_PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Test
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            ctrlPresonCard presonCard = new ctrlPresonCard();
            presonCard.LoadPresonCard(1); // Load person card with PersonID = 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPage1.Controls.Clear();
            tabPage1.Controls.Add(new ctrlPresonCard());
        }
    }
}
