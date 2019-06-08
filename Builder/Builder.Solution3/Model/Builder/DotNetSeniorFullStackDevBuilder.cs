namespace Builder.Solution3.Model
{
    class DotNetSeniorFullStackDevBuilder : DeveloperBuilder
    {
        public override void GetExperience()
        {
            developer.Seniority = eSeniority.Senior;
        }

        public override void FocusInALanguage()
        {
            developer.Technology = eTechnology.Dotnet;
        }

        public override void SelectYourSide()
        {
            developer.Type = eDevType.Fullstack;
        }
    }
}
