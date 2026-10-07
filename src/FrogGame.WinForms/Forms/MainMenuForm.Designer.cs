namespace FrogGame.WinForms.Forms
{
    partial class MainMenuForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titlePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(361, 51);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(346, 39);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Welcome To Frog Game!";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Thistle;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.Location = new System.Drawing.Point(439, 255);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(166, 98);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Game";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.BackColor = System.Drawing.Color.Plum;
            this.leaderboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaderboardButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardButton.Location = new System.Drawing.Point(439, 385);
            this.leaderboardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(166, 98);
            this.leaderboardButton.TabIndex = 4;
            this.leaderboardButton.Text = "Score";
            this.leaderboardButton.UseVisualStyleBackColor = false;
            this.leaderboardButton.Click += new System.EventHandler(this.LeaderboardButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Violet;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(439, 516);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(166, 98);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // titlePicture
            // 
            this.titlePicture.Location = new System.Drawing.Point(-2, -4);
            this.titlePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titlePicture.Name = "titlePicture";
            this.titlePicture.Size = new System.Drawing.Size(1052, 708);
            this.titlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlePicture.TabIndex = 1;
            this.titlePicture.TabStop = false;
            // 
            // 
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 701);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.leaderboardButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titlePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frog Game";
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox titlePicture;
        private System.Windows.Forms.Button leaderboardButton;
        private System.Windows.Forms.Button exitButton;
    }
}

