class ExoRecap
{
    public static List<string> tasks = [];

    public static void ExoRecapMethod()
    {
        try
        {
            var exit = false;
            while(!exit)
            {
                Console.WriteLine("Main menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Display Tasks"); 
                Console.WriteLine("3. Remove Task by Name");
                Console.WriteLine("4. Remove Task by Index");
                Console.WriteLine("5. Exit");

                var input = Console.ReadLine();
                if (!int.TryParse(input, out int number) || number < 1 || number > 5)
                    Console.WriteLine("Input must be an integer between 1 and 5.");

                switch(number)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        DisplayTask();
                        break;
                    case 3:
                        RemoveTaskByName();
                        break;
                    case 4:
                        RemoveTaskByIndex();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }  

    public static void AddTask()
    {
        Console.WriteLine("Enter task name:");
        var taskName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(taskName))
        {
            if(tasks.Contains(taskName))
                Console.WriteLine("Task already exists.");
            else
            {
                tasks.Add(taskName);
                Console.WriteLine("Task added successfully.");                
            }
        }
        else
            Console.WriteLine("Task name cannot be empty.");
    }

    public static void DisplayTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }
        
        Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i}: {tasks[i]}");
        }
    }

    public static void RemoveTaskByName()
    {
        Console.WriteLine("Enter task name to remove:");
        var taskName = Console.ReadLine() ?? "";
        if (tasks.Remove(taskName))
            Console.WriteLine("Task removed successfully.");
        else
            Console.WriteLine("Task not found.");
    }

    public static void RemoveTaskByIndex()
    {
        Console.WriteLine("Enter task index to remove:");
        var input = Console.ReadLine();
        if (int.TryParse(input, out int index) && index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Task removed successfully.");
        }
        else
            Console.WriteLine("Invalid index.");
    }
}