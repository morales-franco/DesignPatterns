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

        //Recipe to create Developers!
        public void BuildDeveloper(string name, string surname)
        {
            //Step 1: Init Developer            
            builder.CreateDeveloper(name, surname);
            //Step 2  
            builder.FocusInALanguage(); 
            //Step 3
            builder.SelectYourSide();
            //Step 4
            builder.GetExperience();
        }

        public Developer GetDeveloper()
        {
            return builder.GetDeveloper();
        }
    }
}
