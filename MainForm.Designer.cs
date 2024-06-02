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
            this.grpConfigurePoints = new System.Windows.Forms.GroupBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventPoints = new System.Windows.Forms.Label();
            this.txtEventPoints = new System.Windows.Forms.TextBox();
            this.btnUpdatePoints = new System.Windows.Forms.Button();
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
            this.grpConfigurePoints.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
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
            this.grpAddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpAddTeam.Controls.Add(this.lblTeamName);
            this.grpAddTeam.Controls.Add(this.lblTeamMembers);
            this.grpAddTeam.Controls.Add(this.txtTeamName);
            this.grpAddTeam.Controls.Add(this.txtTeamMembers);
            this.grpAddTeam.Controls.Add(this.btnAddTeam);
            this.grpAddTeam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpAddTeam.ForeColor = System.Drawing.Color.White;
            this.grpAddTeam.Location = new System.Drawing.Point(3, 3);
            this.grpAddTeam.Name = "grpAddTeam";
            this.grpAddTeam.Size = new System.Drawing.Size(380, 200);
            this.grpAddTeam.TabIndex = 1;
            this.grpAddTeam.TabStop = false;
            this.grpAddTeam.Text = "Add Team";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(20, 40);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(92, 21);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblTeamMembers
            // 
            this.lblTeamMembers.AutoSize = true;
            this.lblTeamMembers.Location = new System.Drawing.Point(20, 90);
            this.lblTeamMembers.Name = "lblTeamMembers";
            this.lblTeamMembers.Size = new System.Drawing.Size(116, 21);
            this.lblTeamMembers.TabIndex = 4;
            this.lblTeamMembers.Text = "Team Members";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(150, 40);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(210, 29);
            this.txtTeamName.TabIndex = 0;
            // 
            // txtTeamMembers
            // 
            this.txtTeamMembers.Location = new System.Drawing.Point(150, 90);
            this.txtTeamMembers.Name = "txtTeamMembers";
            this.txtTeamMembers.Size = new System.Drawing.Size(210, 29);
            this.txtTeamMembers.TabIndex = 1;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddTeam.ForeColor = System.Drawing.Color.White;
            this.btnAddTeam.Location = new System.Drawing.Point(285, 135);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 30);
            this.btnAddTeam.TabIndex = 2;
            this.btnAddTeam.Text = "Add";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // grpAddIndividual
            // 
            this.grpAddIndividual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpAddIndividual.Controls.Add(this.lblIndividualName);
            this.grpAddIndividual.Controls.Add(this.txtIndividualName);
            this.grpAddIndividual.Controls.Add(this.btnAddIndividual);
            this.grpAddIndividual.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpAddIndividual.ForeColor = System.Drawing.Color.White;
            this.grpAddIndividual.Location = new System.Drawing.Point(3, 209);
            this.grpAddIndividual.Name = "grpAddIndividual";
            this.grpAddIndividual.Size = new System.Drawing.Size(380, 150);
            this.grpAddIndividual.TabIndex = 2;
            this.grpAddIndividual.TabStop = false;
            this.grpAddIndividual.Text = "Add Individual";
            // 
            // lblIndividualName
            // 
            this.lblIndividualName.AutoSize = true;
            this.lblIndividualName.Location = new System.Drawing.Point(20, 40);
            this.lblIndividualName.Name = "lblIndividualName";
            this.lblIndividualName.Size = new System.Drawing.Size(124, 21);
            this.lblIndividualName.TabIndex = 4;
            this.lblIndividualName.Text = "Individual Name";
            // 
            // txtIndividualName
            // 
            this.txtIndividualName.Location = new System.Drawing.Point(150, 40);
            this.txtIndividualName.Name = "txtIndividualName";
            this.txtIndividualName.Size = new System.Drawing.Size(210, 29);
            this.txtIndividualName.TabIndex = 0;
            // 
            // btnAddIndividual
            // 
            this.btnAddIndividual.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddIndividual.ForeColor = System.Drawing.Color.White;
            this.btnAddIndividual.Location = new System.Drawing.Point(285, 90);
            this.btnAddIndividual.Name = "btnAddIndividual";
            this.btnAddIndividual.Size = new System.Drawing.Size(75, 30);
            this.btnAddIndividual.TabIndex = 1;
            this.btnAddIndividual.Text = "Add";
            this.btnAddIndividual.UseVisualStyleBackColor = false;
            this.btnAddIndividual.Click += new System.EventHandler(this.btnAddIndividual_Click);
            // 
            // grpRecordScore
            // 
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
            this.grpRecordScore.Name = "grpRecordScore";
            this.grpRecordScore.Size = new System.Drawing.Size(380, 280);
            this.grpRecordScore.TabIndex = 3;
            this.grpRecordScore.TabStop = false;
            this.grpRecordScore.Text = "Record Score";
            // 
            // lblParticipantName
            // 
            this.lblParticipantName.AutoSize = true;
            this.lblParticipantName.Location = new System.Drawing.Point(20, 40);
            this.lblParticipantName.Name = "lblParticipantName";
            this.lblParticipantName.Size = new System.Drawing.Size(129, 21);
            this.lblParticipantName.TabIndex = 5;
            this.lblParticipantName.Text = "Participant Name";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(20, 90);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 21);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(20, 140);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(48, 21);
            this.lblEvent.TabIndex = 7;
            this.lblEvent.Text = "Event";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(20, 190);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(84, 21);
            this.lblEventType.TabIndex = 8;
            this.lblEventType.Text = "Event Type";
            // 
            // txtParticipantName
            // 
            this.txtParticipantName.Location = new System.Drawing.Point(150, 40);
            this.txtParticipantName.Name = "txtParticipantName";
            this.txtParticipantName.Size = new System.Drawing.Size(210, 29);
            this.txtParticipantName.TabIndex = 0;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(150, 90);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(210, 29);
            this.txtScore.TabIndex = 1;
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(150, 140);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(210, 29);
            this.txtEvent.TabIndex = 2;
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(150, 190);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(210, 29);
            this.txtEventType.TabIndex = 3;
            // 
            // btnRecordScore
            // 
            this.btnRecordScore.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRecordScore.ForeColor = System.Drawing.Color.White;
            this.btnRecordScore.Location = new System.Drawing.Point(285, 235);
            this.btnRecordScore.Name = "btnRecordScore";
            this.btnRecordScore.Size = new System.Drawing.Size(75, 30);
            this.btnRecordScore.TabIndex = 4;
            this.btnRecordScore.Text = "Record";
            this.btnRecordScore.UseVisualStyleBackColor = false;
            this.btnRecordScore.Click += new System.EventHandler(this.btnRecordScore_Click);
            // 
            // dgvParticipants
            // 
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
            this.dataGridViewTextBoxColumn4.HeaderText = "Team/Individual";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Participant Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Event Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dgvRankings
            // 
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
            this.dataGridViewTextBoxColumn1.HeaderText = "Team/Individual";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Participant Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // lblParticipants
            // 
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
            this.flowLayoutPanelLeft.AutoScroll = true;
            this.flowLayoutPanelLeft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanelLeft.Controls.Add(this.grpAddTeam);
            this.flowLayoutPanelLeft.Controls.Add(this.grpAddIndividual);
            this.flowLayoutPanelLeft.Controls.Add(this.grpRecordScore);
            this.flowLayoutPanelLeft.Controls.Add(this.grpConfigurePoints);
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
            // grpConfigurePoints
            // 
            this.grpConfigurePoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpConfigurePoints.Controls.Add(this.lblEventName);
            this.grpConfigurePoints.Controls.Add(this.txtEventName);
            this.grpConfigurePoints.Controls.Add(this.lblEventPoints);
            this.grpConfigurePoints.Controls.Add(this.txtEventPoints);
            this.grpConfigurePoints.Controls.Add(this.btnUpdatePoints);
            this.grpConfigurePoints.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpConfigurePoints.ForeColor = System.Drawing.Color.White;
            this.grpConfigurePoints.Location = new System.Drawing.Point(3, 651);
            this.grpConfigurePoints.Name = "grpConfigurePoints";
            this.grpConfigurePoints.Size = new System.Drawing.Size(380, 200);
            this.grpConfigurePoints.TabIndex = 10;
            this.grpConfigurePoints.TabStop = false;
            this.grpConfigurePoints.Text = "Configure Event Points";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(20, 40);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(94, 21);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Event Name";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(150, 40);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(210, 29);
            this.txtEventName.TabIndex = 1;
            // 
            // lblEventPoints
            // 
            this.lblEventPoints.AutoSize = true;
            this.lblEventPoints.Location = new System.Drawing.Point(20, 90);
            this.lblEventPoints.Name = "lblEventPoints";
            this.lblEventPoints.Size = new System.Drawing.Size(94, 21);
            this.lblEventPoints.TabIndex = 2;
            this.lblEventPoints.Text = "Event Points";
            // 
            // txtEventPoints
            // 
            this.txtEventPoints.Location = new System.Drawing.Point(150, 90);
            this.txtEventPoints.Name = "txtEventPoints";
            this.txtEventPoints.Size = new System.Drawing.Size(210, 29);
            this.txtEventPoints.TabIndex = 3;
            // 
            // btnUpdatePoints
            // 
            this.btnUpdatePoints.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUpdatePoints.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePoints.Location = new System.Drawing.Point(285, 135);
            this.btnUpdatePoints.Name = "btnUpdatePoints";
            this.btnUpdatePoints.Size = new System.Drawing.Size(75, 30);
            this.btnUpdatePoints.TabIndex = 4;
            this.btnUpdatePoints.Text = "Update";
            this.btnUpdatePoints.UseVisualStyleBackColor = false;
            this.btnUpdatePoints.Click += new System.EventHandler(this.btnUpdatePoints_Click);
            // 
            // btnShowRankings
            // 
            this.btnShowRankings.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnShowRankings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowRankings.ForeColor = System.Drawing.Color.White;
            this.btnShowRankings.Location = new System.Drawing.Point(3, 857);
            this.btnShowRankings.Name = "btnShowRankings";
            this.btnShowRankings.Size = new System.Drawing.Size(200, 35);
            this.btnShowRankings.TabIndex = 9;
            this.btnShowRankings.Text = "Show Rankings";
            this.btnShowRankings.UseVisualStyleBackColor = false;
            this.btnShowRankings.Click += new System.EventHandler(this.btnShowRankings_Click);
            // 
            // pnlRight
            // 
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
            this.ClientSize = new System.Drawing.Size(1084, 871);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
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
            this.grpConfigurePoints.ResumeLayout(false);
            this.grpConfigurePoints.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpConfigurePoints;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblEventPoints;
        private System.Windows.Forms.TextBox txtEventPoints;
        private System.Windows.Forms.Button btnUpdatePoints;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

    