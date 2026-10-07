using System;

namespace FrogGame.Core
{
    /// <summary>
    /// Tunable numbers that define a round of the game.
    /// </summary>
    public static class GameRules
    {
        public const int RoundDurationSeconds = 120;

        public const int FrogPoints = 100;
        public const int DuckPoints = 200;
        public const int CoinPoints = 50;

        public const int CoinsPerWave = 10;
        public const int CoinWaveIntervalSeconds = 30;
        public const int CoinLifetimeSeconds = 10;

        public const int LeaderboardSize = 5;

        /// <summary>
        /// A new wave of coins appears every <see cref="CoinWaveIntervalSeconds"/>, but not when the round ends.
        /// </summary>
        public static bool IsCoinWaveDue(int secondsRemaining)
        {
            return secondsRemaining > 0 && secondsRemaining % CoinWaveIntervalSeconds == 0;
        }

        /// <summary>
        /// Formats a countdown as m:ss, e.g. 95 seconds becomes "1:35".
        /// </summary>
        public static string FormatTime(int seconds)
        {
            if (seconds < 0) seconds = 0;
            return TimeSpan.FromSeconds(seconds).ToString(@"m\:ss");
        }
    }
}
