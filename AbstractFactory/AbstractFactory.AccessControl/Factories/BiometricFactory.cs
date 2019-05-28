using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.AccessControl.AccessControls;

namespace AbstractFactory.AccessControl.Factories
{
    class BiometricFactory : IAccessControlAbstractFactory
    {
        public IHpAccessControl CreateHp()
        {
            return new BiometricHp();
        }

        public ILgAccessControl CreateLg()
        {
            return new BiometricLg();
        }

        public IZkAccessControl CreateZk()
        {
            return new BiometricZk();
        }
    }
}
