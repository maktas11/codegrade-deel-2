Random rnd = new Random();

for (int j = 0; j < 10; j++)
{
    int number = rnd.Next(1, 6);
    Console.WriteLine(number);
}