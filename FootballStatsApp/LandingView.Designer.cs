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
            standingToolStripMenuItem = new ToolStripMenuItem();
            playersToolStripMenuItem = new ToolStripMenuItem();
            teamsToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            UxLandingFlowLayoutPanel = new FlowLayoutPanel();
            UxWelcomeLabel = new Label();
            UxSiteNameLabel = new Label();
            UxSpacingLabel = new Label();
            nFCVAFCToolStripMenuItem = new ToolStripMenuItem();
            nFCToolStripMenuItem = new ToolStripMenuItem();
            aFCToolStripMenuItem = new ToolStripMenuItem();
            UxLandingMenuStrip.SuspendLayout();
            UxLandingFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxLandingMenuStrip
            // 
            UxLandingMenuStrip.ImageScalingSize = new Size(20, 20);
            UxLandingMenuStrip.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, standingToolStripMenuItem, playersToolStripMenuItem, teamsToolStripMenuItem });
            UxLandingMenuStrip.Location = new Point(0, 0);
            UxLandingMenuStrip.Name = "UxLandingMenuStrip";
            UxLandingMenuStrip.Size = new Size(518, 28);
            UxLandingMenuStrip.TabIndex = 1;
            UxLandingMenuStrip.Text = "menuStrip1";
            // 
            // standingToolStripMenuItem
            // 
            standingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nFCVAFCToolStripMenuItem, nFCToolStripMenuItem, aFCToolStripMenuItem });
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
            // 
            // teamsToolStripMenuItem
            // 
            teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            teamsToolStripMenuItem.Size = new Size(65, 24);
            teamsToolStripMenuItem.Text = "Teams";
            // 
            // hOMEToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // flowLayoutPanel1
            // 
            UxLandingFlowLayoutPanel.AutoSize = true;
            UxLandingFlowLayoutPanel.Controls.Add(UxWelcomeLabel);
            UxLandingFlowLayoutPanel.Controls.Add(UxSpacingLabel);
            UxLandingFlowLayoutPanel.Controls.Add(UxSiteNameLabel);
            UxLandingFlowLayoutPanel.Dock = DockStyle.Left;
            UxLandingFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UxLandingFlowLayoutPanel.Location = new Point(0, 28);
            UxLandingFlowLayoutPanel.Name = "flowLayoutPanel1";
            UxLandingFlowLayoutPanel.Size = new Size(364, 348);
            UxLandingFlowLayoutPanel.TabIndex = 4;
            // 
            // UxWelcomeLabel
            // 
            UxWelcomeLabel.AutoSize = true;
            UxWelcomeLabel.Font = new Font("Segoe UI", 22F);
            UxWelcomeLabel.Location = new Point(3, 0);
            UxWelcomeLabel.Name = "UxWelcomeLabel";
            UxWelcomeLabel.Size = new Size(243, 50);
            UxWelcomeLabel.TabIndex = 0;
            UxWelcomeLabel.Text = "Welcome to...";
            // 
            // UxSiteNameLabel
            // 
            UxSiteNameLabel.AutoSize = true;
            UxSiteNameLabel.Font = new Font("Segoe UI", 33F);
            UxSiteNameLabel.Location = new Point(3, 70);
            UxSiteNameLabel.Name = "UxSiteNameLabel";
            UxSiteNameLabel.Size = new Size(358, 74);
            UxSiteNameLabel.TabIndex = 1;
            UxSiteNameLabel.Text = "NFLStats.com";
            // 
            // UxSpacingLabel
            // 
            UxSpacingLabel.AutoSize = true;
            UxSpacingLabel.Location = new Point(3, 50);
            UxSpacingLabel.Name = "UxSpacingLabel";
            UxSpacingLabel.Size = new Size(0, 20);
            UxSpacingLabel.TabIndex = 2;
            // 
            // nFCVAFCToolStripMenuItem
            // 
            nFCVAFCToolStripMenuItem.Name = "nFCVAFCToolStripMenuItem";
            nFCVAFCToolStripMenuItem.Size = new Size(224, 26);
            nFCVAFCToolStripMenuItem.Text = "NFC v AFC";
            // 
            // nFCToolStripMenuItem
            // 
            nFCToolStripMenuItem.Name = "nFCToolStripMenuItem";
            nFCToolStripMenuItem.Size = new Size(224, 26);
            nFCToolStripMenuItem.Text = "NFC";
            // 
            // aFCToolStripMenuItem
            // 
            aFCToolStripMenuItem.Name = "aFCToolStripMenuItem";
            aFCToolStripMenuItem.Size = new Size(224, 26);
            aFCToolStripMenuItem.Text = "AFC";
            // 
            // LandingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 376);
            Controls.Add(UxLandingFlowLayoutPanel);
            Controls.Add(UxLandingMenuStrip);
            MainMenuStrip = UxLandingMenuStrip;
            Name = "LandingView";
            Text = "NFL Stats App";
            Load += this.LandingView_Load;
            UxLandingMenuStrip.ResumeLayout(false);
            UxLandingMenuStrip.PerformLayout();
            UxLandingFlowLayoutPanel.ResumeLayout(false);
            UxLandingFlowLayoutPanel.PerformLayout();
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
        private Label UxWelcomeLabel;
        private Label UxSiteNameLabel;
        private Label UxSpacingLabel;
        private ToolStripMenuItem nFCVAFCToolStripMenuItem;
        private ToolStripMenuItem nFCToolStripMenuItem;
        private ToolStripMenuItem aFCToolStripMenuItem;
    }
}
