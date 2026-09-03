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
    public partial class frmPeople : frmBase
    {
        public frmPeople()
        {
            InitializeComponent();
            
            this.Tital = "Manage People";
            this.BaseImage = DVLD_PresentationLayer.Properties.Resources.People_400;
        }
        
        private void frmPeople_Load(object sender, EventArgs e)
        {
            DataTable dtPeople = clsPerson.GetAllPeople();

            dtPeople.Columns.Remove("ImagePath");
            dtPeople.Columns.Remove("NationalityCountryID");
            dgvPeople.DataSource = dtPeople;

        }
    }
}
