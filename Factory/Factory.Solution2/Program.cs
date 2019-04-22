using Factory.Solution2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("WELCOME TO FACTORY.SOLUTION 2");
            Console.WriteLine("Enter the access control code, please");

            string accessControlCode = Console.ReadLine();

            AccessControlFactory factory = new AccessControlFactory();
            IAccessControl accessControl = factory.CreateInstance(accessControlCode);
            var users = accessControl.GetUsers();
            var attendances = accessControl.GetAttendeces();


            Console.WriteLine($"Selected Device: { accessControl.Code  }");
            users.ForEach(user => Console.WriteLine(user));
            attendances.ForEach(attendance => Console.WriteLine(attendance));
            Console.ReadLine();
        }
    }
}
