using DVLD___System.Driving_License.Local;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Driving_License.Detained___Release
{
    public partial class DetainLicense_Form : Form
    {
        Business_Layer.DetainedLicense MainDetain {  get; set; }
        public DetainLicense_Form()
        {
            InitializeComponent();
            LoadInternationalApplicationInfo();
        }

        private void LoadInternationalApplicationInfo()
        {
            L_DetainDate.Text = DateTime.Today.ToString("dd MMMM yyyy");
            L_CreatedBy.Text = Settings.Current_User.PersonInfo.FirstName;
        }

        private Business_Layer.DetainedLicense CreateDetainLicenseObject()
        {
            Business_Layer.DetainedLicense detainedLicense = new Business_Layer.DetainedLicense();

            detainedLicense.License = LDLC_LicenseInfo.license;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.FineFees = Convert.ToDouble(TB_FineFees.Text);
            detainedLicense.CreatedByUser = Settings.Current_User;
            detainedLicense.isReleased = false;

            return detainedLicense;
        }
        private void BT_Detain_Click(object sender, EventArgs e)
        {
            if (!LDLC_LicenseInfo.license.DeactivateLicense())
            {
                MessageBox.Show($"An error occurred while attempting to deactivate the license!!\n\nTry Again Later.", "The License couldn't be deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Business_Layer.DetainedLicense detainedLicense = CreateDetainLicenseObject();

            if (detainedLicense.DetainLicense())
            {
                MessageBox.Show("Operation completed successfully!", "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
                L_DetainID.Text = detainedLicense.DetainID.ToString();
                TB_FineFees.Enabled = false;

                LL_ShowLicense.Enabled = true;
                LL_ShowLicensesHist.Enabled = true;

                LDLC_LicenseInfo.deactivate();
                LDLC_LicenseInfo.detain();

                MainDetain = detainedLicense;
            }
            else
                MessageBox.Show("The license detainment process has failed.!!\n\nTry Again Later.", "License Detainment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LDLC_LicenseInfo_LocalLicenseFound(int obj)
        {
            BT_Detain.Enabled = false;
            LL_ShowLicense.Enabled = false;
            LL_ShowLicensesHist.Enabled = false;

            if (Business_Layer.DetainedLicense.isLicenseDetained(obj))
            {
                MessageBox.Show($"This license is currently being detained!!", "The license is not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            L_LicenseID.Text = obj.ToString();
            BT_Detain.Enabled = true;
            TB_FineFees.Text = "";
            TB_FineFees.Enabled = true;
        }

        private void LL_ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicense_Form showLicense_Form = new ShowLicense_Form(LDLC_LicenseInfo.license);
            showLicense_Form.ShowDialog();
        }

        private void LL_ShowLicensesHist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseHistory_Form showLicenseHistory_Form = new ShowLicenseHistory_Form(LDLC_LicenseInfo.GetPersonID());
            showLicenseHistory_Form.ShowDialog();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TB_FineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && TB_FineFees.Text.IndexOf('.') == -1) return;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) return;

            e.Handled = true;
        }

        private void DetainLicense_Form_Load(object sender, EventArgs e)
        {
            LDLC_LicenseInfo.SetFocus();
        }
    }
}
