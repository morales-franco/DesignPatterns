using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter.Solution2.Entities;
using LinkedIn.Sdk;
using LinkedIn.Sdk.Model;

namespace Adapter.Solution2.Services
{
    class LinkedInAdapterService : IHrDataSource
    {
        private readonly LinkedInManager AdapteeLinkedInManager;

        public LinkedInAdapterService()
        {
            AdapteeLinkedInManager = new LinkedInManager();
        }

        public IList<Candidate> GetCandidates(JobHunt jobHunt)
        {
            LinkedInSearch linkedInSearch = MapJobHuntToLinkedInSearch(jobHunt);
            var linkedInCandidates = AdapteeLinkedInManager.SearchInLinkedInCloud(linkedInSearch);
            return MapLinkedInCandidatesToCandidates(linkedInCandidates);
        }

        private IList<Candidate> MapLinkedInCandidatesToCandidates(IList<LinkedInCandidate> linkedInCandidates)
        {
            return linkedInCandidates.Select(l => new Candidate($"{l.Name} {l.Surname}", l.Celphone, l.EmailAdress, l.Technology))
                                     .ToList();
        }

        private LinkedInSearch MapJobHuntToLinkedInSearch(JobHunt jobHunt)
        {
            LinkedInSearch linkedInSearch = new LinkedInSearch(
                jobHunt.GetTechnologiesToFind().ToArray(),
                new List<string> { "Argentina", "New Zealand" } );

            return linkedInSearch;
        }
    }
}
