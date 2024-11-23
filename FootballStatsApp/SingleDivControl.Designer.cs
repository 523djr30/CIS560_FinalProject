namespace FootballStatsApp
{
    partial class SingleDivControl
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
            UxNFCFlowLayoutPanel = new FlowLayoutPanel();
            UxDivisionTitle = new Label();
            UxTeamsFlowPanel = new FlowLayoutPanel();
            UxNFCFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxNFCFlowLayoutPanel
            // 
            UxNFCFlowLayoutPanel.AutoScroll = true;
            UxNFCFlowLayoutPanel.AutoSize = true;
            UxNFCFlowLayoutPanel.Controls.Add(UxDivisionTitle);
            UxNFCFlowLayoutPanel.Controls.Add(UxTeamsFlowPanel);
            UxNFCFlowLayoutPanel.Dock = DockStyle.Fill;
            UxNFCFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UxNFCFlowLayoutPanel.Location = new Point(0, 0);
            UxNFCFlowLayoutPanel.MinimumSize = new Size(50, 50);
            UxNFCFlowLayoutPanel.Name = "UxNFCFlowLayoutPanel";
            UxNFCFlowLayoutPanel.Size = new Size(200, 300);
            UxNFCFlowLayoutPanel.TabIndex = 2;
            // 
            // UxDivisionTitle
            // 
            UxDivisionTitle.AutoSize = true;
            UxDivisionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            UxDivisionTitle.Location = new Point(3, 0);
            UxDivisionTitle.Name = "UxDivisionTitle";
            UxDivisionTitle.Size = new Size(179, 32);
            UxDivisionTitle.TabIndex = 0;
            UxDivisionTitle.Text = "NFC Standings";
            // 
            // UxTeamsFlowPanel
            // 
            UxTeamsFlowPanel.AutoScroll = true;
            UxTeamsFlowPanel.AutoSize = true;
            UxTeamsFlowPanel.Dock = DockStyle.Fill;
            UxTeamsFlowPanel.Location = new Point(3, 35);
            UxTeamsFlowPanel.Name = "UxTeamsFlowPanel";
            UxTeamsFlowPanel.Size = new Size(179, 0);
            UxTeamsFlowPanel.TabIndex = 1;
            // 
            // SingleDivControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(UxNFCFlowLayoutPanel);
            Name = "SingleDivControl";
            Size = new Size(200, 300);
            UxNFCFlowLayoutPanel.ResumeLayout(false);
            UxNFCFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel UxNFCFlowLayoutPanel;
        private Label UxDivisionTitle;
        private FlowLayoutPanel UxTeamsFlowPanel;
    }
}
