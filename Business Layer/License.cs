using System;
using System.Data;

namespace Business_Layer
{
    public class License
    {
        public int LicenseID { get; set; }
        public Application Application { get; set; }
        public Driver Driver { get; set; }
        public LicenseClass LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public double PaidFees { get; set; }
        public int IssueReason { get; set; }
        public User CreatedByUser { get; set; }
        public bool isActive { get; set; }

        public License()
        {
            LicenseID = -1;
            Application = new Application();
            Driver = new Driver();
            LicenseClass = new LicenseClass();
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            Notes = string.Empty;
            PaidFees = 0;
            IssueReason = 0;
            CreatedByUser = new User();
            isActive = false;
        }
        private License(int licenseID, int applicationID, int driverID, int licenseClassID, DateTime issueDate, DateTime expirationDate, string notes, double paidFees, int issueReason, int createdByUserID, bool isActive)
        {
            LicenseID = licenseID;
            Application = Application.FindApplication(applicationID);
            Driver = Driver.FindDriverByID(driverID);
            LicenseClass = LicenseClass.FindLicenseClassByID(licenseClassID);
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IssueReason = issueReason;
            CreatedByUser = User.FindUserByID(createdByUserID);
            this.isActive = isActive;
        }

        static public DataTable FindAllLicensesForPerson(int PersonID)
        {
            return Data_Access_Layer.License.GetLicensesForPerson(PersonID);
        }
        static private License FindLicense(int licenseID, int applicationID, int licenseClassID, int driverID)
        {
            int LicenseID = licenseID, ApplicationID = applicationID, DriverID = driverID, LicenseClassID = licenseClassID, IssueReason = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string Notes = "";
            double PaidFees = 0;
            bool isActive = false;

            if (Data_Access_Layer.License.GetLicenseData(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IssueReason, ref CreatedByUserID, ref isActive))
                return new License(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IssueReason, CreatedByUserID, isActive);

            return null;
        }
        static public License FindLicenseByID(int licenseID)
        {
            return FindLicense(licenseID, -1, -1, -1);
        }
        static public License FindLicenseByApplicationID(int ApplicationID, int LicenseClassID)
        {
            return FindLicense(-1, ApplicationID, LicenseClassID, -1);
        }
        static public License FindLicenseByDriverID(int DriverID)
        {
            return FindLicense(-1, -1, -1, DriverID);
        }
        static public bool isLicenseExistForThisApplication(int ApplicationID, int LicenseClassID)
        {
            return FindLicenseByApplicationID(ApplicationID, LicenseClassID) != null;
        }

        public bool AddNewLicense()
        {
            LicenseID = Data_Access_Layer.License.AddNewLicense(Application.ApplicationID, Driver.DriverID, LicenseClass.LicenseID, IssueDate, ExpirationDate, Notes, PaidFees, IssueReason, CreatedByUser.UserID, isActive);

            return LicenseID != -1;
        }
        public bool DeactivateLicense()
        {
            isActive = false;

            return Data_Access_Layer.License.EditLicense(LicenseID, isActive) != 0;
        }
        public bool ActivateLicense()
        {
            isActive = true;

            return Data_Access_Layer.License.EditLicense(LicenseID, isActive) != 0;
        }
    }
}
