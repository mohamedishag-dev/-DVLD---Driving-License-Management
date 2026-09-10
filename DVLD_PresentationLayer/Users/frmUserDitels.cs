using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Users
{
    public partial class frmUserDitels : Form
    {
        private int _UserID;
        public frmUserDitels(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));
            LoadUserCard();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        public void LoadUserCard()
        {

            clsUser userInfo = clsUser.Find(_UserID);
            ctrlPresonCard1.LoadPresonCard(userInfo.PersonID);

            if (userInfo != null)
            {
                lblUserID.Text = userInfo.UserID.ToString();
                lblUserName.Text = userInfo.UserName;
                lblIsActive.Text = userInfo.IsActive ? "Yes" : "No";
            }
        }

    }
}
