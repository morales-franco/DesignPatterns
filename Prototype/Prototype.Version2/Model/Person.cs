using System;
using System.Threading;

namespace Prototype.Version2.Model
{
    class Person: IPrototype
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

        //Constructor to copy STATE of original object
        public Person(Person original)
        {
            Birth = original.Birth;
            Code = original.Code;
            Name = original.Name;
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

        public IPrototype Clone()
        {
            return new Person(this);
        }
    }
}
