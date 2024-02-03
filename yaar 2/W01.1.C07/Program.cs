Console.WriteLine("You have one chance to guess this six-letter word:");
Console.WriteLine("Le..th");
string answer = Console.ReadLine();
if (answer.Length > 6 || answer.Length < 6)
{
    Console.WriteLine("Incorrect! That is not even a six-letter word!");
}
else if (answer.All(char.IsLower))
{
    Console.WriteLine("Kind of correct; the case was just wrong");
}
else if (string.Equals(answer, "lenght", StringComparison.OrdinalIgnoreCase)) 
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect!");
}