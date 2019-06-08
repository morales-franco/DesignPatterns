namespace Builder.Solution3.Model
{
    class JavaJuniorBackendBuilder : DeveloperBuilder
    {
        public override void GetExperience()
        {
            developer.Seniority = eSeniority.Junior;
        }

        public override void FocusInALanguage()
        {
            developer.Technology = eTechnology.Java;
        }

        public override void SelectYourSide()
        {
            developer.Type = eDevType.Backend;
        }
    }
}
