using System.Collections.Generic;
using System.Linq;

namespace TournamentScoringSystem
{
    public class Participant
    {
        public string Name { get; set; }
        public string Type { get; private set; } // Team or Individual
        public List<(string Event, int Score)> Scores { get; private set; }

        public Participant(string name, string type)
        {
            Name = name;
            Type = type;
            Scores = new List<(string Event, int Score)>();
        }

        public void AddScore(string eventName, int score)
        {
            Scores.Add((eventName, score));
        }

        public int TotalScore()
        {
            return Scores.Sum(s => s.Score);
        }
    }
}
