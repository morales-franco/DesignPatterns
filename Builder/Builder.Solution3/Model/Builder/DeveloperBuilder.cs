namespace Builder.Solution3.Model
{
    abstract class DeveloperBuilder
    {
        protected Developer developer;

        public Developer GetDeveloper()
        {
            return developer;
        }

        public void CreateDeveloper(string name, string surname)
        {
            developer = new Developer(name, surname);
        }

        public abstract void FocusInALanguage();
        public abstract void SelectYourSide();
        public abstract void GetExperience();
    }
}
