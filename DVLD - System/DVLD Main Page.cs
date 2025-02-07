using DVLD___System.Applications;
using DVLD___System.Drivers;
using DVLD___System.Driving_License;
using DVLD___System.Driving_License.Detained___Release;
using DVLD___System.Driving_License.International;
using DVLD___System.Driving_License.Local;
using DVLD___System.Driving_License.Lost___Damaged;
using DVLD___System.Test_Types;
using DVLD___System.Users;
using System;
using System.Windows.Forms;

namespace DVLD___System
{
    public partial class DVLD_Form : Form
    {
        public DVLD_Form()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople_Form managePeople_Form = new ManagePeople_Form();
            managePeople_Form.ShowDialog();
        }

        private void AS_CurrentUserInfo_Click(object sender, EventArgs e)
        {
            ShowUser_Form currentUserInfo_Form = new ShowUser_Form();
            currentUserInfo_Form.ShowDialog();
        }

        private void AS_ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword_Form changePassword_Form = new ChangePassword_Form();
            changePassword_Form.ShowDialog();
        }

        private void AS_LogOut_Click(object sender, EventArgs e)
        {
            Settings.Current_User = null;
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers_Form manageUsers_Form = new ManageUsers_Form();
            manageUsers_Form.ShowDialog();
        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationsTypes_Form manageApplicationsTypes_Forms = new ManageApplicationsTypes_Form();
            manageApplicationsTypes_Forms.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes_Form manageTestTypes_Forms = new ManageTestTypes_Form();
            manageTestTypes_Forms.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewLocalDrivingLicense_Form addNewLocalDrivingLicense_Forms = new AddNewLocalDrivingLicense_Form();
            addNewLocalDrivingLicense_Forms.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicense_Form manageLocalDrivingLicense_Form = new ManageLocalDrivingLicense_Form();
            manageLocalDrivingLicense_Form.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDrivers_Form manageDrivers_Form = new ManageDrivers_Form();
            manageDrivers_Form.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInterLicense_Form addInterLicense_Form = new AddInterLicense_Form();
            addInterLicense_Form.ShowDialog();
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInterLicenses_Form manageInterLicenses_Form = new ManageInterLicenses_Form();
            manageInterLicenses_Form.ShowDialog();
        }

        private void reNewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReNewLicense__Form reNewLicense__Form = new ReNewLicense__Form();
            reNewLicense__Form.ShowDialog();
        }

        private void replacementOfLostOrDamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LostDamagedLicense_Form lostDamagedLicense_Form = new LostDamagedLicense_Form();
            lostDamagedLicense_Form.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicense_Form detainLicense_Form = new DetainLicense_Form();
            detainLicense_Form.ShowDialog();
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseLicense_Form releaseLicense_Form = new ReleaseLicense_Form();
            releaseLicense_Form.ShowDialog();
        }

        private void manageDetainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MngDetainLicenses_Form manageDetainLicenses_Forms = new MngDetainLicenses_Form();
            manageDetainLicenses_Forms.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseLicense_Form releaseLicense_Form = new ReleaseLicense_Form();
            releaseLicense_Form.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicense_Form manageLocalDrivingLicense_Forms = new ManageLocalDrivingLicense_Form();
            manageLocalDrivingLicense_Forms.ShowDialog();
        }
    }
}
