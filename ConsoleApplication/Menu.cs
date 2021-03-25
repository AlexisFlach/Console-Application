using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public static class Menu
{
    static bool Welcome = true;
    private static readonly string WelcomeMsg = "\nWelcome The Console App!\nPlease choose a task\n\nOptions\nTasks #1-16\nMenu #99\nExit #404";

    public static void SetActive(List<ITask> Task)
    {
        int idx;
        if (Welcome)
        {
            Welcome = false;
            idx = Validator.HandleUserMenuChoises(WelcomeMsg);
        }
        else
        {
            idx = Validator.HandleUserMenuChoises("\nWant to try another one?\n\nOptions\nTasks #1-16\nMenu #99\nExit #404");
        }

        if (idx == 99)
        {
            PrintMenu(Task);
        }

        if (idx == 404)
        {
            ConsoleEventing.Msg("Good Bye!");
            Thread.Sleep(2);
            Environment.Exit(0);
        }
        foreach (var task in Task)
        {
            if (idx < 17)
            {
                if (idx == task.TaskId)
                {
                    Console.WriteLine(task.Description);
                    Thread.Sleep(1000);
                    task.Run();
                    Thread.Sleep(1000);
                    SetActive(Task);
                }
            }
            else if (idx != 99 && idx != 404)
            {
                ConsoleEventing.Error("No such task");
                SetActive(Task);
            }
            else
            {
                SetActive(Task);
            }
        }
    }

    public static void PrintMenu(List<ITask> list)
    {
        IEnumerable<ITask> menu = list.OrderBy(task => task.TaskId);
        foreach (var task in menu)
        {
            Console.WriteLine($"{task.TaskId}  {task.Title}");
        }
    }
}




