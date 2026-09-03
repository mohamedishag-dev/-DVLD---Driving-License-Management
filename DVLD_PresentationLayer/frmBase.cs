using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmBase : Form
    {
        protected string Tital
        {
            set { lblTitle.Text = value; }
            get { return lblTitle.Text; }
        }

        protected Image BaseImage
        {
            set { pbBase.Image = value; }
            // get { return pbBase.Image; }
        }

        //protected DataGridView BaseGridView
        //{
        //    set { dgvAllPeople = value; }
        //     get { return dgvAllPeople; }
        //}

        public frmBase()
        {
            InitializeComponent();
        }
        private void frmBase_Load(object sender, EventArgs e)
        {


        }

      

    }
}
