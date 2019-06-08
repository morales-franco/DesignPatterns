using Builder.Solution4.Model;
using System;

namespace Builder.Solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Solution 4  -----");

            var dotnetSeniorFullstack = Developer.Builder()
                .SetCompleteName("Franco", "Morales")
                .SetType(eDevType.Fullstack)
                .SetSeniority(eSeniority.Senior)
                .SetTechnology(eTechnology.Dotnet)
                .Build();

            dotnetSeniorFullstack.Print();

            var javaBackendJunior = Developer.Builder()
                .SetCompleteName("Oscar", "De Santi")
                .SetType(eDevType.Backend)
                .SetSeniority(eSeniority.Junior)
                .SetTechnology(eTechnology.Java)
                .Build();

            javaBackendJunior.Print();
        }
    }
}
