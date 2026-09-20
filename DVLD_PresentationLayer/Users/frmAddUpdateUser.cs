using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        private int _PersonID = -1;
        private clsUser _User;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;
        }

        private void _LoadData()
        {

            _User = clsUser.Find(_UserID);

            if (!clsUser.IsUserExist(_UserID))
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            checkbIsActive.Checked = _User.IsActive;
            txtConfirmPassword.Text = _User.Password;
            ctrlPersonWithFilter1.LoadPersonInfo(_User.PersonID);
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            Image imgEidt = Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));

            Image imgSave = Resources.Save_32;
            btnSave.Image = new Bitmap(imgSave, new Size(24, 24));

            Image imgNext = Resources.Next_64;
            btnNext.Image = new Bitmap(imgNext, new Size(24, 24));

            Image imgPrev = Resources.Prev_64;
            btnPrev.Image = new Bitmap(imgPrev, new Size(24, 24));


            _ResetDefualtValues();

            if (_Mode == enMode.Update)
            {
                _LoadData();
                lblTitle.Text = "Update User";
                ctrlPersonWithFilter1.FilterEnabled = false;
            }

        }

        private void _ResetDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                _User = new clsUser();
            }
            else
            {
                lblTitle.Text = "Update User";

            }

            lblUserID.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            checkbIsActive.Checked = true;

            btnNext.Enabled = false;
            btnSave.Enabled = false;
            tabpLoginInfo.Enabled = false;
            ctrlPersonWithFilter1.FilterEnabled = true;
        }

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

        private void ctrlPersonWithFilter1_OnPersonSelected(int obj)
        {

            if (_Mode == enMode.AddNew)
            {

                if (clsUser.IsUserExistByPersonID(obj))
                {
                    MessageBox.Show("Selected Person alordy has a user. Chose another one", "Select another Person",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnNext.Enabled = false;
                    btnSave.Enabled = false;
                    tabpLoginInfo.Enabled = false;
                    return;
                }
            }


            if (obj == -1)
            {
                btnNext.Enabled = false;
                btnSave.Enabled = false;
                tabpLoginInfo.Enabled = false;
                return;
            }
            _PersonID = obj;
            btnNext.Enabled = true;
            btnSave.Enabled = true;
            tabpLoginInfo.Enabled = true;

        }

        private void ValidateEmptyTestBox(object sender, CancelEventArgs e)
        {

            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we don't continue becuase the from is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon");
                return;
            }

            if (_User != null)
            {
                _User.PersonID = _PersonID;
                _User.UserName = txtUserName.Text.Trim();
                _User.Password = txtPassword.Text.Trim();
                _User.IsActive = (checkbIsActive.Checked);

            }

            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirm does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
    }

}