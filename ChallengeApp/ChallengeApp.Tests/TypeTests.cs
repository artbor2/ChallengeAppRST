namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestRef()
        {
            // typy referencyjne

            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);  // Adam Adam

            // Assert.AreEqual(user1.Login, user2.Login);
        }

        [Test]
        public void TestWar()
        {
            // typy wartosciowe

            // arrange
            int number1 = 1;
            int number2 = 2;

            // act

             
            // assert
            Assert.AreNotEqual(number1, number2);   // 1 -- 2
        }

        [Test]
        public void TestString()
        {
            // string

            // arrange
            string name = "Adam";
            string name1 = "Adam";
 
            // act


            // assert
            Assert.AreEqual(name, name1);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }

    }
}
