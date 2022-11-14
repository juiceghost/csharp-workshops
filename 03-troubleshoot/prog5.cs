// Eftersom i är 1 i exemplet nedan förväntar vi oss att koden inte ska göra något men nu skriver den ut "Two". 
// Varför blir det så och hur löser vi det så att det inte blir någon utskrift om i är 1?

int i = 1;

switch (i)
{
    case 1:
    case 2:
        Console.WriteLine("Two");
        break;
    default:
        Console.WriteLine("Other");
        break;
}
