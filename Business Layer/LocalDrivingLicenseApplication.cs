using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class LocalDrivingLicenseApplication
    {
        public int ID { get; set; }
        public Application Application { get; set; }
        public LicenseClass LicenseClass { get; set; }

        public LocalDrivingLicenseApplication()
        {
            ID = -1;
            Application = new Application();
            LicenseClass = new LicenseClass();
        }
        private LocalDrivingLicenseApplication(int iD, int applicationID, int licenseClassID)
        {
            ID = iD;
            Application = Application.FindApplication(applicationID);
            LicenseClass = LicenseClass.FindLicenseClassByID(licenseClassID);
        }


        static public LocalDrivingLicenseApplication FindLocalDrivingLicenseApplication(int id)
        {
            int ID = id, ApplicationID = -1, LicenseClassID = -1;

            if(Data_Access_Layer.LocalDrivingLicenseApplication.GetLDLApplication(ID, ref ApplicationID, ref LicenseClassID))
                return new LocalDrivingLicenseApplication(ID, ApplicationID, LicenseClassID);

            return null;
        }

        public bool AddNewLDLApplication()
        {
            ID = Data_Access_Layer.LocalDrivingLicenseApplication.AddNewLDLApplication(Application.ApplicationID, LicenseClass.LicenseID);

            return ID != -1;
        }

        static public bool canPersonApplyForThisClass(int PersonID, int ClassID)
        {
            return !Data_Access_Layer.LocalDrivingLicenseApplication.ClassAlreadyExist(PersonID, ClassID);
        }

        static public DataTable FindAllLDLApplications()
        {
            return Data_Access_Layer.LocalDrivingLicenseApplication.GetAllLDLApplications();
        }

        static public bool deleteLocalApplication(int ID)
        {
            return Data_Access_Layer.LocalDrivingLicenseApplication.deleteApplication(ID) != 0;
        }

        public bool UpdateLicenseClass(LicenseClass LC)
        {
            if (LC != null)
            {
                LicenseClass = LC;
                return Data_Access_Layer.LocalDrivingLicenseApplication.updateApplication(ID, LC.LicenseID) > 0;
            }

            return false;
        }
    }
}
