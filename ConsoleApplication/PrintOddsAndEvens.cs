using System;
using System.Linq;

public class PrintOddsAndEvens : ITask
{
    public int TaskId { set; get; } = 14;
    public string Title { get; set; } = "Print Odds and Evens";
    public string Description { get; set; } = "Prints two arrays.\nOne with only odds, one only evens";
    TaskHandler handler;

    public PrintOddsAndEvens(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }

    public int[] UserInput()
    {
        string input = Validator.GetString("Enter comma-seperated values!");
        string[] tokens = input.Split(',');

        int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
        return convertedItems;
    }

    public int[] SortedArray(int[] arr)
    {
        return arr.OrderBy(i => i).ToArray();
    }

    public void PrintEvens(int[] arr)
    {
        string list = "";
        foreach (var item in arr)
        {
            if (item % 2 != 0)
            {
                list += item + " ";
            }
        }
        ConsoleEventing.Msg(list);
    }

    public void PrintOdds(int[] arr)
    {
        string list = "";
        foreach (var item in arr)
        {
            if (item % 2 == 0)
            {
                list += item + " ";
            }
        }
        ConsoleEventing.Msg(list);
    }

    public void Run()
    {
        var userInput = UserInput();
        var sorted = SortedArray(userInput);
        PrintOdds(sorted);
        Console.WriteLine("----------");
        PrintEvens(sorted);
    }
}




