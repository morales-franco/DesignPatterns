using Factory.Solution3.Entities;
using Factory.Solution3.Interfaces;

namespace Factory.Solution3.Factories
{
    class HpAccessControlFactory : IAccessControlFactory
    {
        public IAccessControl GetInstance()
        {
            HpAccessControl accessControl = new HpAccessControl();
            return accessControl;
        }
    }
}
