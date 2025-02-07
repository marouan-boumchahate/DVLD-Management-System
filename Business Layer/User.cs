using System.Data;
using System.Xml.Linq;

namespace Business_Layer
{
    public class User
    {
        enum enMode { add = 0, edit = 1}
        enMode mode = enMode.add;

        public int UserID { get; set; }
        public Person PersonInfo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }


        public User()
        {
            UserID = -1;
            PersonInfo = new Person();
            UserName = string.Empty;
            Password = string.Empty;
            isActive = false;

            mode = enMode.add;
        }
        private User(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonInfo = Person.FindPersonByID(personID);
            UserName = userName;
            Password = password;
            this.isActive = isActive;

            mode = enMode.edit;
        }


        // Get User Data By info
        static private User FindUserByAtt(int userID, string userName, int personID)
        {
            int UserID = userID, PersonID = personID;
            string UserName = userName, Password = string.Empty;
            bool isActive = false;

            
            if(Data_Access_Layer.User.GetUser(ref UserID, ref PersonID, ref UserName, ref Password, ref isActive))
                return new User(UserID, PersonID, UserName, Password, isActive);
            else
                return null;
        }
        static public User FindUserByID(int UserID)
        {
            return FindUserByAtt(UserID, "", -1);
        }
        static public User FindUserByUsername(string UserName)
        {
            return FindUserByAtt(-1, UserName, -1);
        }
        static public User FindUserByPerson(int PersonID)
        {
            return FindUserByAtt(-1, "", PersonID);
        }


        // Check User Existence
        static public bool isUserExist(int UserID)
        {
            return Data_Access_Layer.User.isUserExist(UserID, "");
        }
        static public bool isUserExist(string UserName)
        {
            return Data_Access_Layer.User.isUserExist(-1, UserName);
        }


        // Get All Users Data From Database
        static public DataTable FindAllUsers()
        {
            return Data_Access_Layer.User.GetAllUsers();
        }


        // Add New User to the system
        private bool _AddNewUser()
        {
            this.UserID = Data_Access_Layer.User.AddNewUser(PersonInfo.PersonID, UserName, Password, isActive);

            return UserID != -1;
        }


        // Update Data of a User
        private bool _UpdateUser()
        {
            return Data_Access_Layer.User.UpdateUser(UserID, UserName, Password, isActive) != 0;
        }


        // Save Data of a User
        public bool save()
        {
            switch (mode)
            {
                case enMode.add:
                    if (!_AddNewUser()) return false;
                    mode = enMode.edit;
                    return true;
                case enMode.edit:
                    return _UpdateUser();
                default:
                    return false;
            }
        }
        
        // Delete a User
        static public bool DeleteUser(int UserID)
        {
            return Data_Access_Layer.User.DeleteUser(UserID) != 0;
        }
    }
}
