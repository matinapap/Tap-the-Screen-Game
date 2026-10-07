using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FrogGame.WinForms
{
    /// <summary>
    /// Loads images from the Assets folder next to the executable.
    /// A missing file yields null rather than a crash, so the game stays playable without artwork.
    /// </summary>
    internal static class GameAssets
    {
        public const string Title = "title.gif";
        public const string MenuBackground = "lakeform1.gif";
        public const string LeaderboardBackground = "background3.jpg";
        public const string Frog = "frog.png";
        public const string Duck = "happy.png";
        public const string Coin = "coin.png";
        public const string Wand1 = "wand1.png";
        public const string Wand2 = "wand2.png";
        public const string Wand3 = "wand3.png";

        private static readonly string AssetsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets");
        private static readonly Dictionary<string, Image> Cache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

        public static Image Load(string fileName)
        {
            if (fileName == null)
            {
                return null;
            }

            Image image;
            if (!Cache.TryGetValue(fileName, out image))
            {
                string path = Path.Combine(AssetsDirectory, fileName);
                image = File.Exists(path) ? Image.FromFile(path) : null;
                Cache[fileName] = image;
            }

            return image;
        }

        /// <summary>
        /// Builds a mouse cursor from an image, falling back to the default cursor if the image is missing.
        /// </summary>
        public static Cursor LoadCursor(string fileName, Size size)
        {
            Image image = Load(fileName);
            if (image == null)
            {
                return Cursors.Default;
            }

            using (var bitmap = new Bitmap(image, size))
            {
                return new Cursor(bitmap.GetHicon());
            }
        }
    }
}
