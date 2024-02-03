List<string> tasksList = new List<string>();

Console.WriteLine($"Amount of tasks: {tasksList.Count}");

tasksList.Add("Mow lawn");
tasksList.Add("Pay taxes");

Console.WriteLine($"Amount of tasks: {tasksList.Count}");

for (int i = 0; i < tasksList.Count; i++)
{
    Console.WriteLine(tasksList[i]);
}

tasksList.Remove("Mow lawn");
tasksList.Add("Shopping");

Console.WriteLine($"Amount of tasks: {tasksList.Count}");

for (int i = 0; i < tasksList.Count; i++)
{
    Console.WriteLine(tasksList[i]);
}
