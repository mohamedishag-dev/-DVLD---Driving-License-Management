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

            if (!this.ValidateChildren())
            {
                //Here we don't continue becuase the from is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon");
                return;
            }

            clsUser user = clsUser.Find(_UserID);

            if (user.Password == txtCrruentPassword.Text.Trim())
            {

                if (txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim() && txtNewPassword.Text.Trim() != "")
                    user.Password = txtNewPassword.Text.Trim();
                else
                    MessageBox.Show("Confirm Password Does Not Match Password!");

            }
            else
            {
                MessageBox.Show("Crruent Password is not true");
                return;
            }


            if (user.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");
        }

        private void txtCrruentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (txtCrruentPassword.Text != clsUser.Find(_UserID).Password)
            {
                errorProvider1.SetError(txtCrruentPassword, "Crruent Password is wrong!");
            }
            else
            {
                errorProvider1.SetError(txtCrruentPassword, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateEmptyTestBox(object sender, CancelEventArgs e)
        {

            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text))
            {
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

    }
}
