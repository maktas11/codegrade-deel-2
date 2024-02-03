Console.WriteLine("Hello. Please enter your last name.");
string lastName = Console.ReadLine();
Console.WriteLine("What is the initial of your first name?");
string input = Console.ReadLine();
char initial = Convert.ToChar(input);

Console.WriteLine($"Welcome to the course, {initial} {lastName}. We will watch your career with great interest.");

