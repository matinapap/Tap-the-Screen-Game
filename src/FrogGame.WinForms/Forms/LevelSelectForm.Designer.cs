namespace FrogGame.WinForms.Forms
{
    partial class LevelSelectForm
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
            this.backgroundPicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.level1Button = new System.Windows.Forms.Button();
            this.level3Button = new System.Windows.Forms.Button();
            this.level2Button = new System.Windows.Forms.Button();
            this.level3WandPicture = new System.Windows.Forms.PictureBox();
            this.level1WandPicture = new System.Windows.Forms.PictureBox();
            this.level2WandPicture = new System.Windows.Forms.PictureBox();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3WandPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1WandPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2WandPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPicture
            // 
            this.backgroundPicture.Location = new System.Drawing.Point(0, -3);
            this.backgroundPicture.Name = "backgroundPicture";
            this.backgroundPicture.Size = new System.Drawing.Size(930, 566);
            this.backgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPicture.TabIndex = 0;
            this.backgroundPicture.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(319, 58);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(317, 50);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Choose The Level";
            // 
            // level1Button
            // 
            this.level1Button.BackColor = System.Drawing.Color.Thistle;
            this.level1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level1Button.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1Button.Location = new System.Drawing.Point(70, 457);
            this.level1Button.Name = "level1Button";
            this.level1Button.Size = new System.Drawing.Size(148, 38);
            this.level1Button.TabIndex = 4;
            this.level1Button.Text = "Level 1";
            this.level1Button.UseVisualStyleBackColor = false;
            this.level1Button.Click += new System.EventHandler(this.Level1Button_Click);
            // 
            // level3Button
            // 
            this.level3Button.BackColor = System.Drawing.Color.Thistle;
            this.level3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level3Button.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level3Button.Location = new System.Drawing.Point(689, 457);
            this.level3Button.Name = "level3Button";
            this.level3Button.Size = new System.Drawing.Size(148, 38);
            this.level3Button.TabIndex = 5;
            this.level3Button.Text = "Level 3";
            this.level3Button.UseVisualStyleBackColor = false;
            this.level3Button.Click += new System.EventHandler(this.Level3Button_Click);
            // 
            // level2Button
            // 
            this.level2Button.BackColor = System.Drawing.Color.Thistle;
            this.level2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level2Button.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2Button.Location = new System.Drawing.Point(376, 457);
            this.level2Button.Name = "level2Button";
            this.level2Button.Size = new System.Drawing.Size(148, 38);
            this.level2Button.TabIndex = 6;
            this.level2Button.Text = "Level2";
            this.level2Button.UseVisualStyleBackColor = false;
            this.level2Button.Click += new System.EventHandler(this.Level2Button_Click);
            // 
            // level3WandPicture
            // 
            this.level3WandPicture.BackColor = System.Drawing.Color.Transparent;
            this.level3WandPicture.Location = new System.Drawing.Point(710, 295);
            this.level3WandPicture.Name = "level3WandPicture";
            this.level3WandPicture.Size = new System.Drawing.Size(111, 162);
            this.level3WandPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level3WandPicture.TabIndex = 9;
            this.level3WandPicture.TabStop = false;
            // 
            // level1WandPicture
            // 
            this.level1WandPicture.BackColor = System.Drawing.Color.Transparent;
            this.level1WandPicture.Location = new System.Drawing.Point(95, 286);
            this.level1WandPicture.Name = "level1WandPicture";
            this.level1WandPicture.Size = new System.Drawing.Size(107, 171);
            this.level1WandPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level1WandPicture.TabIndex = 10;
            this.level1WandPicture.TabStop = false;
            // 
            // level2WandPicture
            // 
            this.level2WandPicture.BackColor = System.Drawing.Color.Transparent;
            this.level2WandPicture.Location = new System.Drawing.Point(405, 246);
            this.level2WandPicture.Name = "level2WandPicture";
            this.level2WandPicture.Size = new System.Drawing.Size(94, 211);
            this.level2WandPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2WandPicture.TabIndex = 11;
            this.level2WandPicture.TabStop = false;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.Thistle;
            this.mainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMenuButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainMenuButton.Location = new System.Drawing.Point(70, 58);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(148, 34);
            this.mainMenuButton.TabIndex = 25;
            this.mainMenuButton.Text = "MAIN PAGE";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Thistle;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Location = new System.Drawing.Point(710, 58);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 34);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LevelSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 561);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.level2WandPicture);
            this.Controls.Add(this.level1WandPicture);
            this.Controls.Add(this.level3WandPicture);
            this.Controls.Add(this.level2Button);
            this.Controls.Add(this.level3Button);
            this.Controls.Add(this.level1Button);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backgroundPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LevelSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frog Game - Choose Level";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3WandPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1WandPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2WandPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPicture;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button level1Button;
        private System.Windows.Forms.Button level3Button;
        private System.Windows.Forms.Button level2Button;
        private System.Windows.Forms.PictureBox level3WandPicture;
        private System.Windows.Forms.PictureBox level1WandPicture;
        private System.Windows.Forms.PictureBox level2WandPicture;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button exitButton;
    }
}