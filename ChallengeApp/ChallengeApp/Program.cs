using ChallengeApp;

int index = 0;
while (index < 10)
{
    if (index == 4)
    {
        break;          // end current loop
    }
    Console.Write(index + " ");
    index++;
}
Console.WriteLine();

index = 0;
while (index < 10)
{
   
    index++;
    if (index == 4)
    {
        continue;       // skip current loop jump to next
    }
    Console.Write(index + "  ");
}

Console.WriteLine();

index = 0;
while (index < 10)
{

    
    if (index == 4)
    {
        goto xxxx;  // breaak loop and jump to label
    }
    Console.Write(index + "  ");
    index++;
}


xxxx:
Console.WriteLine("GOHERE");
