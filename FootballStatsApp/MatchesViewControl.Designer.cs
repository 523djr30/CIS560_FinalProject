namespace FootballStatsApp
{
    partial class MatchesViewControl
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
            UxPlayerViewFlowLayoutPanel = new FlowLayoutPanel();
            UxSearchFlowLayoutPanel = new FlowLayoutPanel();
            Team2Box = new TextBox();
            Team1Box = new TextBox();
            UxSearchBtn = new Button();
            UxPlayersListBox = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            UxMatchesResultsFlowPanel = new FlowLayoutPanel();
            UxPlayerViewFlowLayoutPanel.SuspendLayout();
            UxSearchFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxPlayerViewFlowLayoutPanel
            // 
            UxPlayerViewFlowLayoutPanel.AutoSize = true;
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxSearchFlowLayoutPanel);
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxPlayersListBox);
            UxPlayerViewFlowLayoutPanel.Controls.Add(flowLayoutPanel1);
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxMatchesResultsFlowPanel);
            UxPlayerViewFlowLayoutPanel.Dock = DockStyle.Fill;
            UxPlayerViewFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UxPlayerViewFlowLayoutPanel.Location = new Point(0, 0);
            UxPlayerViewFlowLayoutPanel.Name = "UxPlayerViewFlowLayoutPanel";
            UxPlayerViewFlowLayoutPanel.Size = new Size(900, 900);
            UxPlayerViewFlowLayoutPanel.TabIndex = 1;
            // 
            // UxSearchFlowLayoutPanel
            // 
            UxSearchFlowLayoutPanel.Controls.Add(Team2Box);
            UxSearchFlowLayoutPanel.Controls.Add(Team1Box);
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchBtn);
            UxSearchFlowLayoutPanel.Location = new Point(3, 3);
            UxSearchFlowLayoutPanel.Name = "UxSearchFlowLayoutPanel";
            UxSearchFlowLayoutPanel.Size = new Size(894, 105);
            UxSearchFlowLayoutPanel.TabIndex = 0;
            // 
            // Team2Box
            // 
            Team2Box.Location = new Point(3, 3);
            Team2Box.Name = "Team2Box";
            Team2Box.PlaceholderText = "Team 2";
            Team2Box.Size = new Size(285, 27);
            Team2Box.TabIndex = 3;
            Team2Box.Text = "Bills";
            // 
            // Team1Box
            // 
            Team1Box.Location = new Point(294, 3);
            Team1Box.Name = "Team1Box";
            Team1Box.PlaceholderText = "Team 1";
            Team1Box.Size = new Size(285, 27);
            Team1Box.TabIndex = 2;
            Team1Box.Text = "Dolphins";
            // 
            // UxSearchBtn
            // 
            UxSearchBtn.Location = new Point(622, 3);
            UxSearchBtn.Margin = new Padding(40, 3, 3, 3);
            UxSearchBtn.Name = "UxSearchBtn";
            UxSearchBtn.Size = new Size(94, 29);
            UxSearchBtn.TabIndex = 1;
            UxSearchBtn.Text = "Search";
            UxSearchBtn.UseVisualStyleBackColor = true;
            UxSearchBtn.Click += UxSearchBtn_Click;
            // 
            // UxPlayersListBox
            // 
            UxPlayersListBox.Dock = DockStyle.Top;
            UxPlayersListBox.FormattingEnabled = true;
            UxPlayersListBox.Location = new Point(3, 114);
            UxPlayersListBox.Name = "UxPlayersListBox";
            UxPlayersListBox.Size = new Size(894, 124);
            UxPlayersListBox.TabIndex = 2;
            UxPlayersListBox.SelectedIndexChanged += UxPlayersListBox_SelectedIndexChanged;
            UxPlayersListBox.DataContextChanged += UxPlayersListBox_DataContextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 244);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(894, 0);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // UxMatchesResultsFlowPanel
            // 
            UxMatchesResultsFlowPanel.AutoScroll = true;
            UxMatchesResultsFlowPanel.AutoSize = true;
            UxMatchesResultsFlowPanel.Dock = DockStyle.Fill;
            UxMatchesResultsFlowPanel.Location = new Point(3, 250);
            UxMatchesResultsFlowPanel.Name = "UxMatchesResultsFlowPanel";
            UxMatchesResultsFlowPanel.Size = new Size(894, 0);
            UxMatchesResultsFlowPanel.TabIndex = 5;
            // 
            // MatchesViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UxPlayerViewFlowLayoutPanel);
            Name = "MatchesViewControl";
            Size = new Size(900, 900);
            UxPlayerViewFlowLayoutPanel.ResumeLayout(false);
            UxPlayerViewFlowLayoutPanel.PerformLayout();
            UxSearchFlowLayoutPanel.ResumeLayout(false);
            UxSearchFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox Team1Box;
        private System.Windows.Forms.TextBox Team2Box;

        #endregion

        private System.Windows.Forms.FlowLayoutPanel UxPlayerViewFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel UxSearchFlowLayoutPanel;
        private System.Windows.Forms.Button UxSearchBtn;
        private System.Windows.Forms.ListBox UxPlayersListBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel UxMatchesResultsFlowPanel;
    }
}
