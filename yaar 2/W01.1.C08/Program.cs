Console.WriteLine("What direction would you like to go?");
Console.WriteLine("Up");
Console.WriteLine("Down");
Console.WriteLine("Right");
Console.WriteLine("Left");
string direction = Console.ReadLine();
switch (direction.ToUpper())
{
    case "UP":
        Console.WriteLine("Current position");
        Console.WriteLine("X:0, Y:1");
        break;
    case "DOWN":
        Console.WriteLine("Current position");
        Console.WriteLine("X:0, Y:-1");
        break;
    case "RIGHT":
        Console.WriteLine("Current position");
        Console.WriteLine("X:1, Y:0");
        break;
    case "LEFT":
        Console.WriteLine("Current position");
        Console.WriteLine("X:-1, Y:0");
        break;

}