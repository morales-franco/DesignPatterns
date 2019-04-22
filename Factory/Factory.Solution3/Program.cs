using Factory.Solution3.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("WELCOME TO FACTORY.SOLUTION 2");
            Console.WriteLine("Enter the access control code, please");

            string accessControlCode = Console.ReadLine();

            IAccessControlFactory factory = GetFactory(accessControlCode.ToUpper());
            IAccessControl accessControl = factory.GetInstance();
            var users = accessControl.GetUsers();
            var attendances = accessControl.GetAttendeces();


            Console.WriteLine($"Selected Device: { accessControl.Code  }");
            users.ForEach(user => Console.WriteLine(user));
            attendances.ForEach(attendance => Console.WriteLine(attendance));
            Console.ReadLine();
        }

        private static IAccessControlFactory GetFactory(string accessControlCode)
        {
            var factories = GetFactoriesTypes();

            if (!factories.ContainsKey(accessControlCode))
                throw new ArgumentNullException();

            return Activator.CreateInstance(factories[accessControlCode]) as IAccessControlFactory;

        }

        private static Dictionary<string, Type> GetFactoriesTypes()
        {
            var dictionary = new Dictionary<string, Type>();
            var accessControlFactoriesCollection = ConfigurationManager.GetSection("AccessControlFactories") as NameValueCollection;

            foreach (var key in accessControlFactoriesCollection.AllKeys)
            {
                Type factoryType = Type.GetType(accessControlFactoriesCollection[key]);

                if (factoryType == null)
                    continue;

                dictionary.Add(key, factoryType);
            }

            return dictionary;
        }


    }
}
