using Prototype.Version3.Model;
using System;

namespace Prototype.Version3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype V3");

            Person personFm = new Person("Franco", new DateTime(1990, 06, 04));
            personFm.AsignCode(1);
            personFm.Print();

            Person fmCopy = personFm.Clone() as Person;
            fmCopy.Print();
        }
    }
}
