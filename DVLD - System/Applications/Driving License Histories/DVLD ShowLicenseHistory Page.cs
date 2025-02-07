using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Driving_License.Local
{
    public partial class ShowLicenseHistory_Form : Form
    {
        DataTable LocalLicenses = new DataTable();
        DataTable InternationalLicenses = new DataTable();
        int PersonID {  get; set; }
        private void LoadLocalLicenses()
        {
            LocalLicenses = Business_Layer.License.FindAllLicensesForPerson(PersonID);
            DGV_LocalLicenses.DataSource = LocalLicenses;

            L_LRecordsLength.Text = LocalLicenses.Rows.Count.ToString();

            DGV_LocalLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadInternationalLicense()
        {
            InternationalLicenses = Business_Layer.InternationalLicense.AllInternationalLicensesForPerson(PersonID);
            DGV_InternationalLicenses.DataSource = InternationalLicenses;

            L_IRecordsLength.Text = InternationalLicenses.Rows.Count.ToString();

            DGV_InternationalLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public ShowLicenseHistory_Form(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;

            PCWF_PersonInfo.LoadPersonInfo(PersonID);
            PCWF_PersonInfo.DisableFilter();

            LoadLocalLicenses();
            LoadInternationalLicense();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
