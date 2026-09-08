using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsPerson;

namespace DVLD_PresentationLayer
{
    public partial class frmTest : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPerson _Person;


        public frmTest(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Close button clicked");
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                //    e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "First Name should have a value!");
            }
            else
            {
                e.Cancel = false;
                //  txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, null);
            }

        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtSecondName.Text))
            {
                errorProvider1.SetError(txtSecondName, "Second Name should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSecondName, null);
            }

        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtThirdName.Text))
            {
                //    e.Cancel = true;
                errorProvider1.SetError(txtThirdName, "Third Name should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtThirdName, null);
            }

        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                //    e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Last Name should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, null);
            }
        }

        private void txtNationailNO_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationailNO.Text))
            {
                //    e.Cancel = true;
                errorProvider1.SetError(txtNationailNO, "National Number should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationailNO, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                //    e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Email should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                //    e.Cancel = true;
                errorProvider1.SetError(txtAddress, "Address should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, null);
            }
        }

        private void llOpenFileDialog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
                // ...
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;

            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNationailNO.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gendor = 0;
            else
                _Person.Gendor = 1;

            _Person.Phone = txtPhone.Text;
            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            _Person.NationalityCountryID = NationalityCountryID;

            if (pictureBox1.ImageLocation != null)
                _Person.ImagePath = pictureBox1.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;
            lblMode.Text = "Edit Person ID = " + _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();

        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                cbCountry.Items.Add(row["CountryName"]);

            }

        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            _FillCountriesInComoboBox();
            cbCountry.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Person";
                _Person = new clsPerson();
                return;
            }

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Person with ID = " + _PersonID);
                this.Close();

                return;
            }

            lblMode.Text = "Edit Person ID = " + _PersonID;
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
             txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationailNO.Text = _Person.NationalNo;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.ImagePath != "")
            {
              //  pictureBox1.Load(_Person.ImagePath);
            }

            llRemoveImage.Visible = (_Person.ImagePath != "");

            //this will select the country in the combobox.
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Person.NationalityCountryID).CountryName);
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pictureBox1.ImageLocation = null;
            llRemoveImage.Visible = false;

        }

    }
}
