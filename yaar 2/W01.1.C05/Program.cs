Console.WriteLine("What is the temperature of the water? (Celsius)");
float degrees = float.Parse(Console.ReadLine());
if (degrees == 0)
{
    Console.WriteLine("At 0 degrees Celsius, the water will be solid");
}
else if (degrees > 0 & degrees < 100)
{
    Console.WriteLine($"At {degrees} degrees Celsius, the water will be liquid");
}
else if (degrees >= 100)
{
    Console.WriteLine($"At {degrees} degrees Celsius, the water will be gas");
}