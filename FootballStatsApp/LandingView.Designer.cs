namespace FootballStatsApp
{
    partial class LandingView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UxLandingMenuStrip = new System.Windows.Forms.MenuStrip();
            homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            standingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            joinTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mathcesBetweenTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            UxLandingFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            UxLandingMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // UxLandingMenuStrip
            // 
            UxLandingMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            UxLandingMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { homeToolStripMenuItem, standingToolStripMenuItem, playersToolStripMenuItem, teamsToolStripMenuItem, addPlayerToolStripMenuItem, joinTeamToolStripMenuItem, addMatchToolStripMenuItem, mathcesBetweenTeamsToolStripMenuItem });
            UxLandingMenuStrip.Location = new System.Drawing.Point(0, 0);
            UxLandingMenuStrip.Name = "UxLandingMenuStrip";
            UxLandingMenuStrip.Size = new System.Drawing.Size(982, 28);
            UxLandingMenuStrip.TabIndex = 1;
            UxLandingMenuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // standingToolStripMenuItem
            // 
            standingToolStripMenuItem.Name = "standingToolStripMenuItem";
            standingToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            standingToolStripMenuItem.Text = "Standings";
            standingToolStripMenuItem.Click += standingToolStripMenuItem_Click;
            // 
            // playersToolStripMenuItem
            // 
            playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            playersToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            playersToolStripMenuItem.Text = "Players";
            playersToolStripMenuItem.Click += playersToolStripMenuItem_Click;
            // 
            // teamsToolStripMenuItem
            // 
            teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            teamsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            teamsToolStripMenuItem.Text = "Teams";
            teamsToolStripMenuItem.Click += teamsToolStripMenuItem_Click;
            // 
            // addPlayerToolStripMenuItem
            // 
            addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            addPlayerToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            addPlayerToolStripMenuItem.Text = "Add Player";
            addPlayerToolStripMenuItem.Click += addPlayerToolStripMenuItem_Click;
            // 
            // joinTeamToolStripMenuItem
            // 
            joinTeamToolStripMenuItem.Name = "joinTeamToolStripMenuItem";
            joinTeamToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            joinTeamToolStripMenuItem.Text = "Join Team";
            joinTeamToolStripMenuItem.Click += joinTeamToolStripMenuItem_Click;
            // 
            // addMatchToolStripMenuItem
            // 
            addMatchToolStripMenuItem.Name = "addMatchToolStripMenuItem";
            addMatchToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            addMatchToolStripMenuItem.Text = "Add Match";
            addMatchToolStripMenuItem.Click += addMatchToolStripMenuItem_Click;
            // 
            // mathcesBetweenTeamsToolStripMenuItem
            // 
            mathcesBetweenTeamsToolStripMenuItem.Name = "mathcesBetweenTeamsToolStripMenuItem";
            mathcesBetweenTeamsToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            mathcesBetweenTeamsToolStripMenuItem.Text = "Matches Between Teams";
            mathcesBetweenTeamsToolStripMenuItem.Click += mathcesBetweenTeamsToolStripMenuItem_Click;
            // 
            // UxLandingFlowLayoutPanel
            // 
            UxLandingFlowLayoutPanel.AutoScroll = true;
            UxLandingFlowLayoutPanel.AutoSize = true;
            UxLandingFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            UxLandingFlowLayoutPanel.Location = new System.Drawing.Point(12, 31);
            UxLandingFlowLayoutPanel.MaximumSize = new System.Drawing.Size(2000, 2000);
            UxLandingFlowLayoutPanel.MinimumSize = new System.Drawing.Size(1000, 500);
            UxLandingFlowLayoutPanel.Name = "UxLandingFlowLayoutPanel";
            UxLandingFlowLayoutPanel.Size = new System.Drawing.Size(1000, 1000);
            UxLandingFlowLayoutPanel.TabIndex = 2;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // LandingView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(982, 547);
            Controls.Add(UxLandingFlowLayoutPanel);
            Controls.Add(UxLandingMenuStrip);
            MainMenuStrip = UxLandingMenuStrip;
            Text = "NFL Stats App";
            Load += LandingView_Load;
            UxLandingMenuStrip.ResumeLayout(false);
            UxLandingMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        #endregion
        private MenuStrip UxLandingMenuStrip;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem standingToolStripMenuItem;
        private ToolStripMenuItem playersToolStripMenuItem;
        private ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel UxLandingFlowLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathcesBetweenTeamsToolStripMenuItem;
    }
}
