using DVLD_BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();

        }
        private int _PersonID = -1;

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbctrlAddUser.SelectedIndex = tbctrlAddUser.SelectedIndex + 1;

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tbctrlAddUser.SelectedIndex = tbctrlAddUser.SelectedIndex - 1;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));

            Image imgSave = Properties.Resources.Save_32;
            btnSave.Image = new Bitmap(imgSave, new Size(24, 24));

            Image imgNext = Properties.Resources.Next_64;
            btnNext.Image = new Bitmap(imgNext, new Size(24, 24));

            Image imgPrev = Properties.Resources.Prev_64;
            btnPrev.Image = new Bitmap(imgPrev, new Size(24, 24));

            btnNext.Enabled = false;
            btnSave.Enabled = false;
            tabpLoginInfo.Enabled = false;
            ctrlPersonWithFilter1.DataBack += DataBackWithPersonID;

        }

        private void DataBackWithPersonID(object sender, int personID)
        {
            _PersonID = personID;

            btnNext.Enabled = true;
            btnSave.Enabled = true;
            tabpLoginInfo.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();

            user.PersonID = _PersonID;

            if (clsPerson.IsPersonExist(_PersonID))
            {

                if (!string.IsNullOrEmpty(txtUserName.Text))
                    user.UserName = txtUserName.Text;

                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                        user.Password = txtPassword.Text;
                    else
                        MessageBox.Show("Confirm Password Not Equal Password");
                }

                if (checkbIsActive.Checked)
                    user.IsActive = true;
                else
                    user.IsActive = false;

            }
            else
                MessageBox.Show("Person is not fund");

            if (user != null)
            {
                if (user.Save())
                {
                    MessageBox.Show("Data Saved Successfully.");
                    lblUserID.Text = user.UserID.ToString();
                    btnSave.Enabled = false;
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.");

            }


        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "UserName should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }

        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password currnet have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

    }

}