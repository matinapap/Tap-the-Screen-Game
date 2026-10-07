using System;
using System.Windows.Forms;

namespace FrogGame.WinForms.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            titlePicture.Image = GameAssets.Load(GameAssets.Title);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Navigator.GoTo(this, new LevelSelectForm());
        }

        private void LeaderboardButton_Click(object sender, EventArgs e)
        {
            Navigator.GoTo(this, new LeaderboardForm());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
