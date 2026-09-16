using DVLD_BusinessLayer;
using System;
using System.Drawing;
using System.IO;
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
            try
            {
                
                string UserName = txtUserName.Text;
                string Password = txtPassword.Text;

                clsGlobal.CurrentUser = clsUser.Find(UserName, Password);

                if (clsGlobal.CurrentUser == null)
                {
                    MessageBox.Show($"Invaled UserName & Password", "Wrong ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 

                if (clsGlobal.CurrentUser.IsActive)
                {

                    if (chkRememberMe.Checked)
                        clsGlobal.RememberMe();
                    else
                    {
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        clsGlobal.Remove();

                    }


                    frmMain MainScreen = new frmMain();
                    this.Hide();
                    clsGlobal.RegisterLogIn();
                    MainScreen.ShowDialog();
                    this.Show();

                }

                else
                    MessageBox.Show($"The User [{clsGlobal.CurrentUser.UserName}], is not Active", "Wrong ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

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
  
            chkRememberMe.Checked = true;

            if (clsGlobal.Login())
            {
                txtUserName.Text = clsGlobal.CurrentUser.UserName;
                txtPassword.Text = clsGlobal.CurrentUser.Password;
            }

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