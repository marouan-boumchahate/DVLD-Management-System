using System;
using System.Data;
using System.Data.SqlTypes;

namespace Business_Layer
{
    public class Application
    {
        enum enMode { add = 1, edit = 2 }
        enMode Mode = enMode.add;

        public int ApplicationID { get; set; }
        public Person PersonInfo { get; set; }
        public DateTime ApplicationDate { get; set; }
        public ApplicationType ApplicationTypeInfo { get; set; }
        public byte Status { get; set; }
        public DateTime LastStatusDate { get; set; }
        public double PaidFees { get; set; }
        public User CreatedBy { get; set; }


        public Application()
        {
            ApplicationID = -1;
            PersonInfo = new Person();
            ApplicationDate = DateTime.MinValue;
            ApplicationTypeInfo = new ApplicationType();
            Status = 0;
            LastStatusDate = DateTime.MinValue;
            CreatedBy = new User();
            PaidFees = 0;

            Mode = enMode.add;
        }
        private Application(int applicationID, int personID, DateTime applicationDate, int applicationTypeID, byte status, DateTime lastStatusDate, double paidFees, int createdBy)
        {
            ApplicationID = applicationID;
            PersonInfo = Person.FindPersonByID(personID);
            ApplicationDate = applicationDate;
            ApplicationTypeInfo = ApplicationType.FindApplicationByID(applicationTypeID);
            Status = status;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedBy = User.FindUserByID(createdBy);

            Mode = enMode.edit;
        }
    
        private bool _AddNewApplication()
        {
            ApplicationID = Data_Access_Layer.Application.AddNewApplication(PersonInfo.PersonID, ApplicationDate, ApplicationTypeInfo.ApplicationID, Status, LastStatusDate, PaidFees, CreatedBy.UserID);

            return ApplicationID != -1;
        }
        private bool _UpdateApplication()
        {
            return Data_Access_Layer.Application.UpdateApplication(ApplicationID, Status, LastStatusDate) != 0;
        }
        static public Application FindApplication(int applicationID)
        {
            int ApplicationID = applicationID, PersonID = -1, ApplicationTypeID = -1, CreatedBy = -1;
            DateTime ApplicationDate = DateTime.MinValue, LastStatusDate = DateTime.MinValue;
            byte Status = 0;
            double PaidFees = 0;

            if(Data_Access_Layer.Application.GetApplication(ApplicationID, ref PersonID, ref ApplicationDate, ref ApplicationTypeID, ref Status, ref LastStatusDate, ref PaidFees, ref CreatedBy))
                return new Application(ApplicationID, PersonID, ApplicationDate, ApplicationTypeID, Status, LastStatusDate, PaidFees, CreatedBy);

            return null;
        }
        
        public string statusASword()
        {
            switch(Status)
            {
                case 1:
                    return "New";
                case 2:
                    return "Cancelled";
                case 3:
                    return "Completed";
                default:
                    return "None";
            }
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.add:
                    if(!_AddNewApplication()) return false;
                    Mode = enMode.edit; return true;
                case enMode.edit:
                    return _UpdateApplication();
                default:
                    return false;
            }
        }
        static public bool deleteApplication(int applicationID)
        {
            return Data_Access_Layer.Application.deleteApplication(applicationID) != 0;
        }
    }
}
