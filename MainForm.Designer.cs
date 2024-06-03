using System.Drawing;
using System;
using System.Windows.Forms;

namespace TournamentScoringSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose method to clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Method to initialize the components of the form
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpAddTeam = new System.Windows.Forms.GroupBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblTeamMembers = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtTeamMembers = new System.Windows.Forms.TextBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.grpAddIndividual = new System.Windows.Forms.GroupBox();
            this.lblIndividualName = new System.Windows.Forms.Label();
            this.txtIndividualName = new System.Windows.Forms.TextBox();
            this.btnAddIndividual = new System.Windows.Forms.Button();
            this.grpRecordScore = new System.Windows.Forms.GroupBox();
            this.lblParticipantName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.txtParticipantName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.btnRecordScore = new System.Windows.Forms.Button();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRankings = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblParticipants = new System.Windows.Forms.Label();
            this.lblRankings = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.grpUpdateParticipant = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateParticipantName = new System.Windows.Forms.TextBox();
            this.txtUpdateScore = new System.Windows.Forms.TextBox();
            this.txtUpdateEventTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateEventType = new System.Windows.Forms.TextBox();
            this.btnUpdateParticipant = new System.Windows.Forms.Button();
            this.btnShowRankings = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpAddTeam.SuspendLayout();
            this.grpAddIndividual.SuspendLayout();
            this.grpRecordScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankings)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanelLeft.SuspendLayout();
            this.grpUpdateParticipant.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            // Title label for the form
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(439, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tournament Scoring System";
            // 
            // grpAddTeam
            // 
            // Group box for adding a team
            this.grpAddTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpAddTeam.Controls.Add(this.lblTeamName);
            this.grpAddTeam.Controls.Add(this.lblTeamMembers);
            this.grpAddTeam.Controls.Add(this.txtTeamName);
            this.grpAddTeam.Controls.Add(this.txtTeamMembers);
            this.grpAddTeam.Controls.Add(this.btnAddTeam);
            this.grpAddTeam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpAddTeam.ForeColor = System.Drawing.Color.White;
            this.grpAddTeam.Location = new System.Drawing.Point(3, 3);
            this.grpAddTeam.MinimumSize = new System.Drawing.Size(380, 0);
            this.grpAddTeam.Name = "grpAddTeam";
            this.grpAddTeam.Size = new System.Drawing.Size(380, 200);
            this.grpAddTeam.TabIndex = 1;
            this.grpAddTeam.TabStop = false;
            this.grpAddTeam.Text = "Add Team";
            // 
            // lblTeamName
            // 
            // Label for team name input
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(20, 40);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(92, 21);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblTeamMembers
            // 
            // Label for team members input
            this.lblTeamMembers.AutoSize = true;
            this.lblTeamMembers.Location = new System.Drawing.Point(20, 90);
            this.lblTeamMembers.Name = "lblTeamMembers";
            this.lblTeamMembers.Size = new System.Drawing.Size(116, 21);
            this.lblTeamMembers.TabIndex = 4;
            this.lblTeamMembers.Text = "Team Members";
            // 
            // txtTeamName
            // 
            // TextBox for team name input
            this.txtTeamName.Location = new System.Drawing.Point(150, 40);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(210, 29);
            this.txtTeamName.TabIndex = 0;
            this.txtTeamName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // txtTeamMembers
            // 
            // TextBox for team members input
            this.txtTeamMembers.Location = new System.Drawing.Point(150, 90);
            this.txtTeamMembers.Name = "txtTeamMembers";
            this.txtTeamMembers.Size = new System.Drawing.Size(210, 29);
            this.txtTeamMembers.TabIndex = 1;
            this.txtTeamMembers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // btnAddTeam
            // 
            // Button to add a team
            this.btnAddTeam.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddTeam.ForeColor = System.Drawing.Color.White;
            this.btnAddTeam.Location = new System.Drawing.Point(285, 135);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 30);
            this.btnAddTeam.TabIndex = 2;
            this.btnAddTeam.Text = "Add";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // grpAddIndividual
            // 
            // Group box for adding an individual
            this.grpAddIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddIndividual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpAddIndividual.Controls.Add(this.lblIndividualName);
            this.grpAddIndividual.Controls.Add(this.txtIndividualName);
            this.grpAddIndividual.Controls.Add(this.btnAddIndividual);
            this.grpAddIndividual.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpAddIndividual.ForeColor = System.Drawing.Color.White;
            this.grpAddIndividual.Location = new System.Drawing.Point(3, 209);
            this.grpAddIndividual.MinimumSize = new System.Drawing.Size(380, 0);
            this.grpAddIndividual.Name = "grpAddIndividual";
            this.grpAddIndividual.Size = new System.Drawing.Size(380, 150);
            this.grpAddIndividual.TabIndex = 2;
            this.grpAddIndividual.TabStop = false;
            this.grpAddIndividual.Text = "Add Individual";
            // 
            // lblIndividualName
            // 
            // Label for individual name input
            this.lblIndividualName.AutoSize = true;
            this.lblIndividualName.Location = new System.Drawing.Point(20, 40);
            this.lblIndividualName.Name = "lblIndividualName";
            this.lblIndividualName.Size = new System.Drawing.Size(124, 21);
            this.lblIndividualName.TabIndex = 4;
            this.lblIndividualName.Text = "Individual Name";
            // 
            // txtIndividualName
            // 
            // TextBox for individual name input
            this.txtIndividualName.Location = new System.Drawing.Point(150, 40);
            this.txtIndividualName.Name = "txtIndividualName";
            this.txtIndividualName.Size = new System.Drawing.Size(210, 29);
            this.txtIndividualName.TabIndex = 0;
            this.txtIndividualName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // btnAddIndividual
            // 
            // Button to add an individual
            this.btnAddIndividual.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddIndividual.ForeColor = System.Drawing.Color.White;
            this.btnAddIndividual.Location = new System.Drawing.Point(285, 90);
            this.btnAddIndividual.Name = "btnAddIndividual";
            this.btnAddIndividual.Size = new System.Drawing.Size(75, 30);
            this.btnAddIndividual.TabIndex = 1;
            this.btnAddIndividual.Text = "Add";
            this.btnAddIndividual.UseVisualStyleBackColor = false;
            this.btnAddIndividual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnAddIndividual.Click += new System.EventHandler(this.btnAddIndividual_Click);
            // 
            // grpRecordScore
            // 
            // Group box for recording a score
            this.grpRecordScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRecordScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpRecordScore.Controls.Add(this.lblParticipantName);
            this.grpRecordScore.Controls.Add(this.lblScore);
            this.grpRecordScore.Controls.Add(this.lblEvent);
            this.grpRecordScore.Controls.Add(this.lblEventType);
            this.grpRecordScore.Controls.Add(this.txtParticipantName);
            this.grpRecordScore.Controls.Add(this.txtScore);
            this.grpRecordScore.Controls.Add(this.txtEvent);
            this.grpRecordScore.Controls.Add(this.txtEventType);
            this.grpRecordScore.Controls.Add(this.btnRecordScore);
            this.grpRecordScore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpRecordScore.ForeColor = System.Drawing.Color.White;
            this.grpRecordScore.Location = new System.Drawing.Point(3, 365);
            this.grpRecordScore.MinimumSize = new System.Drawing.Size(380, 0);
            this.grpRecordScore.Name = "grpRecordScore";
            this.grpRecordScore.Size = new System.Drawing.Size(380, 280);
            this.grpRecordScore.TabIndex = 3;
            this.grpRecordScore.TabStop = false;
            this.grpRecordScore.Text = "Record Score";
            // 
            // lblParticipantName
            // 
            // Label for participant name input
            this.lblParticipantName.AutoSize = true;
            this.lblParticipantName.Location = new System.Drawing.Point(20, 40);
            this.lblParticipantName.Name = "lblParticipantName";
            this.lblParticipantName.Size = new System.Drawing.Size(129, 21);
            this.lblParticipantName.TabIndex = 5;
            this.lblParticipantName.Text = "Participant Name";
            // 
            // lblScore
            // 
            // Label for score input
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(20, 90);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 21);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score";
            // 
            // lblEvent
            // 
            // Label for event title input
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(20, 140);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(81, 21);
            this.lblEvent.TabIndex = 7;
            this.lblEvent.Text = "Event Title";
            // 
            // lblEventType
            // 
            // Label for event category input
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(20, 190);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(115, 21);
            this.lblEventType.TabIndex = 8;
            this.lblEventType.Text = "Event Category";
            // 
            // txtParticipantName
            // 
            // TextBox for participant name input
            this.txtParticipantName.Location = new System.Drawing.Point(150, 40);
            this.txtParticipantName.Name = "txtParticipantName";
            this.txtParticipantName.Size = new System.Drawing.Size(210, 29);
            this.txtParticipantName.TabIndex = 0;
            this.txtParticipantName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // txtScore
            // 
            // TextBox for score input
            this.txtScore.Location = new System.Drawing.Point(150, 90);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(210, 29);
            this.txtScore.TabIndex = 1;
            this.txtScore.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // txtEvent
            // 
            // TextBox for event title input
            this.txtEvent.Location = new System.Drawing.Point(150, 140);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(210, 29);
            this.txtEvent.TabIndex = 2;
            this.txtEvent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // txtEventType
            // 
            // TextBox for event category input
            this.txtEventType.Location = new System.Drawing.Point(150, 190);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(210, 29);
            this.txtEventType.TabIndex = 3;
            this.txtEventType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // btnRecordScore
            // 
            // Button to record the score
            this.btnRecordScore.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRecordScore.ForeColor = System.Drawing.Color.White;
            this.btnRecordScore.Location = new System.Drawing.Point(285, 235);
            this.btnRecordScore.Name = "btnRecordScore";
            this.btnRecordScore.Size = new System.Drawing.Size(75, 30);
            this.btnRecordScore.TabIndex = 4;
            this.btnRecordScore.Text = "Record";
            this.btnRecordScore.UseVisualStyleBackColor = false;
            this.btnRecordScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnRecordScore.Click += new System.EventHandler(this.btnRecordScore_Click);
            // 
            // dgvParticipants
            // 
            // DataGridView to display participants
            this.dgvParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParticipants.BackgroundColor = System.Drawing.Color.White;
            this.dgvParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvParticipants.EnableHeadersVisualStyles = false;
            this.dgvParticipants.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParticipants.Location = new System.Drawing.Point(27, 53);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.Size = new System.Drawing.Size(601, 320);
            this.dgvParticipants.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            // DataGridView column for team/individual
            this.dataGridViewTextBoxColumn4.HeaderText = "Team/Individual";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            // DataGridView column for participant name
            this.dataGridViewTextBoxColumn5.HeaderText = "Participant Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            // DataGridView column for event title
            this.dataGridViewTextBoxColumn6.HeaderText = "Event Title";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            // DataGridView column for total score
            this.dataGridViewTextBoxColumn7.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dgvRankings
            // 
            // DataGridView to display rankings
            this.dgvRankings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRankings.BackgroundColor = System.Drawing.Color.White;
            this.dgvRankings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRankings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvRankings.EnableHeadersVisualStyles = false;
            this.dgvRankings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRankings.Location = new System.Drawing.Point(27, 442);
            this.dgvRankings.Name = "dgvRankings";
            this.dgvRankings.Size = new System.Drawing.Size(601, 320);
            this.dgvRankings.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            // DataGridView column for team/individual in rankings
            this.dataGridViewTextBoxColumn1.HeaderText = "Team/Individual";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 186;
            // 
            // dataGridViewTextBoxColumn2
            // 
            // DataGridView column for participant name in rankings
            this.dataGridViewTextBoxColumn2.HeaderText = "Participant Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 188;
            // 
            // dataGridViewTextBoxColumn3
            // 
            // DataGridView column for total score in rankings
            this.dataGridViewTextBoxColumn3.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 186;
            // 
            // lblParticipants
            // 
            // Label for participants section
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblParticipants.ForeColor = System.Drawing.Color.Black;
            this.lblParticipants.Location = new System.Drawing.Point(22, 15);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(118, 25);
            this.lblParticipants.TabIndex = 7;
            this.lblParticipants.Text = "Participants";
            // 
            // lblRankings
            // 
            // Label for rankings section
            this.lblRankings.AutoSize = true;
            this.lblRankings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRankings.ForeColor = System.Drawing.Color.Black;
            this.lblRankings.Location = new System.Drawing.Point(22, 405);
            this.lblRankings.Name = "lblRankings";
            this.lblRankings.Size = new System.Drawing.Size(94, 25);
            this.lblRankings.TabIndex = 8;
            this.lblRankings.Text = "Rankings";
            // 
            // pnlHeader
            // 
            // Panel for the header section
            this.pnlHeader.BackColor = System.Drawing.Color.Navy;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 80);
            this.pnlHeader.TabIndex = 9;
            this.pnlHeader.Resize += new System.EventHandler(this.pnlHeader_Resize);
            // 
            // pnlContent
            // 
            // Panel for the content section
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1084, 791);
            this.pnlContent.TabIndex = 10;
            // 
            // splitContainer1
            // 
            // SplitContainer to divide the left and right panels
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlRight);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 791);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 11;
            // 
            // flowLayoutPanelLeft
            // 
            // FlowLayoutPanel for the left side controls
            this.flowLayoutPanelLeft.AutoScroll = true;
            this.flowLayoutPanelLeft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanelLeft.Controls.Add(this.grpAddTeam);
            this.flowLayoutPanelLeft.Controls.Add(this.grpAddIndividual);
            this.flowLayoutPanelLeft.Controls.Add(this.grpRecordScore);
            this.flowLayoutPanelLeft.Controls.Add(this.grpUpdateParticipant);
            this.flowLayoutPanelLeft.Controls.Add(this.btnShowRankings);
            this.flowLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLeft.Name = "flowLayoutPanelLeft";
            this.flowLayoutPanelLeft.Size = new System.Drawing.Size(420, 791);
            this.flowLayoutPanelLeft.TabIndex = 0;
            this.flowLayoutPanelLeft.WrapContents = false;
            this.flowLayoutPanelLeft.Resize += new System.EventHandler(this.flowLayoutPanelLeft_Resize);
            // 
            // grpUpdateParticipant
            // 
            // Group box for updating a participant
            this.grpUpdateParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUpdateParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpUpdateParticipant.Controls.Add(this.label4);
            this.grpUpdateParticipant.Controls.Add(this.label3);
            this.grpUpdateParticipant.Controls.Add(this.label2);
            this.grpUpdateParticipant.Controls.Add(this.label1);
            this.grpUpdateParticipant.Controls.Add(this.txtUpdateParticipantName);
            this.grpUpdateParticipant.Controls.Add(this.txtUpdateScore);
            this.grpUpdateParticipant.Controls.Add(this.txtUpdateEventTitle);
            this.grpUpdateParticipant.Controls.Add(this.txtUpdateEventType);
            this.grpUpdateParticipant.Controls.Add(this.btnUpdateParticipant);
            this.grpUpdateParticipant.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpUpdateParticipant.ForeColor = System.Drawing.Color.White;
            this.grpUpdateParticipant.Location = new System.Drawing.Point(3, 651);
            this.grpUpdateParticipant.MinimumSize = new System.Drawing.Size(380, 0);
            this.grpUpdateParticipant.Name = "grpUpdateParticipant";
            this.grpUpdateParticipant.Size = new System.Drawing.Size(380, 250);
            this.grpUpdateParticipant.TabIndex = 10;
            this.grpUpdateParticipant.TabStop = false;
            this.grpUpdateParticipant.Text = "Update Participant";
            // 
            // label4
            // 
            // Label for event category input in update participant section
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Event Category";
            // 
            // label3
            // 
            // Label for event title input in update participant section
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Event Title";
            // 
            // label2
            // 
            // Label for score input in update participant section
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Score";
            // 
            // label1
            // 
            // Label for participant name input in update participant section
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Participant Name";
            // 
            // txtUpdateParticipantName
            // 
            // TextBox for participant name input in update participant section
            this.txtUpdateParticipantName.Location = new System.Drawing.Point(150, 28);
            this.txtUpdateParticipantName.Name = "txtUpdateParticipantName";
            this.txtUpdateParticipantName.Size = new System.Drawing.Size(210, 29);
            this.txtUpdateParticipantName.TabIndex = 1;
            this.txtUpdateParticipantName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // txtUpdateScore
            // 
            // TextBox for score input in update participant section
            this.txtUpdateScore.Location = new System.Drawing.Point(150, 72);
            this.txtUpdateScore.Name = "txtUpdateScore";
            this.txtUpdateScore.Size = new System.Drawing.Size(210, 29);
            this.txtUpdateScore.TabIndex = 3;
            this.txtUpdateScore.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // txtUpdateEventTitle
            // 
            // TextBox for event title input in update participant section
            this.txtUpdateEventTitle.Location = new System.Drawing.Point(150, 120);
            this.txtUpdateEventTitle.Name = "txtUpdateEventTitle";
            this.txtUpdateEventTitle.Size = new System.Drawing.Size(210, 29);
            this.txtUpdateEventTitle.TabIndex = 5;
            this.txtUpdateEventTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // txtUpdateEventType
            // 
            // TextBox for event category input in update participant section
            this.txtUpdateEventType.Location = new System.Drawing.Point(150, 165);
            this.txtUpdateEventType.Name = "txtUpdateEventType";
            this.txtUpdateEventType.Size = new System.Drawing.Size(210, 29);
            this.txtUpdateEventType.TabIndex = 7;
            this.txtUpdateEventType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // btnUpdateParticipant
            // 
            // Button to update the participant information
            this.btnUpdateParticipant.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUpdateParticipant.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateParticipant.Location = new System.Drawing.Point(285, 214);
            this.btnUpdateParticipant.Name = "btnUpdateParticipant";
            this.btnUpdateParticipant.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateParticipant.TabIndex = 8;
            this.btnUpdateParticipant.Text = "Update";
            this.btnUpdateParticipant.UseVisualStyleBackColor = false;
            this.btnUpdateParticipant.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnUpdateParticipant.Click += new System.EventHandler(this.btnUpdateParticipant_Click);
            // 
            // btnShowRankings
            // 
            // Button to show the rankings
            this.btnShowRankings.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnShowRankings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowRankings.ForeColor = System.Drawing.Color.White;
            this.btnShowRankings.Location = new System.Drawing.Point(3, 907);
            this.btnShowRankings.Name = "btnShowRankings";
            this.btnShowRankings.Size = new System.Drawing.Size(200, 35);
            this.btnShowRankings.TabIndex = 9;
            this.btnShowRankings.Text = "Show Rankings";
            this.btnShowRankings.UseVisualStyleBackColor = false;
            this.btnShowRankings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnShowRankings.Click += new System.EventHandler(this.btnShowRankings_Click);
            // 
            // pnlRight
            // 
            // Panel for the right section
            this.pnlRight.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlRight.Controls.Add(this.lblParticipants);
            this.pnlRight.Controls.Add(this.dgvParticipants);
            this.pnlRight.Controls.Add(this.lblRankings);
            this.pnlRight.Controls.Add(this.dgvRankings);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(660, 791);
            this.pnlRight.TabIndex = 1;
            this.pnlRight.Resize += new System.EventHandler(this.pnlRight_Resize);
            // 
            // MainForm
            // 
            // MainForm settings
            this.ClientSize = new System.Drawing.Size(1084, 871);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Scoring System";
            this.grpAddTeam.ResumeLayout(false);
            this.grpAddTeam.PerformLayout();
            this.grpAddIndividual.ResumeLayout(false);
            this.grpAddIndividual.PerformLayout();
            this.grpRecordScore.ResumeLayout(false);
            this.grpRecordScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankings)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanelLeft.ResumeLayout(false);
            this.grpUpdateParticipant.ResumeLayout(false);
            this.grpUpdateParticipant.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpAddTeam;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblTeamMembers;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtTeamMembers;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.GroupBox grpAddIndividual;
        private System.Windows.Forms.Label lblIndividualName;
        private System.Windows.Forms.TextBox txtIndividualName;
        private System.Windows.Forms.Button btnAddIndividual;
        private System.Windows.Forms.GroupBox grpRecordScore;
        private System.Windows.Forms.Label lblParticipantName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.TextBox txtParticipantName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.Button btnRecordScore;
        private System.Windows.Forms.Button btnShowRankings;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.DataGridView dgvRankings;
        private System.Windows.Forms.Label lblParticipants;
        private System.Windows.Forms.Label lblRankings;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox grpUpdateParticipant;
        private System.Windows.Forms.TextBox txtUpdateParticipantName;
        private System.Windows.Forms.TextBox txtUpdateScore;
        private System.Windows.Forms.TextBox txtUpdateEventTitle;
        private System.Windows.Forms.TextBox txtUpdateEventType;
        private System.Windows.Forms.Button btnUpdateParticipant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

