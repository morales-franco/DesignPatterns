using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.AccessControl.AccessControls;

namespace AbstractFactory.AccessControl.Factories
{
    class CardFactory : IAccessControlAbstractFactory
    {
        public IHpAccessControl CreateHp()
        {
            return new CardHp();
        }

        public ILgAccessControl CreateLg()
        {
            return new CardLg();
        }

        public IZkAccessControl CreateZk()
        {
            return new CardZk();
        }
    }
}
