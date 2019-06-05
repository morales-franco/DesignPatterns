using Prototype.Version2.Model;
using System;
using System.Diagnostics;

namespace Prototype.Version2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype V2");
            Stopwatch stopwatch = Stopwatch.StartNew();
            Person personFm = new Person("Franco", new DateTime(1990, 06, 04));
            personFm.AsignCode(1);
            personFm.Print();

            Person fmCopy = personFm.Clone() as Person;
            fmCopy.Print();

            stopwatch.Stop();
            Console.WriteLine($"Delay: { stopwatch.ElapsedMilliseconds } ms");
        }
    }
}
