Console.WriteLine("Give some text");
string text = Console.ReadLine();

Console.WriteLine("What do you want to do with this text?");
Console.WriteLine("U: make all uppercase");
Console.WriteLine("L: make all lowercase");
Console.WriteLine("Any other key: do not change");
string choice = Console.ReadLine();

if (string.Equals(choice, "U", StringComparison.OrdinalIgnoreCase))

{
    string newText = text.ToUpper();
    Console.WriteLine(newText);
}
else if (string.Equals(choice, "L", StringComparison.OrdinalIgnoreCase))
{
    string newText = text.ToLower();
    Console.WriteLine(newText);
}
else
{
    string newText = text;
    Console.WriteLine(newText);
}
