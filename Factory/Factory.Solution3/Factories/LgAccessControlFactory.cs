using Factory.Solution3.Entities;
using Factory.Solution3.Interfaces;

namespace Factory.Solution3.Factories
{
    class LgAccessControlFactory : IAccessControlFactory
    {
        public IAccessControl GetInstance()
        {
            LgAccessControl accessControl = new LgAccessControl();
            return accessControl;
        }
    }
}
