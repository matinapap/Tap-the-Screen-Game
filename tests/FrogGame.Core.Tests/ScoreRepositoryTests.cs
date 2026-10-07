using System;
using System.IO;
using System.Linq;
using FrogGame.Core;
using Microsoft.Data.Sqlite;
using Xunit;

namespace FrogGame.Core.Tests
{
    public sealed class ScoreRepositoryTests : IDisposable
    {
        private readonly string databasePath = Path.Combine(Path.GetTempPath(), $"froggame-{Guid.NewGuid():N}.db");

        public void Dispose()
        {
            SqliteConnection.ClearAllPools();
            File.Delete(databasePath);
        }

        [Fact]
        public void GetTopScores_ReturnsHighestFirst_ForTheRequestedLevelOnly()
        {
            var repository = new ScoreRepository(databasePath);
            repository.AddScore("alice_1", 1, 300);
            repository.AddScore("bobby_2", 1, 900);
            repository.AddScore("carol_3", 1, 500);
            repository.AddScore("dave_44", 2, 9999);

            var top = repository.GetTopScores(1);

            Assert.Equal(new[] { "bobby_2", "carol_3", "alice_1" }, top.Select(s => s.Username));
            Assert.Equal(new[] { 900, 500, 300 }, top.Select(s => s.Score));
        }

        [Fact]
        public void GetTopScores_ReturnsAtMostTheRequestedCount()
        {
            var repository = new ScoreRepository(databasePath);
            for (int i = 0; i < 8; i++)
            {
                repository.AddScore("player" + i, 3, i * 100);
            }

            Assert.Equal(GameRules.LeaderboardSize, repository.GetTopScores(3).Count);
        }

        [Fact]
        public void GetTopScores_ReadsRowsWrittenByTheOriginalVersion()
        {
            // The first release stored the level as text; those rows must still show up.
            new ScoreRepository(databasePath);
            using (var connection = new SqliteConnection($"Data Source={databasePath}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Players (Username, Level, Counter) VALUES ('legacy_player', '2', 1200)";
                command.ExecuteNonQuery();
            }

            var top = new ScoreRepository(databasePath).GetTopScores(2);

            Assert.Equal("legacy_player", Assert.Single(top).Username);
        }
    }
}
