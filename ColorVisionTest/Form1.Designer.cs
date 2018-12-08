namespace ColorVisionTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gameHolder = new System.Windows.Forms.Panel();
            this.refreshGameBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.bestScore = new System.Windows.Forms.Label();
            this.showBestScore = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Panel();
            this.timeCountDown = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Button();
            this.myError = new System.Windows.Forms.Label();
            this.myScore = new System.Windows.Forms.Label();
            this.gameBox = new System.Windows.Forms.FlowLayoutPanel();
            this.doctorPanel = new System.Windows.Forms.Panel();
            this.doctorSaid = new System.Windows.Forms.TextBox();
            this.processAnimal = new System.Windows.Forms.Panel();
            this.doi = new System.Windows.Forms.Panel();
            this.chuot = new System.Windows.Forms.Panel();
            this.robot = new System.Windows.Forms.Panel();
            this.cho = new System.Windows.Forms.Panel();
            this.meo = new System.Windows.Forms.Panel();
            this.dieuhau = new System.Windows.Forms.Panel();
            this.ho = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameHolder.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.clock.SuspendLayout();
            this.doctorPanel.SuspendLayout();
            this.processAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameHolder
            // 
            this.gameHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameHolder.BackColor = System.Drawing.Color.White;
            this.gameHolder.Controls.Add(this.refreshGameBtn);
            this.gameHolder.Controls.Add(this.historyBtn);
            this.gameHolder.Controls.Add(this.bestScore);
            this.gameHolder.Controls.Add(this.showBestScore);
            this.gameHolder.Controls.Add(this.scorePanel);
            this.gameHolder.Controls.Add(this.gameBox);
            this.gameHolder.Controls.Add(this.doctorPanel);
            this.gameHolder.Location = new System.Drawing.Point(0, 0);
            this.gameHolder.Margin = new System.Windows.Forms.Padding(0);
            this.gameHolder.Name = "gameHolder";
            this.gameHolder.Size = new System.Drawing.Size(1000, 503);
            this.gameHolder.TabIndex = 0;
            // 
            // refreshGameBtn
            // 
            this.refreshGameBtn.BackgroundImage = global::ColorVisionTest.Properties.Resources.refresh;
            this.refreshGameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshGameBtn.FlatAppearance.BorderSize = 0;
            this.refreshGameBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.refreshGameBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.refreshGameBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.refreshGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshGameBtn.Location = new System.Drawing.Point(682, 408);
            this.refreshGameBtn.Name = "refreshGameBtn";
            this.refreshGameBtn.Size = new System.Drawing.Size(120, 90);
            this.refreshGameBtn.TabIndex = 5;
            this.refreshGameBtn.UseVisualStyleBackColor = true;
            this.refreshGameBtn.Click += new System.EventHandler(this.refreshGameBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.BackgroundImage = global::ColorVisionTest.Properties.Resources.if_history_2;
            this.historyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.historyBtn.FlatAppearance.BorderSize = 0;
            this.historyBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.historyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.historyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBtn.Location = new System.Drawing.Point(522, 408);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(120, 90);
            this.historyBtn.TabIndex = 4;
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // bestScore
            // 
            this.bestScore.BackColor = System.Drawing.Color.PaleGreen;
            this.bestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestScore.Location = new System.Drawing.Point(702, 11);
            this.bestScore.Name = "bestScore";
            this.bestScore.Size = new System.Drawing.Size(56, 37);
            this.bestScore.TabIndex = 1;
            this.bestScore.Text = "0";
            this.bestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showBestScore
            // 
            this.showBestScore.BackColor = System.Drawing.Color.PaleGreen;
            this.showBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBestScore.Location = new System.Drawing.Point(492, 9);
            this.showBestScore.Name = "showBestScore";
            this.showBestScore.Size = new System.Drawing.Size(340, 39);
            this.showBestScore.TabIndex = 3;
            this.showBestScore.Text = "Your Best Score:           ";
            this.showBestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.White;
            this.scorePanel.Controls.Add(this.button1);
            this.scorePanel.Controls.Add(this.clock);
            this.scorePanel.Controls.Add(this.Error);
            this.scorePanel.Controls.Add(this.Score);
            this.scorePanel.Controls.Add(this.myError);
            this.scorePanel.Controls.Add(this.myScore);
            this.scorePanel.Location = new System.Drawing.Point(847, 0);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(133, 500);
            this.scorePanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Location = new System.Drawing.Point(3, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Author";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clock
            // 
            this.clock.BackgroundImage = global::ColorVisionTest.Properties.Resources.clock;
            this.clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clock.Controls.Add(this.timeCountDown);
            this.clock.Location = new System.Drawing.Point(3, 12);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(127, 127);
            this.clock.TabIndex = 5;
            // 
            // timeCountDown
            // 
            this.timeCountDown.BackColor = System.Drawing.Color.Transparent;
            this.timeCountDown.FlatAppearance.BorderSize = 0;
            this.timeCountDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.timeCountDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.timeCountDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCountDown.Location = new System.Drawing.Point(8, 18);
            this.timeCountDown.Name = "timeCountDown";
            this.timeCountDown.Size = new System.Drawing.Size(119, 106);
            this.timeCountDown.TabIndex = 0;
            this.timeCountDown.Text = "15";
            this.timeCountDown.UseVisualStyleBackColor = false;
            // 
            // Error
            // 
            this.Error.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.Error.FlatAppearance.BorderSize = 3;
            this.Error.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.Error.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Error.Location = new System.Drawing.Point(20, 303);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(96, 42);
            this.Error.TabIndex = 4;
            this.Error.Text = "0";
            this.Error.UseVisualStyleBackColor = true;
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.White;
            this.Score.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.Score.FlatAppearance.BorderSize = 3;
            this.Score.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Score.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Green;
            this.Score.Location = new System.Drawing.Point(20, 199);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(96, 42);
            this.Score.TabIndex = 3;
            this.Score.Text = "0";
            this.Score.UseVisualStyleBackColor = false;
            // 
            // myError
            // 
            this.myError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myError.Location = new System.Drawing.Point(16, 263);
            this.myError.Name = "myError";
            this.myError.Size = new System.Drawing.Size(100, 37);
            this.myError.TabIndex = 2;
            this.myError.Text = "Error";
            this.myError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myScore
            // 
            this.myScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myScore.Location = new System.Drawing.Point(16, 157);
            this.myScore.Name = "myScore";
            this.myScore.Size = new System.Drawing.Size(100, 39);
            this.myScore.TabIndex = 0;
            this.myScore.Text = "Score";
            this.myScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameBox
            // 
            this.gameBox.BackColor = System.Drawing.SystemColors.Info;
            this.gameBox.Location = new System.Drawing.Point(492, 62);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(340, 340);
            this.gameBox.TabIndex = 0;
            // 
            // doctorPanel
            // 
            this.doctorPanel.BackColor = System.Drawing.Color.White;
            this.doctorPanel.BackgroundImage = global::ColorVisionTest.Properties.Resources.eye_doctor2;
            this.doctorPanel.Controls.Add(this.doctorSaid);
            this.doctorPanel.Location = new System.Drawing.Point(12, 30);
            this.doctorPanel.Name = "doctorPanel";
            this.doctorPanel.Size = new System.Drawing.Size(474, 452);
            this.doctorPanel.TabIndex = 0;
            // 
            // doctorSaid
            // 
            this.doctorSaid.BackColor = System.Drawing.Color.White;
            this.doctorSaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doctorSaid.Cursor = System.Windows.Forms.Cursors.Default;
            this.doctorSaid.Enabled = false;
            this.doctorSaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.doctorSaid.ForeColor = System.Drawing.SystemColors.MenuText;
            this.doctorSaid.Location = new System.Drawing.Point(33, 69);
            this.doctorSaid.Multiline = true;
            this.doctorSaid.Name = "doctorSaid";
            this.doctorSaid.ReadOnly = true;
            this.doctorSaid.Size = new System.Drawing.Size(149, 87);
            this.doctorSaid.TabIndex = 1;
            this.doctorSaid.Text = "Can you find the different color ?";
            this.doctorSaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // processAnimal
            // 
            this.processAnimal.BackColor = System.Drawing.Color.LightGreen;
            this.processAnimal.Controls.Add(this.doi);
            this.processAnimal.Controls.Add(this.chuot);
            this.processAnimal.Controls.Add(this.robot);
            this.processAnimal.Controls.Add(this.cho);
            this.processAnimal.Controls.Add(this.meo);
            this.processAnimal.Controls.Add(this.dieuhau);
            this.processAnimal.Controls.Add(this.ho);
            this.processAnimal.Location = new System.Drawing.Point(0, 506);
            this.processAnimal.Name = "processAnimal";
            this.processAnimal.Size = new System.Drawing.Size(0, 89);
            this.processAnimal.TabIndex = 1;
            // 
            // doi
            // 
            this.doi.BackColor = System.Drawing.Color.LightGreen;
            this.doi.BackgroundImage = global::ColorVisionTest.Properties.Resources.doi;
            this.doi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doi.Location = new System.Drawing.Point(3, 0);
            this.doi.Name = "doi";
            this.doi.Size = new System.Drawing.Size(135, 89);
            this.doi.TabIndex = 2;
            // 
            // chuot
            // 
            this.chuot.BackColor = System.Drawing.Color.LightGreen;
            this.chuot.BackgroundImage = global::ColorVisionTest.Properties.Resources.chuot;
            this.chuot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chuot.Location = new System.Drawing.Point(141, 0);
            this.chuot.Name = "chuot";
            this.chuot.Size = new System.Drawing.Size(135, 89);
            this.chuot.TabIndex = 3;
            // 
            // robot
            // 
            this.robot.BackColor = System.Drawing.Color.LightGreen;
            this.robot.BackgroundImage = global::ColorVisionTest.Properties.Resources.robot;
            this.robot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.robot.Location = new System.Drawing.Point(847, 0);
            this.robot.Name = "robot";
            this.robot.Size = new System.Drawing.Size(135, 89);
            this.robot.TabIndex = 3;
            // 
            // cho
            // 
            this.cho.BackColor = System.Drawing.Color.LightGreen;
            this.cho.BackgroundImage = global::ColorVisionTest.Properties.Resources.cho;
            this.cho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cho.Location = new System.Drawing.Point(282, 0);
            this.cho.Name = "cho";
            this.cho.Size = new System.Drawing.Size(135, 89);
            this.cho.TabIndex = 3;
            // 
            // meo
            // 
            this.meo.BackColor = System.Drawing.Color.LightGreen;
            this.meo.BackgroundImage = global::ColorVisionTest.Properties.Resources.mao;
            this.meo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.meo.Location = new System.Drawing.Point(423, 0);
            this.meo.Name = "meo";
            this.meo.Size = new System.Drawing.Size(135, 89);
            this.meo.TabIndex = 3;
            // 
            // dieuhau
            // 
            this.dieuhau.BackColor = System.Drawing.Color.LightGreen;
            this.dieuhau.BackgroundImage = global::ColorVisionTest.Properties.Resources.dieuhau;
            this.dieuhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dieuhau.Location = new System.Drawing.Point(706, 0);
            this.dieuhau.Name = "dieuhau";
            this.dieuhau.Size = new System.Drawing.Size(135, 89);
            this.dieuhau.TabIndex = 3;
            // 
            // ho
            // 
            this.ho.BackColor = System.Drawing.Color.LightGreen;
            this.ho.BackgroundImage = global::ColorVisionTest.Properties.Resources.ho;
            this.ho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ho.Location = new System.Drawing.Point(564, 0);
            this.ho.Name = "ho";
            this.ho.Size = new System.Drawing.Size(135, 89);
            this.ho.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(992, 596);
            this.Controls.Add(this.processAnimal);
            this.Controls.Add(this.gameHolder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameHolder.ResumeLayout(false);
            this.scorePanel.ResumeLayout(false);
            this.clock.ResumeLayout(false);
            this.doctorPanel.ResumeLayout(false);
            this.doctorPanel.PerformLayout();
            this.processAnimal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameHolder;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.FlowLayoutPanel gameBox;
        private System.Windows.Forms.Panel doctorPanel;
        private System.Windows.Forms.TextBox doctorSaid;
        private System.Windows.Forms.Label myError;
        private System.Windows.Forms.Label myScore;
        private System.Windows.Forms.Button Error;
        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.Panel processAnimal;
        private System.Windows.Forms.Panel doi;
        private System.Windows.Forms.Panel ho;
        private System.Windows.Forms.Panel meo;
        private System.Windows.Forms.Panel cho;
        private System.Windows.Forms.Panel chuot;
        private System.Windows.Forms.Panel dieuhau;
        private System.Windows.Forms.Panel robot;
        private System.Windows.Forms.Panel clock;
        private System.Windows.Forms.Button timeCountDown;
        private System.Windows.Forms.Button refreshGameBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Label bestScore;
        private System.Windows.Forms.Label showBestScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

