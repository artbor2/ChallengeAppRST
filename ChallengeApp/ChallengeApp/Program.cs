var number1 = 5;
var number2 = 10;

// operatory relacyjne < > <= >= != ==

  if (number1 < number2)
{
    Console.WriteLine("JESTEM TUTAJ W LINI 6");
}
else
{
    Console.WriteLine("JESTEN TUTAJ W LINI 10");
}

// operatory logiczne AND (I)  OR (LUB) &&, (Zaprzeczenie, negacja) NOT !

var name = "Adam";
var age = 33;

if (name  == "Adam" && age < 50)
{
    Console.WriteLine("Adam przed 50 lat");
} else
{
    Console.WriteLine( "Jestem kims innym" );
}

if (name == "Adam" || age < 50)
{
    Console.WriteLine("Jestem Adamem lub przed 50 ");
} else
{
    Console.WriteLine("Jestem kims innym");
}

// (Zaprzeczenie, negacja) NOT !
bool isActive = true;
Console.WriteLine(isActive);
Console.WriteLine(!isActive);
