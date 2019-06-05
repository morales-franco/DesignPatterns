using System;
using System.Threading;

namespace Prototype.Version3.Model
{
    class Person : ICloneable
    {
        public int Code { get; private set; }
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

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
