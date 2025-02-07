using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        private Country(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }
        public Country()
        {
            CountryID = -1;
            CountryName = string.Empty;
        }


        static public Dictionary<string, int> FindAllCountries()
        {
            return Data_Access_Layer.Country.GetAllCountries();
        }

        static private Country FindCountry(int countryID, string countryName)
        {
            int CountryID = countryID;
            string CountryName = countryName;

            if(Data_Access_Layer.Country.GetCountry(ref CountryID, ref CountryName))
                return new Country(CountryID, CountryName);

            return null;
        }

        static public Country FindCountry(int CountryID)
        {
            return FindCountry(CountryID, "");
        }
        static public Country FindCountry(string CountryName)
        {
            return FindCountry(-1, CountryName);
        }
    }
}
