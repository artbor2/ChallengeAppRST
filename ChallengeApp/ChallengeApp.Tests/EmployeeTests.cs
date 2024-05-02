namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsInteger()
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
        public void Employee_AddGrade_WhenUserGetGrade_AsLong()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5L);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(5f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsDouble()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(5.0D);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(5f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsCharA()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade('A');


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(100f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsCharB()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade('B');


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(80f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsCharC()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade('C');


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(60f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsCharD()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade('D');


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(40f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsCharE()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade('E');


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(20f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsNumericString()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade("5");


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(5f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsStringLetterA()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade("A");


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(100.0f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsStringLetterB()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade("B");


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(80.0f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsStringLetterC()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade("C");


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(60.0f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsStringLetterD()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade("D");


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(40.0f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsStringLetterE()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade("E");


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(20.0f, result.Average);

        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsStringSmallLetter()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade("a");


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(100f, result.Average);

        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsWrongString()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade("Damian");        // 'D' first letter

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(0f, result.Average);
        }


        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_AsNegativeValue()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(-500);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(0, result.Max);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_BiggerThan100()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(500);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(0, result.Max);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrade_0_Should_get_0()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(0);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(0, result.Average);
        }


        [Test]
        public void Employee_AddGrade_WhenUserGetGrades_ShouldGetCorrectMinimum()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(1f, result.Min);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrades_ShouldGetCorrectMaximum()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(3f, result.Max);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrades_ShouldGetCorrectAverage()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(2f, result.Average);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrades_ShouldGetAverageLetterA()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(100);
            employee.AddGrade(100);
            employee.AddGrade(100);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('A', result.AverageLetter);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrades_ShouldGetAverageLetterB()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(80);
            employee.AddGrade(80);
            employee.AddGrade(80);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('B', result.AverageLetter);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrades_ShouldGetAverageLetterC()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(60);
            employee.AddGrade(60);
            employee.AddGrade(60);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('C', result.AverageLetter);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrades_ShouldGetAverageLetterD()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(40);
            employee.AddGrade(40);
            employee.AddGrade(40);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('D', result.AverageLetter);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrades_ShouldGetAverageLetterE()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(20);
            employee.AddGrade(20);
            employee.AddGrade(20);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('E', result.AverageLetter);
        }

        [Test]
        public void Employee_AddGrade_WhenUserGetGrades_ShouldGetAverageLetterF()
        {
            // arrange
            var employee = new Employee("", "");
            employee.AddGrade(0);
            employee.AddGrade(0);
            employee.AddGrade(0);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('F', result.AverageLetter);
        }
    }
}