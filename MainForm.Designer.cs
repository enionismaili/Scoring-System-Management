namespace TournamentScoringSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtTeamMembers = new System.Windows.Forms.TextBox();
            this.txtIndividualName = new System.Windows.Forms.TextBox();
            this.txtParticipantName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddIndividual = new System.Windows.Forms.Button();
            this.btnRecordScore = new System.Windows.Forms.Button();
            this.btnShowRankings = new System.Windows.Forms.Button();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.dgvRankings = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankings)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(12, 12);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(150, 20);
            this.txtTeamName.TabIndex = 0;
            this.txtTeamName.Text = "Team Name";
            // 
            // txtTeamMembers
            // 
            this.txtTeamMembers.Location = new System.Drawing.Point(12, 38);
            this.txtTeamMembers.Name = "txtTeamMembers";
            this.txtTeamMembers.Size = new System.Drawing.Size(150, 20);
            this.txtTeamMembers.TabIndex = 1;
            this.txtTeamMembers.Text = "Team Members (comma-separated)";
            // 
            // txtIndividualName
            // 
            this.txtIndividualName.Location = new System.Drawing.Point(12, 64);
            this.txtIndividualName.Name = "txtIndividualName";
            this.txtIndividualName.Size = new System.Drawing.Size(150, 20);
            this.txtIndividualName.TabIndex = 2;
            this.txtIndividualName.Text = "Individual Name";
            // 
            // txtParticipantName
            // 
            this.txtParticipantName.Location = new System.Drawing.Point(12, 90);
            this.txtParticipantName.Name = "txtParticipantName";
            this.txtParticipantName.Size = new System.Drawing.Size(150, 20);
            this.txtParticipantName.TabIndex = 3;
            this.txtParticipantName.Text = "Participant Name";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(12, 116);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(150, 20);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(12, 142);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(150, 20);
            this.txtEvent.TabIndex = 5;
            this.txtEvent.Text = "Event";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(168, 10);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(100, 23);
            this.btnAddTeam.TabIndex = 6;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddIndividual
            // 
            this.btnAddIndividual.Location = new System.Drawing.Point(168, 62);
            this.btnAddIndividual.Name = "btnAddIndividual";
            this.btnAddIndividual.Size = new System.Drawing.Size(100, 23);
            this.btnAddIndividual.TabIndex = 7;
            this.btnAddIndividual.Text = "Add Individual";
            this.btnAddIndividual.UseVisualStyleBackColor = true;
            this.btnAddIndividual.Click += new System.EventHandler(this.btnAddIndividual_Click);
            // 
            // btnRecordScore
            // 
            this.btnRecordScore.Location = new System.Drawing.Point(168, 114);
            this.btnRecordScore.Name = "btnRecordScore";
            this.btnRecordScore.Size = new System.Drawing.Size(100, 23);
            this.btnRecordScore.TabIndex = 8;
            this.btnRecordScore.Text = "Record Score";
            this.btnRecordScore.UseVisualStyleBackColor = true;
            this.btnRecordScore.Click += new System.EventHandler(this.btnRecordScore_Click);
            // 
            // btnShowRankings
            // 
            this.btnShowRankings.Location = new System.Drawing.Point(168, 140);
            this.btnShowRankings.Name = "btnShowRankings";
            this.btnShowRankings.Size = new System.Drawing.Size(100, 23);
            this.btnShowRankings.TabIndex = 9;
            this.btnShowRankings.Text = "Show Rankings";
            this.btnShowRankings.UseVisualStyleBackColor = true;
            this.btnShowRankings.Click += new System.EventHandler(this.btnShowRankings_Click);
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvParticipants.Location = new System.Drawing.Point(12, 170);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.Size = new System.Drawing.Size(776, 150);
            this.dgvParticipants.TabIndex = 10;
            // 
            // dgvRankings
            // 
            this.dgvRankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRankings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvRankings.Location = new System.Drawing.Point(12, 326);
            this.dgvRankings.Name = "dgvRankings";
            this.dgvRankings.Size = new System.Drawing.Size(776, 150);
            this.dgvRankings.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Participant Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Team/Individual";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Participant Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.dgvRankings);
            this.Controls.Add(this.dgvParticipants);
            this.Controls.Add(this.btnShowRankings);
            this.Controls.Add(this.btnRecordScore);
            this.Controls.Add(this.btnAddIndividual);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtParticipantName);
            this.Controls.Add(this.txtIndividualName);
            this.Controls.Add(this.txtTeamMembers);
            this.Controls.Add(this.txtTeamName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Tournament Scoring System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtTeamMembers;
        private System.Windows.Forms.TextBox txtIndividualName;
        private System.Windows.Forms.TextBox txtParticipantName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddIndividual;
        private System.Windows.Forms.Button btnRecordScore;
        private System.Windows.Forms.Button btnShowRankings;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.DataGridView dgvRankings;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
