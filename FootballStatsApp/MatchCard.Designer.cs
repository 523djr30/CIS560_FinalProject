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
            UxMatchDateBtn = new Button();
            UxAwayTeamLabel = new Label();
            UxHomeTeamLabel = new Label();
            UxWinningTeamLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1647873F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.094793F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2468052F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2468052F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2468052F));
            tableLayoutPanel1.Controls.Add(UxMatchDateBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(UxAwayTeamLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(UxHomeTeamLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(UxWinningTeamLabel, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UxMatchDateBtn
            // 
            UxMatchDateBtn.Dock = DockStyle.Fill;
            UxMatchDateBtn.Font = new Font("Segoe UI", 12F);
            UxMatchDateBtn.Location = new Point(6, 6);
            UxMatchDateBtn.Name = "UxMatchDateBtn";
            UxMatchDateBtn.Size = new Size(175, 38);
            UxMatchDateBtn.TabIndex = 0;
            UxMatchDateBtn.Text = "TeamNameHere";
            UxMatchDateBtn.UseVisualStyleBackColor = true;
            // 
            // UxAwayTeamLabel
            // 
            UxAwayTeamLabel.AutoSize = true;
            UxAwayTeamLabel.Dock = DockStyle.Fill;
            UxAwayTeamLabel.Font = new Font("Segoe UI", 12F);
            UxAwayTeamLabel.Location = new Point(417, 3);
            UxAwayTeamLabel.Name = "UxAwayTeamLabel";
            UxAwayTeamLabel.Size = new Size(183, 44);
            UxAwayTeamLabel.TabIndex = 2;
            UxAwayTeamLabel.Text = "Away";
            UxAwayTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UxHomeTeamLabel
            // 
            UxHomeTeamLabel.AutoSize = true;
            UxHomeTeamLabel.Dock = DockStyle.Fill;
            UxHomeTeamLabel.Font = new Font("Segoe UI", 12F);
            UxHomeTeamLabel.Location = new Point(225, 3);
            UxHomeTeamLabel.Name = "UxHomeTeamLabel";
            UxHomeTeamLabel.Size = new Size(183, 44);
            UxHomeTeamLabel.TabIndex = 3;
            UxHomeTeamLabel.Text = "Home";
            UxHomeTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UxWinningTeamLabel
            // 
            UxWinningTeamLabel.AutoSize = true;
            UxWinningTeamLabel.Dock = DockStyle.Fill;
            UxWinningTeamLabel.Font = new Font("Segoe UI", 12F);
            UxWinningTeamLabel.Location = new Point(609, 3);
            UxWinningTeamLabel.Name = "UxWinningTeamLabel";
            UxWinningTeamLabel.Size = new Size(185, 44);
            UxWinningTeamLabel.TabIndex = 4;
            UxWinningTeamLabel.Text = "Winner";
            UxWinningTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MatchCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MatchCard";
            Size = new Size(800, 50);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button UxMatchDateBtn;
        private Label UxAwayTeamLabel;
        private Label UxHomeTeamLabel;
        private Label UxWinningTeamLabel;
    }
}
