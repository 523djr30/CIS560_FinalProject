namespace FootballStatsApp
{
    partial class BothDivStandControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            UxAFCFlowPanel = new FlowLayoutPanel();
            UxAFCDivLabel = new Label();
            UxAFCDataGridView = new DataGridView();
            UxNFCFlowLayoutPanel = new FlowLayoutPanel();
            UxNFCLabel = new Label();
            UxNFCDataGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            UxAFCFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UxAFCDataGridView).BeginInit();
            UxNFCFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UxNFCDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(UxNFCFlowLayoutPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(UxAFCFlowPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1000, 500);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UxAFCFlowPanel
            // 
            UxAFCFlowPanel.AutoSize = true;
            UxAFCFlowPanel.Controls.Add(UxAFCDivLabel);
            UxAFCFlowPanel.Controls.Add(UxAFCDataGridView);
            UxAFCFlowPanel.Dock = DockStyle.Fill;
            UxAFCFlowPanel.FlowDirection = FlowDirection.TopDown;
            UxAFCFlowPanel.Location = new Point(14, 14);
            UxAFCFlowPanel.Name = "UxAFCFlowPanel";
            UxAFCFlowPanel.Size = new Size(482, 472);
            UxAFCFlowPanel.TabIndex = 0;
            // 
            // UxAFCDivLabel
            // 
            UxAFCDivLabel.AutoSize = true;
            UxAFCDivLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            UxAFCDivLabel.Location = new Point(3, 0);
            UxAFCDivLabel.Name = "UxAFCDivLabel";
            UxAFCDivLabel.Size = new Size(177, 32);
            UxAFCDivLabel.TabIndex = 0;
            UxAFCDivLabel.Text = "AFC Standings";
            // 
            // UxAFCDataGridView
            // 
            UxAFCDataGridView.AllowUserToAddRows = false;
            UxAFCDataGridView.AllowUserToDeleteRows = false;
            UxAFCDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UxAFCDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UxAFCDataGridView.Dock = DockStyle.Fill;
            UxAFCDataGridView.Location = new Point(3, 35);
            UxAFCDataGridView.Name = "UxAFCDataGridView";
            UxAFCDataGridView.ReadOnly = true;
            UxAFCDataGridView.RowHeadersWidth = 51;
            UxAFCDataGridView.Size = new Size(177, 188);
            UxAFCDataGridView.TabIndex = 1;
            // 
            // UxNFCFlowLayoutPanel
            // 
            UxNFCFlowLayoutPanel.AutoSize = true;
            UxNFCFlowLayoutPanel.Controls.Add(UxNFCLabel);
            UxNFCFlowLayoutPanel.Controls.Add(UxNFCDataGridView);
            UxNFCFlowLayoutPanel.Dock = DockStyle.Fill;
            UxNFCFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UxNFCFlowLayoutPanel.Location = new Point(503, 14);
            UxNFCFlowLayoutPanel.Name = "UxNFCFlowLayoutPanel";
            UxNFCFlowLayoutPanel.Size = new Size(483, 472);
            UxNFCFlowLayoutPanel.TabIndex = 1;
            // 
            // UxNFCLabel
            // 
            UxNFCLabel.AutoSize = true;
            UxNFCLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            UxNFCLabel.Location = new Point(3, 0);
            UxNFCLabel.Name = "UxNFCLabel";
            UxNFCLabel.Size = new Size(179, 32);
            UxNFCLabel.TabIndex = 0;
            UxNFCLabel.Text = "NFC Standings";
            // 
            // UxNFCDataGridView
            // 
            UxNFCDataGridView.AllowUserToAddRows = false;
            UxNFCDataGridView.AllowUserToDeleteRows = false;
            UxNFCDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UxNFCDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UxNFCDataGridView.Dock = DockStyle.Fill;
            UxNFCDataGridView.Location = new Point(3, 35);
            UxNFCDataGridView.Name = "UxNFCDataGridView";
            UxNFCDataGridView.ReadOnly = true;
            UxNFCDataGridView.RowHeadersWidth = 51;
            UxNFCDataGridView.Size = new Size(179, 188);
            UxNFCDataGridView.TabIndex = 1;
            // 
            // BothDivStandControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1000, 500);
            Name = "BothDivStandControl";
            Size = new Size(1000, 500);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            UxAFCFlowPanel.ResumeLayout(false);
            UxAFCFlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UxAFCDataGridView).EndInit();
            UxNFCFlowLayoutPanel.ResumeLayout(false);
            UxNFCFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UxNFCDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel UxAFCFlowPanel;
        private Label UxAFCDivLabel;
        private FlowLayoutPanel UxNFCFlowLayoutPanel;
        private Label UxNFCLabel;
        private DataGridView UxNFCDataGridView;
        private DataGridView UxAFCDataGridView;
    }
}
