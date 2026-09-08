using DVLD_BusinessLayer;
using DVLD_PresentationLayer.People;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmPerson : frmBase
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        private void frmPreson_Load(object sender, EventArgs e)
        {

            this.Tital = "Manage People";
            this.BaseImage = Properties.Resources.People_400;

            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));

            _FillAllPeople();
            _FillPeopeleInComoboBox();
            txtFiltering.Enabled = false;

        }

        private void _FillPeopeleInComoboBox()
        {

            DataTable dtPeople = clsPerson.GetAllPeople();
            dtPeople.Columns.Remove("Gendor");
            dtPeople.Columns.Remove("Address");
            dtPeople.Columns.Remove("ImagePath");
            dtPeople.Columns.Remove("DateOfBirth");
            cbFilter.Items.AddRange(dtPeople.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray());
            cbFilter.SelectedIndex = 0;

        }

        private void showDitelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object PersonID = dgvPeople.CurrentRow.Cells[0].Value.ToString();

            if (int.TryParse(PersonID.ToString(), out int personID))
            {
                frmPresonDitels presonDetailsForm = new frmPresonDitels(personID);
                presonDetailsForm.ShowDialog();
            }
            _FillAllPeople();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addPersonForm = new frmAddEditPerson(-1);
            addPersonForm.ShowDialog();
            _FillAllPeople();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object PersonID = dgvPeople.CurrentRow.Cells[0].Value.ToString();

            if (int.TryParse(PersonID.ToString(), out int personID))
            {
                frmAddEditPerson editPersonForm = new frmAddEditPerson(personID);
                editPersonForm.ShowDialog();
            }
            _FillAllPeople();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object PersonID = dgvPeople.CurrentRow.Cells[0].Value.ToString();
            if (int.TryParse(PersonID.ToString(), out int personID))
            {
                if (MessageBox.Show($"Are you sure you want to delete this person [{PersonID.ToString()}]?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsPerson.DeletePerson(personID))
                    {
                        MessageBox.Show($"Person id [{PersonID}] was delete.");
                    }
                    else
                    {
                        MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }

            _FillAllPeople();

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Email Clicked");

        }

        private void phoneCallToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Call Clicked");

        }

        private void dgvPeople_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            object PersonID = dgvPeople.CurrentRow.Cells[0].Value.ToString();

            if (int.TryParse(PersonID.ToString(), out int personID))
            {
                frmPresonDitels presonDetailsForm = new frmPresonDitels(personID);
                presonDetailsForm.ShowDialog();
            }
        }

        private void _FillAllPeople()
        {

            DataTable dtPeople = new DataTable("People");

            dtPeople = clsPerson.GetAllPeople();
            dtPeople.Columns.Add("Gender", typeof(string));

            dtPeople.Columns.Remove("ImagePath");
            dtPeople.Columns.Remove("Address");

            DataRow[] ResultRows = dtPeople.Select();

            foreach (var item in ResultRows)
            {
                item["Gender"] = item["Gendor"].ToString() == "0" ? "Male" : "Female";
            }
            dtPeople.Columns.Remove("Gendor");

            dgvPeople.DataSource = dtPeople;
            lblTotalRecods.Text = dtPeople.Rows.Count.ToString();

        }

        private void btnAddPreson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addPersonForm = new frmAddEditPerson(-1);
            addPersonForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cbFilter.SelectedIndex != 0)
            {
                txtFiltering.Enabled = true;
                txtFiltering.Focus();
            }
            else
                txtFiltering.Enabled = false;
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            DataTable dtPeople = clsPerson.GetAllPeople();
            dtPeople.Columns.Add("Gender", typeof(string));

            dtPeople.Columns.Remove("ImagePath");
            dtPeople.Columns.Remove("Address");

            DataRow[] ResultRows = dtPeople.Select();

            foreach (var item in ResultRows)
            {
                item["Gender"] = item["Gendor"].ToString() == "0" ? "Male" : "Female";
            }
            dtPeople.Columns.Remove("Gendor");


            if (txtFiltering.Text == "")
            {
                dgvPeople.DataSource = dtPeople.DefaultView;
                lblTotalRecods.Text = dtPeople.DefaultView.Count.ToString();
                return;
            }

            string FilterBy = cbFilter.Text;


            if (FilterBy == "PersonID")
            {
                if (int.TryParse(txtFiltering.Text, out int PersonID))
                    dtPeople.DefaultView.RowFilter = $"PersonID = {PersonID}";
                else
                {
                    txtFiltering.Text = txtFiltering.Text.Remove(txtFiltering.Text.Length - 1);
                    return;
                }
            }

            else if (FilterBy == "NationalNo")
                dtPeople.DefaultView.RowFilter = $"NationalNo LIKE '{txtFiltering.Text}%'";

            else if (FilterBy == "FirstName")
                dtPeople.DefaultView.RowFilter = $"FirstName LIKE '{txtFiltering.Text}%'";

            else if (FilterBy == "SecondName")
                dtPeople.DefaultView.RowFilter = $"SecondName LIKE '{txtFiltering.Text}%'";

            else if (FilterBy == "ThirdName")
                dtPeople.DefaultView.RowFilter = $"ThirdName LIKE '{txtFiltering.Text}%'";

            else if (FilterBy == "LastName")
                dtPeople.DefaultView.RowFilter = $"LastName LIKE '{txtFiltering.Text}%'";

            else if (FilterBy == "Email")
                dtPeople.DefaultView.RowFilter = $"Email LIKE '{txtFiltering.Text}%'";

            else if (FilterBy == "Phone")
                dtPeople.DefaultView.RowFilter = $"Phone LIKE '{txtFiltering.Text}%'";

            else if (FilterBy == "Nationality")
                dtPeople.DefaultView.RowFilter = $"Nationality LIKE '{txtFiltering.Text}%'";

            if (dtPeople != null)
            {
                dgvPeople.DataSource = dtPeople.DefaultView;
                lblTotalRecods.Text = dtPeople.DefaultView.Count.ToString();
            }
        }


    }


}
