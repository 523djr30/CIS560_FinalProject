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
            UxPlayerViewFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            UxSearchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            Team1Box = new System.Windows.Forms.TextBox();
            UxSearchBtn = new System.Windows.Forms.Button();
            Team2Box = new System.Windows.Forms.TextBox();
            UxPlayersListBox = new System.Windows.Forms.ListBox();
            UxPlayerViewFlowLayoutPanel.SuspendLayout();
            UxSearchFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxPlayerViewFlowLayoutPanel
            // 
            UxPlayerViewFlowLayoutPanel.AutoSize = true;
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxSearchFlowLayoutPanel);
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxPlayersListBox);
            UxPlayerViewFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            UxPlayerViewFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            UxPlayerViewFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            UxPlayerViewFlowLayoutPanel.Name = "UxPlayerViewFlowLayoutPanel";
            UxPlayerViewFlowLayoutPanel.Size = new System.Drawing.Size(900, 900);
            UxPlayerViewFlowLayoutPanel.TabIndex = 1;
            // 
            // UxSearchFlowLayoutPanel
            // 
            UxSearchFlowLayoutPanel.Controls.Add(Team2Box);
            UxSearchFlowLayoutPanel.Controls.Add(Team1Box);
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchBtn);
            UxSearchFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            UxSearchFlowLayoutPanel.Name = "UxSearchFlowLayoutPanel";
            UxSearchFlowLayoutPanel.Size = new System.Drawing.Size(894, 105);
            UxSearchFlowLayoutPanel.TabIndex = 0;
            // 
            // Team1Box
            // 
            Team1Box.Location = new System.Drawing.Point(294, 3);
            Team1Box.Name = "Team1Box";
            Team1Box.PlaceholderText = "Team 1";
            Team1Box.Size = new System.Drawing.Size(285, 27);
            Team1Box.TabIndex = 2;
            Team1Box.Text = "Dolphins";
            // 
            // UxSearchBtn
            // 
            UxSearchBtn.Location = new System.Drawing.Point(622, 3);
            UxSearchBtn.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            UxSearchBtn.Name = "UxSearchBtn";
            UxSearchBtn.Size = new System.Drawing.Size(94, 29);
            UxSearchBtn.TabIndex = 1;
            UxSearchBtn.Text = "Search";
            UxSearchBtn.UseVisualStyleBackColor = true;
            UxSearchBtn.Click += UxSearchBtn_Click;
            // 
            // Team2Box
            // 
            Team2Box.Location = new System.Drawing.Point(3, 3);
            Team2Box.Name = "Team2Box";
            Team2Box.PlaceholderText = "Team 2";
            Team2Box.Size = new System.Drawing.Size(285, 27);
            Team2Box.TabIndex = 3;
            Team2Box.Text = "Bills";
            // 
            // UxPlayersListBox
            // 
            UxPlayersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            UxPlayersListBox.FormattingEnabled = true;
            UxPlayersListBox.Location = new System.Drawing.Point(3, 114);
            UxPlayersListBox.Name = "UxPlayersListBox";
            UxPlayersListBox.Size = new System.Drawing.Size(894, 400);
            UxPlayersListBox.TabIndex = 2;
            UxPlayersListBox.SelectedIndexChanged += UxPlayersListBox_SelectedIndexChanged;
            UxPlayersListBox.DataContextChanged += UxPlayersListBox_DataContextChanged;
            // 
            // MatchesViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(UxPlayerViewFlowLayoutPanel);
            Size = new System.Drawing.Size(900, 900);
            UxPlayerViewFlowLayoutPanel.ResumeLayout(false);
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
    }
}
