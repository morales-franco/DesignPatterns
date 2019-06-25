using LinkedIn.Sdk.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinkedIn.Sdk
{
    public class LinkedInManager
    {
        private IList<LinkedInCandidate> candidates = new List<LinkedInCandidate>()
        {
            new LinkedInCandidate("Franco", "Morales (From LinkedIn)", DateTime.Now.AddYears(-25), "Male", "fm@test", "1231", "New Zealand", "dotnet"),
            new LinkedInCandidate("Raphael", "Kim (From LinkedIn)", DateTime.Now.AddYears(-20), "Male", "rk@test", "1456","New Zealand", "java"),
        };

        public IList<LinkedInCandidate> SearchInLinkedInCloud(LinkedInSearch parameters)
        {
            return candidates.Where(c =>
                parameters.AllowedCountries.Contains(c.Country) &&
                parameters.Technologies.Contains(c.Technology)
            ).ToList();
        }
    }
}
