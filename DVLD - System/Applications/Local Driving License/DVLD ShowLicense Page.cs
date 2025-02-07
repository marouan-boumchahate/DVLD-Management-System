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
    public partial class ShowLicense_Form : Form
    {
        public ShowLicense_Form(int LDLApplicationID)
        {
            InitializeComponent();

            Business_Layer.LocalDrivingLicenseApplication LocalApplication = Business_Layer.LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLApplicationID);
            Business_Layer.License license = Business_Layer.License.FindLicenseByApplicationID(LocalApplication.Application.ApplicationID, LocalApplication.LicenseClass.LicenseID);

            LDLC_DrivingLicense.LoadDrivingLicenseCard(license);
        }
        public ShowLicense_Form(Business_Layer.License license)
        {
            InitializeComponent();

            LDLC_DrivingLicense.LoadDrivingLicenseCard(license);
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
