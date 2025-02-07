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
    public partial class AddNewLocalDrivingLicense_Form : Form
    {
        Business_Layer.LocalDrivingLicenseApplication ldla = null;

        public AddNewLocalDrivingLicense_Form()
        {
            InitializeComponent();
        }
        public AddNewLocalDrivingLicense_Form(int ID)
        {
            InitializeComponent();

            ldla = Business_Layer.LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(ID);
            if(ldla == null ) this.Close();
        }


        private void fillComboBox()
        {
            DataTable dt = Business_Layer.LicenseClass.FindAllLicenseClasses();

            CB_LicenseClass.Items.Clear();  

            foreach(DataRow row in dt.Rows)
                CB_LicenseClass.Items.Add(row[1]);

            CB_LicenseClass.SelectedIndex = 0;
        }

        private void AddNewLocalDrivingLicense_Form_Load(object sender, EventArgs e)
        {
            L_ApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            fillComboBox();
            L_Fees.Text = Business_Layer.ApplicationType.FindApplicationByID(1).ApplicationFees.ToString();
            
            if(ldla != null)
            {
                // This means we are at the updating mode
                L_CreatedBy.Text = Settings.Current_User.PersonInfo.FirstName;
                L_LDLApplicationID.Text = ldla.ID.ToString();
                L_CreatedBy.Text = ldla.Application.CreatedBy.PersonInfo.FirstName;
                CB_LicenseClass.SelectedItem = ldla.LicenseClass.LicenseName.ToString();
                PCWF_PersonFilter.LoadPersonInfo(ldla.Application.PersonInfo.PersonID);
                PCWF_PersonFilter.DisableFilter();
            }
        }
        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BT_Next_Click(object sender, EventArgs e)
        {
            TC_AddApplicationTabs.SelectedIndex = 1;
        }

        private void UpdateApplication()
        {
            if (Business_Layer.TestAppointment.FindAllApointmentsForLocalDrivingLicenseID(ldla.ID, 1).Rows.Count > 0)
            { MessageBox.Show($"This application already got some test appointments!\nSo you are not able to update (you can only delete and apply again for a new application).", "Cannot be updated!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (ldla.UpdateLicenseClass(Business_Layer.LicenseClass.FindLicenseClassByName(CB_LicenseClass.SelectedItem.ToString())))
                MessageBox.Show($"The application Updated successfuly to '{ldla.LicenseClass.LicenseName}'.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"The application Failed to Update!!!!!", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            // This Means that we are saving for updating NOT adding
            if(ldla != null)
            {
                UpdateApplication();
                return;
            }

            Business_Layer.LocalDrivingLicenseApplication LDLA = new Business_Layer.LocalDrivingLicenseApplication();
            Business_Layer.LicenseClass licenseClass = Business_Layer.LicenseClass.FindLicenseClassByName(CB_LicenseClass.SelectedItem.ToString());

            LDLA.LicenseClass = licenseClass;


            if (!Business_Layer.LocalDrivingLicenseApplication.canPersonApplyForThisClass(PCWF_PersonFilter.GetPersonID(), LDLA.LicenseClass.LicenseID))
            { MessageBox.Show($"You cannot apply a new application of type '{licenseClass.LicenseName}'.\n\nSince this client already has one (new/completed)", "Failed To Operate", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            Business_Layer.Application application = new Business_Layer.Application();
            application.ApplicationDate = DateTime.Now;
            application.PersonInfo = Business_Layer.Person.FindPersonByID(PCWF_PersonFilter.GetPersonID());
            application.ApplicationTypeInfo = Business_Layer.ApplicationType.FindApplicationByID(1);
            application.Status = 1;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = Convert.ToDouble(L_Fees.Text);
            application.CreatedBy = Settings.Current_User;

            if(!application.Save()) {MessageBox.Show("The system couldn't apply for a new application for this Person.\nPlease Try Again Later!!!", "Failed To Operate", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            LDLA.Application = application;

            if (LDLA.AddNewLDLApplication()) {MessageBox.Show("New Local Driving License application has been applied successfuly for this person", "Successfuly Applied", MessageBoxButtons.OK, MessageBoxIcon.Information); L_LDLApplicationID.Text = LDLA.ID.ToString(); }
            else MessageBox.Show("The system couldn't apply for a new local driving license application for this Person.\nPlease Try Again Later!!!", "Failed To Operate", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PCWF_PersonFilter_OnPersonFound(int obj)
        {
            BT_Save.Enabled = true;
        }
    }
}
