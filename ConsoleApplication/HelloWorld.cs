public class HelloWorld : ITask
{
    public int TaskId { get; set; } = 1;
    public string Title { get; set; } = "Hello World";
    public string Description { get; set; } = "Prints 'Hello World'.";

    TaskHandler handler;

    public HelloWorld(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }

    private void PrintString(string msg)
    {
        ConsoleEventing.Msg(msg);
    }

    public void Run()
    {
        PrintString("Hello World");
    }
}




