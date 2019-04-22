using Factory.Solution3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Solution3.Interfaces
{
    interface IAccessControlFactory
    {
        IAccessControl GetInstance();
    }
}
