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

            ctrlUserCard1.LoadUserCard(_UserID);
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
                    MessageBox.Show("Data Saved Successfully.");
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.");
            }

        }

        private void txtCrruentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (txtCrruentPassword.Text != clsUser.Find(_UserID).Password) 
            {
                errorProvider1.SetError(txtCrruentPassword, "Crruent Password is not true!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCrruentPassword, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtNewPassword, "Invaled New Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password is not same New Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
    }
}
