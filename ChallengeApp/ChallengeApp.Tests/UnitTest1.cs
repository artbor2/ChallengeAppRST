
namespace ChallengeApp.Tests
{
    public class Tests
    {
        // [Test]
        public void WhenTwoNumberAreAdded_shouldReturnSum()
        {
            // arrange
            int age1 = 10;
            int age2 = 3;

            // act
            int result = age1 + age2;

            // assert
            Assert.AreEqual(13, result);
        }

        [Test]
        public void WhenUserCollectTwoScores_ShouldGetCorrectResult()
        {
            // arrange
            var user = new User("Adam","gkdgkhsdpog");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(11, result);

        }
    }
}