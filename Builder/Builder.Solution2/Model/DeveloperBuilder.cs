using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Solution2.Model
{
    class DeveloperBuilder
    {
        Developer developer;

        public Developer GetDeveloper()
        {
            return developer;
        }

        public void CreateDeveloper(string name, string surname)
        {
            developer = new Developer(name, surname);

            FocusInALanguage();
            SelectYourSide();
            GetExperience();
        }

        private void GetExperience()
        {
            developer.Seniority = eSeniority.Senior;
        }

        private void SelectYourSide()
        {
            developer.Type = eDevType.Fullstack;
        }

        private void FocusInALanguage()
        {
            developer.Technology = eTechnology.Dotnet;
        }
    }
}
