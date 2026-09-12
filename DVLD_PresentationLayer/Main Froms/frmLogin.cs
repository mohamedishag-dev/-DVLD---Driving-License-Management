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

                GlolbalUser.CurrentUser = clsUser.Find(UserName, Password);

                if (GlolbalUser.CurrentUser == null)
                {
                    MessageBox.Show($"Invaled UserName & Password", "Wrong ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 

                if (GlolbalUser.CurrentUser.IsActive)
                {

                    if (chkRememberMe.Checked)
                        GlolbalUser.RememberMe();
                    else
                    {
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        GlolbalUser.Remove();

                    }


                    frmMain MainScreen = new frmMain();
                    this.Hide();
                    GlolbalUser.RegisterLogIn();
                    MainScreen.ShowDialog();
                    this.Show();

                }

                else
                    MessageBox.Show($"The User [{GlolbalUser.CurrentUser.UserName}], is not Active", "Wrong ", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            if (GlolbalUser.Login())
            {
                txtUserName.Text = GlolbalUser.CurrentUser.UserName;
                txtPassword.Text = GlolbalUser.CurrentUser.Password;
            }

        }
    }
}