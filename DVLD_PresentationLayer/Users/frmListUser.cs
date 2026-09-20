using System;
using System.Data;
using System.Drawing;
using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Users
{
    public partial class frmListUser : Form
    {
        private static DataTable _dtAllUsers = clsUser.GetAllUsers();

        private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID", "FullName",
                                                       "UserName", "IsActive");
        public frmListUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));

            cbFilterBy.SelectedIndex = 0;
            dgvUsers.DataSource = _dtUsers;
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            lblRecordsCount.Text = _dtUsers.Rows.Count.ToString();

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[4].HeaderText = "Is Active";

            }
        }

        private void _RefreshUsersList()
        {

            _dtAllUsers = clsUser.GetAllUsers();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID", "FullName",
                                                       "UserName", "IsActive");

            dgvUsers.DataSource = _dtUsers.DefaultView;
            lblRecordsCount.Text = _dtUsers.Rows.Count.ToString();

        }

        private void showDetalisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();

            //refresh
            _RefreshUsersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete this user [{UserID.ToString()}]?", "Confirm Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show($"Person id [{UserID}] was delete.");

                    //refresh dgvUsers
                    _RefreshUsersList();
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            //refresh dgvUsers
            _RefreshUsersList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "UserID")
                //in this case we deal with integer not string.
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());

            else if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();

            //refresh dgvUsers
            _RefreshUsersList();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtUsers.DefaultView.RowFilter = "";

            if (cbFilterBy.Text == "None")
            {
                cbIsActive.Visible = false;
                txtFilterValue.Visible = false;
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;

            }
            else if (cbFilterBy.Text == "Is Active")
            {
                cbIsActive.Visible = true;
                txtFilterValue.Visible = false;
                cbIsActive.SelectedIndex = 0;
                return;
            }
            else
            {
                cbIsActive.Visible = false;
                txtFilterValue.Visible = true;
                txtFilterValue.Focus();
            }

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtUsers.DefaultView.RowFilter = "";

            if (cbIsActive.Text == "Yes")
                _dtUsers.DefaultView.RowFilter = "IsActive = true";
            else if (cbIsActive.Text == "No")
                _dtUsers.DefaultView.RowFilter = "IsActive = false";

            dgvUsers.DataSource = _dtUsers.DefaultView;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            //refresh dgvUsers
            _RefreshUsersList();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
