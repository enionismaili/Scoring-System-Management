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

        private Dictionary<string, int[]> eventPoints;

        public MainForm()
        {
            InitializeComponent();
            teams = new Dictionary<string, List<Participant>>();
            individuals = new List<Participant>();
            teamCount = 0;
            individualCount = 0;
            eventPoints = new Dictionary<string, int[]>
            {
                { "Event1", new int[] { 10, 8, 6, 4, 2 } },
                { "Event2", new int[] { 10, 8, 6, 4, 2 } },
                { "Event3", new int[] { 10, 8, 6, 4, 2 } },
                { "Event4", new int[] { 10, 8, 6, 4, 2 } },
                { "Event5", new int[] { 10, 8, 6, 4, 2 } }
            };
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
                var members = memberNames.Select(name => new Participant(name.Trim(), teamName)).ToList();
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
            string eventType = txtEventType.Text;
            string score = txtScore.Text;
            string eventName = txtEvent.Text;

            foreach (var team in teams.Values)
            {
                var member = team.FirstOrDefault(p => p.Name == participantName);
                if (member != null)
                {
                    if (member.Scores.Any(s => s.Event == eventName))
                    {
                        MessageBox.Show("Participant has already completed this event.");
                        return;
                    }
                    member.AddScore(eventName, score, eventType);
                    UpdateParticipantList();
                    return;
                }
            }

            var individual = individuals.FirstOrDefault(p => p.Name == participantName);
            if (individual != null)
            {
                if (individual.Scores.Any(s => s.Event == eventName))
                {
                    MessageBox.Show("Participant has already completed this event.");
                    return;
                }
                individual.AddScore(eventName, score, eventType);
                UpdateParticipantList();
            }
            else
            {
                MessageBox.Show("Participant not found!");
            }
        }

        private void btnShowRankings_Click(object sender, EventArgs e)
        {
            dgvRankings.Rows.Clear();
            var allParticipants = teams.Values.SelectMany(team => team).Concat(individuals).ToList();
            foreach (var participant in allParticipants)
            {
                participant.TotalPoints = participant.Scores.Sum(s => double.TryParse(s.Score, out var result) ? result : 0);
            }
            foreach (var eventGroup in allParticipants.SelectMany(p => p.Scores).GroupBy(s => s.Event))
            {
                var rankedParticipants = eventGroup.OrderByDescending(s => double.TryParse(s.Score, out var result) ? result : 0).ToList();
                for (int i = 0; i < rankedParticipants.Count; i++)
                {
                    int points = GetPointsForRank(eventGroup.Key, i + 1);
                    var participant = allParticipants.First(p => p.Scores.Contains(rankedParticipants[i]));
                    participant.AddPoints(eventGroup.Key, points);
                }
            }
            var rankings = allParticipants.OrderByDescending(p => p.TotalPoints).ToList();
            foreach (var participant in rankings)
            {
                dgvRankings.Rows.Add(participant.Type == "Individual" ? "Individual" : participant.Type, participant.Name, participant.TotalPoints);
            }
        }

        private int GetPointsForRank(string eventName, int rank)
        {
            if (eventPoints.ContainsKey(eventName))
            {
                var pointsArray = eventPoints[eventName];
                return rank <= pointsArray.Length ? pointsArray[rank - 1] : 0;
            }
            return 0;
        }

        private void UpdateParticipantList()
        {
            dgvParticipants.Rows.Clear();
            foreach (var team in teams)
            {
                foreach (var member in team.Value)
                {
                    dgvParticipants.Rows.Add(team.Key, member.Name, member.TotalScore(), member.Type);
                }
            }
            foreach (var individual in individuals)
            {
                dgvParticipants.Rows.Add("Individual", individual.Name, individual.TotalScore(), individual.Type);
            }
        }

        private void btnUpdatePoints_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            string[] pointsText = txtEventPoints.Text.Split(',');
            int[] points = pointsText.Select(p => int.TryParse(p, out var value) ? value : 0).ToArray();
            UpdateEventPoints(eventName, points);
        }

        private void UpdateEventPoints(string eventName, int[] points)
        {
            if (eventPoints.ContainsKey(eventName))
            {
                eventPoints[eventName] = points;
            }
            else
            {
                eventPoints.Add(eventName, points);
            }
        }

        private void pnlRight_Resize(object sender, EventArgs e)
        {
            // Adjust the height of dgvParticipants and dgvRankings to fit the panel.
            int availableHeight = pnlRight.Height - lblParticipants.Height - lblRankings.Height - 40; // Adjusting for some padding and labels
            int halfHeight = availableHeight / 2;

            dgvParticipants.Height = halfHeight;
            dgvRankings.Height = halfHeight;
            dgvRankings.Top = dgvParticipants.Bottom + 10; // Adding some padding between the grids
        }
    }

    public class Participant
    {
        public string Name { get; set; }
        public string Type { get; private set; }
        public List<(string Event, string Score, string EventType)> Scores { get; private set; }
        public double TotalPoints { get; set; }

        public Participant(string name, string type)
        {
            Name = name;
            Type = type;
            Scores = new List<(string Event, string Score, string EventType)>();
            TotalPoints = 0;
        }

        public void AddScore(string eventName, string score, string eventType)
        {
            Scores.Add((eventName, score, eventType));
        }

        public void AddPoints(string eventName, int points)
        {
            TotalPoints += points;
        }

        public double TotalScore()
        {
            return Scores.Sum(s => double.TryParse(s.Score, out var result) ? result : 0);
        }
    }
}
