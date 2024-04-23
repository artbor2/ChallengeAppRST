// liczby całkowite
int myAge = 120;
int newAge = myAge + 5;
Console.WriteLine(newAge); // 125

int myInt = int.MaxValue;
Console.WriteLine("IntMaxValue: " + myInt);
Console.WriteLine("IntMaxValue + 1: " + (myInt + 1));

myInt = int.MinValue;
Console.WriteLine("IntMinValue: " + myInt);
Console.WriteLine("IntMinValue - 1: " + (myInt - 1));

uint myUInt = uint.MaxValue;
Console.WriteLine("Unsigned Int Max: " + myUInt);
myUInt = uint.MinValue;
Console.WriteLine("Unsigned Int Min: " + myUInt);

long myLong = long.MaxValue;
Console.WriteLine("Long maxValue: " + myLong);
myLong = long.MinValue;
Console.WriteLine("Long minValue: " + myLong);

ulong myULong = ulong.MaxValue;
Console.WriteLine("ulong maxValue: " + myULong);
myULong = ulong.MinValue;
Console.WriteLine("ulong minValue: " + myULong);
Console.WriteLine();

// liczby zmiennoprzecinkowe
float myFloat = float.MaxValue;
Console.WriteLine(myFloat);
double myDouble = double.MaxValue;
Console.WriteLine(myDouble);
decimal myDecimal = decimal.MaxValue;
Console.WriteLine(myDecimal);
Console.WriteLine();

// zmienne tekstowe
string name = "Adam";
string surname = "Kamizelich";
Console.WriteLine(name + surname);
Console.WriteLine(name + " " + surname);
Console.WriteLine("rok " + 20 + 24 ); // Teksty 
Console.WriteLine("rok " + (2000 + 24));
Console.WriteLine();

// zmienne znakowe
char myChar = 'c';
Console.WriteLine(myChar);
var result2 = name.ToCharArray();
Console.WriteLine(result2);

// zmienna logiczna
bool isActive = true;
Console.WriteLine(isActive);
var isOk = (5 > 6);
Console.WriteLine(isOk);

