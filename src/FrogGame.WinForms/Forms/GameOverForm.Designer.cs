namespace FrogGame.WinForms.Forms
{
    partial class GameOverForm
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
            this.backgroundPicture = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernamePromptLabel = new System.Windows.Forms.Label();
            this.usernameHintLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.CausesValidation = false;
            this.titleLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.titleLabel.Location = new System.Drawing.Point(259, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(591, 99);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "YOUR SCORE";
            // 
            // backgroundPicture
            // 
            this.backgroundPicture.Location = new System.Drawing.Point(-7, -11);
            this.backgroundPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backgroundPicture.Name = "backgroundPicture";
            this.backgroundPicture.Size = new System.Drawing.Size(1051, 682);
            this.backgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPicture.TabIndex = 1;
            this.backgroundPicture.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.8F);
            this.scoreLabel.Location = new System.Drawing.Point(416, 159);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(234, 74);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "scoreLabel";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.Pink;
            this.mainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMenuButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.mainMenuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainMenuButton.Location = new System.Drawing.Point(426, 424);
            this.mainMenuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(206, 82);
            this.mainMenuButton.TabIndex = 3;
            this.mainMenuButton.Text = "MAIN PAGE";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightPink;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(451, 544);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 88);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(439, 341);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(164, 26);
            this.usernameTextBox.TabIndex = 5;
            // 
            // usernamePromptLabel
            // 
            this.usernamePromptLabel.AutoSize = true;
            this.usernamePromptLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamePromptLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.usernamePromptLabel.ForeColor = System.Drawing.Color.Black;
            this.usernamePromptLabel.Location = new System.Drawing.Point(381, 284);
            this.usernamePromptLabel.Name = "usernamePromptLabel";
            this.usernamePromptLabel.Size = new System.Drawing.Size(301, 39);
            this.usernamePromptLabel.TabIndex = 6;
            this.usernamePromptLabel.Text = "Enter your username";
            // 
            // usernameHintLabel
            // 
            this.usernameHintLabel.AutoSize = true;
            this.usernameHintLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameHintLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameHintLabel.Location = new System.Drawing.Point(350, 372);
            this.usernameHintLabel.Name = "usernameHintLabel";
            this.usernameHintLabel.Size = new System.Drawing.Size(392, 26);
            this.usernameHintLabel.TabIndex = 7;
            this.usernameHintLabel.Text = "lower letters, underscore _ and numbers 0-9";
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 666);
            this.ControlBox = false;
            this.Controls.Add(this.usernameHintLabel);
            this.Controls.Add(this.usernamePromptLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backgroundPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frog Game - Game Over";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox backgroundPicture;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernamePromptLabel;
        private System.Windows.Forms.Label usernameHintLabel;
    }
}