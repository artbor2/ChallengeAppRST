namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_Should_get_5()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(5, result.Max);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetNegativeGrade_Should_get_Minus5()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(-5);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(-5, result.Max);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGet_0_Should_get_0()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(0);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(0, result.Max);
        }

        [Test]
        public void Employee_AddGrade_Max__6()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(1); 

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, result.Max);
        }

        [Test]
        public void Employee_AddGrade_Min_1()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(1);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(1, result.Min);
        }

        [Test]
        public void Employee_AddGrade_Average_4()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(1);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(4f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_Negative_value()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(-5);
            employee.AddGrade(-6);
            employee.AddGrade(-1);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(-1, result.Max);
            Assert.AreEqual(-6, result.Min);
            Assert.AreEqual(-4, result.Average);
        }

        [Test]
        public void Employee_AddGrade_zeroing_value()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(-5);
            employee.AddGrade(6);
            employee.AddGrade(-1);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, result.Max);
            Assert.AreEqual(-5, result.Min);
            Assert.AreEqual(0f, result.Average);
        }

    }
}
