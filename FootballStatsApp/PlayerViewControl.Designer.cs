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
            UxPlayerViewFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            UxSearchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            UxSearchTb = new System.Windows.Forms.TextBox();
            UxSearchBtn = new System.Windows.Forms.Button();
            UxPlayersListBox = new System.Windows.Forms.ListBox();
            UxPlayerViewFlowLayoutPanel.SuspendLayout();
            UxSearchFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxPlayerViewFlowLayoutPanel
            // 
            UxPlayerViewFlowLayoutPanel.AutoSize = true;
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxSearchFlowLayoutPanel);
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxPlayersListBox);
            UxPlayerViewFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            UxPlayerViewFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            UxPlayerViewFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            UxPlayerViewFlowLayoutPanel.Name = "UxPlayerViewFlowLayoutPanel";
            UxPlayerViewFlowLayoutPanel.Size = new System.Drawing.Size(510, 443);
            UxPlayerViewFlowLayoutPanel.TabIndex = 1;
            // 
            // UxSearchFlowLayoutPanel
            // 
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchTb);
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchBtn);
            UxSearchFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            UxSearchFlowLayoutPanel.Name = "UxSearchFlowLayoutPanel";
            UxSearchFlowLayoutPanel.Size = new System.Drawing.Size(486, 57);
            UxSearchFlowLayoutPanel.TabIndex = 0;
            // 
            // UxSearchTb
            // 
            UxSearchTb.Location = new System.Drawing.Point(3, 3);
            UxSearchTb.Name = "UxSearchTb";
            UxSearchTb.Size = new System.Drawing.Size(285, 35);
            UxSearchTb.TabIndex = 0;
            UxSearchTb.Text = "Enter Player name...";
            UxSearchTb.TextChanged += UxSearchTb_TextChanged;
            // 
            // UxSearchBtn
            // 
            UxSearchBtn.Location = new System.Drawing.Point(331, 3);
            UxSearchBtn.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            UxSearchBtn.Name = "UxSearchBtn";
            UxSearchBtn.Size = new System.Drawing.Size(94, 29);
            UxSearchBtn.TabIndex = 1;
            UxSearchBtn.Text = "Search";
            UxSearchBtn.UseVisualStyleBackColor = true;
            UxSearchBtn.Click += UxSearchBtn_Click;
            // 
            // UxPlayersListBox
            // 
            UxPlayersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            UxPlayersListBox.FormattingEnabled = true;
            UxPlayersListBox.ItemHeight = 30;
            UxPlayersListBox.Location = new System.Drawing.Point(3, 66);
            UxPlayersListBox.MinimumSize = new System.Drawing.Size(450, 300);
            UxPlayersListBox.Name = "UxPlayersListBox";
            UxPlayersListBox.Size = new System.Drawing.Size(486, 300);
            UxPlayersListBox.TabIndex = 2;
            UxPlayersListBox.DataContextChanged += UxPlayersListBox_DataContextChanged;
            // 
            // PlayerViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(UxPlayerViewFlowLayoutPanel);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Size = new System.Drawing.Size(510, 443);
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
        private System.Windows.Forms.ListBox UxPlayersListBox;
    }
}
