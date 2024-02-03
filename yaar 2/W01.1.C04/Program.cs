Console.WriteLine("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the age of the student next to you?");
int age2 = Convert.ToInt32(Console.ReadLine());

if (age == age2)
{
    Console.WriteLine("Your ages are equal");
}
else if (age > age2)
{
    Console.WriteLine("You are older");
}
else if (age < age2)
{
    Console.WriteLine("You are younger");
}