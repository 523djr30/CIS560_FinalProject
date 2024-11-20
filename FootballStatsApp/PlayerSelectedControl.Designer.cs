namespace FootballStatsApp
{
    partial class PlayerSelectedControl
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
            UxPlayerSelViewFlowPanel = new FlowLayoutPanel();
            UxPlayerInfoFlowPanel = new FlowLayoutPanel();
            UxPlayerNameLabel = new Label();
            UxInfoOrganizerFlowPanel = new FlowLayoutPanel();
            UxPlayerDataGridView = new DataGridView();
            UxPlayerSelViewFlowPanel.SuspendLayout();
            UxPlayerInfoFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UxPlayerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // UxPlayerSelViewFlowPanel
            // 
            UxPlayerSelViewFlowPanel.Controls.Add(UxPlayerInfoFlowPanel);
            UxPlayerSelViewFlowPanel.Controls.Add(UxPlayerDataGridView);
            UxPlayerSelViewFlowPanel.Dock = DockStyle.Fill;
            UxPlayerSelViewFlowPanel.Location = new Point(0, 0);
            UxPlayerSelViewFlowPanel.Name = "UxPlayerSelViewFlowPanel";
            UxPlayerSelViewFlowPanel.Size = new Size(519, 423);
            UxPlayerSelViewFlowPanel.TabIndex = 0;
            // 
            // UxPlayerInfoFlowPanel
            // 
            UxPlayerInfoFlowPanel.Controls.Add(UxPlayerNameLabel);
            UxPlayerInfoFlowPanel.Controls.Add(UxInfoOrganizerFlowPanel);
            UxPlayerInfoFlowPanel.Dock = DockStyle.Top;
            UxPlayerInfoFlowPanel.Location = new Point(3, 3);
            UxPlayerInfoFlowPanel.Name = "UxPlayerInfoFlowPanel";
            UxPlayerInfoFlowPanel.Size = new Size(250, 125);
            UxPlayerInfoFlowPanel.TabIndex = 0;
            // 
            // UxPlayerNameLabel
            // 
            UxPlayerNameLabel.AutoSize = true;
            UxPlayerNameLabel.Font = new Font("Segoe UI", 16F);
            UxPlayerNameLabel.Location = new Point(3, 0);
            UxPlayerNameLabel.Name = "UxPlayerNameLabel";
            UxPlayerNameLabel.Size = new Size(167, 37);
            UxPlayerNameLabel.TabIndex = 0;
            UxPlayerNameLabel.Text = "Player Name";
            // 
            // UxInfoOrganizerFlowPanel
            // 
            UxInfoOrganizerFlowPanel.Location = new Point(3, 40);
            UxInfoOrganizerFlowPanel.Name = "UxInfoOrganizerFlowPanel";
            UxInfoOrganizerFlowPanel.Size = new Size(448, 322);
            UxInfoOrganizerFlowPanel.TabIndex = 1;
            // 
            // UxPlayerDataGridView
            // 
            UxPlayerDataGridView.AllowUserToAddRows = false;
            UxPlayerDataGridView.AllowUserToDeleteRows = false;
            UxPlayerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UxPlayerDataGridView.Dock = DockStyle.Fill;
            UxPlayerDataGridView.Location = new Point(3, 134);
            UxPlayerDataGridView.Name = "UxPlayerDataGridView";
            UxPlayerDataGridView.ReadOnly = true;
            UxPlayerDataGridView.RowHeadersWidth = 51;
            UxPlayerDataGridView.Size = new Size(300, 0);
            UxPlayerDataGridView.TabIndex = 1;
            // 
            // PlayerSelectedControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UxPlayerSelViewFlowPanel);
            Name = "PlayerSelectedControl";
            Size = new Size(519, 423);
            UxPlayerSelViewFlowPanel.ResumeLayout(false);
            UxPlayerInfoFlowPanel.ResumeLayout(false);
            UxPlayerInfoFlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UxPlayerDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel UxPlayerSelViewFlowPanel;
        private FlowLayoutPanel UxPlayerInfoFlowPanel;
        private Label UxPlayerNameLabel;
        private FlowLayoutPanel UxInfoOrganizerFlowPanel;
        private DataGridView UxPlayerDataGridView;
    }
}
