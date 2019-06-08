using Builder.Solution2.Model;
using System;

namespace Builder.Solution2
{
    /*
     * We only build Dot Net Senior FullStack Developers
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Solution 2  -----");

            var builder = new DeveloperBuilder();
            builder.CreateDeveloper("Franco", "Morales");
            var dotnetSeniorFullstack = builder.GetDeveloper();
            dotnetSeniorFullstack.Print();
        }
    }
}
