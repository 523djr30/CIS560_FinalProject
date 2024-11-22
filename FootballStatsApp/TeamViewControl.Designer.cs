﻿namespace FootballStatsApp
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
            FlowPanel = new FlowLayoutPanel();
            UxFilterFlowPanel = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            UxTeamsFlowPanel = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            FlowPanel.SuspendLayout();
            UxFilterFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(FlowPanel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.MaximumSize = new Size(1500, 1500);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(975, 451);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // FlowPanel
            // 
            FlowPanel.Controls.Add(UxFilterFlowPanel);
            FlowPanel.Controls.Add(UxTeamsFlowPanel);
            FlowPanel.Dock = DockStyle.Top;
            FlowPanel.Location = new Point(3, 3);
            FlowPanel.Name = "FlowPanel";
            FlowPanel.Size = new Size(900, 347);
            FlowPanel.TabIndex = 1;
            // 
            // UxFilterFlowPanel
            // 
            UxFilterFlowPanel.Controls.Add(label1);
            UxFilterFlowPanel.Controls.Add(comboBox1);
            UxFilterFlowPanel.Controls.Add(button1);
            UxFilterFlowPanel.Dock = DockStyle.Top;
            UxFilterFlowPanel.Location = new Point(3, 3);
            UxFilterFlowPanel.Name = "UxFilterFlowPanel";
            UxFilterFlowPanel.Size = new Size(881, 71);
            UxFilterFlowPanel.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 36);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 7);
            label1.Margin = new Padding(3, 7, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 1;
            label1.Text = "Seach Teams:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(406, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // UxTeamsFlowPanel
            // 
            UxTeamsFlowPanel.AutoScroll = true;
            UxTeamsFlowPanel.Dock = DockStyle.Fill;
            UxTeamsFlowPanel.Location = new Point(3, 80);
            UxTeamsFlowPanel.Name = "UxTeamsFlowPanel";
            UxTeamsFlowPanel.Size = new Size(250, 0);
            UxTeamsFlowPanel.TabIndex = 1;
            // 
            // TeamViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "TeamViewControl";
            Size = new Size(975, 451);
            flowLayoutPanel1.ResumeLayout(false);
            FlowPanel.ResumeLayout(false);
            UxFilterFlowPanel.ResumeLayout(false);
            UxFilterFlowPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel FlowPanel;
        private FlowLayoutPanel UxFilterFlowPanel;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private FlowLayoutPanel UxTeamsFlowPanel;
    }
}
