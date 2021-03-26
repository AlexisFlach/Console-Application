using System;
using System.Linq;

public class PrintOddsAndEvens : Task
{ 
    TaskHandler handler;

    public PrintOddsAndEvens(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 14;
        Title = "Odds and Evens";
        Description = "Prints two arrays. One with only odds, one only evens.";
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

    public override void Run()
    {
        var userInput = UserInput();
        var sorted = SortedArray(userInput);
        PrintOdds(sorted);
        Console.WriteLine("----------");
        PrintEvens(sorted);
    }
}




