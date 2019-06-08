using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Solution3.Model
{
    class ItRecruiter
    {
        private readonly DeveloperBuilder builder;

        public ItRecruiter(DeveloperBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildDeveloper(string name, string surname)
        {
            builder.CreateDeveloper(name, surname);
            builder.FocusInALanguage();
            builder.SelectYourSide();
            builder.GetExperience();
        }

        public Developer GetDeveloper()
        {
            return builder.GetDeveloper();
        }
    }
}
