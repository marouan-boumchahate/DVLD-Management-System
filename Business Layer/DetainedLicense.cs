using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class DetainedLicense
    {
        public int DetainID { get; set; }
        public License License { get; set; }
        public DateTime DetainDate { get; set; }
        public double FineFees { get; set; }
        public User CreatedByUser { get; set; }
        public bool isReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public User ReleasedByUser { get; set; }
        public Application ReleaseApplication { get; set; }

        public DetainedLicense()
        {
            DetainID = -1;
            License = new License();
            DetainDate = DateTime.MinValue;
            FineFees = 0;
            CreatedByUser = new User();
            isReleased = false;
            ReleaseDate = DateTime.MinValue;
            ReleasedByUser = new User();
            ReleaseApplication = new Application();
        }
        private DetainedLicense(int detainID, int licenseID, DateTime detainDate, double fineFees, int createdByUserID, bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            DetainID = detainID;
            License = License.FindLicenseByID(licenseID);
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUser = User.FindUserByID(createdByUserID);
            this.isReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUser = User.FindUserByID(releasedByUserID);
            ReleaseApplication = Application.FindApplication(releaseApplicationID);
        }
    
        static private DetainedLicense FindDetainedLicense(int licenseID, int applicationID, int detainID)
        {
            int DetainID = detainID, LicenseID = licenseID, ReleaseApplicationID = applicationID, CreatedByUserID = -1, ReleasedByUserID = -1;
            DateTime DetainDate = DateTime.MinValue, ReleaseDate = DateTime.MinValue;
            double FineFees = 0;
            bool isReleased = false;

            if(Data_Access_Layer.DetainedLicense.GetDetainLicense(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref isReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new DetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, isReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            return null;
        }
        static public DetainedLicense FindDetainLicenseByID(int DetainID)
        {
            return FindDetainedLicense(-1, -1, DetainID);
        }
        static public DetainedLicense FindDetainLicenseByLicenseID(int LicenseID)
        {
            return FindDetainedLicense(LicenseID, -1, -1);
        }
        static public DetainedLicense FindDetainLicenseByApplicationID(int ApplicationID)
        {
            return FindDetainedLicense(-1, ApplicationID, -1);
        }
    
        static public DataTable FindAllDetainLicenses()
        {
            return Data_Access_Layer.DetainedLicense.GetAllDetainLicenses();
        }

        static public bool isLicenseDetained(int licenseID)
        {
            DetainedLicense dl =  FindDetainLicenseByLicenseID(licenseID);

            return dl != null;
        }
        public bool isLicenseDetained()
        {
            return !isReleased;
        }
    
        public bool DetainLicense()
        {
            DetainID = Data_Access_Layer.DetainedLicense.AddNewDetainLicenseRecord(License.LicenseID, DetainDate, FineFees, CreatedByUser.UserID, isReleased);

            return DetainID != -1;
        }

        public bool ReleaseLicense()
        {
            return Data_Access_Layer.DetainedLicense.UpdateDetainLicense(DetainID, isReleased, ReleaseDate, ReleasedByUser.UserID, ReleaseApplication.ApplicationID) != 0;
        }
    }
}
