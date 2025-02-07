

using System.Data;
using System;

namespace Business_Layer
{
    public class Driver
    {
        // Declare all Attributes that exists in The Database
        public int DriverID { get; set; }
        public Person PersonInfo { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }


        // Constructor
        public Driver()
        {
            DriverID = -1;
            PersonInfo = new Person();
            CreatedBy = new User();
            DateTime CreatedDate = DateTime.MinValue;
        }
        private Driver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonInfo = Person.FindPersonByID(personID);
            CreatedBy = User.FindUserByID(createdByUserID);
            CreatedDate = createdDate;
        }


        // Get Driver Data By info
        static private Driver FindDriver(int ID, int personID)
        {
            int DriverID = ID, PersonID = personID, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (Data_Access_Layer.Driver.GetDriverData(ref DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new Driver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }
        static public Driver FindDriverByPersonID(int PersonID)
        {
            return FindDriver(-1, PersonID);
        }
        static public Driver FindDriverByID(int ID)
        {
            return FindDriver(ID, -1);
        }


        // Check Driver Existence
        static public bool isDriverExist(int DriverID)
        {
            return Data_Access_Layer.Driver.isDriverExist(DriverID);
        }


        // Get All Drivers Data From Database
        static public DataTable FindAllDrivers()
        {
            return Data_Access_Layer.Driver.GetAllDrivers();
        }


        // Add New Driver to the system
        public bool AddNewDriver()
        {
            this.DriverID = Data_Access_Layer.Driver.AddNewDriver(PersonInfo.PersonID, CreatedBy.UserID, CreatedDate);

            return DriverID != -1;
        }
    }
}
