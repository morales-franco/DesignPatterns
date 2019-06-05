using Prototype.Version1.Model;
using System;
using System.Diagnostics;

namespace Prototype.Version1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype V1");

            Stopwatch stopwatch = Stopwatch.StartNew();

            Person personFm = new Person("Franco", new DateTime(1990, 06, 04));
            personFm.AsignCode(1);
            personFm.Print();

            Person fmCopy = new Person("Franco", new DateTime(1990, 06, 04));
            fmCopy.AsignCode(1);
            fmCopy.Print();

            stopwatch.Stop();
            Console.WriteLine($"Delay: { stopwatch.ElapsedMilliseconds } ms");

        }
    }
}
