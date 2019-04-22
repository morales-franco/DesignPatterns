using Factory.Solution2.Entities;
using Factory.Solution2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Solution2
{
    class AccessControlFactory
    {

        Dictionary<string, Type> _accessControls;

        public AccessControlFactory()
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            _accessControls = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IAccessControl).ToString()) != null)
                    _accessControls.Add(type.Name.ToLower().Replace("accesscontrol", ""), type);
            }
        }

        public IAccessControl CreateInstance(string accessControlCode)
        {
            Type t = GetTypeToCreate(accessControlCode);

            if (t == null)
                return new NullAccessControl();

            return Activator.CreateInstance(t) as IAccessControl;
        }

        private Type GetTypeToCreate(string accessControlCode)
        {
            if (!_accessControls.ContainsKey(accessControlCode))
                return null;

            return _accessControls[accessControlCode];
        }
    }
}
