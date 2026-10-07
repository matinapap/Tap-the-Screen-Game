using System;
using System.Windows.Forms;

namespace FrogGame.WinForms.Forms
{
    public partial class LevelSelectForm : Form
    {
        public LevelSelectForm()
        {
            InitializeComponent();

            BackgroundImage = GameAssets.Load(GameAssets.MenuBackground);
            backgroundPicture.Image = GameAssets.Load(GameAssets.MenuBackground);
            level1WandPicture.Image = GameAssets.Load(GameAssets.Wand1);
            level2WandPicture.Image = GameAssets.Load(GameAssets.Wand2);
            level3WandPicture.Image = GameAssets.Load(GameAssets.Wand3);
        }

        private void StartLevel(int level)
        {
            Navigator.GoTo(this, new GameForm(level));
        }

        private void Level1Button_Click(object sender, EventArgs e) => StartLevel(1);

        private void Level2Button_Click(object sender, EventArgs e) => StartLevel(2);

        private void Level3Button_Click(object sender, EventArgs e) => StartLevel(3);

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
