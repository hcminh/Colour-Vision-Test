namespace ColorVisionTest
{
    partial class HistoryBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OkBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ScoreLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NameLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DateLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Location = new System.Drawing.Point(0, 509);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(0);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(487, 51);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.Ok_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(487, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Score              Name            Date";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ScoreLayoutPanel
            // 
            this.ScoreLayoutPanel.Location = new System.Drawing.Point(0, 50);
            this.ScoreLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ScoreLayoutPanel.Name = "ScoreLayoutPanel";
            this.ScoreLayoutPanel.Size = new System.Drawing.Size(139, 456);
            this.ScoreLayoutPanel.TabIndex = 3;
            // 
            // NameLayoutPanel
            // 
            this.NameLayoutPanel.Location = new System.Drawing.Point(139, 50);
            this.NameLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NameLayoutPanel.Name = "NameLayoutPanel";
            this.NameLayoutPanel.Size = new System.Drawing.Size(176, 456);
            this.NameLayoutPanel.TabIndex = 4;
            // 
            // DateLayoutPanel
            // 
            this.DateLayoutPanel.Location = new System.Drawing.Point(311, 50);
            this.DateLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DateLayoutPanel.Name = "DateLayoutPanel";
            this.DateLayoutPanel.Size = new System.Drawing.Size(176, 456);
            this.DateLayoutPanel.TabIndex = 5;
            // 
            // HistoryBox
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(487, 560);
            this.Controls.Add(this.DateLayoutPanel);
            this.Controls.Add(this.NameLayoutPanel);
            this.Controls.Add(this.ScoreLayoutPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OkBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoryBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel ScoreLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel NameLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel DateLayoutPanel;
    }
}