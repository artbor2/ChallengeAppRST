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

for (int i = 0; i < dayOfWeeks.Count; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}
Console.WriteLine();