using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class ctrlUserCard : UserControl
    {

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void ctrlUserCard_Load(object sender, EventArgs e)
        {
            // clsUser userInfo = clsUser.Find(_UserID);
            // ctrlPresonCard1.LoadPresonCard(userInfo.PersonID);
            //
            // if (userInfo != null)
            // {
            //     lblUserID.Text = userInfo.UserID.ToString();
            //     lblUserName.Text = userInfo.UserName;
            //     lblIsActive.Text = userInfo.IsActive ? "Yes" : "No";
            // }
        }

        public void LoadUserCard(int userID)
        {

            clsUser userInfo = clsUser.Find(userID);
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
