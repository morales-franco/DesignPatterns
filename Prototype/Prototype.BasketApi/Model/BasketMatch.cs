using System;

namespace Prototype.BasketApi.Model
{
    public class BasketMatch: ICloneable
    {
        public int Id { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public int ScoreTeamA { get; set; }
        public int ScoreTeamB { get; set; }

        private BasketMatch()
        {

        }

        private BasketMatch(int id)
        {
            Id = id;
        }

        private BasketMatch(int id, string teamA, string teamB)
            : this(id)
        {
            TeamA = teamA;
            TeamB = teamB;
        }

        internal BasketMatch(int id, string teamA, string teamB, int scoreA, int scoreB)
            : this(id, teamA, teamB)
        {
            ScoreTeamA = scoreA;
            ScoreTeamB = scoreB;
        }

        public string Print()
        {
            return $"Match Id: { Id } - Team A: { TeamA} - Team B: { TeamB} - Score Team A: { ScoreTeamA} - Score Team B: { ScoreTeamB }";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
