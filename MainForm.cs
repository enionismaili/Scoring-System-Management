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

        public MainForm()
        {
            InitializeComponent();
            teams = new Dictionary<string, List<Participant>>();
            individuals = new List<Participant>();
            teamCount = 0;
            individualCount = 0;
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
                    member.AddScore(eventName, score);
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
}
