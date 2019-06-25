using System.Collections.Generic;
using Adapter.Solution2.Entities;
using Adapter.Solution2.Services.Api;

namespace Adapter.Solution2.Services
{
    class Universo8BitAdapterService : IHrDataSource
    {
        private readonly Universo8BitApi apiAdaptee = new Universo8BitApi();

        public IList<Candidate> GetCandidates(JobHunt jobHunt)
        {
            return apiAdaptee.SearchCandidates(jobHunt);
        }
    }
}
