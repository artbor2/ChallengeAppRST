/* Przygotuj program, który policzy ile jakich cyfr występuje
 * w podanej liczbie.
 *
 * Przykład:
 * Wyniki dla liczby 4566
 * 0 => 0
 * 1 => 0
 * 2 => 0
 * 3 => 0
 * 4 => 1
 * 5 => 1
 * 6 => 2
 * 7 => 0
 * 8 => 0
 * 9 => 0
 */

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int[] digitsStats = new int[10];
foreach (char c in letters)
{
    string digitAsString = c.ToString();
    int digit = int.Parse(digitAsString);
    digitsStats[digit]++;
}

Console.WriteLine(number);
for (int i = 0; i < digitsStats.Length; i++)
{
    Console.WriteLine(i + " => " + digitsStats[i]);
}