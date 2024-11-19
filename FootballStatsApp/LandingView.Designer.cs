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
            tableLayoutPanel1 = new TableLayoutPanel();
            PlayerBtn = new Button();
            TeamBtn = new Button();
            SeasonBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 304F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PlayerBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(TeamBtn, 1, 3);
            tableLayoutPanel1.Controls.Add(SeasonBtn, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(518, 376);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // PlayerBtn
            // 
            PlayerBtn.Dock = DockStyle.Fill;
            PlayerBtn.Font = new Font("Segoe UI", 17F);
            PlayerBtn.Location = new Point(105, 31);
            PlayerBtn.Name = "PlayerBtn";
            PlayerBtn.Size = new Size(306, 80);
            PlayerBtn.TabIndex = 0;
            PlayerBtn.Text = "Player";
            PlayerBtn.UseVisualStyleBackColor = true;
            // 
            // TeamBtn
            // 
            TeamBtn.Dock = DockStyle.Fill;
            TeamBtn.Font = new Font("Segoe UI", 17F);
            TeamBtn.Location = new Point(105, 145);
            TeamBtn.Name = "TeamBtn";
            TeamBtn.Size = new Size(306, 80);
            TeamBtn.TabIndex = 1;
            TeamBtn.Text = "Team";
            TeamBtn.UseVisualStyleBackColor = true;
            // 
            // SeasonBtn
            // 
            SeasonBtn.Dock = DockStyle.Fill;
            SeasonBtn.Font = new Font("Segoe UI", 17F);
            SeasonBtn.Location = new Point(105, 259);
            SeasonBtn.Name = "SeasonBtn";
            SeasonBtn.Size = new Size(306, 80);
            SeasonBtn.TabIndex = 2;
            SeasonBtn.Text = "Season";
            SeasonBtn.UseVisualStyleBackColor = true;
            // 
            // LandingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 376);
            Controls.Add(tableLayoutPanel1);
            Name = "LandingView";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button PlayerBtn;
        private Button TeamBtn;
        private Button SeasonBtn;
    }
}
