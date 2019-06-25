using Adapter.Solution1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Solution1.Services
{
    interface IHrDataSource
    {
        IList<Candidate> GetCandidates(JobHunt jobHunt);
    }
}
