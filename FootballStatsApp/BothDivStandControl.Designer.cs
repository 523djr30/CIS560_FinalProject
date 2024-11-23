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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            UxNFCFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            UxAFCFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(UxNFCFlowLayoutPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(UxAFCFlowPanel, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1200, 800);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1200, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UxNFCFlowLayoutPanel
            // 
            UxNFCFlowLayoutPanel.AutoScroll = true;
            UxNFCFlowLayoutPanel.AutoSize = true;
            UxNFCFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            UxNFCFlowLayoutPanel.Location = new System.Drawing.Point(603, 14);
            UxNFCFlowLayoutPanel.Name = "UxNFCFlowLayoutPanel";
            UxNFCFlowLayoutPanel.Size = new System.Drawing.Size(583, 772);
            UxNFCFlowLayoutPanel.TabIndex = 1;
            // 
            // UxAFCFlowPanel
            // 
            UxAFCFlowPanel.AutoScroll = true;
            UxAFCFlowPanel.AutoSize = true;
            UxAFCFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            UxAFCFlowPanel.Location = new System.Drawing.Point(14, 14);
            UxAFCFlowPanel.Name = "UxAFCFlowPanel";
            UxAFCFlowPanel.Size = new System.Drawing.Size(582, 772);
            UxAFCFlowPanel.TabIndex = 0;
            // 
            // BothDivStandControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new System.Drawing.Size(1200, 800);
            Size = new System.Drawing.Size(1200, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel UxAFCFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel UxNFCFlowLayoutPanel;
    }
}
