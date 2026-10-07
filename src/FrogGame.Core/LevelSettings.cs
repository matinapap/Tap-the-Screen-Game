using System;

namespace FrogGame.Core
{
    /// <summary>
    /// Difficulty and look of each of the three levels.
    /// </summary>
    public sealed class LevelSettings
    {
        public const int MinLevel = 1;
        public const int MaxLevel = 3;

        private LevelSettings(int number, int frogSpeed, int duckSpeed, string wandAsset, string backgroundAsset)
        {
            Number = number;
            FrogSpeed = frogSpeed;
            DuckSpeed = duckSpeed;
            WandAsset = wandAsset;
            BackgroundAsset = backgroundAsset;
        }

        public int Number { get; }

        /// <summary>Pixels the frog moves per animation tick.</summary>
        public int FrogSpeed { get; }

        /// <summary>Pixels the duck moves per animation tick; zero means there is no duck.</summary>
        public int DuckSpeed { get; }

        public bool HasDuck => DuckSpeed > 0;

        /// <summary>From level 2 on, the frog jumps in a random direction every time it is hit.</summary>
        public bool FrogDodgesWhenHit => Number > 1;

        /// <summary>File name of the wand image used as the mouse cursor.</summary>
        public string WandAsset { get; }

        /// <summary>File name of the background image, or null for a plain background.</summary>
        public string BackgroundAsset { get; }

        public static LevelSettings For(int level)
        {
            switch (level)
            {
                case 1: return new LevelSettings(1, frogSpeed: 5, duckSpeed: 0, wandAsset: "wand1.png", backgroundAsset: "water.jpg");
                case 2: return new LevelSettings(2, frogSpeed: 8, duckSpeed: 0, wandAsset: "wand2.png", backgroundAsset: "lake.png");
                case 3: return new LevelSettings(3, frogSpeed: 6, duckSpeed: 10, wandAsset: "wand3.png", backgroundAsset: null);
                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, $"Level must be between {MinLevel} and {MaxLevel}.");
            }
        }
    }
}
