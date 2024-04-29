using ChallengeApp;

var employee = new Employee("Joe", "Doe");

employee.AddGrade(5);
employee.AddGrade(2);
employee.AddGrade(1);

var statistics = employee.GetStatistics();
Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:f2}");
Console.WriteLine($"Min {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");