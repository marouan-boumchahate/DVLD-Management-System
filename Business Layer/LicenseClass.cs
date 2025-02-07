using System.Data;

namespace Business_Layer
{
    public class LicenseClass
    {
        public int LicenseID { get; set; }
        public string LicenseName { get; set; }
        public string LicenseDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public double Fees {  get; set; }

        public LicenseClass()
        {
            LicenseID = -1;
            LicenseName = string.Empty;
            LicenseDescription = string.Empty;
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            Fees = 0;
        }
        private LicenseClass(int licenseID, string licenseName, string licenseDescription, int minimumAllowedAge, int defaultValidityLength, double fees)
        {
            LicenseID = licenseID;
            LicenseName = licenseName;
            LicenseDescription = licenseDescription;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            Fees = fees;
        }


        static public DataTable FindAllLicenseClasses()
        {
            return Data_Access_Layer.LicenseClass.GetAllLicenseClasses();
        }

        static public LicenseClass FindLicenseClassBy(int ID, string Name)
        {
            int LicenseID = ID, MinAge = 0, Length = 0;
            string ClassName = Name, Des = "";
            double Fees = 0;

            if(Data_Access_Layer.LicenseClass.GetLicenseClass(ref LicenseID, ref ClassName, ref Des, ref MinAge, ref Length, ref Fees))
                return new LicenseClass(LicenseID, ClassName, Des, MinAge, Length, Fees);
            
            return null;
        }
        static public LicenseClass FindLicenseClassByID(int ID)
        {
            return FindLicenseClassBy(ID, "");
        }
        static public LicenseClass FindLicenseClassByName(string Name)
        {
            return FindLicenseClassBy(-1, Name);
        }
    }
}
