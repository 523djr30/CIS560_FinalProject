namespace FootballStatsApp
{
    partial class TeamInDiv
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
            UxTeamNameLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            RankLabel = new Label();
            UxRankValLable = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.39616F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.6038322F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(UxTeamNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(227, 39);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UxTeamNameLabel
            // 
            UxTeamNameLabel.Cursor = Cursors.SizeAll;
            UxTeamNameLabel.Dock = DockStyle.Fill;
            UxTeamNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UxTeamNameLabel.Location = new Point(3, 0);
            UxTeamNameLabel.MaximumSize = new Size(400, 200);
            UxTeamNameLabel.Name = "UxTeamNameLabel";
            UxTeamNameLabel.Size = new Size(110, 39);
            UxTeamNameLabel.TabIndex = 9;
            UxTeamNameLabel.Text = "TeamName";
            UxTeamNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(RankLabel);
            flowLayoutPanel1.Controls.Add(UxRankValLable);
            flowLayoutPanel1.Location = new Point(119, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(97, 33);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // RankLabel
            // 
            RankLabel.AutoSize = true;
            RankLabel.Font = new Font("Segoe UI", 9F);
            RankLabel.Location = new Point(6, 6);
            RankLabel.Margin = new Padding(6);
            RankLabel.Name = "RankLabel";
            RankLabel.Size = new Size(48, 20);
            RankLabel.TabIndex = 0;
            RankLabel.Text = "RANK";
            // 
            // UxRankValLable
            // 
            UxRankValLable.AutoSize = true;
            UxRankValLable.Font = new Font("Segoe UI", 9F);
            UxRankValLable.Location = new Point(66, 6);
            UxRankValLable.Margin = new Padding(6);
            UxRankValLable.Name = "UxRankValLable";
            UxRankValLable.Size = new Size(18, 20);
            UxRankValLable.TabIndex = 1;
            UxRankValLable.Text = "#";
            // 
            // TeamInDiv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TeamInDiv";
            Size = new Size(227, 39);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label UxTeamNameLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label RankLabel;
        private Label UxRankValLable;
    }
}
