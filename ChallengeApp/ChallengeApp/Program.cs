using ChallengeApp;

var employee = new Employee("", "");
Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var input = "";
while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statidtics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Min: {statidtics.Min}");
Console.WriteLine($"Max: {statidtics.Max}");
Console.WriteLine($"Average: {statidtics.Average}");
Console.WriteLine($"AverasgeLetter: {statidtics.AverageLetter}");