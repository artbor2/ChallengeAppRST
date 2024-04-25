int[] grades = new int[5];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piatek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";
Console.WriteLine(dayOfWeeks[2]);
Console.WriteLine(dayOfWeeks.Length);
Console.WriteLine();

for (int i = 0; i < 10; i = i + 1)
{
    Console.Write(i + " ");
}
Console.WriteLine();

for (int i = 0; i < dayOfWeeks.Length; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}
Console.WriteLine();

for (int i = 0; i < dayOfWeeks.Length; i += 2)
{
    Console.WriteLine(dayOfWeeks[i]);
}