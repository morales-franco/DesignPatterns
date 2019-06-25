using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Solution2.Entities
{
    class JobHunt
    {
        private IList<string> Technologies { get; set; }

        public JobHunt(IList<string> technologies)
        {
            Technologies = technologies;
        }

        public IList<string> GetTechnologiesToFind()
        {
            return Technologies;
        }
    }
}
