using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Version2.Model
{
    interface IPrototype
    {
        IPrototype Clone();
    }
}
