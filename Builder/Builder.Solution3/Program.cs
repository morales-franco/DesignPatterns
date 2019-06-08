using Builder.Solution3.Model;
using System;

namespace Builder.Solution3
{
    /*
     * We  build Dot Net Senior FullStack &
     * Java Junior Backend Developers
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Solution 3  -----");

            var recruiterDotNetMaker = new ItRecruiter(new DotNetSeniorFullStackDevBuilder());
            recruiterDotNetMaker.BuildDeveloper("Franco", "Morales");
            var dotnetSeniorFullstack = recruiterDotNetMaker.GetDeveloper();
            dotnetSeniorFullstack.Print();

            var recruiterJavaMaker = new ItRecruiter(new JavaJuniorBackendBuilder());
            recruiterJavaMaker.BuildDeveloper("Oscar", "De Santi");
            var javaBackendJunior = recruiterJavaMaker.GetDeveloper();
            javaBackendJunior.Print();
        }
    }
}
