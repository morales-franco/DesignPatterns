using Adapter.Solution2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Solution2.Services
{
    //IAdapter
    interface IHrDataSource
    {
        IList<Candidate> GetCandidates(JobHunt jobHunt);
    }
}
