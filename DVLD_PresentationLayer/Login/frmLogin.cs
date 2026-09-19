using DVLD_BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsUser user = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (user == null)
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user.IsActive)
            {

                if (chkRememberMe.Checked)
                    clsGlobal.RememberMe();
                else
                {
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    clsGlobal.Remove();

                }

                clsGlobal.CurrentUser = user;
                this.Hide();
                frmMain MainScreen = new frmMain();
                clsGlobal.RegisterLogIn();
                MainScreen.ShowDialog();
                this.Show();

            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Image imgLogin = Properties.Resources.sign_in_32;
            btnLogin.Image = new Bitmap(imgLogin, new Size(24, 24));


            if (clsGlobal.Login())
            {
                txtUserName.Text = clsGlobal.CurrentUser.UserName;
                txtPassword.Text = clsGlobal.CurrentUser.Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}