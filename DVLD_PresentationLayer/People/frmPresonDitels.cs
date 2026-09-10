using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.People
{
    public partial class frmPresonDitels : Form
    {
        private int _PersonID;
        public frmPresonDitels(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void ctrlPresonCard1_Load(object sender, EventArgs e)
        {
            ctrlPresonCard1.LoadPresonCard(_PersonID);
        }

        private void frmPresonDitels_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
