using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.People
{
    public partial class frmAddEditPerson : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPerson _Person;

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            this.dtpDateOfBirth.MaxDate = DateTime.Now.Subtract(TimeSpan.FromDays(18 * 365));
            this.dtpDateOfBirth.Value = this.dtpDateOfBirth.MaxDate;


            _PersonID = PersonID;

            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.Close_32;
            btnClose.Image = new Bitmap(imgEidt, new Size(24, 24));

            Image imgSave = Properties.Resources.Save_32;
            btnSave.Image = new Bitmap(imgSave, new Size(24, 24));

            _FillCountriesInComoboBox();
            cbCountry.SelectedIndex = 164;

            rbMale.Checked = true;
            imgImagePath.Image = Properties.Resources.Male_512;

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
            mtxtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gendor == 0)
            {
                rbMale.Checked = true;

                if (_Person.ImagePath != "")
                    if (File.Exists(_Person.ImagePath))
                    {
                        imgImagePath.Load(_Person.ImagePath);
                        llRemoveImage.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("could not find this image." + _Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        imgImagePath.Image = Properties.Resources.Male_512;
                    }
            }
            else
            {
                rbFemale.Checked = true;
                if (_Person.ImagePath == "")
                {
                    imgImagePath.Image = Properties.Resources.Female_512;
                    llRemoveImage.Visible = true;
                }
                else
                    imgImagePath.Load(_Person.ImagePath);

            }
            llRemoveImage.Visible = (_Person.ImagePath != "");

            //this will select the country in the combobox.
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Person.NationalityCountryID).CountryName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                //   e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "First Name should have a value!");
            }
            else
            {
                e.Cancel = false;
                //  txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, null);
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
                // MessageBox.Show("Selected Image is:" + selectedFilePath);
                imgImagePath.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;

            if (!string.IsNullOrEmpty(txtFirstName.Text))
                _Person.FirstName = txtFirstName.Text;

            if (!string.IsNullOrEmpty(txtSecondName.Text))
                _Person.SecondName = txtSecondName.Text;

            if (!string.IsNullOrEmpty(txtThirdName.Text))
                _Person.ThirdName = txtThirdName.Text;

            if (!string.IsNullOrEmpty(txtLastName.Text))
                _Person.LastName = txtLastName.Text;

            if (!string.IsNullOrEmpty(txtNationailNO.Text))
                _Person.NationalNo = txtNationailNO.Text;

            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gendor = 0;
            else
                _Person.Gendor = 1;

            if (!string.IsNullOrEmpty(mtxtPhone.Text))
                _Person.Phone = mtxtPhone.Text;

            if (!string.IsNullOrEmpty(txtEmail.Text))
                _Person.Email = txtEmail.Text;

            if (!string.IsNullOrEmpty(txtAddress.Text))
                _Person.Address = txtAddress.Text;

            _Person.NationalityCountryID = NationalityCountryID;

            if (imgImagePath.ImageLocation != null)
            {
                string selectedFilePath = openFileDialog1.FileName;

                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    File.Delete(_Person.ImagePath);
                }

                File.Copy(selectedFilePath, Path.Combine(@"D:\DVLD-People-Images\", Path.GetFileName(selectedFilePath)), true);

                _Person.ImagePath = Path.Combine(@"D:\DVLD-People-Images\", Path.GetFileName(selectedFilePath));
            }
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully.");

                _Mode = enMode.Update;
                lblMode.Text = "Edit Person ID = " + _Person.PersonID;
                lblPersonID.Text = _Person.PersonID.ToString();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                cbCountry.Items.Add(row["CountryName"]);

            }

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            imgImagePath.ImageLocation = null;
            llRemoveImage.Visible = false;

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(_Person.ImagePath))
            {
                imgImagePath.Image = Properties.Resources.Female_512;
            }

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(_Person.ImagePath))
            {
                imgImagePath.Image = Properties.Resources.Male_512;
            }

        }

        private void mtxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(mtxtPhone.Text))
            {
                //    e.Cancel = true;
                errorProvider1.SetError(mtxtPhone, "Phone should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtPhone, null);
            }
        }


    }
}
