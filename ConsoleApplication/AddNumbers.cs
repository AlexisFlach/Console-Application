using System;

public class AddNumbers : ITask
{
    public int TaskId { get; set; } = 15;
    public string Title { get; set; } = "Add Numbers Together";
    public string Description { get; set; } = "Prints the total sum of comma-separeted values";

    TaskHandler handler;

    public AddNumbers(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
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

    public void Run()
    {
        var input = UserInput();
        Console.WriteLine(Add(input));
    }
}




