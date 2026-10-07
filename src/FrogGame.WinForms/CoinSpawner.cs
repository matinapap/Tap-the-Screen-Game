using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FrogGame.Core;

namespace FrogGame.WinForms
{
    /// <summary>
    /// Scatters bonus coins across a screen and removes them when collected or expired.
    /// </summary>
    internal sealed class CoinSpawner
    {
        private static readonly Size CoinSize = new Size(50, 50);
        private const int EdgeMargin = 30;
        private const int TopMargin = 50;

        private readonly Control container;
        private readonly EventHandler onCoinClick;
        private readonly Random random;
        private readonly List<PictureBox> coins = new List<PictureBox>();

        public CoinSpawner(Control container, EventHandler onCoinClick, Random random)
        {
            this.container = container;
            this.onCoinClick = onCoinClick;
            this.random = random;
        }

        public void SpawnWave()
        {
            Size area = container.ClientSize;
            for (int i = 0; i < GameRules.CoinsPerWave; i++)
            {
                var coin = new PictureBox
                {
                    BackColor = Color.Transparent,
                    Image = GameAssets.Load(GameAssets.Coin),
                    Size = CoinSize,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(
                        random.Next(EdgeMargin, area.Width - CoinSize.Width - EdgeMargin),
                        random.Next(TopMargin, area.Height - CoinSize.Height - EdgeMargin)),
                };
                coin.Click += onCoinClick;
                container.Controls.Add(coin);
                coin.BringToFront();
                coins.Add(coin);
            }
        }

        public void Remove(PictureBox coin)
        {
            if (coins.Remove(coin))
            {
                container.Controls.Remove(coin);
                coin.Dispose();
            }
        }

        public void RemoveAll()
        {
            foreach (PictureBox coin in coins.ToArray())
            {
                Remove(coin);
            }
        }
    }
}
