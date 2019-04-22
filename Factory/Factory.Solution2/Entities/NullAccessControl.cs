using Factory.Solution2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Solution2.Entities
{
    class NullAccessControl : IAccessControl
    {
        public string Code { get => "UNKNOWN"; }

        public List<string> GetAttendeces() => new List<string>();


        public List<string> GetUsers() => new List<string>();
    }
}
