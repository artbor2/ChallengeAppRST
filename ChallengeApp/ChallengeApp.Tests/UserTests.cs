
namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserGetScore_ShouldGetCorrectResult()
        {
            // arrange
            var user = new User("Jan", "4974646");
            user.AddScore(5);

            // act
            var result = user.Result; 

            // assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void WhenUserGetNegativeScore_ShouldGetCorrectResult()
        {
            // arrange
            var user = new User("Jan", "4974646");
            user.AddScore(-5);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void WhenUserGet_0_Score_ShouldGetCorrectResult()
        {
            // arrange
            var user = new User("Jan", "4974646");
            user.AddScore(0);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(0, result);
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

        [Test]
        public void WhenUserCollectTwoNegativeScores_ShouldGetCorrectResult()
        {
            // arrange
            var user = new User("Adam", "gkdgkhsdpog");
            user.AddScore(-5);
            user.AddScore(-6);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(-11, result);

        }

        [Test]
        public void WhenUserCollectTwoDifferentSignScores_ShouldGetCorrectResult()
        {
            // arrange
            var user = new User("Adam", "gkdgkhsdpog");
            user.AddScore(-5);
            user.AddScore(6);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(1, result);

        }

        [Test]
        public void WhenUserCollectTwoSignScores_ZeroingThemself_ShouldGetCorrectResult()
        {
            // arrange
            var user = new User("Adam", "gkdgkhsdpog");
            user.AddScore(-5);
            user.AddScore(5);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(0, result);

        }
    }
}