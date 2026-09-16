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
