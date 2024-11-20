namespace FootballStatsApp
{
    partial class TeamCardControl
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
            UxTeamFlowPanel = new FlowLayoutPanel();
            UxTeamDataListBox = new ListBox();
            UxNameLabel = new Label();
            UxTeamFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxTeamFlowPanel
            // 
            UxTeamFlowPanel.Controls.Add(UxNameLabel);
            UxTeamFlowPanel.Controls.Add(UxTeamDataListBox);
            UxTeamFlowPanel.Dock = DockStyle.Fill;
            UxTeamFlowPanel.Location = new Point(0, 0);
            UxTeamFlowPanel.Name = "UxTeamFlowPanel";
            UxTeamFlowPanel.Size = new Size(298, 148);
            UxTeamFlowPanel.TabIndex = 0;
            // 
            // UxTeamDataListBox
            // 
            UxTeamDataListBox.Dock = DockStyle.Fill;
            UxTeamDataListBox.FormattingEnabled = true;
            UxTeamDataListBox.Location = new Point(3, 40);
            UxTeamDataListBox.Name = "UxTeamDataListBox";
            UxTeamDataListBox.Size = new Size(248, 0);
            UxTeamDataListBox.TabIndex = 3;
            // 
            // UxNameLabel
            // 
            UxNameLabel.AutoSize = true;
            UxNameLabel.Font = new Font("Segoe UI", 16F);
            UxNameLabel.Location = new Point(3, 0);
            UxNameLabel.Name = "UxNameLabel";
            UxNameLabel.Size = new Size(157, 37);
            UxNameLabel.TabIndex = 2;
            UxNameLabel.Text = "Team Name";
            // 
            // TeamCardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(UxTeamFlowPanel);
            MaximumSize = new Size(300, 150);
            MinimumSize = new Size(300, 150);
            Name = "TeamCardControl";
            Size = new Size(298, 148);
            UxTeamFlowPanel.ResumeLayout(false);
            UxTeamFlowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel UxTeamFlowPanel;
        private Label UxNameLabel;
        private ListBox UxTeamDataListBox;
    }
}
