using System;
using System.Windows.Forms;
using FrogGame.Core;

namespace FrogGame.WinForms.Forms
{
    /// <summary>
    /// Shows the final score and saves it under the player's username.
    /// </summary>
    public partial class GameOverForm : Form
    {
        private readonly int score;
        private readonly int level;

        public GameOverForm(int score, int level)
        {
            InitializeComponent();

            this.score = score;
            this.level = level;

            BackgroundImage = GameAssets.Load(GameAssets.MenuBackground);
            backgroundPicture.Image = GameAssets.Load(GameAssets.MenuBackground);
            scoreLabel.Text = score.ToString();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            if (TrySaveScore())
            {
                Navigator.GoTo(this, new MainMenuForm());
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (TrySaveScore())
            {
                Application.Exit();
            }
        }

        private bool TrySaveScore()
        {
            string username = usernameTextBox.Text;
            string error;
            if (!UsernameValidator.TryValidate(username, out error))
            {
                MessageBox.Show(error, "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Clear();
                usernameTextBox.Focus();
                return false;
            }

            Program.Scores.AddScore(username, level, score);
            return true;
        }
    }
}
