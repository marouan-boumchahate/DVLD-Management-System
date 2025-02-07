using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Driving_License
{
    public partial class LocalDrivingLicenseCardWithFilter : UserControl
    {
        public event Action<int> LocalLicenseFound;
        protected virtual void LicenseFound(int LocalLicenseID)
        {
            Action<int> handler = LocalLicenseFound;

            if (handler != null)
            {
                handler(LocalLicenseID);
            }
        }
        public Business_Layer.License license {  get; set; }
        public LocalDrivingLicenseCardWithFilter()
        {
            InitializeComponent();
        }

        private void TB_TextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        private void PB_Search_Click(object sender, EventArgs e)
        {
            license = Business_Layer.License.FindLicenseByID(Convert.ToInt32(TB_TextFilter.Text));

            if (license != null)
            {
                LDLC_LicenseInfo.LoadDrivingLicenseCard(license);

                if(LocalLicenseFound != null)
                    LicenseFound(license.LicenseID);
            }
            else MessageBox.Show($"There is no Local Driving License By this ID = {TB_TextFilter.Text}.", "Incorrect Local Driving License ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public int GetPersonID()
        {
            return LDLC_LicenseInfo.GetPersonID();
        }

        public void deactivate()
        {
            LDLC_LicenseInfo.deactivate();
        }
        public void activate()
        {
            LDLC_LicenseInfo.activate();
        }
        public void detain()
        {
            LDLC_LicenseInfo.detain();
        }
        public void release()
        {
            LDLC_LicenseInfo.release();
        }

        private void TB_TextFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                PB_Search_Click(new object(), new EventArgs());
        }

        public void LoadLicense(int LicenseID)
        {
            TB_TextFilter.Text = LicenseID.ToString();
            PB_Search_Click(new object(), new EventArgs());

            GB_Filter.Enabled = false;
        }

        public void SetFocus()
        {
            TB_TextFilter.Focus();
        }
    }
}
