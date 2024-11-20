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
            UxTeamViewFlowPanel = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(UxTeamViewFlowPanel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.MaximumSize = new Size(1500, 1500);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(356, 356);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // UxTeamViewFlowPanel
            // 
            UxTeamViewFlowPanel.Dock = DockStyle.Fill;
            UxTeamViewFlowPanel.Location = new Point(3, 3);
            UxTeamViewFlowPanel.Name = "UxTeamViewFlowPanel";
            UxTeamViewFlowPanel.Size = new Size(250, 0);
            UxTeamViewFlowPanel.TabIndex = 0;
            UxTeamViewFlowPanel.Paint += flowLayoutPanel2_Paint;
            // 
            // TeamViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "TeamViewControl";
            Size = new Size(356, 356);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel UxTeamViewFlowPanel;
    }
}
