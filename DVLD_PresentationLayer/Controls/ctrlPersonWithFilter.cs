using DVLD_BusinessLayer;
using DVLD_PresentationLayer.People;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class ctrlPersonWithFilter : UserControl
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        public ctrlPersonWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlFindPerson_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            string txtSearch = txtFilter.Text.Trim();

            if (cbFilter.SelectedIndex == 0)
            {
                ctrlPresonCard1.LoadPresonCard(txtSearch);
                DataBack?.Invoke(this, clsPerson.Find(txtSearch).PersonID);
            }
            else
            {
                if (int.TryParse(txtSearch.ToString(), out int PersonID))
                {
                    ctrlPresonCard1.LoadPresonCard(PersonID);
                    DataBack?.Invoke(this, PersonID);
                }
            }
            txtFilter.Focus();

        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtFilter.Text))
                    return;

                if (!int.TryParse(txtFilter.Text, out int PersonID))
                {
                    txtFilter.Text = txtFilter.Text.Remove(txtFilter.Text.Length - 1);
                    return;
                }

            }
        }

        private void btnAddPreson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addPerson = new frmAddEditPerson(-1);
            addPerson.DataBack += BackPersonID;
            addPerson.ShowDialog();
        }

        private void cbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtFilter.Focus();
        }

        private void BackPersonID(object sender, int personID)
        {
            txtFilter.Text = clsPerson.Find(personID).NationalNo;

            if (int.TryParse(personID.ToString(), out int PersonID))
            {
                ctrlPresonCard1.LoadPresonCard(PersonID);
                DataBack?.Invoke(this, PersonID);
            }
        }

    }
}
