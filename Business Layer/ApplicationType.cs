using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ApplicationType
    {
        public int ApplicationID { get; set; }
        public string ApplicationTitle { get; set; }
        public double ApplicationFees { get; set; }

        public ApplicationType()
        {
            ApplicationID = -1;
            ApplicationTitle = string.Empty;
            ApplicationFees = 0;
        }
        private ApplicationType(int applicationID, string applicationTitle, double applicationFees)
        {
            ApplicationID = applicationID;
            ApplicationTitle = applicationTitle;
            ApplicationFees = applicationFees;
        }

        static public DataTable FindAllApplicationTypes()
        {
            return Data_Access_Layer.ApplicationType.GetAllApplicationTypes();
        }
        static public ApplicationType FindApplicationByID(int id)
        {
            int ID = id; string Title = ""; double Fees = 0;

            if(Data_Access_Layer.ApplicationType.GetApplicationType(ID, ref Title, ref Fees))
                return new ApplicationType(ID, Title, Fees);

            return null;
        }
        static public double ReTakeTestApplicationFees()
        {
            ApplicationType AppT = FindApplicationByID(8);

            if(AppT == null) return 0;

            return AppT.ApplicationFees;
        }

        public bool EditApplicationType()
        {
            return Data_Access_Layer.ApplicationType.UpdateApplicationType(ApplicationID, ApplicationTitle, ApplicationFees) != 0;
        }
    }
}
