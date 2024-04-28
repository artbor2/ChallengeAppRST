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

setSth(statistics); 
Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:f2}");
Console.WriteLine($"Min {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");

setSth2(ref statistics);
Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:f2}");
Console.WriteLine($"Min {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");

setSth3(out statistics);


// przekazywaniw przez wartość referencji
void setSth(Statistics statistics)
{
    statistics = new Statistics();
}

// przekazywanie przez referencje
void setSth2(ref Statistics statistics)
{
    statistics = new Statistics();
}

void setSth3(out Statistics statistics)
{
    // nadpisac wartosc statistic
    statistics = new Statistics();
}




