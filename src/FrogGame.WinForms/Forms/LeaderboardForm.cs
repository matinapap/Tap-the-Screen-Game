using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrogGame.Core;

namespace FrogGame.WinForms.Forms
{
    /// <summary>
    /// Shows the top five scores for the selected level.
    /// </summary>
    public partial class LeaderboardForm : Form
    {
        private const string EmptySlot = "-";

        private readonly Label[] nameLabels;
        private readonly Label[] scoreLabels;

        public LeaderboardForm()
        {
            InitializeComponent();

            BackgroundImage = GameAssets.Load(GameAssets.LeaderboardBackground);
            nameLabels = new[] { name1Label, name2Label, name3Label, name4Label, name5Label };
            scoreLabels = new[] { score1Label, score2Label, score3Label, score4Label, score5Label };
        }

        private void ShowLevel(int level)
        {
            IReadOnlyList<ScoreEntry> topScores = Program.Scores.GetTopScores(level, nameLabels.Length);

            for (int i = 0; i < nameLabels.Length; i++)
            {
                bool hasEntry = i < topScores.Count;
                nameLabels[i].Text = hasEntry ? topScores[i].Username : EmptySlot;
                scoreLabels[i].Text = hasEntry ? topScores[i].Score.ToString() : EmptySlot;
            }
        }

        private void Level1Button_Click(object sender, EventArgs e) => ShowLevel(1);

        private void Level2Button_Click(object sender, EventArgs e) => ShowLevel(2);

        private void Level3Button_Click(object sender, EventArgs e) => ShowLevel(3);

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Navigator.GoTo(this, new MainMenuForm());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
