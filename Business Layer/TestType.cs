using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class TestType
    {
        public int TestID { get; set; }
        public string TestTitle { get; set; }
        public string TestDescription { get; set; }
        public double TestFees { get; set; }

        public TestType()
        {
            TestID = -1;
            TestTitle = string.Empty;
            TestDescription = string.Empty;
            TestFees = 0;
        }
        private TestType(int testID, string testTitle, string testDescription, double testFees)
        {
            TestID = testID;
            TestTitle = testTitle;
            TestDescription = testDescription;
            TestFees = testFees;
        }

        static public DataTable FindAllTestTypes()
        {
            return Data_Access_Layer.TestType.GetAllTestTypes();
        }
        static public TestType FindTestByID(int id)
        {
            int ID = id; string Title = "", Description = ""; double Fees = 0;

            if (Data_Access_Layer.TestType.GetTestType(ID, ref Title, ref Description, ref Fees))
                return new TestType(ID, Title, Description, Fees);

            return null;
        }

        public bool EditTestType()
        {
            return Data_Access_Layer.TestType.UpdateTestType(TestID, TestTitle, TestDescription, TestFees) != 0;
        }
    }
}
