
public class HelloWorld : Task
{
    ////private int Id { get; set; } = 1;
    //private string Title { get; set; } = "Hello World";
    //private string Description { get; set; } = "Prints 'Hello World'.";

    TaskHandler handler;

    public HelloWorld(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 1;
        Title = "Hello World";
        Description = "Prints 'Hello World'.";
    }

    private void PrintString(string msg)
    {
        ConsoleEventing.Msg(msg);
    }


    public override void Run()
    {
        PrintString("Hello World");
    }
}



