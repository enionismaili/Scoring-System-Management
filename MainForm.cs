using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TournamentScoringSystem
{
    // Main form class for the Tournament Scoring System application
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Participant>> teams; // Stores teams and their participants
        private List<Participant> individuals; // Stores individual participants
        private int teamCount; // Current number of teams
        private int individualCount; // Current number of individual participants
        private const int MaxTeams = 4; // Maximum number of teams allowed
        private const int MaxIndividuals = 20; // Maximum number of individual participants allowed
        private const int MaxEvents = 5; // Maximum number of events allowed

        private Dictionary<string, int[]> eventPoints; // Stores points for each event based on ranks

        // Constructor initializes components and data structures
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

        // Event handler for adding a new team
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (teamCount >= MaxTeams)
            {
                MessageBox.Show("Maximum number of teams reached.");
                return;
            }

            string teamName = txtTeamName.Text.Trim();
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

        // Event handler for adding a new individual participant
        private void btnAddIndividual_Click(object sender, EventArgs e)
        {
            if (individualCount >= MaxIndividuals)
            {
                MessageBox.Show("Maximum number of individual participants reached.");
                return;
            }

            string name = txtIndividualName.Text.Trim();
            if (!individuals.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
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

        // Event handler for recording a score for a participant
        private void btnRecordScore_Click(object sender, EventArgs e)
        {
            string participantName = txtParticipantName.Text.Trim();
            string eventType = txtEventType.Text.Trim();
            string score = txtScore.Text.Trim();
            string eventName = txtEvent.Text.Trim();

            var participant = FindParticipant(participantName);

            if (participant != null)
            {
                try
                {
                    participant.AddScore(eventName, score, eventType);
                    UpdateParticipantList();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Participant not found!");
            }
        }

        // Event handler for displaying the rankings
        private void btnShowRankings_Click(object sender, EventArgs e)
        {
            UpdateRankings();
        }

        // Event handler for updating a participant's score
        private void btnUpdateParticipant_Click(object sender, EventArgs e)
        {
            string name = txtUpdateParticipantName.Text.Trim();
            string newScore = txtUpdateScore.Text.Trim();
            string newEventTitle = txtUpdateEventTitle.Text.Trim();
            string newEventType = txtUpdateEventType.Text.Trim();

            var participant = FindParticipant(name);

            if (participant != null)
            {
                try
                {
                    participant.UpdateScore(newEventTitle, newScore, newEventType);
                    UpdateParticipantList();
                    MessageBox.Show("Participant updated successfully!");
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Participant not found!");
            }
        }

        // Finds a participant by name from the teams and individuals lists
        private Participant FindParticipant(string name)
        {
            foreach (var team in teams.Values)
            {
                var member = team.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (member != null)
                {
                    return member;
                }
            }

            return individuals.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Updates the participant list in the DataGridView
        private void UpdateParticipantList()
        {
            dgvParticipants.Rows.Clear();

            foreach (var team in teams)
            {
                foreach (var member in team.Value)
                {
                    dgvParticipants.Rows.Add(team.Key, member.Name, member.GetLatestEvent(), member.TotalScore());
                }
            }

            foreach (var individual in individuals)
            {
                dgvParticipants.Rows.Add("Individual", individual.Name, individual.GetLatestEvent(), individual.TotalScore());
            }
        }

        // Updates the rankings based on participants' scores
        private void UpdateRankings()
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

        // Gets points for a specific rank in an event
        private int GetPointsForRank(string eventName, int rank)
        {
            if (eventPoints.ContainsKey(eventName))
            {
                var pointsArray = eventPoints[eventName];
                return rank <= pointsArray.Length ? pointsArray[rank - 1] : 0;
            }
            return 0;
        }

        // Resizes the right panel to adjust DataGridView heights
        private void pnlRight_Resize(object sender, EventArgs e)
        {
            int availableHeight = pnlRight.Height - lblParticipants.Height - lblRankings.Height - 60;
            int halfHeight = availableHeight / 2;

            dgvParticipants.Height = halfHeight;
            lblRankings.Top = dgvParticipants.Bottom + 10;
            dgvRankings.Top = lblRankings.Bottom + 5;
            dgvRankings.Height = halfHeight;

            dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRankings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Centers the title label in the header panel
        private void pnlHeader_Resize(object sender, EventArgs e)
        {
            lblTitle.Left = (pnlHeader.Width - lblTitle.Width) / 2;
        }

        // Adjusts the width of controls in the left flow layout panel
        private void flowLayoutPanelLeft_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanelLeft.Controls)
            {
                control.Width = flowLayoutPanelLeft.ClientSize.Width - 20;
            }
        }

    }

    // Represents a participant in the tournament
    public class Participant
    {
        public string Name { get; set; }
        public string Type { get; private set; }
        public List<EventScore> Scores { get; private set; }
        public double TotalPoints { get; set; }

        public Participant(string name, string type)
        {
            Name = name;
            Type = type;
            Scores = new List<EventScore>();
            TotalPoints = 0;
        }

        // Adds a score for a participant in an event
        public void AddScore(string eventName, string score, string eventType)
        {
            var existingScore = Scores.FirstOrDefault(s => s.Event == eventName);
            if (existingScore != null)
            {
                existingScore.Score = score;
                existingScore.EventType = eventType;
            }
            else
            {
                Scores.Add(new EventScore(eventName, score, eventType));
            }
        }

        // Adds points to the participant's total score
        public void AddPoints(string eventName, int points)
        {
            TotalPoints += points;
        }

        // Calculates the total score of the participant
        public double TotalScore()
        {
            return Scores.Sum(s => double.TryParse(s.Score, out var result) ? result : 0);
        }

        // Updates the score for a specific event
        public void UpdateScore(string eventName, string newScore, string newEventType)
        {
            var existingScore = Scores.FirstOrDefault(s => s.Event == eventName);
            if (existingScore != null)
            {
                existingScore.Score = newScore;
                existingScore.EventType = newEventType;
            }
            else
            {
                throw new InvalidOperationException("The player hasn't been a part of any event yet!");
            }
        }

        // Gets the latest event the participant participated in
        public string GetLatestEvent()
        {
            return Scores.Count > 0 ? Scores.Last().Event : "";
        }
    }

    // Represents a score in an event for a participant
    public class EventScore
    {
        public string Event { get; set; }
        public string Score { get; set; }
        public string EventType { get; set; }

        public EventScore(string eventName, string score, string eventType)
        {
            Event = eventName;
            Score = score;
            EventType = eventType;
        }
    }
}
