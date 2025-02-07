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

namespace DVLD___System.Driving_License.International
{
    public partial class AddInterLicense_Form : Form
    {
        public AddInterLicense_Form()
        {
            InitializeComponent();
            LoadInternationalApplicationInfo();
        }

        private void LoadInternationalApplicationInfo()
        {
            L_ApplicationDate.Text = DateTime.Today.ToString("dd MMMM yyyy");
            L_IssueDate.Text = DateTime.Today.ToString("dd MMMM yyyy");
            L_ExpirationDate.Text = DateTime.Today.AddYears(1).ToString("dd MMMM yyyy");
            L_Fees.Text = Business_Layer.ApplicationType.FindApplicationByID(6).ApplicationFees.ToString();
            L_CreatedBy.Text = Settings.Current_User.PersonInfo.FirstName;
        }
        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }


        private Business_Layer.Application CreateApplicationObject()
        {
            Business_Layer.Application newApplication = new Business_Layer.Application();

            newApplication.ApplicationDate = Convert.ToDateTime(L_ApplicationDate.Text);
            newApplication.PersonInfo = LDLC_LicenseInfo.license.Driver.PersonInfo;
            newApplication.ApplicationTypeInfo = Business_Layer.ApplicationType.FindApplicationByID(6);
            newApplication.Status = 3;
            newApplication.LastStatusDate = newApplication.ApplicationDate;
            newApplication.PaidFees = Convert.ToDouble(L_Fees.Text);
            newApplication.CreatedBy = Settings.Current_User;

            return newApplication;
        }
        private Business_Layer.InternationalLicense CreateInternationalLicenseObject(int ApplicationID)
        {
            Business_Layer.InternationalLicense internationalLicense = new Business_Layer.InternationalLicense();

            internationalLicense.Application = Business_Layer.Application.FindApplication(ApplicationID);
            internationalLicense.Driver = LDLC_LicenseInfo.license.Driver;
            internationalLicense.IssuedUsingLocalLicense = LDLC_LicenseInfo.license;
            internationalLicense.IssueDate = Convert.ToDateTime(L_IssueDate.Text);
            internationalLicense.ExpirationDate = internationalLicense.IssueDate.AddYears(1);
            internationalLicense.isActive = true;
            internationalLicense.CreatedByUser = Settings.Current_User;

            return internationalLicense;
        }
        private void BT_Issue_Click(object sender, EventArgs e)
        {
            if (Business_Layer.InternationalLicense.isInternationalLicenseForDriverExist(LDLC_LicenseInfo.license.Driver.DriverID))
            {
                MessageBox.Show($"This Client cannot get an international License!! Because he/she already has an active one", "Already Has International License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Business_Layer.Application app = CreateApplicationObject();

            if (!app.Save())
            {
                MessageBox.Show("The Application couldn't be applied for this client!!\n\nTry Again Later.", "Application Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Business_Layer.InternationalLicense interLicense = CreateInternationalLicenseObject(app.ApplicationID);

            if (interLicense.AddNewInternationalLicense())
            {
                MessageBox.Show("The International Driving License Has been issued successfully.", "Issuing Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                L_InterApplicationID.Text = app.ApplicationID.ToString();
                L_InterLicenseID.Text = interLicense.InternationalLicenseID.ToString();

                LL_ShowLicense.Enabled = true;
                LL_ShowLicensesHist.Enabled = true;
            }
            else
                MessageBox.Show("Something went wrong during the issuing of the license!!\n\nTry Again Later.", "Issuing Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LDLC_LicenseInfo_LocalLicenseFound(int obj)
        {
            BT_Issue.Enabled = false;
            LL_ShowLicense.Enabled = false;
            LL_ShowLicensesHist.Enabled = false;

            if (LDLC_LicenseInfo.license.LicenseClass.LicenseID < 3)
            {
                MessageBox.Show($"This Client cannot get an international License!!\n\nNOTE: The international license can be issued only for drivers who has at least '{Business_Layer.LicenseClass.FindLicenseClassByID(3).LicenseName}'", "Local License Class NOT supported", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LDLC_LicenseInfo.license.ExpirationDate.AddYears(-1).Date < DateTime.Today.Date)
            {
                MessageBox.Show("This Client cannot get an international License!!\n\nNOTE: The Driver must have at least 1 year available before the local license expiration date.", "Local License Life is less than a year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            L_LocalLicenseID.Text = obj.ToString();
            BT_Issue.Enabled = true;
        }

        private void LL_ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int InternLicenseID = Convert.ToInt32(L_InterLicenseID.Text);

            ShowInterLicense_Form showInterLicense_Form = new ShowInterLicense_Form(InternLicenseID);
            showInterLicense_Form.ShowDialog();
        }

        private void LL_ShowLicensesHist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseHistory_Form showLicenseHistory_Form = new ShowLicenseHistory_Form(LDLC_LicenseInfo.GetPersonID());
            showLicenseHistory_Form.ShowDialog();
        }
    }
}
