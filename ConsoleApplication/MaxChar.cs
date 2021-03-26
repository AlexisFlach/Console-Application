public class MaxChar : Task
{
    TaskHandler handler;

    MaxCharPrinter maxCharPrinter = new MaxCharPrinter();

    public MaxChar(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 8;
        Title = "Max Char";
        Description = "Given a string, return char that is most often used.";
    }


    public override void Run()
    {
        string input = Validator.ValidateString("Write a word!");
        maxCharPrinter.PrintMaxChar(input);
    }
}




