using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Applications.Local_Driving_License
{
    public partial class ShowLocalDrivingApplication_Page : Form
    {
        int LocalDrivingLicenseID = -1;

        public ShowLocalDrivingApplication_Page(int LocalDrivingLicenseID)
        {
            InitializeComponent();
            this.LocalDrivingLicenseID = LocalDrivingLicenseID;
        }

        private void ShowLocalDrivingApplication_Page_Load(object sender, EventArgs e)
        {
            ctr_LocalApplicationInfo.LoadLocalDrivingApplication(LocalDrivingLicenseID);
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
