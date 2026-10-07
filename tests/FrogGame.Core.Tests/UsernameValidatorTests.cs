using FrogGame.Core;
using Xunit;

namespace FrogGame.Core.Tests
{
    public class UsernameValidatorTests
    {
        [Theory]
        [InlineData("player")]
        [InlineData("frog_master_99")]
        [InlineData("______")]
        public void AcceptsValidNames(string username)
        {
            Assert.True(UsernameValidator.TryValidate(username, out string error));
            Assert.Null(error);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("short")]
        public void RejectsNamesThatAreTooShort(string username)
        {
            Assert.False(UsernameValidator.TryValidate(username, out string error));
            Assert.Contains("at least", error);
        }

        [Theory]
        [InlineData("Player1")]
        [InlineData("player one")]
        [InlineData("player{1}")]
        [InlineData("player-one")]
        public void RejectsDisallowedCharacters(string username)
        {
            Assert.False(UsernameValidator.TryValidate(username, out string error));
            Assert.Contains("lowercase", error);
        }
    }
}
