using System;
using System.Threading;

namespace Prototype.Version4.Model
{
    class Match: ICloneable
    {
        public int Id { get; private set; }
        public DateTime SyncDate { get; private set; }
        public string TeamA { get; private set; }

        public string TeamB { get; private set; }
        public int ScoreTeamA { get; private set; }
        public int ScoreTeamB { get; private set; }
        public float ProbabilityThatTeamAWins { get; private set; }

        public Match()
        {
            CallApi();
            ProbabilityThatTeamAWins = CalculateProbabilityThatTeamAWins();
        }

        private void CallApi()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Id = 1;
            SyncDate = DateTime.Now;
            TeamA = "River Plate";
            TeamB = "Barcelona F.C";
            ScoreTeamA = 0;
            ScoreTeamB = 1;
        }

        private float CalculateProbabilityThatTeamAWins()
        {
            float probability = 0f;
            DoComplexOperationA(ref probability);
            DoComplexOperationB(ref probability);
            DoComplexOperationC(ref probability);
            ApplyNBusinessRules(ref probability);
            return probability;
        }

        private void ApplyNBusinessRules(ref float probability)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            probability = new Random().Next(0, 100) / 100.0f;
        }

        private void DoComplexOperationC(ref float probability)
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            probability = new Random().Next(0, 100) / 100.0f;
        }

        private void DoComplexOperationB(ref float probability)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            probability = new Random().Next(0, 100) / 100.0f;
        }

        private void DoComplexOperationA(ref float probability)
        {
            Thread.Sleep(TimeSpan.FromSeconds(6));
            probability = new Random().Next(0, 100) / 100.0f;
        }

        public string Print()
        {
            return $"Match Id: { Id } - Team A: { TeamA} - Team B: { TeamB} - Score Team A: { ScoreTeamA} - Score Team B: { ScoreTeamB } - Probability that Team A wins the match: { ProbabilityThatTeamAWins * 100 } %";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
