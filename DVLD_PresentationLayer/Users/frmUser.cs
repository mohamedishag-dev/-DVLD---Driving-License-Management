using DVLD_BusinessLayer;
using DVLD_PresentationLayer.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Users
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            _FillUsersInComoboBox();
            dgvUsers.DataSource = clsUser.GetAllUsers();
            lblTotalRecods.Text = dgvUsers.Rows.Count.ToString();

            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));
        }

        private void _FillUsersInComoboBox()
        {
            cbFilter.SelectedIndex = 0;
            DataTable dtPeople = clsUser.GetAllUsers();
            cbFilter.Items.AddRange(dtPeople.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray());
        }

        private void showDetalisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object UserID = dgvUsers.CurrentRow.Cells[0].Value.ToString();

            if (int.TryParse(UserID.ToString(), out int userID))
            {
                frmUserDitels UserDetailsForm = new frmUserDitels(userID);
                UserDetailsForm.ShowDialog();
            }

            dgvUsers.DataSource = clsUser.GetAllUsers();
            lblTotalRecods.Text = dgvUsers.Rows.Count.ToString();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.ShowDialog();
            this.Refresh();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit User Clicked");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object UserID = dgvUsers.CurrentRow.Cells[0].Value.ToString();

            if (int.TryParse(UserID.ToString(), out int userID))
            {
                if (MessageBox.Show($"Are you sure you want to delete this user [{userID.ToString()}]?", "Confirm Delete",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsUser.DeleteUser(userID))
                    {
                        MessageBox.Show($"Person id [{userID}] was delete.");
                    }
                    else
                        MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

         
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Password Clicked");
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Email Clicked");
        }
       
        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Call Clicked");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            object UserID = dgvUsers.CurrentRow.Cells[0].Value.ToString();

            if (int.TryParse(UserID.ToString(), out int userID))
            {
                frmUserDitels UserInfo = new frmUserDitels(userID);
                UserInfo.ShowDialog();
            }

        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {

            DataTable dtUsers = clsUser.GetAllUsers();

            if (txtFiltering.Text == "")
            {
                dgvUsers.DataSource = dtUsers.DefaultView;
                lblTotalRecods.Text = dtUsers.DefaultView.Count.ToString();
                return;
            }

            string FilterBy = cbFilter.Text;


            if (FilterBy == "UserID")
            {
                if (int.TryParse(txtFiltering.Text, out int UserID))
                    dtUsers.DefaultView.RowFilter = $"UserID = {UserID}";
                else
                {
                    txtFiltering.Text = txtFiltering.Text.Remove(txtFiltering.Text.Length - 1);
                    return;
                }
            }

            if (FilterBy == "PersonID")
            {
                if (int.TryParse(txtFiltering.Text, out int PersonID))
                    dtUsers.DefaultView.RowFilter = $"PersonID = {PersonID}";
                else
                {
                    txtFiltering.Text = txtFiltering.Text.Remove(txtFiltering.Text.Length - 1);
                    return;
                }
            }


            else if (FilterBy == "FullName")
                dtUsers.DefaultView.RowFilter = $"FullName LIKE '{txtFiltering.Text}%'";

            else if (FilterBy == "UserName")
                dtUsers.DefaultView.RowFilter = $"UserName LIKE '{txtFiltering.Text}%'";


            if (dtUsers != null)
            {
                dgvUsers.DataSource = dtUsers.DefaultView;
                lblTotalRecods.Text = dtUsers.DefaultView.Count.ToString();
            }
        }

        private void cbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbFilter.Text == "IsActive")
            {
                cbActives.Visible = true;
                txtFiltering.Visible = false;
                cbActives.SelectedIndex = 0;

            }
            else if (cbFilter.Text != "Active")
            {
                cbActives.Visible = false;
                txtFiltering.Visible = true;
                txtFiltering.Focus();
            }


        }

        private void cbActives_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtUsers = clsUser.GetAllUsers();

            if (cbActives.Text == "Yes")
                dtUsers.DefaultView.RowFilter = "IsActive = true";
            else if (cbActives.Text == "No")
                dtUsers.DefaultView.RowFilter = "IsActive = false";


            dgvUsers.DataSource = dtUsers.DefaultView;
            lblTotalRecods.Text = dgvUsers.Rows.Count.ToString();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.ShowDialog();
            this.Refresh();
        }

    }
}
