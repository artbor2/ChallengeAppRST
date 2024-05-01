namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_Should_getMax5()
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
        public void Employee_AddGrade_WhenUserGetGrade_Should_getMin5()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(5, result.Min);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_Should_getAvg()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(5f, result.Average);
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
            Assert.AreEqual(0, result.Max);
        }

        [Test]
        public void Employee_AddGrade_Max_200()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(200);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(0, result.Max);
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
        public void Employee_AddGrade_zeroing_value()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(-5);
            employee.AddGrade(-6);
            employee.AddGrade(-1);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(0f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_AsString()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade("5");
            employee.AddGrade("6");
            employee.AddGrade("1");

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(4f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_AsWrongString()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5);
            employee.AddGrade("A");
            employee.AddGrade(1);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(3f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_AsDouble()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5.5D);
            employee.AddGrade(1.5D);
            employee.AddGrade(2.0D);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(3f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_AsLong()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5L);
            employee.AddGrade(2L);
            employee.AddGrade(2L);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(3f, result.Average);
        }
    }
}