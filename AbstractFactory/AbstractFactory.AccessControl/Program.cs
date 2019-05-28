using AbstractFactory.AccessControl.AccessControls;
using AbstractFactory.AccessControl.Factories;
using System;

namespace AbstractFactory.AccessControl
{
    class Program
    {
        private static IAccessControlAbstractFactory factory;

        static void Main(string[] args)
        {
            Console.WriteLine("Access Control Abstract Factory");


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Biometric - Access Controls");
            factory = new BiometricFactory();

            IHpAccessControl hpAccessControl = factory.CreateHp();
            ILgAccessControl lgAccessControl = factory.CreateLg();
            IZkAccessControl zkAccessControl = factory.CreateZk();

            Console.WriteLine($"Hp: { hpAccessControl.Code }");
            Console.WriteLine($"Lg: { lgAccessControl.Code }");
            Console.WriteLine($"Zk: { zkAccessControl.Code }");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Card - Access Controls");
            factory = new CardFactory();

            hpAccessControl = factory.CreateHp();
            lgAccessControl = factory.CreateLg();
            zkAccessControl = factory.CreateZk();

            Console.WriteLine($"Hp: { hpAccessControl.Code }");
            Console.WriteLine($"Lg: { lgAccessControl.Code }");
            Console.WriteLine($"Zk: { zkAccessControl.Code }");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fingerprint - Access Controls");
            factory = new FingerprintFactory();

            hpAccessControl = factory.CreateHp();
            lgAccessControl = factory.CreateLg();
            zkAccessControl = factory.CreateZk();

            Console.WriteLine($"Hp: { hpAccessControl.Code }");
            Console.WriteLine($"Lg: { lgAccessControl.Code }");
            Console.WriteLine($"Zk: { zkAccessControl.Code }");

        }
    }
}
