using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Driving_License
{
    public partial class LocalDrivingLicenseCard : UserControl
    {
        public LocalDrivingLicenseCard()
        {
            InitializeComponent();
        }

        private string ReasonWord(int Reason)
        {
            switch (Reason)
            {
                case 1:
                    return "First License";
                case 2:
                    return "Re-new License";
                case 3:
                    return "Lost License";
                case 4:
                    return "Damaged License";
                case 5:
                    return "Release License";
                default:
                    return "International License";
            }
        }
        public void LoadDrivingLicenseCard(Business_Layer.License license)
        {
            Business_Layer.Person per = license.Driver.PersonInfo;
            
            L_Class.Text = license.LicenseClass.LicenseName;
            L_Name.Text = Business_Layer.Person.PersonFullName(per.PersonID);
            L_LicenseID.Text = license.LicenseID.ToString();
            L_NationalNo.Text = per.NationalNo;
            L_Gender.Text = per.Gender == 'M' ? "Male" : "Female";
            L_IssueDate.Text = license.IssueDate.ToString("dd MMMM yyyy");
            L_IssueReason.Text = ReasonWord(license.IssueReason);
            L_Note.Text = license.Notes;
            L_isActive.Text = license.isActive == true ? "Yes" : "No";
            L_DriverID.Text = license.Driver.DriverID.ToString();
            L_DateOfBirth.Text = per.DateOfBirth.ToString("dd MMMM yyyy");
            L_ExpirationDate.Text = license.ExpirationDate.ToString("dd MMMM yyyy");
            L_isDetained.Text = Business_Layer.DetainedLicense.isLicenseDetained(license.LicenseID) ? "Yes" : "No";

            PB_ProfilePicture.Image = (per.ImagePath == "") ? (per.Gender == 'M') ? Properties.Resources.Male_Profile_1 : Properties.Resources.Female_Profile_1 : Image.FromFile(per.ImagePath);
        }

        public int GetPersonID()
        {
            return Business_Layer.Driver.FindDriverByID(Convert.ToInt32(L_DriverID.Text)).PersonInfo.PersonID;
        }

        public void deactivate()
        {
            L_isActive.Text = "No";
        }
        public void activate()
        {
            L_isActive.Text = "Yes";
        }
        public void detain()
        {
            L_isDetained.Text = "Yes";
        }
        public void release()
        {
            L_isDetained.Text = "No";
        }
    }
}
