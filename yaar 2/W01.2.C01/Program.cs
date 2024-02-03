int money = 4;

while (money > 0){
    Console.WriteLine($"Money left: {money}");
    Console.WriteLine($"Look around (1) or go in a ride (2)?");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 1){
        Console.WriteLine("Yay!");
    }
    else if(answer == 2)
    {
        Console.WriteLine("Wheee!");
        money--;
    }
    if(money == 0)
    {
        Console.WriteLine("Time to go home");
    }
}
