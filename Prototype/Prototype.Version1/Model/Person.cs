using System;
using System.Threading;

namespace Prototype.Version1.Model
{
    class Person
    {
        private int Code { get;  set; }
        public string Name { get; private set; }
        public DateTime Birth { get; private set; }

        public Person(string name, DateTime birth)
        {
            //Complex operation
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Name = name;
            Birth = birth;
        }

        internal void Print()
        {
            Console.WriteLine($"{ Code } - { Name } - { Birth.ToShortDateString() }");
        }

        public void AsignCode(int code)
        {
            //Complex operation
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Code = code;
        }
    }
}
