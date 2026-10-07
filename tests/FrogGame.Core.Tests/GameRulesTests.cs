using System;
using FrogGame.Core;
using Xunit;

namespace FrogGame.Core.Tests
{
    public class GameRulesTests
    {
        [Theory]
        [InlineData(120, "2:00")]
        [InlineData(95, "1:35")]
        [InlineData(9, "0:09")]
        [InlineData(0, "0:00")]
        [InlineData(-3, "0:00")]
        public void FormatTime_ShowsMinutesAndSeconds(int seconds, string expected)
        {
            Assert.Equal(expected, GameRules.FormatTime(seconds));
        }

        [Theory]
        [InlineData(90, true)]
        [InlineData(60, true)]
        [InlineData(30, true)]
        [InlineData(0, false)]
        [InlineData(45, false)]
        public void IsCoinWaveDue_EveryThirtySecondsExceptAtTheEnd(int secondsRemaining, bool expected)
        {
            Assert.Equal(expected, GameRules.IsCoinWaveDue(secondsRemaining));
        }

        [Fact]
        public void LevelSettings_OnlyLevelThreeHasADuck()
        {
            Assert.False(LevelSettings.For(1).HasDuck);
            Assert.False(LevelSettings.For(2).HasDuck);
            Assert.True(LevelSettings.For(3).HasDuck);
        }

        [Fact]
        public void LevelSettings_FrogDodgesFromLevelTwo()
        {
            Assert.False(LevelSettings.For(1).FrogDodgesWhenHit);
            Assert.True(LevelSettings.For(2).FrogDodgesWhenHit);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4)]
        public void LevelSettings_RejectsUnknownLevels(int level)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => LevelSettings.For(level));
        }
    }
}
