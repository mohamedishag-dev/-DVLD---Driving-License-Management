using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Users
{
    public partial class frmUserInfo : Form
    {
        private int _UserID;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));
            ctrlUserCard1.LoadUserCard(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
