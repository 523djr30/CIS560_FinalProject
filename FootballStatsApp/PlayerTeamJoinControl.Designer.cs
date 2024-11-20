namespace FootballStatsApp
{
    partial class PlayerTeamJoinControl
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
            JoinDateTextBox = new System.Windows.Forms.TextBox();
            PlayerIdBox = new System.Windows.Forms.TextBox();
            TeamNameBox = new System.Windows.Forms.TextBox();
            UxSearchBtn = new System.Windows.Forms.Button();
            UxPlayerViewFlowLayoutPanel.SuspendLayout();
            UxSearchFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxPlayerViewFlowLayoutPanel
            // 
            UxPlayerViewFlowLayoutPanel.AutoSize = true;
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxSearchFlowLayoutPanel);
            UxPlayerViewFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            UxPlayerViewFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            UxPlayerViewFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            UxPlayerViewFlowLayoutPanel.Name = "UxPlayerViewFlowLayoutPanel";
            UxPlayerViewFlowLayoutPanel.Size = new System.Drawing.Size(510, 443);
            UxPlayerViewFlowLayoutPanel.TabIndex = 1;
            // 
            // UxSearchFlowLayoutPanel
            // 
            UxSearchFlowLayoutPanel.Controls.Add(JoinDateTextBox);
            UxSearchFlowLayoutPanel.Controls.Add(PlayerIdBox);
            UxSearchFlowLayoutPanel.Controls.Add(TeamNameBox);
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchBtn);
            UxSearchFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            UxSearchFlowLayoutPanel.Name = "UxSearchFlowLayoutPanel";
            UxSearchFlowLayoutPanel.Size = new System.Drawing.Size(486, 218);
            UxSearchFlowLayoutPanel.TabIndex = 0;
            // 
            // JoinDateTextBox
            // 
            JoinDateTextBox.Location = new System.Drawing.Point(3, 3);
            JoinDateTextBox.Name = "JoinDateTextBox";
            JoinDateTextBox.PlaceholderText = "Join Date";
            JoinDateTextBox.Size = new System.Drawing.Size(285, 27);
            JoinDateTextBox.TabIndex = 4;
            // 
            // PlayerIdBox
            // 
            PlayerIdBox.Location = new System.Drawing.Point(3, 36);
            PlayerIdBox.Name = "PlayerIdBox";
            PlayerIdBox.PlaceholderText = "Player Id";
            PlayerIdBox.Size = new System.Drawing.Size(285, 27);
            PlayerIdBox.TabIndex = 2;
            PlayerIdBox.TextChanged += textBox1_TextChanged;
            // 
            // TeamNameBox
            // 
            TeamNameBox.Location = new System.Drawing.Point(3, 69);
            TeamNameBox.Name = "TeamNameBox";
            TeamNameBox.PlaceholderText = "Team Name";
            TeamNameBox.Size = new System.Drawing.Size(285, 27);
            TeamNameBox.TabIndex = 0;
            TeamNameBox.TextChanged += UxSearchTb_TextChanged;
            // 
            // UxSearchBtn
            // 
            UxSearchBtn.Location = new System.Drawing.Point(331, 69);
            UxSearchBtn.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            UxSearchBtn.Name = "UxSearchBtn";
            UxSearchBtn.Size = new System.Drawing.Size(94, 29);
            UxSearchBtn.TabIndex = 1;
            UxSearchBtn.Text = "Add To Team";
            UxSearchBtn.UseVisualStyleBackColor = true;
            UxSearchBtn.Click += UxSearchBtn_Click;
            // 
            // PlayerTeamJoinControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(UxPlayerViewFlowLayoutPanel);
            Size = new System.Drawing.Size(510, 443);
            UxPlayerViewFlowLayoutPanel.ResumeLayout(false);
            UxSearchFlowLayoutPanel.ResumeLayout(false);
            UxSearchFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox JoinDateTextBox;

        private System.Windows.Forms.TextBox PlayerIdBox;

        #endregion

        private System.Windows.Forms.FlowLayoutPanel UxPlayerViewFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel UxSearchFlowLayoutPanel;
        private System.Windows.Forms.TextBox TeamNameBox;
        private System.Windows.Forms.Button UxSearchBtn;
    }
}
