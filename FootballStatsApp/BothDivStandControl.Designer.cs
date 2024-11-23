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
            UxNFCFlowLayoutPanel = new FlowLayoutPanel();
            UxAFCFlowPanel = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(800, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UxNFCFlowLayoutPanel
            // 
            UxNFCFlowLayoutPanel.AutoScroll = true;
            UxNFCFlowLayoutPanel.AutoSize = true;
            UxNFCFlowLayoutPanel.Dock = DockStyle.Fill;
            UxNFCFlowLayoutPanel.Location = new Point(403, 14);
            UxNFCFlowLayoutPanel.Name = "UxNFCFlowLayoutPanel";
            UxNFCFlowLayoutPanel.Size = new Size(383, 772);
            UxNFCFlowLayoutPanel.TabIndex = 1;
            // 
            // UxAFCFlowPanel
            // 
            UxAFCFlowPanel.AutoScroll = true;
            UxAFCFlowPanel.AutoSize = true;
            UxAFCFlowPanel.Dock = DockStyle.Fill;
            UxAFCFlowPanel.Location = new Point(14, 14);
            UxAFCFlowPanel.Name = "UxAFCFlowPanel";
            UxAFCFlowPanel.Size = new Size(382, 772);
            UxAFCFlowPanel.TabIndex = 0;
            // 
            // BothDivStandControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "BothDivStandControl";
            Size = new Size(800, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel UxAFCFlowPanel;
        private FlowLayoutPanel UxNFCFlowLayoutPanel;
    }
}
