using DVLD_BusinessLayer;
using DVLD_PresentationLayer.People;
using System.Windows.Forms;
using System.IO;

namespace DVLD_PresentationLayer
{
    public partial class ctrlPresonCard : UserControl
    {
        private clsPerson _Person;
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
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillPresonInfo();
            _PersonID = _Person.PersonID;

        }

        public void LoadPresonCard(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillPresonInfo();
            _PersonID = _Person.PersonID;

        }

        private void _LoadPresonImage()
        {

            if (_Person.Gendor == 0)
                imgPerson.Image = Properties.Resources.Male_5121;
            else
                imgPerson.Image = Properties.Resources.Female_512;

            if (_Person.ImagePath != "")
                if (File.Exists(_Person.ImagePath))
                    imgPerson.Load(_Person.ImagePath);
                else
                    MessageBox.Show("could not find this image." + _Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPresonInfo()
        {

            lblPresonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblNationailNO.Text = _Person.NationalNo;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblDateOfBrith.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = _Person.countryInfo.CountryName;
            lblAddress.Text = _Person.Address;
            lblGedor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            _LoadPresonImage();

        }

        private void linkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();

            //refresh
            LoadPresonCard(PersonID);
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
