using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Menu<T> where T : Task
{
    static bool Welcome = true;
    private static readonly string WelcomeMsg = "\nWelcome to The Console App!\nPlease choose a task\n\nOptions\nTasks #1-16\nMenu #99\nExit #404";


    public static void SetActive(List<T> list)
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
            PrintMenu(list);
        }

        if (idx == 404)
        {
            ConsoleEventing.Msg("Good Bye!");
            Thread.Sleep(2);
            Environment.Exit(0);
        }
        foreach (var task in list)
        {
            if (idx < 17)
            {
                int id = task.GetId();
                if (idx == id)
                {
                    Console.WriteLine(task.GetDescription());
                    Thread.Sleep(500);
                    task.Run();
                    Thread.Sleep(500);
                    SetActive(list);
                }
            }
            else if (idx != 99 && idx != 404)
            {
                ConsoleEventing.Error("No such task");
                SetActive(list);
            }
            else
            {
                SetActive(list);
            }
        }
    }

    public static void PrintMenu(List<T> list)
    {
        IEnumerable<T> menu = list.OrderBy(item => item.GetId());
        foreach (var item in menu)
        {
            Console.WriteLine($"{item.GetId()}  {item.GetTitle()}");
        }
    }
}




