using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Driving_License.International
{
    public partial class ShowInterLicense_Form : Form
    {
        private int InternationalLicenseID {  get; set; }
        public ShowInterLicense_Form(int internationalLicenseID)
        {
            InitializeComponent();
            InternationalLicenseID = internationalLicenseID;

            IDLC_LicenseInfo.LoadInternationalLicense(InternationalLicenseID);
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
