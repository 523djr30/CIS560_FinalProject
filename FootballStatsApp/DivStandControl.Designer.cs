namespace FootballStatsApp
{
    partial class DivStandControl
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
            UxDivisionLayoutPanel = new FlowLayoutPanel();
            UxDivNameLabel = new Label();
            UxDivDataGridView = new DataGridView();
            UxDivisionLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UxDivDataGridView).BeginInit();
            SuspendLayout();
            // 
            // UxDivisionLayoutPanel
            // 
            UxDivisionLayoutPanel.AutoSize = true;
            UxDivisionLayoutPanel.Controls.Add(UxDivNameLabel);
            UxDivisionLayoutPanel.Controls.Add(UxDivDataGridView);
            UxDivisionLayoutPanel.Dock = DockStyle.Fill;
            UxDivisionLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UxDivisionLayoutPanel.Location = new Point(0, 0);
            UxDivisionLayoutPanel.Name = "UxDivisionLayoutPanel";
            UxDivisionLayoutPanel.Size = new Size(500, 500);
            UxDivisionLayoutPanel.TabIndex = 2;
            // 
            // UxDivNameLabel
            // 
            UxDivNameLabel.AutoSize = true;
            UxDivNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            UxDivNameLabel.Location = new Point(3, 0);
            UxDivNameLabel.Name = "UxDivNameLabel";
            UxDivNameLabel.Size = new Size(179, 32);
            UxDivNameLabel.TabIndex = 0;
            UxDivNameLabel.Text = "NFC Standings";
            // 
            // UxDivDataGridView
            // 
            UxDivDataGridView.AllowUserToAddRows = false;
            UxDivDataGridView.AllowUserToDeleteRows = false;
            UxDivDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UxDivDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UxDivDataGridView.Dock = DockStyle.Fill;
            UxDivDataGridView.Location = new Point(3, 35);
            UxDivDataGridView.Name = "UxDivDataGridView";
            UxDivDataGridView.ReadOnly = true;
            UxDivDataGridView.RowHeadersWidth = 51;
            UxDivDataGridView.Size = new Size(179, 188);
            UxDivDataGridView.TabIndex = 1;
            // 
            // DivStandControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UxDivisionLayoutPanel);
            MinimumSize = new Size(500, 500);
            Name = "DivStandControl";
            Size = new Size(500, 500);
            UxDivisionLayoutPanel.ResumeLayout(false);
            UxDivisionLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UxDivDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel UxDivisionLayoutPanel;
        private Label UxDivNameLabel;
        private DataGridView UxDivDataGridView;
    }
}
