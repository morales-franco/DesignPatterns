using Factory.Solution3.Entities;
using Factory.Solution3.Interfaces;

namespace Factory.Solution3.Factories
{
    class ZkAccessControlFactory: IAccessControlFactory
    {

        public IAccessControl GetInstance()
        {
            ZkAccessControl accessControl = new ZkAccessControl();

            //I modify the code because of business requirements.
            accessControl.SetCode("Zk ++");

            return accessControl;
        }
    }
}
