using ChallengeApp;

var employee = new Employee("Joe", "Doe");

employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade("-5");
employee.AddGrade(2);
employee.AddGrade(6L);
employee.AddGrade(3.5);
employee.AddGrade('B');

var statistics = employee.GetStatistics();

Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:f2}");
Console.WriteLine($"Min {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");
Console.WriteLine($"AverageLetter {statistics.AverageLetter}");
