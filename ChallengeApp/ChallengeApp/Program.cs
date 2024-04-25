var age = 55;
var name = "Adam";

if (age > 50)
{
    if (name == "Adam")
    {
        Console.WriteLine("Adam");
    }
    else
    {
        Console.WriteLine("Nie Adam ?!");
    }
    Console.WriteLine(" > 50 lat");
}
else if (age > 40)
{
    Console.WriteLine("40-50 latek");
}
else if (age > 30)
{
    Console.WriteLine("30-40 latek");
}
else
{
    Console.WriteLine("Mniej niż 30 lat");
}