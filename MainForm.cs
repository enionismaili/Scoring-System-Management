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

        public MainForm()
        {
            InitializeComponent();
            teams = new Dictionary<string, List<Participant>>();
            individuals = new List<Participant>();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            string teamName = txtTeamName.Text;
            string[] memberNames = txtTeamMembers.Text.Split(',');

            if (!teams.ContainsKey(teamName))
            {
                var members = memberNames.Select(name => new Participant(name.Trim())).ToList();
                teams[teamName] = members;
                UpdateParticipantList();
            }
            else
            {
                MessageBox.Show("Team already exists!");
            }
        }

        private void btnAddIndividual_Click(object sender, EventArgs e)
        {
            string name = txtIndividualName.Text;
            if (!individuals.Any(p => p.Name == name))
            {
                individuals.Add(new Participant(name));
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
                    member.AddScore(eventName, score);
                    UpdateParticipantList();
                    return;
                }
            }

            var individual = individuals.FirstOrDefault(p => p.Name == participantName);
            if (individual != null)
            {
                individual.AddScore(eventName, score);
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
            var rankings = allParticipants.OrderByDescending(p => p.TotalScore()).ToList();

            dgvRankings.Rows.Clear();
            foreach (var participant in rankings)
            {
                dgvRankings.Rows.Add(participant.Name, participant.TotalScore());
            }
        }

        private void UpdateParticipantList()
        {
            dgvParticipants.Rows.Clear();
            foreach (var team in teams)
            {
                foreach (var member in team.Value)
                {
                    dgvParticipants.Rows.Add(team.Key, member.Name, member.TotalScore());
                }
            }

            foreach (var individual in individuals)
            {
                dgvParticipants.Rows.Add("Individual", individual.Name, individual.TotalScore());
            }
        }
    }

    public class Participant
    {
        public string Name { get; set; }
        public List<(string Event, int Score)> Scores { get; private set; }

        public Participant(string name)
        {
            Name = name;
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
