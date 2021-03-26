using System;

public class AddNumbers : Task
{
    TaskHandler handler;

    public AddNumbers(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 15;
        Title = "Add Numbers Together";
        Description = "Prints the total sum of comma-separeted values";
    }

    public int[] UserInput()
    {
        string input = Validator.GetString("Please enter some comma-seperated values");
        string[] tokens = input.Split(',');
        int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

        return convertedItems;
    }

    public int Add(int[] arr)
    {
        var sum = 0;

        foreach (var value in arr)
        {
            sum += value;
        }
        return sum;
    }

    public override void Run()
    {
        var input = UserInput();
        Console.WriteLine(Add(input));
    }
}




