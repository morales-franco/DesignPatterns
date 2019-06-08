using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Solution3.Model
{
    class Developer
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public eDevType Type { get; set; }
        public eSeniority Seniority { get; set; }
        public eTechnology Technology { get; set; }

        public Developer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void Print()
        {
            Console.WriteLine($"Name: { Name } - Surname: { Surname } - Type: { Type.ToString() } - Seniority: { Seniority.ToString() } - Technology: { Technology.ToString() }");
        }

    }
}
