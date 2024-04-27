namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareReferenceValues()
        {
            // typy referencyjne

            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);  // Adam Adam

        }

        [Test]
        public void CompareReferenceValues2()
        {
            // typy referencyjne

            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Tomasz");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);  // inne obiekty

        }

        [Test]
        public void CompareReferenceValuesByValues()
        {
            // typy referencyjne

            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act


            // assert
            Assert.AreEqual(user1.Login, user2.Login);  // Adam Adam

        }

        [Test]
        public void CompareValueTypes ()
        {
            // typy wartosciowe

            // arrange
            int number1 = 2;
            int number2 = 2;

            // act

             
            // assert
            Assert.AreEqual(number1, number2);   // 2 -- 2
        }

        [Test]
        public void CompareValueTypes_floats()
        {
            // typy wartosciowe

            // arrange
            float floatValue= 2.5f;
            float floatValue2 = 2.5f;

            // act


            // assert
            Assert.AreEqual(floatValue, floatValue2);
        }



        [Test]
        public void CompareStringTypeValue()
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
