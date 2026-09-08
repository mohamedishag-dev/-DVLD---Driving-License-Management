using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD_PresentationLayer
{
    public partial class ctrlPresonCard : UserControl
    {
        private clsPerson _Person = null;
        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public ctrlPresonCard()
        {
            InitializeComponent();
        }

        public void LoadPresonCard(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person == null)
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                _LoadPresonInfo();

        }

        public void LoadPresonCard(string NationailNO)
        {
            _Person = clsPerson.Find(NationailNO);

            if (_Person == null)
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                _LoadPresonInfo();

        }

        private void _LoadPresonInfo()
        {

            lblPresonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblNationailNO.Text = _Person.NationalNo;
            lblPhone.Text = _Person.Phone;
            
            if (_Person.Gendor == 0)
            {
                lblGedor.Text = "Male";
                pbPersonImage.Image = Properties.Resources.Male_5121;
            }
            else
            {
                lblGedor.Text = "Female";
                pbPersonImage.Image = Properties.Resources.Female_512;
            }

            lblEmail.Text = _Person.Email;
            lblDateOfBrith.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lblAddress.Text = _Person.Address;

            if (_Person.Gendor == 0)
                pbPersonImage.Image = Properties.Resources.Male_5121;
            else
                pbPersonImage.Image = Properties.Resources.Female_512;

            if (_Person.ImagePath != "")
                if (System.IO.File.Exists(_Person.ImagePath))
                    pbPersonImage.Load(_Person.ImagePath);
                else
                    MessageBox.Show("could not find this image." + _Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
