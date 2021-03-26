using System.Linq;

public class NumbersBetween : Task
{
    TaskHandler handler;

    public NumbersBetween(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 13;
        Title = "Numbers Between";
        Description = "Given two inputs prints all numbers inbetween";
    }

    public void PrintNumbersBetween()
    {
        int input1 = Validator.ValidateInt("Please enter a number");
        int input2 = Validator.ValidateInt("Please enter another number");

        if (input1 == input2 || input1 >= input2)
        {
            ConsoleEventing.Error("Try Again! The first number must be smaller than the second.");
            PrintNumbersBetween();
        }
        else
        {
            int[] numbers = Enumerable.Range(input1 + 1, input2 - input1 - 1).ToArray();
            string list = "";
            foreach (var item in numbers)
            {
                list += item + " ";
            }
            ConsoleEventing.Msg(list);
        }
    }

    public override void Run()
    {
        PrintNumbersBetween();
    }
}




