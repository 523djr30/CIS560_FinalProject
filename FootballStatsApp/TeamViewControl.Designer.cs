namespace FootballStatsApp
{
    partial class TeamViewControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            UxFilterFlowPanel = new FlowLayoutPanel();
            label1 = new Label();
            UxTeamComboBox = new ComboBox();
            UxSearchBtn = new Button();
            UxTeamsFlowPanel = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            UxFilterFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(UxFilterFlowPanel);
            flowLayoutPanel1.Controls.Add(UxTeamsFlowPanel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.MaximumSize = new Size(3000, 3000);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(889, 633);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // UxFilterFlowPanel
            // 
            UxFilterFlowPanel.Controls.Add(label1);
            UxFilterFlowPanel.Controls.Add(UxTeamComboBox);
            UxFilterFlowPanel.Controls.Add(UxSearchBtn);
            UxFilterFlowPanel.Location = new Point(3, 3);
            UxFilterFlowPanel.Name = "UxFilterFlowPanel";
            UxFilterFlowPanel.Size = new Size(881, 71);
            UxFilterFlowPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 7);
            label1.Margin = new Padding(3, 7, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 1;
            label1.Text = "Seach Teams:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // UxTeamComboBox
            // 
            UxTeamComboBox.Font = new Font("Segoe UI", 12F);
            UxTeamComboBox.FormattingEnabled = true;
            UxTeamComboBox.Location = new Point(134, 3);
            UxTeamComboBox.Name = "UxTeamComboBox";
            UxTeamComboBox.Size = new Size(266, 36);
            UxTeamComboBox.TabIndex = 0;
            // 
            // UxSearchBtn
            // 
            UxSearchBtn.Font = new Font("Segoe UI", 12F);
            UxSearchBtn.Location = new Point(406, 3);
            UxSearchBtn.Name = "UxSearchBtn";
            UxSearchBtn.Size = new Size(94, 36);
            UxSearchBtn.TabIndex = 2;
            UxSearchBtn.Text = "Search";
            UxSearchBtn.UseVisualStyleBackColor = true;
            UxSearchBtn.Click += UxSearchBtn_Click;
            // 
            // UxTeamsFlowPanel
            // 
            UxTeamsFlowPanel.AutoScroll = true;
            UxTeamsFlowPanel.AutoSize = true;
            UxTeamsFlowPanel.Dock = DockStyle.Top;
            UxTeamsFlowPanel.Location = new Point(3, 80);
            UxTeamsFlowPanel.MaximumSize = new Size(2000, 2000);
            UxTeamsFlowPanel.MinimumSize = new Size(700, 400);
            UxTeamsFlowPanel.Name = "UxTeamsFlowPanel";
            UxTeamsFlowPanel.Size = new Size(700, 400);
            UxTeamsFlowPanel.TabIndex = 1;
            // 
            // TeamViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "TeamViewControl";
            Size = new Size(889, 633);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            UxFilterFlowPanel.ResumeLayout(false);
            UxFilterFlowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel UxFilterFlowPanel;
        private Label label1;
        private ComboBox UxTeamComboBox;
        private Button UxSearchBtn;
        private FlowLayoutPanel UxTeamsFlowPanel;
    }
}
