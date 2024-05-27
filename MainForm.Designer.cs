﻿namespace TournamentScoringSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnShowRankings = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpAddTeam.SuspendLayout();
            this.grpAddIndividual.SuspendLayout();
            this.grpRecordScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankings)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
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
            this.grpAddTeam.Location = new System.Drawing.Point(20, 20);
            this.grpAddTeam.Name = "grpAddTeam";
            this.grpAddTeam.Size = new System.Drawing.Size(350, 200);
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
            this.txtTeamName.Size = new System.Drawing.Size(180, 29);
            this.txtTeamName.TabIndex = 0;
            // 
            // txtTeamMembers
            // 
            this.txtTeamMembers.Location = new System.Drawing.Point(150, 90);
            this.txtTeamMembers.Name = "txtTeamMembers";
            this.txtTeamMembers.Size = new System.Drawing.Size(180, 29);
            this.txtTeamMembers.TabIndex = 1;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddTeam.ForeColor = System.Drawing.Color.White;
            this.btnAddTeam.Location = new System.Drawing.Point(255, 135);
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
            this.grpAddIndividual.Location = new System.Drawing.Point(20, 240);
            this.grpAddIndividual.Name = "grpAddIndividual";
            this.grpAddIndividual.Size = new System.Drawing.Size(350, 150);
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
            this.txtIndividualName.Size = new System.Drawing.Size(180, 29);
            this.txtIndividualName.TabIndex = 0;
            // 
            // btnAddIndividual
            // 
            this.btnAddIndividual.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddIndividual.ForeColor = System.Drawing.Color.White;
            this.btnAddIndividual.Location = new System.Drawing.Point(255, 90);
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
            this.grpRecordScore.Location = new System.Drawing.Point(20, 410);
            this.grpRecordScore.Name = "grpRecordScore";
            this.grpRecordScore.Size = new System.Drawing.Size(350, 280);
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
            this.txtParticipantName.Size = new System.Drawing.Size(180, 29);
            this.txtParticipantName.TabIndex = 0;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(150, 90);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(180, 29);
            this.txtScore.TabIndex = 1;
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(150, 140);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(180, 29);
            this.txtEvent.TabIndex = 2;
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(150, 190);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(180, 29);
            this.txtEventType.TabIndex = 3;
            // 
            // btnRecordScore
            // 
            this.btnRecordScore.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRecordScore.ForeColor = System.Drawing.Color.White;
            this.btnRecordScore.Location = new System.Drawing.Point(255, 235);
            this.btnRecordScore.Name = "btnRecordScore";
            this.btnRecordScore.Size = new System.Drawing.Size(75, 30);
            this.btnRecordScore.TabIndex = 4;
            this.btnRecordScore.Text = "Record";
            this.btnRecordScore.UseVisualStyleBackColor = false;
            this.btnRecordScore.Click += new System.EventHandler(this.btnRecordScore_Click);
            // 
            // dgvParticipants
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvParticipants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParticipants.BackgroundColor = System.Drawing.Color.White;
            this.dgvParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvParticipants.EnableHeadersVisualStyles = false;
            this.dgvParticipants.Location = new System.Drawing.Point(449, 31);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.Size = new System.Drawing.Size(600, 320);
            this.dgvParticipants.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Team/Individual";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Participant Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Event Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dgvRankings
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.dgvRankings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRankings.BackgroundColor = System.Drawing.Color.White;
            this.dgvRankings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRankings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRankings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvRankings.EnableHeadersVisualStyles = false;
            this.dgvRankings.Location = new System.Drawing.Point(449, 400);
            this.dgvRankings.Name = "dgvRankings";
            this.dgvRankings.Size = new System.Drawing.Size(600, 320);
            this.dgvRankings.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Team/Individual";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Participant Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblParticipants
            // 
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblParticipants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblParticipants.Location = new System.Drawing.Point(260, 20);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(118, 25);
            this.lblParticipants.TabIndex = 7;
            this.lblParticipants.Text = "Participants";
            // 
            // lblRankings
            // 
            this.lblRankings.AutoSize = true;
            this.lblRankings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRankings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblRankings.Location = new System.Drawing.Point(260, 370);
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
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Controls.Add(this.pnlLeft);
            this.pnlContent.Controls.Add(this.pnlRight);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1084, 791);
            this.pnlContent.TabIndex = 10;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlLeft.Controls.Add(this.grpAddTeam);
            this.pnlLeft.Controls.Add(this.grpAddIndividual);
            this.pnlLeft.Controls.Add(this.grpRecordScore);
            this.pnlLeft.Controls.Add(this.btnShowRankings);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(400, 791);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnShowRankings
            // 
            this.btnShowRankings.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnShowRankings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowRankings.ForeColor = System.Drawing.Color.White;
            this.btnShowRankings.Location = new System.Drawing.Point(20, 735);
            this.btnShowRankings.Name = "btnShowRankings";
            this.btnShowRankings.Size = new System.Drawing.Size(200, 35);
            this.btnShowRankings.TabIndex = 9;
            this.btnShowRankings.Text = "Show Rankings";
            this.btnShowRankings.UseVisualStyleBackColor = false;
            this.btnShowRankings.Click += new System.EventHandler(this.btnShowRankings_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.lblRankings);
            this.pnlRight.Controls.Add(this.lblParticipants);
            this.pnlRight.Controls.Add(this.dgvParticipants);
            this.pnlRight.Controls.Add(this.dgvRankings);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1084, 791);
            this.pnlRight.TabIndex = 1;
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
            this.pnlLeft.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
