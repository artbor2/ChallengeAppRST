List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piatek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");

Console.WriteLine(dayOfWeeks.Count);
Console.WriteLine();

foreach (string day in dayOfWeeks)
{
    Console.WriteLine(day);
}