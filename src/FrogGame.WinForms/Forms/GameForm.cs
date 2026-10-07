using System;
using System.Drawing;
using System.Windows.Forms;
using FrogGame.Core;

namespace FrogGame.WinForms.Forms
{
    /// <summary>
    /// The play screen: click the moving frog (and duck on level 3) and grab bonus coins before time runs out.
    /// </summary>
    public partial class GameForm : Form
    {
        private const int HeaderHeight = 50;
        private static readonly Size WandCursorSize = new Size(80, 130);

        private readonly Random random = new Random();
        private readonly LevelSettings level;
        private readonly MovingTarget frog;
        private readonly MovingTarget duck;
        private readonly CoinSpawner coins;

        private int score;
        private int secondsRemaining = GameRules.RoundDurationSeconds;
        private int coinSecondsRemaining;

        public GameForm(int levelNumber)
        {
            InitializeComponent();

            level = LevelSettings.For(levelNumber);
            coins = new CoinSpawner(this, Coin_Click, random);

            Rectangle playArea = Rectangle.FromLTRB(0, HeaderHeight, ClientSize.Width, ClientSize.Height);

            frogPicture.Image = GameAssets.Load(GameAssets.Frog);
            frog = new MovingTarget(GameRules.FrogPoints, level.FrogSpeed,
                RandomPointIn(playArea, frogPicture.Size), random.Next(360), playArea, frogPicture.Size);

            if (level.HasDuck)
            {
                duckPicture.Image = GameAssets.Load(GameAssets.Duck);
                duckPicture.Visible = true;
                duck = new MovingTarget(GameRules.DuckPoints, level.DuckSpeed,
                    RandomPointIn(playArea, duckPicture.Size), random.Next(360), playArea, duckPicture.Size);
            }

            Image background = GameAssets.Load(level.BackgroundAsset);
            if (background != null)
            {
                BackgroundImage = background;
            }

            Cursor = GameAssets.LoadCursor(level.WandAsset, WandCursorSize);
            levelLabel.Text = "Level " + level.Number;
            UpdateScore(0);
            timeLabel.Text = GameRules.FormatTime(secondsRemaining);

            countdownTimer.Enabled = true;
        }

        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            frogPicture.Location = frog.Move();
            if (duck != null)
            {
                duckPicture.Location = duck.Move();
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            secondsRemaining--;
            timeLabel.Text = GameRules.FormatTime(secondsRemaining);

            if (secondsRemaining <= 0)
            {
                EndRound();
                return;
            }

            if (GameRules.IsCoinWaveDue(secondsRemaining))
            {
                coins.SpawnWave();
                coinSecondsRemaining = GameRules.CoinLifetimeSeconds;
            }
            else if (coinSecondsRemaining > 0 && --coinSecondsRemaining == 0)
            {
                coins.RemoveAll();
            }
        }

        private void FrogPicture_Click(object sender, EventArgs e)
        {
            // On level 1 the frog keeps its course; later levels make it dodge in a random direction.
            UpdateScore(level.FrogDodgesWhenHit ? frog.Hit(random.Next(360)) : frog.Points);
        }

        private void DuckPicture_Click(object sender, EventArgs e)
        {
            UpdateScore(duck.Hit(random.Next(360)));
        }

        private void Coin_Click(object sender, EventArgs e)
        {
            UpdateScore(GameRules.CoinPoints);
            coins.Remove((PictureBox)sender);
        }

        private void UpdateScore(int pointsEarned)
        {
            score += pointsEarned;
            scoreLabel.Text = "Score: " + score;
        }

        private void EndRound()
        {
            countdownTimer.Enabled = false;
            movementTimer.Enabled = false;
            Navigator.GoTo(this, new GameOverForm(score, level.Number));
        }

        private Point RandomPointIn(Rectangle area, Size size)
        {
            return new Point(
                random.Next(area.Left, area.Right - size.Width),
                random.Next(area.Top, area.Bottom - size.Height));
        }
    }
}
