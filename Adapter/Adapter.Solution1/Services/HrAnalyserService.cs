using Adapter.Solution1.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Adapter.Solution1.Services
{
    class HrAnalyserService
    {
        private readonly IList<IHrDataSource> hrDataSources = new List<IHrDataSource>();
        private readonly List<Candidate> candidates = new List<Candidate>();

        public HrAnalyserService()
        {
            LoadDataSources();
        }

        private void LoadDataSources()
        {
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IHrDataSource).ToString()) != null)
                    hrDataSources.Add(Activator.CreateInstance(type) as IHrDataSource);
            }
        }

        public IList<Candidate> GetBestCandidates(JobHunt jobHunt)
        {
            SetCandidates(jobHunt);
            return FilterCandidatesWithSecretAlgorithm();
             
        }

        private IList<Candidate> FilterCandidatesWithSecretAlgorithm()
        {
            //Apply superb Algorithm!
            //A lot of magic here!!
            return candidates;
        }

        private void SetCandidates(JobHunt jobHunt)
        {
            candidates.Clear();

            foreach (var dataSource in hrDataSources)
            {
                candidates.AddRange(dataSource.GetCandidates(jobHunt));
            }
        }
    }
}
