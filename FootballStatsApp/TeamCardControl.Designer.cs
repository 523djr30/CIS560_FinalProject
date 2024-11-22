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
            UxTableLayout = new TableLayoutPanel();
            UxTeamNameLabel = new Label();
            UxAllMatchesBtn = new Button();
            UxStatsBySeasonBtn = new Button();
            UxWinsFlowPanel = new FlowLayoutPanel();
            WinLabel = new Label();
            UxNumWinLabel = new Label();
            UxLossesFlowPanel = new FlowLayoutPanel();
            LossLabel = new Label();
            UxNumLossLabel = new Label();
            UxInfoFlowPanel = new FlowLayoutPanel();
            UxStadiumLabel = new Label();
            UxCityLocLabel = new Label();
            UxDivisionNameLabel = new Label();
            UxRosterButton = new Button();
            UxTableLayout.SuspendLayout();
            UxWinsFlowPanel.SuspendLayout();
            UxLossesFlowPanel.SuspendLayout();
            UxInfoFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxTableLayout
            // 
            UxTableLayout.ColumnCount = 3;
            UxTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            UxTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            UxTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            UxTableLayout.Controls.Add(UxTeamNameLabel, 1, 0);
            UxTableLayout.Controls.Add(UxAllMatchesBtn, 0, 2);
            UxTableLayout.Controls.Add(UxStatsBySeasonBtn, 1, 2);
            UxTableLayout.Controls.Add(UxWinsFlowPanel, 1, 1);
            UxTableLayout.Controls.Add(UxLossesFlowPanel, 2, 1);
            UxTableLayout.Controls.Add(UxInfoFlowPanel, 0, 1);
            UxTableLayout.Controls.Add(UxRosterButton, 2, 2);
            UxTableLayout.Dock = DockStyle.Fill;
            UxTableLayout.Location = new Point(0, 0);
            UxTableLayout.Name = "UxTableLayout";
            UxTableLayout.RowCount = 3;
            UxTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            UxTableLayout.RowStyles.Add(new RowStyle());
            UxTableLayout.RowStyles.Add(new RowStyle());
            UxTableLayout.Size = new Size(770, 200);
            UxTableLayout.TabIndex = 0;
            // 
            // UxTeamNameLabel
            // 
            UxTeamNameLabel.Cursor = Cursors.SizeAll;
            UxTeamNameLabel.Dock = DockStyle.Fill;
            UxTeamNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            UxTeamNameLabel.Location = new Point(259, 0);
            UxTeamNameLabel.MaximumSize = new Size(400, 200);
            UxTeamNameLabel.Name = "UxTeamNameLabel";
            UxTeamNameLabel.Size = new Size(250, 50);
            UxTeamNameLabel.TabIndex = 0;
            UxTeamNameLabel.Text = "TeamName";
            UxTeamNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UxAllMatchesBtn
            // 
            UxAllMatchesBtn.Dock = DockStyle.Fill;
            UxAllMatchesBtn.Location = new Point(3, 152);
            UxAllMatchesBtn.Name = "UxAllMatchesBtn";
            UxAllMatchesBtn.Size = new Size(250, 45);
            UxAllMatchesBtn.TabIndex = 9;
            UxAllMatchesBtn.Text = "Display All Matches";
            UxAllMatchesBtn.UseVisualStyleBackColor = true;
            // 
            // UxStatsBySeasonBtn
            // 
            UxStatsBySeasonBtn.Dock = DockStyle.Fill;
            UxStatsBySeasonBtn.Location = new Point(259, 152);
            UxStatsBySeasonBtn.Name = "UxStatsBySeasonBtn";
            UxStatsBySeasonBtn.Size = new Size(250, 45);
            UxStatsBySeasonBtn.TabIndex = 10;
            UxStatsBySeasonBtn.Text = "Stats By Season";
            UxStatsBySeasonBtn.UseVisualStyleBackColor = true;
            // 
            // UxWinsFlowPanel
            // 
            UxWinsFlowPanel.Controls.Add(WinLabel);
            UxWinsFlowPanel.Controls.Add(UxNumWinLabel);
            UxWinsFlowPanel.Location = new Point(259, 53);
            UxWinsFlowPanel.Name = "UxWinsFlowPanel";
            UxWinsFlowPanel.Size = new Size(250, 93);
            UxWinsFlowPanel.TabIndex = 6;
            // 
            // WinLabel
            // 
            WinLabel.AutoSize = true;
            WinLabel.Font = new Font("Segoe UI", 14F);
            WinLabel.Location = new Point(6, 6);
            WinLabel.Margin = new Padding(6);
            WinLabel.Name = "WinLabel";
            WinLabel.Size = new Size(78, 32);
            WinLabel.TabIndex = 0;
            WinLabel.Text = "Wins: ";
            WinLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UxNumWinLabel
            // 
            UxNumWinLabel.AutoSize = true;
            UxNumWinLabel.Font = new Font("Segoe UI", 14F);
            UxNumWinLabel.Location = new Point(96, 6);
            UxNumWinLabel.Margin = new Padding(6);
            UxNumWinLabel.Name = "UxNumWinLabel";
            UxNumWinLabel.Size = new Size(28, 32);
            UxNumWinLabel.TabIndex = 1;
            UxNumWinLabel.Text = "#";
            UxNumWinLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UxLossesFlowPanel
            // 
            UxLossesFlowPanel.Controls.Add(LossLabel);
            UxLossesFlowPanel.Controls.Add(UxNumLossLabel);
            UxLossesFlowPanel.Location = new Point(515, 53);
            UxLossesFlowPanel.Name = "UxLossesFlowPanel";
            UxLossesFlowPanel.Size = new Size(250, 93);
            UxLossesFlowPanel.TabIndex = 7;
            UxLossesFlowPanel.Paint += UxLossesFlowPanel_Paint;
            // 
            // LossLabel
            // 
            LossLabel.AutoSize = true;
            LossLabel.Font = new Font("Segoe UI", 14F);
            LossLabel.Location = new Point(6, 6);
            LossLabel.Margin = new Padding(6);
            LossLabel.Name = "LossLabel";
            LossLabel.Size = new Size(87, 32);
            LossLabel.TabIndex = 0;
            LossLabel.Text = "Losses:";
            // 
            // UxNumLossLabel
            // 
            UxNumLossLabel.AutoSize = true;
            UxNumLossLabel.Font = new Font("Segoe UI", 14F);
            UxNumLossLabel.Location = new Point(105, 6);
            UxNumLossLabel.Margin = new Padding(6);
            UxNumLossLabel.Name = "UxNumLossLabel";
            UxNumLossLabel.Size = new Size(28, 32);
            UxNumLossLabel.TabIndex = 1;
            UxNumLossLabel.Text = "#";
            // 
            // UxInfoFlowPanel
            // 
            UxInfoFlowPanel.Controls.Add(UxStadiumLabel);
            UxInfoFlowPanel.Controls.Add(UxCityLocLabel);
            UxInfoFlowPanel.Controls.Add(UxDivisionNameLabel);
            UxInfoFlowPanel.FlowDirection = FlowDirection.TopDown;
            UxInfoFlowPanel.Location = new Point(3, 53);
            UxInfoFlowPanel.Name = "UxInfoFlowPanel";
            UxInfoFlowPanel.Size = new Size(250, 93);
            UxInfoFlowPanel.TabIndex = 8;
            // 
            // UxStadiumLabel
            // 
            UxStadiumLabel.AutoSize = true;
            UxStadiumLabel.Location = new Point(6, 6);
            UxStadiumLabel.Margin = new Padding(6);
            UxStadiumLabel.Name = "UxStadiumLabel";
            UxStadiumLabel.Size = new Size(104, 20);
            UxStadiumLabel.TabIndex = 5;
            UxStadiumLabel.Text = "Stadium: none";
            // 
            // UxCityLocLabel
            // 
            UxCityLocLabel.AutoSize = true;
            UxCityLocLabel.Location = new Point(6, 38);
            UxCityLocLabel.Margin = new Padding(6);
            UxCityLocLabel.Name = "UxCityLocLabel";
            UxCityLocLabel.Size = new Size(74, 20);
            UxCityLocLabel.TabIndex = 2;
            UxCityLocLabel.Text = "City: none";
            // 
            // UxDivisionNameLabel
            // 
            UxDivisionNameLabel.AutoSize = true;
            UxDivisionNameLabel.Location = new Point(122, 6);
            UxDivisionNameLabel.Margin = new Padding(6);
            UxDivisionNameLabel.Name = "UxDivisionNameLabel";
            UxDivisionNameLabel.Size = new Size(102, 20);
            UxDivisionNameLabel.TabIndex = 4;
            UxDivisionNameLabel.Text = "Division: none";
            // 
            // UxRosterButton
            // 
            UxRosterButton.Dock = DockStyle.Fill;
            UxRosterButton.Location = new Point(515, 152);
            UxRosterButton.Name = "UxRosterButton";
            UxRosterButton.Size = new Size(252, 45);
            UxRosterButton.TabIndex = 11;
            UxRosterButton.Text = "Roster";
            UxRosterButton.UseVisualStyleBackColor = true;
            // 
            // TeamCardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(UxTableLayout);
            Name = "TeamCardControl";
            Size = new Size(770, 200);
            UxTableLayout.ResumeLayout(false);
            UxWinsFlowPanel.ResumeLayout(false);
            UxWinsFlowPanel.PerformLayout();
            UxLossesFlowPanel.ResumeLayout(false);
            UxLossesFlowPanel.PerformLayout();
            UxInfoFlowPanel.ResumeLayout(false);
            UxInfoFlowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel UxTableLayout;
        private Label UxTeamNameLabel;
        private FlowLayoutPanel UxLossesFlowPanel;
        private Label LossLabel;
        private Label UxNumLossLabel;
        private FlowLayoutPanel UxWinsFlowPanel;
        private Label WinLabel;
        private Label UxNumWinLabel;
        private FlowLayoutPanel UxInfoFlowPanel;
        private Label UxCityLocLabel;
        private Label UxDivisionNameLabel;
        private Button UxRosterButton;
        private Button UxStatsBySeasonBtn;
        private Button UxAllMatchesBtn;
        private Label UxStadiumLabel;
    }
}
