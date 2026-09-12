using DVLD_BusinessLayer;
using DVLD_PresentationLayer.People;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class ctrlPresonCard : UserControl
    {
        private clsPerson _Person = null;
        
        public ctrlPresonCard()
        {
            InitializeComponent();
        }
        private void ctrlPresonCard_Load(object sender, System.EventArgs e)
        {
            imgPerson.Image = Properties.Resources.Male_5121;

        }

        public void LoadPresonCard(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _LoadPresonInfo();

        }

        public void LoadPresonCard(string NationailNO)
        {
            _Person = clsPerson.Find(NationailNO);

            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                imgPerson.Image = Properties.Resources.Male_5121;
            }
            else
            {
                lblGedor.Text = "Female";
                imgPerson.Image = Properties.Resources.Female_512;
            }

            lblEmail.Text = _Person.Email;
            lblDateOfBrith.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lblAddress.Text = _Person.Address;

            if (_Person.Gendor == 0)
                imgPerson.Image = Properties.Resources.Male_5121;
            else
                imgPerson.Image = Properties.Resources.Female_512;

            if (_Person.ImagePath != "")
                if (System.IO.File.Exists(_Person.ImagePath))
                    imgPerson.Load(_Person.ImagePath);
                else
                    MessageBox.Show("could not find this image." + _Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void linkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(_Person.PersonID);  
            frmAddEditPerson.ShowDialog();
            LoadPresonCard(_Person.PersonID);
        }

        private void _ResetPersonInfo()
        {
            imgPerson.Image = Properties.Resources.Male_5121;
            lblPresonID.Text = "N/A";
            lblName.Text = "[????]";
            lblNationailNO.Text = "[????]";
            lblPhone.Text = "[????]";
            lblGedor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblDateOfBrith.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
        }

    }
}
