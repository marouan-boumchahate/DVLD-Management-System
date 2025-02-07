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
    public partial class InternationalDrivingLicenseCard : UserControl
    {
        public InternationalDrivingLicenseCard()
        {
            InitializeComponent();
        }

        public void LoadInternationalLicense(int InternationalLicenseID)
        {
            Business_Layer.InternationalLicense interLicense = Business_Layer.InternationalLicense.FindInternationalLicenseByID(InternationalLicenseID);
            Business_Layer.Person person = interLicense.Driver.PersonInfo;

            L_Name.Text = person.GetFullName();
            L_InternationalLicenseID.Text = interLicense.InternationalLicenseID.ToString();
            L_LicenseID.Text = interLicense.IssuedUsingLocalLicense.LicenseID.ToString();
            L_NationalNo.Text = person.NationalNo;
            L_Gender.Text = (person.Gender == 'M') ? "Male" : "Female";
            L_IssueDate.Text = interLicense.IssueDate.ToString("dd MMMM yyyy");
            L_ExpirationDate.Text = interLicense.ExpirationDate.ToString("dd MMMM yyyy");
            L_DateOfBirth.Text = person.DateOfBirth.ToString("dd MMMM yyyy");
            L_isActive.Text = interLicense.isActive ? "Yes" : "No";
            L_DriverID.Text = interLicense.Driver.DriverID.ToString();
            PB_ProfilePicture.Image = (person.ImagePath == "") ? (person.Gender == 'M') ? Properties.Resources.Male_Profile_1 : Properties.Resources.Female_Profile_1 : Image.FromFile(person.ImagePath);
        }
    }
}
