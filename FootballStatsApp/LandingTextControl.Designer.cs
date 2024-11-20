namespace FootballStatsApp
{
    partial class LandingTextControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UxLandingFlowLayoutPanel = new FlowLayoutPanel();
            UxWelcomeLabel = new Label();
            UxSpacingLabel = new Label();
            UxSiteNameLabel = new Label();
            UxLandingFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxLandingFlowLayoutPanel
            // 
            UxLandingFlowLayoutPanel.AutoSize = true;
            UxLandingFlowLayoutPanel.Controls.Add(UxWelcomeLabel);
            UxLandingFlowLayoutPanel.Controls.Add(UxSpacingLabel);
            UxLandingFlowLayoutPanel.Controls.Add(UxSiteNameLabel);
            UxLandingFlowLayoutPanel.Dock = DockStyle.Left;
            UxLandingFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UxLandingFlowLayoutPanel.Location = new Point(0, 0);
            UxLandingFlowLayoutPanel.Name = "UxLandingFlowLayoutPanel";
            UxLandingFlowLayoutPanel.Size = new Size(364, 500);
            UxLandingFlowLayoutPanel.TabIndex = 5;
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
            // UxSpacingLabel
            // 
            UxSpacingLabel.AutoSize = true;
            UxSpacingLabel.Location = new Point(3, 50);
            UxSpacingLabel.Name = "UxSpacingLabel";
            UxSpacingLabel.Size = new Size(0, 20);
            UxSpacingLabel.TabIndex = 2;
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
            // LandingTextControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UxLandingFlowLayoutPanel);
            Name = "LandingTextControl";
            Size = new Size(500, 500);
            UxLandingFlowLayoutPanel.ResumeLayout(false);
            UxLandingFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel UxLandingFlowLayoutPanel;
        private Label UxWelcomeLabel;
        private Label UxSpacingLabel;
        private Label UxSiteNameLabel;
    }
}
