public class LargestNumberPrinter : Task
{
    TaskHandler handler;

    public LargestNumberPrinter(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 5;
        Title = "Compare Numbers";
        Description = "Compares two inputs, returns largest number.";
    }

    public string Compare()
    {
        int num1 = Validator.ValidateInt("Enter a number...");
        int num2 = Validator.ValidateInt("Enter another number...");
        string res = CompareTwoInt(num1, num2);
        return res;
    }

    public static string CompareTwoInt(int a, int b)
    {
        if (a > b)
        {
            return a.ToString();
        }
        else if (a < b)
        {
            return b.ToString();
        }
        else
        {
            return "They are equals";
        }
    }

    public override void Run()
    {
        string output = Compare();
        ConsoleEventing.Msg(output);
    }
}




