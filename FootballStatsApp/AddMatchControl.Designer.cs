namespace FootballStatsApp
{
    partial class AddMatchControl
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
            DateBox = new System.Windows.Forms.TextBox();
            HomeBox = new System.Windows.Forms.TextBox();
            UxSearchBtn = new System.Windows.Forms.Button();
            AwayBox = new System.Windows.Forms.TextBox();
            UxPlayerViewFlowLayoutPanel.SuspendLayout();
            UxSearchFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UxPlayerViewFlowLayoutPanel
            // 
            UxPlayerViewFlowLayoutPanel.AutoSize = true;
            UxPlayerViewFlowLayoutPanel.Controls.Add(UxSearchFlowLayoutPanel);
            UxPlayerViewFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            UxPlayerViewFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            UxPlayerViewFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            UxPlayerViewFlowLayoutPanel.Name = "UxPlayerViewFlowLayoutPanel";
            UxPlayerViewFlowLayoutPanel.Size = new System.Drawing.Size(510, 443);
            UxPlayerViewFlowLayoutPanel.TabIndex = 1;
            // 
            // UxSearchFlowLayoutPanel
            // 
            UxSearchFlowLayoutPanel.Controls.Add(DateBox);
            UxSearchFlowLayoutPanel.Controls.Add(HomeBox);
            UxSearchFlowLayoutPanel.Controls.Add(UxSearchBtn);
            UxSearchFlowLayoutPanel.Controls.Add(AwayBox);
            UxSearchFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            UxSearchFlowLayoutPanel.Name = "UxSearchFlowLayoutPanel";
            UxSearchFlowLayoutPanel.Size = new System.Drawing.Size(486, 218);
            UxSearchFlowLayoutPanel.TabIndex = 0;
            // 
            // DateBox
            // 
            DateBox.Location = new System.Drawing.Point(3, 3);
            DateBox.Name = "DateBox";
            DateBox.PlaceholderText = "Match Date";
            DateBox.Size = new System.Drawing.Size(285, 27);
            DateBox.TabIndex = 4;
            // 
            // HomeBox
            // 
            HomeBox.Location = new System.Drawing.Point(3, 36);
            HomeBox.Name = "HomeBox";
            HomeBox.PlaceholderText = "Home Team";
            HomeBox.Size = new System.Drawing.Size(285, 27);
            HomeBox.TabIndex = 0;
            HomeBox.Text = "Bills";
            HomeBox.TextChanged += UxSearchTb_TextChanged;
            // 
            // UxSearchBtn
            // 
            UxSearchBtn.Location = new System.Drawing.Point(331, 36);
            UxSearchBtn.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            UxSearchBtn.Name = "UxSearchBtn";
            UxSearchBtn.Size = new System.Drawing.Size(94, 29);
            UxSearchBtn.TabIndex = 1;
            UxSearchBtn.Text = "Add To Team";
            UxSearchBtn.UseVisualStyleBackColor = true;
            UxSearchBtn.Click += UxSearchBtn_Click;
            // 
            // AwayBox
            // 
            AwayBox.Location = new System.Drawing.Point(3, 71);
            AwayBox.Name = "AwayBox";
            AwayBox.PlaceholderText = "AwayTeam";
            AwayBox.Size = new System.Drawing.Size(285, 27);
            AwayBox.TabIndex = 5;
            AwayBox.Text = "Dolphins";
            // 
            // AddMatchControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(UxPlayerViewFlowLayoutPanel);
            Size = new System.Drawing.Size(510, 443);
            UxPlayerViewFlowLayoutPanel.ResumeLayout(false);
            UxSearchFlowLayoutPanel.ResumeLayout(false);
            UxSearchFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox AwayBox;

        private System.Windows.Forms.TextBox DateBox;

        #endregion

        private System.Windows.Forms.FlowLayoutPanel UxPlayerViewFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel UxSearchFlowLayoutPanel;
        private System.Windows.Forms.TextBox HomeBox;
        private System.Windows.Forms.Button UxSearchBtn;
    }
}
