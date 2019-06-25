using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedIn.Sdk.Model
{
    public class LinkedInSearch
    {
        public string[] Technologies { get; set; }
        public IList<string> AllowedCountries { get; set; }

        public LinkedInSearch(string[] technologies, IList<string> allowedCountries)
        {
            Technologies = technologies;
            AllowedCountries = allowedCountries;
        }
    }
}
