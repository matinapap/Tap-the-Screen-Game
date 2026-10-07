using System.Text.RegularExpressions;

namespace FrogGame.Core
{
    /// <summary>
    /// Rules for the name a player saves their score under.
    /// </summary>
    public static class UsernameValidator
    {
        public const int MinLength = 6;

        private static readonly Regex AllowedCharacters = new Regex("^[a-z0-9_]+$", RegexOptions.Compiled);

        /// <summary>
        /// Returns true when <paramref name="username"/> is valid; otherwise sets <paramref name="error"/> to a message for the player.
        /// </summary>
        public static bool TryValidate(string username, out string error)
        {
            if (string.IsNullOrEmpty(username) || username.Length < MinLength)
            {
                error = $"Username must be at least {MinLength} characters long.";
                return false;
            }

            if (!AllowedCharacters.IsMatch(username))
            {
                error = "You must only use lowercase letters, numbers and the underscore.";
                return false;
            }

            error = null;
            return true;
        }
    }
}
