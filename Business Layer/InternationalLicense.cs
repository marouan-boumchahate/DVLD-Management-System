using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class InternationalLicense
    {
        public int InternationalLicenseID {  get; set; }
        public Application Application { get; set; }
        public Driver Driver { get; set; }
        public License IssuedUsingLocalLicense { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool isActive { get; set; }
        public User CreatedByUser { get; set; }

        public InternationalLicense()
        {
            InternationalLicenseID = -1;
            Application = new Application();
            Driver = new Driver();
            IssuedUsingLocalLicense = new License();
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            isActive = false;
            CreatedByUser = new User();
        }
        private InternationalLicense(int internationalLicenseID, int applicationID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            Application = Application.FindApplication(applicationID);
            Driver = Driver.FindDriverByID(driverID);
            IssuedUsingLocalLicense = License.FindLicenseByID(issuedUsingLocalLicenseID);
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            this.isActive = isActive;
            CreatedByUser = User.FindUserByID(createdByUserID);
        }

        static private InternationalLicense FindInternationalLicense(int internationalLicenseID, int applicationID)
        {
            int createdByUserID = -1, InternationalLicenseID = internationalLicenseID, ApplicationID = applicationID, DriverID = -1, IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            bool isActive = false;

            if (Data_Access_Layer.InternationalLicense.GetInternationalLicense(ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref isActive, ref createdByUserID))
                return new InternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, isActive, createdByUserID);

            return null;
        }

        static public InternationalLicense FindInternationalLicenseByID(int InterLicenseID)
        {
            return FindInternationalLicense(InterLicenseID, -1);
        }
        static public InternationalLicense FindInternationalLicenseByApplicationID(int ApplicationID)
        {
            return FindInternationalLicense(-1, ApplicationID);
        }


        static public DataTable AllInternationalLicenses()
        {
            return Data_Access_Layer.InternationalLicense.GetInternationalLicenses();
        }
        static public DataTable AllInternationalLicensesForPerson(int PersonID)
        {
            return Data_Access_Layer.InternationalLicense.GetInternationalLicensesForPerson(PersonID);
        }


        static public bool isInternationalLicenseForDriverExist(int DriverID)
        {
            return Data_Access_Layer.InternationalLicense.isInternationalLicenseForDriverExist((int)DriverID);
        }
        public bool AddNewInternationalLicense()
        {
            InternationalLicenseID = Data_Access_Layer.InternationalLicense.AddNewInternationalDrivingLicense(Application.ApplicationID, Driver.DriverID, IssuedUsingLocalLicense.LicenseID, IssueDate, ExpirationDate, isActive, CreatedByUser.UserID);

            return InternationalLicenseID != -1;
        }
        public bool DeactivateInternationalLicense()
        {
            isActive = false;

            return Data_Access_Layer.InternationalLicense.UpdateInternationLicense(InternationalLicenseID, isActive) != 0;
        }
        public bool ActivateInternationalLicense()
        {
            isActive = true;

            return Data_Access_Layer.InternationalLicense.UpdateInternationLicense(InternationalLicenseID, isActive) != 0;
        }
    }
}
