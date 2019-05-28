using AbstractFactory.AccessControl.AccessControls;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AccessControl.Factories
{
    interface IAccessControlAbstractFactory
    {
        IZkAccessControl CreateZk();
        IHpAccessControl CreateHp();
        ILgAccessControl CreateLg();
    }
}
