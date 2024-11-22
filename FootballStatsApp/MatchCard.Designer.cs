namespace FootballStatsApp
{
    partial class MatchCard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            UxDateLabel = new Label();
            UxAwayTeamLabel = new Label();
            UxHomeTeamLabel = new Label();
            WinLbl = new Label();
            UxHomePointsLabel = new Label();
            UxAwayPointsLabel = new Label();
            UxStadiumNameLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.88394F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.514844F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.812706F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.65296F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9508533F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3640919F));
            tableLayoutPanel1.Controls.Add(UxDateLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(UxAwayTeamLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(UxHomeTeamLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(WinLbl, 4, 0);
            tableLayoutPanel1.Controls.Add(UxHomePointsLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(UxAwayPointsLabel, 3, 1);
            tableLayoutPanel1.Controls.Add(UxStadiumNameLabel, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1000, 80);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UxDateLabel
            // 
            UxDateLabel.AutoSize = true;
            UxDateLabel.Dock = DockStyle.Fill;
            UxDateLabel.Font = new Font("Segoe UI", 14F);
            UxDateLabel.Location = new Point(6, 3);
            UxDateLabel.Name = "UxDateLabel";
            UxDateLabel.Size = new Size(188, 35);
            UxDateLabel.TabIndex = 8;
            UxDateLabel.Text = "Date";
            UxDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UxAwayTeamLabel
            // 
            UxAwayTeamLabel.AutoSize = true;
            UxAwayTeamLabel.Dock = DockStyle.Fill;
            UxAwayTeamLabel.Font = new Font("Segoe UI", 12F);
            UxAwayTeamLabel.Location = new Point(446, 3);
            UxAwayTeamLabel.Name = "UxAwayTeamLabel";
            UxAwayTeamLabel.Size = new Size(166, 35);
            UxAwayTeamLabel.TabIndex = 2;
            UxAwayTeamLabel.Text = "Away";
            UxAwayTeamLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UxHomeTeamLabel
            // 
            UxHomeTeamLabel.AutoSize = true;
            UxHomeTeamLabel.Dock = DockStyle.Fill;
            UxHomeTeamLabel.Font = new Font("Segoe UI", 12F);
            UxHomeTeamLabel.Location = new Point(240, 3);
            UxHomeTeamLabel.Name = "UxHomeTeamLabel";
            UxHomeTeamLabel.Size = new Size(197, 35);
            UxHomeTeamLabel.TabIndex = 3;
            UxHomeTeamLabel.Text = "Home";
            UxHomeTeamLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WinLbl
            // 
            WinLbl.AutoSize = true;
            WinLbl.Dock = DockStyle.Fill;
            WinLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            WinLbl.Location = new Point(621, 3);
            WinLbl.Name = "WinLbl";
            WinLbl.Size = new Size(159, 35);
            WinLbl.TabIndex = 4;
            WinLbl.Text = "Winner";
            WinLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UxHomePointsLabel
            // 
            UxHomePointsLabel.AutoSize = true;
            UxHomePointsLabel.Dock = DockStyle.Fill;
            UxHomePointsLabel.Font = new Font("Segoe UI", 12F);
            UxHomePointsLabel.Location = new Point(240, 41);
            UxHomePointsLabel.Name = "UxHomePointsLabel";
            UxHomePointsLabel.Size = new Size(197, 36);
            UxHomePointsLabel.TabIndex = 5;
            UxHomePointsLabel.Text = "HomePts";
            UxHomePointsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UxAwayPointsLabel
            // 
            UxAwayPointsLabel.AutoSize = true;
            UxAwayPointsLabel.Dock = DockStyle.Fill;
            UxAwayPointsLabel.Font = new Font("Segoe UI", 12F);
            UxAwayPointsLabel.Location = new Point(446, 41);
            UxAwayPointsLabel.Name = "UxAwayPointsLabel";
            UxAwayPointsLabel.Size = new Size(166, 36);
            UxAwayPointsLabel.TabIndex = 6;
            UxAwayPointsLabel.Text = "AwayPts";
            UxAwayPointsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UxStadiumNameLabel
            // 
            UxStadiumNameLabel.AutoSize = true;
            UxStadiumNameLabel.Dock = DockStyle.Fill;
            UxStadiumNameLabel.Font = new Font("Segoe UI", 12F);
            UxStadiumNameLabel.Location = new Point(789, 3);
            UxStadiumNameLabel.Name = "UxStadiumNameLabel";
            UxStadiumNameLabel.Size = new Size(205, 35);
            UxStadiumNameLabel.TabIndex = 9;
            UxStadiumNameLabel.Text = "Stadium";
            UxStadiumNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MatchCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MatchCard";
            Size = new Size(1000, 80);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label UxAwayTeamLabel;
        private Label UxHomeTeamLabel;
        private Label WinLbl;
        private Label UxHomePointsLabel;
        private Label UxAwayPointsLabel;
        private Label UxDateLabel;
        private Label UxStadiumNameLabel;
    }
}
