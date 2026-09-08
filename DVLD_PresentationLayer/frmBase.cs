using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public frmBase()
        {
            InitializeComponent();
        }
    }
}
