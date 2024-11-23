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
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            UxFilterFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            UxTeamComboBox = new System.Windows.Forms.ComboBox();
            UxSearchBtn = new System.Windows.Forms.Button();
            UxTeamsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            UxFilterFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(UxFilterFlowPanel);
            flowLayoutPanel1.Controls.Add(UxTeamsFlowPanel);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.MaximumSize = new System.Drawing.Size(3000, 3000);
            flowLayoutPanel1.MinimumSize = new System.Drawing.Size(1200, 800);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1200, 800);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // UxFilterFlowPanel
            // 
            UxFilterFlowPanel.Controls.Add(label1);
            UxFilterFlowPanel.Controls.Add(UxTeamComboBox);
            UxFilterFlowPanel.Controls.Add(UxSearchBtn);
            UxFilterFlowPanel.Location = new System.Drawing.Point(3, 3);
            UxFilterFlowPanel.Name = "UxFilterFlowPanel";
            UxFilterFlowPanel.Size = new System.Drawing.Size(881, 71);
            UxFilterFlowPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(3, 7);
            label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 28);
            label1.TabIndex = 1;
            label1.Text = "Seach Teams:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // UxTeamComboBox
            // 
            UxTeamComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            UxTeamComboBox.FormattingEnabled = true;
            UxTeamComboBox.Location = new System.Drawing.Point(134, 3);
            UxTeamComboBox.Name = "UxTeamComboBox";
            UxTeamComboBox.Size = new System.Drawing.Size(266, 36);
            UxTeamComboBox.TabIndex = 0;
            // 
            // UxSearchBtn
            // 
            UxSearchBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            UxSearchBtn.Location = new System.Drawing.Point(406, 3);
            UxSearchBtn.Name = "UxSearchBtn";
            UxSearchBtn.Size = new System.Drawing.Size(94, 36);
            UxSearchBtn.TabIndex = 2;
            UxSearchBtn.Text = "Search";
            UxSearchBtn.UseVisualStyleBackColor = true;
            UxSearchBtn.Click += UxSearchBtn_Click;
            // 
            // UxTeamsFlowPanel
            // 
            UxTeamsFlowPanel.AutoScroll = true;
            UxTeamsFlowPanel.AutoSize = true;
            UxTeamsFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            UxTeamsFlowPanel.Location = new System.Drawing.Point(3, 80);
            UxTeamsFlowPanel.MaximumSize = new System.Drawing.Size(2000, 2000);
            UxTeamsFlowPanel.MinimumSize = new System.Drawing.Size(1100, 800);
            UxTeamsFlowPanel.Name = "UxTeamsFlowPanel";
            UxTeamsFlowPanel.Size = new System.Drawing.Size(1100, 800);
            UxTeamsFlowPanel.TabIndex = 1;
            // 
            // TeamViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Size = new System.Drawing.Size(889, 633);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            UxFilterFlowPanel.ResumeLayout(false);
            UxFilterFlowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel UxFilterFlowPanel;
        private Label label1;
        private ComboBox UxTeamComboBox;
        private Button UxSearchBtn;
        private System.Windows.Forms.FlowLayoutPanel UxTeamsFlowPanel;
    }
}
