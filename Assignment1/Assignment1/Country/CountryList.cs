using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Country
{
    class CountryList
    {
        private List<string> countries;

        public CountryList()
        {
            countries = new List<string>();
            CultureInfo[] cultureInfos = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);
            foreach (CultureInfo culture in cultureInfos)
            {
                RegionInfo region = new RegionInfo(culture.LCID);

                if (!(countries.Contains(region.EnglishName)))
                    countries.Add(region.EnglishName);
            }
        }

        public int GetCountOfIPrefixCountry()
        {
            List<string> result = countries.Where(x => x[0] == 'I').ToList();
            return result.Count;
        }
        
        public IDictionary<int, List<string>> GetGroupByCountryByLength()
        {
            var result = countries.GroupBy(x => x.Length).ToDictionary(x => x.Key, y => y.ToList());
            return result;
        }
    }
}
