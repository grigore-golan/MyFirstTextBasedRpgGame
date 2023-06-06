using MyFirstTextBasedRpgGame.Common.BaseEntities;

namespace MyFirstTextBasedRpgGame.Testing.UnitTests
{
    public class PlayerTests
    {
        [Fact]
        public void Should_return_the_same_instance()
        {
            //Arrange
            Player expected = Player.GetInstance();

            //Act
            var actual = Player.GetInstance();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_not_be_null()
        {
            var actual = Player.GetInstance();

            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("Jojo")]
        [InlineData("Geko123")]
        [InlineData("_._")]
        [InlineData("Sentinel_Imaizumi")]
        public void Should_rename_with_the_given_name(string name)
        {
            var player = Player.GetInstance();

            player.Rename(name);

            Assert.Equal(name, player.Name);
        }
    }
}