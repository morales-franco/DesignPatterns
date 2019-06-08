using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Solution1.Model
{
    class Developer
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public eDevType Type { get; private set; }
        public eSeniority Seniority { get; private set; }
        public eTechnology Technology { get; private set; }

        public Developer(string name, string surname, eDevType type, eTechnology technology, eSeniority seniority)
        {
            Name = name;
            Surname = surname;
            Type = type;
            Seniority = seniority;
            Technology = technology;
        }

        public void Print()
        {
            Console.WriteLine($"Name: { Name } - Surname: { Surname } - Type: { Type.ToString() } - Seniority: { Seniority.ToString() } - Technology: { Technology.ToString() }");
        }

    }
}
