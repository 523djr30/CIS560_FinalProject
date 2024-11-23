namespace FootballStatsApp
{
    partial class PlayerViewControl
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
            UxSearchTb = new TextBox();
            UxSearchBtn = new Button();
            UxPlayersListBox = new ListBox();
            UxPlayerViewFlowLayoutPanel.SuspendLayout();
            UxSearchFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxPlayerViewFlowLayoutPanel
            // 
            UxPlayerViewFlowLayoutPanel.AutoSize = true;
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxSearchFlowLayoutPanel);
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxPlayersListBox);
            UxPlayerViewFlowLayoutPanel.Dock = DockStyle.Fill;
            UxPlayerViewFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UxPlayerViewFlowLayoutPanel.Location = new Point(0, 0);
            UxPlayerViewFlowLayoutPanel.Margin = new Padding(2, 2, 2, 2);
            UxPlayerViewFlowLayoutPanel.Name = "UxPlayerViewFlowLayoutPanel";
            UxPlayerViewFlowLayoutPanel.Size = new Size(340, 295);
            UxPlayerViewFlowLayoutPanel.TabIndex = 1;
            // 
            // UxSearchFlowLayoutPanel
            // 
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchTb);
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchBtn);
            UxSearchFlowLayoutPanel.Location = new Point(2, 2);
            UxSearchFlowLayoutPanel.Margin = new Padding(2, 2, 2, 2);
            UxSearchFlowLayoutPanel.Name = "UxSearchFlowLayoutPanel";
            UxSearchFlowLayoutPanel.Size = new Size(324, 38);
            UxSearchFlowLayoutPanel.TabIndex = 0;
            // 
            // UxSearchTb
            // 
            UxSearchTb.Font = new Font("Segoe UI", 14F);
            UxSearchTb.Location = new Point(2, 2);
            UxSearchTb.Margin = new Padding(2, 2, 2, 2);
            UxSearchTb.Name = "UxSearchTb";
            UxSearchTb.Size = new Size(191, 39);
            UxSearchTb.TabIndex = 0;
            UxSearchTb.Text = "Enter Player name...";
            UxSearchTb.TextChanged += UxSearchTb_TextChanged;
            // 
            // UxSearchBtn
            // 
            UxSearchBtn.AutoSize = true;
            UxSearchBtn.Font = new Font("Segoe UI", 14F);
            UxSearchBtn.Location = new Point(222, 2);
            UxSearchBtn.Margin = new Padding(27, 2, 2, 2);
            UxSearchBtn.Name = "UxSearchBtn";
            UxSearchBtn.Size = new Size(95, 42);
            UxSearchBtn.TabIndex = 1;
            UxSearchBtn.Text = "Search";
            UxSearchBtn.UseVisualStyleBackColor = true;
            UxSearchBtn.Click += UxSearchBtn_Click;
            // 
            // UxPlayersListBox
            // 
            UxPlayersListBox.Dock = DockStyle.Fill;
            UxPlayersListBox.Font = new Font("Segoe UI", 12F);
            UxPlayersListBox.FormattingEnabled = true;
            UxPlayersListBox.ItemHeight = 28;
            UxPlayersListBox.Location = new Point(2, 44);
            UxPlayersListBox.Margin = new Padding(2, 2, 2, 2);
            UxPlayersListBox.MinimumSize = new Size(301, 201);
            UxPlayersListBox.Name = "UxPlayersListBox";
            UxPlayersListBox.Size = new Size(324, 201);
            UxPlayersListBox.TabIndex = 2;
            UxPlayersListBox.DataContextChanged += UxPlayersListBox_DataContextChanged;
            // 
            // PlayerViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UxPlayerViewFlowLayoutPanel);
            Name = "PlayerViewControl";
            Size = new Size(340, 295);
            UxPlayerViewFlowLayoutPanel.ResumeLayout(false);
            UxSearchFlowLayoutPanel.ResumeLayout(false);
            UxSearchFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel UxPlayerViewFlowLayoutPanel;
        private FlowLayoutPanel UxSearchFlowLayoutPanel;
        private TextBox UxSearchTb;
        private Button UxSearchBtn;
        private System.Windows.Forms.ListBox UxPlayersListBox;
    }
}
