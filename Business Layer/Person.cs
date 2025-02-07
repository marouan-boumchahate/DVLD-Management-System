using System;
using System.Data;
using System.Security.Cryptography;

namespace Business_Layer
{
    public class Person
    {
        public enum enMode { Add = 0, Edit = 1 }
        public enMode Mode = enMode.Add;

        // Declare all Attributes that exists in The Database
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Country CountryInformation { get; set; }
        //public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }


        // Constructor
        public Person()
        {
            PersonID = -1;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            NationalNo = string.Empty;
            DateTime DateOfBirth = DateTime.MinValue;
            Gender = 'M';
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            CountryInformation = new Country();
            ImagePath = string.Empty;

            Mode = enMode.Add;
        }
        private Person(int personID, string firstName, string secondName, string thirdName, string lastName,
                       string nationalNo, DateTime dateOfBirth, char gender, string address, string phone, string email,
                       int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            NationalNo = nationalNo;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            CountryInformation = Country.FindCountry(nationalityCountryID);
            ImagePath = imagePath;

            Mode = enMode.Edit;
        }


        // Get Person Info By info
        static private Person _FindPersonByAttr(int ID, string nationalNo)
        {
            int PersonID = ID, NationalityCountryID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "", NationalNo = nationalNo;
            DateTime DateOfBirth = DateTime.MinValue;
            char Gender = 'M';

            if(Data_Access_Layer.Person.GetPersonData(ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth, ref Gender,
                                                      ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
                return new Person(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else 
                return null;
        }
        static public Person FindPersonByID(int ID)
        {
            return _FindPersonByAttr(ID, "");
        }
        static public Person FindPersonByNationalNo(string NationalNo)
        {
            return _FindPersonByAttr(-1, NationalNo);
        }
        static public string PersonFullName(int ID)
        {
            Person per = FindPersonByID(ID);

            if (per == null) return "";

            return per.FirstName + " " + per.SecondName + " " + per.ThirdName + " " + per.LastName;
        }
        public string GetFullName()
        {
            string FullName = FirstName;

            if (SecondName != "") FullName += (" " + SecondName);
            if (ThirdName != "") FullName += (" " + ThirdName);
            if (LastName != "") FullName += (" " + LastName);

            return FullName;
        }
        static public string PersonFullName(string NationalNo)
        {
            Person per = FindPersonByNationalNo(NationalNo);

            if (per == null) return "";

            return per.FirstName + " " + per.SecondName + " " + per.ThirdName + " " + per.LastName;
        }

        // Check Person Existence
        static public bool isPersonExist(int PersonID)
        {
            return Data_Access_Layer.Person.isPersonExist(PersonID, "");
        }
        static public bool isPersonExist(string NationalNo)
        {
            return Data_Access_Layer.Person.isPersonExist(-1, NationalNo);
        }


        // Get All People Data From Database
        static public DataTable FindAllPeople()
        {
            return Data_Access_Layer.Person.GetAllPeople();
        }


        // Add New Person to the system
        private bool _AddNewPerson()
        {
            if (string.IsNullOrEmpty(Email)) Email = "";
            if (string.IsNullOrEmpty(SecondName)) SecondName = "";
            if (string.IsNullOrEmpty(ThirdName)) ThirdName = "";
            if (string.IsNullOrEmpty(ImagePath)) ImagePath = "";

            this.PersonID = Data_Access_Layer.Person.AddNewPerson(FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Address, Phone, Email, CountryInformation.CountryID, ImagePath);

            return PersonID != -1;
        }


        // Update Data of a person
        private bool _UpdatePerson()
        {
            return Data_Access_Layer.Person.UpdatePerson(PersonID, Address, Phone, Email, ImagePath) != 0;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if(_AddNewPerson()) {Mode = enMode.Add; return true;}
                    return false;
                case enMode.Edit:
                    if (_UpdatePerson()) return true;
                    return false;
                default:
                    return false;
            }
        }

        // Delete a Person
        static public bool DeletePerson(int PersonID)
        {
            return Data_Access_Layer.Person.DeletePerson(PersonID) != 0;
        }
    }
}
