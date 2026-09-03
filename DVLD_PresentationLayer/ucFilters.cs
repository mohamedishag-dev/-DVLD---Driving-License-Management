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
    public partial class ucFilters : UserControl
    {
        public ucFilters()
        {
            InitializeComponent();
        }

        private void _FillPeopeleInComoboBox()
        {

            DataTable dtPeople = clsPerson.GetAllPeople();
            DataView dvPeople = new DataView();

            dtPeople.Columns.Remove("Gendor");
            dtPeople.Columns.Remove("Address");
            dtPeople.Columns.Remove("ImagePath");
            dtPeople.Columns.Remove("DateOfBirth");
            dtPeople.Columns.Remove("NationalityCountryID");

            foreach (DataColumn Column in dtPeople.Columns)
            {

                cbFilter.Items.Add(Column.ColumnName);
//                cbSorts.Items.Add(Column.ColumnName);

            }
            cbFilter.SelectedIndex = 0;
            //cbSorts.SelectedIndex = 0;
      
        }



        private void ucFilters_Load(object sender, EventArgs e)
        {
            _FillPeopeleInComoboBox();
            txtFiltering.Enabled = false;
        }

        private void cbFilter_Click(object sender, EventArgs e)
        {

        }








         //if (cbFilter.SelectedIndex != 0)
         //   {
         //       txtFiltering.Enabled = true;
         //       txtFiltering.Focus();
         //   }
         //   else
         //   {
         //       txtFiltering.Enabled = false;

         //   }




private void txtFiltering_TextChanged(object sender, EventArgs e)
        {

            if (txtFiltering.Text == "")
            {
                return;
            }
            string FilteringName = cbFilter.Text;

            DataTable dtPeople = DVLD_BusinessLayer.clsPerson.GetAllPeople();
            dtPeople.DefaultView.RowFilter = string.Empty;
            DataView dvCountries = new DataView(dtPeople);

            if (FilteringName == "ContactID")
            {

                int ContactID;
                if (int.TryParse(txtFiltering.Text, out ContactID))
                    dvCountries.RowFilter = $"ContactID = {ContactID}";
                else
                    return;
            }

            else if (FilteringName == "FirstName")
                dvCountries.RowFilter = $"FirstName = '{txtFiltering.Text}'";

            else if (FilteringName == "LastName")
                dvCountries.RowFilter = $"LastName = '{txtFiltering.Text}'";

            else if (FilteringName == "Email")
                dvCountries.RowFilter = $"Email = '{txtFiltering.Text}'";

            else if (FilteringName == "Phone")
                dvCountries.RowFilter = $"Phone = '{txtFiltering.Text}'";

            else if (FilteringName == "DateOfBirth")
                dvCountries.RowFilter = $"DateOfBirth =' {txtFiltering.Text}'";

            else if (FilteringName == "CountryID")
            {
                int CountryID;
                if (int.TryParse(txtFiltering.Text, out CountryID))
                    dvCountries.RowFilter = $"CountryID = {CountryID}";
                else
                    return;
            }


        }

       
        private void cbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != 0)
            {
                txtFiltering.Enabled = true;
                txtFiltering.Focus();
            }
            else
            {
                txtFiltering.Enabled = false;

            }
        }
    }
}
