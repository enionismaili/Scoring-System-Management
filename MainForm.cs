using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TournamentScoringSystem
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Participant>> teams;
        private List<Participant> individuals;
        private int teamCount;
        private int individualCount;
        private const int MaxTeams = 4;
        private const int MaxIndividuals = 20;
        private const int MaxEvents = 5;

        private Dictionary<string, int[]> eventPoints; // Dictionary to hold points for events

        public MainForm()
        {
            InitializeComponent();
            teams = new Dictionary<string, List<Participant>>();
            individuals = new List<Participant>();
            teamCount = 0;
            individualCount = 0;
            eventPoints = new Dictionary<string, int[]>(); // Initialize event points
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (teamCount >= MaxTeams)
            {
                MessageBox.Show("Maximum number of teams reached.");
                return;
            }

            string teamName = txtTeamName.Text;
            string[] memberNames = txtTeamMembers.Text.Split(',');

            if (memberNames.Length != 5)
            {
                MessageBox.Show("Each team must have 5 members.");
                return;
            }

            if (!teams.ContainsKey(teamName))
            {
                var members = memberNames.Select(name => new Participant(name.Trim(), "Team")).ToList();
                teams[teamName] = members;
                teamCount++;
                UpdateParticipantList();
            }
            else
            {
                MessageBox.Show("Team already exists!");
            }
        }

        private void btnAddIndividual_Click(object sender, EventArgs e)
        {
            if (individualCount >= MaxIndividuals)
            {
                MessageBox.Show("Maximum number of individual participants reached.");
                return;
            }

            string name = txtIndividualName.Text;
            if (!individuals.Any(p => p.Name == name))
            {
                individuals.Add(new Participant(name, "Individual"));
                individualCount++;
                UpdateParticipantList();
            }
            else
            {
                MessageBox.Show("Individual already exists!");
            }
        }

        private void btnRecordScore_Click(object sender, EventArgs e)
        {
            string participantName = txtParticipantName.Text;
            string eventType = txtEventType.Text; // Get the event type
            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Invalid score value.");
                return;
            }
            string eventName = txtEvent.Text;

            foreach (var team in teams.Values)
            {
                var member = team.FirstOrDefault(p => p.Name == participantName);
                if (member != null)
                {
                    if (member.Scores.Count >= MaxEvents)
                    {
                        MessageBox.Show("Participant has already completed the maximum number of events.");
                        return;
                    }
                    member.AddScore(eventName, score, eventType); // Include event type
                    UpdateParticipantList();
                    return;
                }
            }

            var individual = individuals.FirstOrDefault(p => p.Name == participantName);
            if (individual != null)
            {
                if (individual.Scores.Count >= MaxEvents)
                {
                    MessageBox.Show("Participant has already completed the maximum number of events.");
                    return;
                }
                individual.AddScore(eventName, score, eventType); // Include event type
                UpdateParticipantList();
            }
            else
            {
                MessageBox.Show("Participant not found!");
            }
        }

        private void btnShowRankings_Click(object sender, EventArgs e)
        {
            var allParticipants = teams.Values.SelectMany(team => team).Concat(individuals).ToList();

            // Rank participants for each event and assign points
            foreach (var eventGroup in allParticipants.SelectMany(p => p.Scores).GroupBy(s => s.Event))
            {
                var rankedParticipants = eventGroup.OrderByDescending(s => s.Score).ToList();
                for (int i = 0; i < rankedParticipants.Count; i++)
                {
                    int points = GetPointsForRank(eventGroup.Key, i + 1);
                    var participant = allParticipants.First(p => p.Scores.Contains(rankedParticipants[i]));
                    participant.AddScore(eventGroup.Key, points, rankedParticipants[i].EventType);
                }
            }

            var rankings = allParticipants.OrderByDescending(p => p.TotalScore()).ToList();

            dgvRankings.Rows.Clear();
            foreach (var participant in rankings)
            {
                dgvRankings.Rows.Add(participant.Name, participant.TotalScore());
            }
        }

        private int GetPointsForRank(string eventName, int rank)
        {
            if (eventPoints.ContainsKey(eventName))
            {
                var pointsArray = eventPoints[eventName];
                return rank <= pointsArray.Length ? pointsArray[rank - 1] : 0;
            }
            return 0; // Default points if not defined
        }

        private void UpdateParticipantList()
        {
            dgvParticipants.Rows.Clear();
            foreach (var team in teams)
            {
                foreach (var member in team.Value)
                {
                    foreach (var score in member.Scores)
                    {
                        dgvParticipants.Rows.Add(team.Key, member.Name, member.TotalScore(), score.EventType); // Include event type
                    }
                }
            }

            foreach (var individual in individuals)
            {
                foreach (var score in individual.Scores)
                {
                    dgvParticipants.Rows.Add("Individual", individual.Name, individual.TotalScore(), score.EventType); // Include event type
                }
            }
        }
    }

    public class Participant
    {
        public string Name { get; set; }
        public string Type { get; private set; } // Team or Individual
        public List<(string Event, int Score, string EventType)> Scores { get; private set; } // Include event type

        public Participant(string name, string type)
        {
            Name = name;
            Type = type;
            Scores = new List<(string Event, int Score, string EventType)>();
        }

        public void AddScore(string eventName, int score, string eventType) // Include event type
        {
            Scores.Add((eventName, score, eventType));
        }

        public int TotalScore()
        {
            return Scores.Sum(s => s.Score);
        }
    }
}
