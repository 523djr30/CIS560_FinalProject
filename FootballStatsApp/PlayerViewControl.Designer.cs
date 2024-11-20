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
            UxPlayerViewFlowLayoutPanel.Name = "UxPlayerViewFlowLayoutPanel";
            UxPlayerViewFlowLayoutPanel.Size = new Size(510, 443);
            UxPlayerViewFlowLayoutPanel.TabIndex = 1;
            // 
            // UxSearchFlowLayoutPanel
            // 
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchTb);
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchBtn);
            UxSearchFlowLayoutPanel.Location = new Point(3, 3);
            UxSearchFlowLayoutPanel.Name = "UxSearchFlowLayoutPanel";
            UxSearchFlowLayoutPanel.Size = new Size(486, 57);
            UxSearchFlowLayoutPanel.TabIndex = 0;
            // 
            // UxSearchTb
            // 
            UxSearchTb.Location = new Point(3, 3);
            UxSearchTb.Name = "UxSearchTb";
            UxSearchTb.Size = new Size(285, 27);
            UxSearchTb.TabIndex = 0;
            UxSearchTb.Text = "Enter Player name...";
            UxSearchTb.TextChanged += UxSearchTb_TextChanged;
            // 
            // UxSearchBtn
            // 
            UxSearchBtn.Location = new Point(331, 3);
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
            UxPlayersListBox.Dock = DockStyle.Fill;
            UxPlayersListBox.FormattingEnabled = true;
            UxPlayersListBox.Location = new Point(3, 66);
            UxPlayersListBox.Name = "UxPlayersListBox";
            UxPlayersListBox.Size = new Size(486, 120);
            UxPlayersListBox.TabIndex = 2;
            UxPlayersListBox.DataContextChanged += UxPlayersListBox_DataContextChanged;
            // 
            // PlayerViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UxPlayerViewFlowLayoutPanel);
            Name = "PlayerViewControl";
            Size = new Size(510, 443);
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
        private ListBox UxPlayersListBox;
    }
}
