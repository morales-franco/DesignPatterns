using Builder.Solution1.Model;
using System;

namespace Builder.Solution1
{
    class Program
    {
        /*
         * We only build Dot Net Senior FullStack Developers
         */
        static void Main(string[] args)
        {
            Console.WriteLine("---- Solution 1 -----");

            var dotnetSeniorFullstack = new Developer("Franco", "Morales", eDevType.Fullstack, eTechnology.Dotnet, eSeniority.Senior);

            dotnetSeniorFullstack.Print();

        }
    }
}
