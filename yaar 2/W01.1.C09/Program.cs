Console.WriteLine("Enter an age:");
int age = Convert.ToInt32(Console.ReadLine());

string result = age switch
{
    var a when a < 0 || a > 149 => $"Age {age}: invalid",
    var a when a < 13 => $"Age {age}: a child",
    var a when a > 12 && a < 19 => $"Age {age}: a teenager",
    var a when a > 19 && a < 151 => $"Age {age}: an adult",
    _ => ""
};

Console.WriteLine(result);