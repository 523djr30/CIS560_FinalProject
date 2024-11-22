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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingTextControl));
            UxLandingFlowLayoutPanel = new FlowLayoutPanel();
            UxWelcomeLabel = new Label();
            UxSpacingLabel = new Label();
            UxSiteNameLabel = new Label();
            pictureBox1 = new PictureBox();
            UxLandingFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UxLandingFlowLayoutPanel
            // 
            UxLandingFlowLayoutPanel.Controls.Add(UxWelcomeLabel);
            UxLandingFlowLayoutPanel.Controls.Add(UxSpacingLabel);
            UxLandingFlowLayoutPanel.Controls.Add(UxSiteNameLabel);
            UxLandingFlowLayoutPanel.Controls.Add(pictureBox1);
            UxLandingFlowLayoutPanel.Dock = DockStyle.Left;
            UxLandingFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UxLandingFlowLayoutPanel.Location = new Point(0, 0);
            UxLandingFlowLayoutPanel.Name = "UxLandingFlowLayoutPanel";
            UxLandingFlowLayoutPanel.Size = new Size(602, 500);
            UxLandingFlowLayoutPanel.TabIndex = 5;
            // 
            // UxWelcomeLabel
            // 
            UxWelcomeLabel.AutoSize = true;
            UxWelcomeLabel.Dock = DockStyle.Top;
            UxWelcomeLabel.Font = new Font("Segoe UI", 22F);
            UxWelcomeLabel.Location = new Point(3, 0);
            UxWelcomeLabel.Name = "UxWelcomeLabel";
            UxWelcomeLabel.Size = new Size(471, 50);
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
            UxSiteNameLabel.Anchor = AnchorStyles.Top;
            UxSiteNameLabel.AutoSize = true;
            UxSiteNameLabel.Font = new Font("Segoe UI", 33F);
            UxSiteNameLabel.Location = new Point(3, 70);
            UxSiteNameLabel.Name = "UxSiteNameLabel";
            UxSiteNameLabel.Size = new Size(471, 74);
            UxSiteNameLabel.TabIndex = 1;
            UxSiteNameLabel.Text = "Team 16 NFL stats";
            UxSiteNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            UxSiteNameLabel.Click += UxSiteNameLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 299);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LandingTextControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UxLandingFlowLayoutPanel);
            Name = "LandingTextControl";
            Size = new Size(605, 500);
            UxLandingFlowLayoutPanel.ResumeLayout(false);
            UxLandingFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel UxLandingFlowLayoutPanel;
        private Label UxWelcomeLabel;
        private Label UxSpacingLabel;
        private Label UxSiteNameLabel;
        private PictureBox pictureBox1;
    }
}
