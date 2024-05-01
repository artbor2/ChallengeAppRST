using ChallengeApp;

var employee = new Employee("Joe", "Doe");

employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade("-5");
employee.AddGrade(2);
employee.AddGrade(6L);
employee.AddGrade(3.5);


var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:f2}");
Console.WriteLine($"Min {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");

Console.WriteLine($"Average: {statistics1.Average:f2}");
Console.WriteLine($"Min {statistics1.Min}");
Console.WriteLine($"Max {statistics1.Max}");

Console.WriteLine($"Average: {statistics2.Average:f2}");
Console.WriteLine($"Min {statistics2.Min}");
Console.WriteLine($"Max {statistics2.Max}");

Console.WriteLine($"Average: {statistics3.Average:f2}");
Console.WriteLine($"Min {statistics3.Min}");
Console.WriteLine($"Max {statistics3.Max}");

Console.WriteLine($"Average: {statistics4.Average:f2}");
Console.WriteLine($"Min {statistics4.Min}");
Console.WriteLine($"Max {statistics4.Max}");