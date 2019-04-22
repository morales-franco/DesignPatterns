using Factory.Solution1.Entities;
using Factory.Solution1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("WELCOME TO FACTORY.SOLUTION 1");
            Console.WriteLine("Enter the access control code, please");

            string accessControlCode = Console.ReadLine();

            IAccessControl accessControl = GetAccessControl(accessControlCode.ToUpper());
            var users = accessControl.GetUsers();
            var attendances = accessControl.GetAttendeces();


            Console.WriteLine($"Selected Device: { accessControl.Code  }");
            users.ForEach(user => Console.WriteLine(user));
            attendances.ForEach(attendance => Console.WriteLine(attendance));
            Console.ReadLine();
        }

        private static IAccessControl GetAccessControl(string code)
        {
            switch (code)
            {
                case "ZK":
                    return new ZkAccessControl();
                case "LG":
                    return new LgAccessControl();
                case "HP":
                    return new HpAccessControl();
                default:
                    return new NullAccessControl();
            }
        }
    }
}
