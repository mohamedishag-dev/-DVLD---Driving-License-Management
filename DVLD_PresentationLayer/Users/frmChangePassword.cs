using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        public frmChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

            Image imgCancel = Properties.Resources.Close_32;
            btnCancel.Image = new Bitmap(imgCancel, new Size(24, 24));

            Image imgSave = Properties.Resources.Save_32;
            btnSave.Image = new Bitmap(imgSave, new Size(24, 24));

            LoadUserCard();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            clsUser user = clsUser.Find(_UserID);

            if (user.Password == txtCrruentPassword.Text)
            {

                if (!string.IsNullOrEmpty(txtNewPassword.Text))
                {
                    if (txtNewPassword.Text == txtNewPassword.Text)
                        user.Password = txtNewPassword.Text;
                    else
                        MessageBox.Show("Confirm Password Not Equal Password");
                }
                else
                    MessageBox.Show("New Password Is Null Or Empty");

            }
            else
            {
                MessageBox.Show("Crruent Password is not true");
                return;
            }

            if (user != null)
            {
                if (user.Save())
                {
                    MessageBox.Show("Data Saved Successfully.");
                    lblUserID.Text = user.UserID.ToString();
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.");

            }

        }

        private void txtCrruentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                errorProvider1.SetError(txtNewPassword, "New Password should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
