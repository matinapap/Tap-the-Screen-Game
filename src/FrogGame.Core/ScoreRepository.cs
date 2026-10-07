using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace FrogGame.Core
{
    public sealed class ScoreEntry
    {
        public ScoreEntry(string username, int score)
        {
            Username = username;
            Score = score;
        }

        public string Username { get; }
        public int Score { get; }
    }

    /// <summary>
    /// Stores high scores in a local SQLite database.
    /// </summary>
    public sealed class ScoreRepository
    {
        private readonly string connectionString;

        /// <param name="databasePath">Path to the SQLite file; it is created if it does not exist.</param>
        public ScoreRepository(string databasePath)
        {
            connectionString = new SqliteConnectionStringBuilder { DataSource = databasePath }.ToString();
            EnsureCreated();
        }

        public void AddScore(string username, int level, int score)
        {
            using (var connection = Open())
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Players (Username, Level, Counter) VALUES (@username, @level, @score)";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@level", level);
                command.Parameters.AddWithValue("@score", score);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Returns the best scores for a level, highest first.
        /// </summary>
        public IReadOnlyList<ScoreEntry> GetTopScores(int level, int count = GameRules.LeaderboardSize)
        {
            var results = new List<ScoreEntry>();

            using (var connection = Open())
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Username, Counter FROM Players WHERE Level = @level ORDER BY Counter DESC LIMIT @count";
                command.Parameters.AddWithValue("@level", level);
                command.Parameters.AddWithValue("@count", count);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new ScoreEntry(reader.GetString(0), reader.GetInt32(1)));
                    }
                }
            }

            return results;
        }

        private void EnsureCreated()
        {
            using (var connection = Open())
            using (var command = connection.CreateCommand())
            {
                // Table and column names are kept from the original schema so existing databases still work.
                command.CommandText = "CREATE TABLE IF NOT EXISTS Players (Level INTEGER, Username TEXT, Counter INTEGER)";
                command.ExecuteNonQuery();
            }
        }

        private SqliteConnection Open()
        {
            var connection = new SqliteConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
