using Assignment1.Models;

namespace Assignment1_Test
{
    public class Tests
    {
        private TeamsModel team = new TeamsModel() { Names = "Armando Yanez\n Art Robles\n Milo Wall\n Pedro Leonard", NumTeams = 2 };
        private TeamsModel teamNull = new TeamsModel();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArrayShuffledSuccessfullyTest()
        {
            // Arrange
            var originalStringArray = team.Names.Split('\n');

            // Act
            var stringArrayShuffled = team.Shuffle(originalStringArray);

            // Assert

            Assert.False(originalStringArray.Equals(stringArrayShuffled));
        }

        [Test]
        public void ArrayNotSuccessfullyShuffledTest()
        {
            // Arrange
            var originalStringArray = team.Names.Split('\n');

            // Act
            var stringArrayShuffled = originalStringArray;

            // Assert

            Assert.True(originalStringArray.Equals(stringArrayShuffled));
        }

        [Test]
        public void ArrayShuffledAttemptedWhileNullExceptionTest()
        {
            // Assert
            Assert.Throws<NullReferenceException>(() =>
            {
                teamNull.Names.Split('\n');
            });
        }

        [Test]
        public void ArrayColorsShuffledSuccessfullyTest()
        {
            // Act
            var colorsArrayShuffled = team.Shuffle(team.ColorsAvaliable);

            // Assert
            Assert.False(colorsArrayShuffled.Equals(team.ColorsAvaliable));
        }
    }
}