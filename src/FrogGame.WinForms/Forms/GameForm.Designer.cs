namespace FrogGame.WinForms.Forms
{
    partial class GameForm
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
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.duckPicture = new System.Windows.Forms.PictureBox();
            this.frogPicture = new System.Windows.Forms.PictureBox();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.duckPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frogPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 15;
            this.movementTimer.Tick += new System.EventHandler(this.MovementTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(102, 31);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "scoreLabel";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F);
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.timeLabel.Location = new System.Drawing.Point(812, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(102, 31);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "timeLabel";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F);
            this.levelLabel.Location = new System.Drawing.Point(459, 9);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(96, 31);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "Level ";
            // 
            // duckPicture
            // 
            this.duckPicture.BackColor = System.Drawing.Color.Transparent;
            this.duckPicture.Location = new System.Drawing.Point(131, 139);
            this.duckPicture.Name = "duckPicture";
            this.duckPicture.Size = new System.Drawing.Size(124, 113);
            this.duckPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.duckPicture.TabIndex = 4;
            this.duckPicture.TabStop = false;
            this.duckPicture.Visible = false;
            this.duckPicture.Click += new System.EventHandler(this.DuckPicture_Click);
            // 
            // frogPicture
            // 
            this.frogPicture.BackColor = System.Drawing.Color.Transparent;
            this.frogPicture.Location = new System.Drawing.Point(425, 139);
            this.frogPicture.Name = "frogPicture";
            this.frogPicture.Size = new System.Drawing.Size(100, 113);
            this.frogPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frogPicture.TabIndex = 0;
            this.frogPicture.TabStop = false;
            this.frogPicture.Click += new System.EventHandler(this.FrogPicture_Click);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.ControlBox = false;
            this.Controls.Add(this.duckPicture);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.frogPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frog Game";
            ((System.ComponentModel.ISupportInitialize)(this.duckPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frogPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox frogPicture;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.PictureBox duckPicture;
        private System.Windows.Forms.Timer countdownTimer;
    }
}