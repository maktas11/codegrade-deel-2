Console.WriteLine("What is the temperature in Celsius?");
float temprature = float.Parse(Console.ReadLine());
float answer = (float)(temprature * 1.8) + 32;
Console.WriteLine($"{temprature} C = {answer} F");
Console.WriteLine($"Truncated that is {(int)answer} F");