using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter.Solution2.Entities;

namespace Adapter.Solution2.Services
{
    class CodersZService : IHrDataSource
    {
        private readonly List<Candidate> dataSource =  new List<Candidate>()
        {
            new Candidate("David (From CodersZ)", "+5411-12", "fm@test.com", "Ruby"),
            new Candidate("Mati (From CodersZ)", "+5411-14", "mt@test.com", "dotnet"),
            new Candidate("John (From CodersZ)", "+5411-16", "jj@test.com", "java"),
            new Candidate("Shara (From CodersZ)", "+5411-17", "ss@test.com", "nodejs")
        };

    public IList<Candidate> GetCandidates(JobHunt jobHunt)
        {
            //Searching candidates in XML Files!
            return dataSource.Where(c => jobHunt.GetTechnologiesToFind().Contains(c.Technology))
                             .ToList();
        }
    }
}
