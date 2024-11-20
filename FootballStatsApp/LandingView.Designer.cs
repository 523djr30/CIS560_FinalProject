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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UxLandingMenuStrip = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            standingToolStripMenuItem = new ToolStripMenuItem();
            playersToolStripMenuItem = new ToolStripMenuItem();
            teamsToolStripMenuItem = new ToolStripMenuItem();
            UxLandingFlowLayoutPanel = new FlowLayoutPanel();
            UxLandingMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // UxLandingMenuStrip
            // 
            UxLandingMenuStrip.ImageScalingSize = new Size(20, 20);
            UxLandingMenuStrip.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, standingToolStripMenuItem, playersToolStripMenuItem, teamsToolStripMenuItem });
            UxLandingMenuStrip.Location = new Point(0, 0);
            UxLandingMenuStrip.Name = "UxLandingMenuStrip";
            UxLandingMenuStrip.Size = new Size(982, 28);
            UxLandingMenuStrip.TabIndex = 1;
            UxLandingMenuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // standingToolStripMenuItem
            // 
            standingToolStripMenuItem.Name = "standingToolStripMenuItem";
            standingToolStripMenuItem.Size = new Size(88, 24);
            standingToolStripMenuItem.Text = "Standings";
            standingToolStripMenuItem.Click += standingToolStripMenuItem_Click;
            // 
            // playersToolStripMenuItem
            // 
            playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            playersToolStripMenuItem.Size = new Size(69, 24);
            playersToolStripMenuItem.Text = "Players";
            playersToolStripMenuItem.Click += playersToolStripMenuItem_Click;
            // 
            // teamsToolStripMenuItem
            // 
            teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            teamsToolStripMenuItem.Size = new Size(65, 24);
            teamsToolStripMenuItem.Text = "Teams";
            // 
            // UxLandingFlowLayoutPanel
            // 
            UxLandingFlowLayoutPanel.AutoScroll = true;
            UxLandingFlowLayoutPanel.AutoSize = true;
            UxLandingFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UxLandingFlowLayoutPanel.Location = new Point(12, 31);
            UxLandingFlowLayoutPanel.MaximumSize = new Size(2000, 2000);
            UxLandingFlowLayoutPanel.MinimumSize = new Size(500, 500);
            UxLandingFlowLayoutPanel.Name = "UxLandingFlowLayoutPanel";
            UxLandingFlowLayoutPanel.Size = new Size(958, 500);
            UxLandingFlowLayoutPanel.TabIndex = 2;
            // 
            // LandingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(982, 547);
            Controls.Add(UxLandingFlowLayoutPanel);
            Controls.Add(UxLandingMenuStrip);
            MainMenuStrip = UxLandingMenuStrip;
            Name = "LandingView";
            Text = "NFL Stats App";
            Load += LandingView_Load;
            UxLandingMenuStrip.ResumeLayout(false);
            UxLandingMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip UxLandingMenuStrip;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem standingToolStripMenuItem;
        private ToolStripMenuItem playersToolStripMenuItem;
        private ToolStripMenuItem teamsToolStripMenuItem;
        private FlowLayoutPanel UxLandingFlowLayoutPanel;
    }
}
