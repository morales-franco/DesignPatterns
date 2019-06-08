using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Solution4.Model
{
    class Developer
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public eDevType Type { get; set; }
        public eSeniority Seniority { get; set; }
        public eTechnology Technology { get; set; }

        public Developer() { }

        public Developer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void Print()
        {
            Console.WriteLine($"Name: { Name } - Surname: { Surname } - Type: { Type.ToString() } - Seniority: { Seniority.ToString() } - Technology: { Technology.ToString() }");
        }

        public static DeveloperBuilder Builder()
        {
            return new DeveloperBuilder();
        }


        public class DeveloperBuilder
        {
            private string Name;
            private string Surname;
            private eDevType Type;
            private eSeniority Seniority;
            private eTechnology Technology;

            public DeveloperBuilder SetCompleteName(string name, string surname)
            {
                Name = name;
                Surname = surname;
                return this;
            }

            public DeveloperBuilder SetType(eDevType type)
            {
                Type = type;
                return this;
            }

            public DeveloperBuilder SetSeniority(eSeniority seniority)
            {
                Seniority = seniority;
                return this;
            }

            public DeveloperBuilder SetTechnology(eTechnology technology)
            {
                Technology = technology;
                return this;
            }

            public Developer Build()
            {
                Developer developer = new Developer(Name, Surname);
                developer.Seniority = Seniority;
                developer.Technology = Technology;
                developer.Type = Type;

                return developer;
            }

        }

    }
}
