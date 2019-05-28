using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.AccessControl.AccessControls;

namespace AbstractFactory.AccessControl.Factories
{
    class FingerprintFactory : IAccessControlAbstractFactory
    {
        public IHpAccessControl CreateHp()
        {
            return new FingerprintHp();
        }

        public ILgAccessControl CreateLg()
        {
            return new FingerprintLg();
        }

        public IZkAccessControl CreateZk()
        {
            return new FingerprintZk();
        }
    }
}
