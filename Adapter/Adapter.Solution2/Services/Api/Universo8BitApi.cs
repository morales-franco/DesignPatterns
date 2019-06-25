using Adapter.Solution2.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Adapter.Solution2.Services.Api
{
    public class Universo8BitApi
    {
        private readonly List<Candidate> dataSource = new List<Candidate>()
        {
            new Candidate("Shara (From Universo8Bit)", "+5411-17", "ss@test.com", "nodejs"),
            new Candidate("Pau (From Universo8Bit)", "+5411-17", "ss@test.com", "java")
        };

        internal IList<Candidate> SearchCandidates(JobHunt jobHunt)
        {
            return dataSource.Where(c => jobHunt.GetTechnologiesToFind().Contains(c.Technology))
                             .ToList();
        }
    }
}
