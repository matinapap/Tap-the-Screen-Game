using System;
using System.IO;
using System.Windows.Forms;
using FrogGame.Core;
using FrogGame.WinForms.Forms;

namespace FrogGame.WinForms
{
    internal static class Program
    {
        private static readonly Lazy<ScoreRepository> scores = new Lazy<ScoreRepository>(
            () => new ScoreRepository(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "frogdb.db")));

        /// <summary>The high-score database shared by all screens.</summary>
        public static ScoreRepository Scores => scores.Value;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Navigator(new MainMenuForm()));
        }
    }
}
