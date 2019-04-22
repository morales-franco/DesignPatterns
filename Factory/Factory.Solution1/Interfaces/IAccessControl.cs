using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Solution1.Interfaces
{
    interface IAccessControl
    {
        string Code { get; }

        List<string> GetUsers();
        List<string> GetAttendeces();
    

    }
}
