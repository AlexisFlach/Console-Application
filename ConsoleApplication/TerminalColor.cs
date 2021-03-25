using System;

public class TerminalColor : ITask
{
    public int TaskId { get; set; } = 3;
    public string Title { get; set; } = "Terminal Color";
    public string Description { get; set; } = "Changes Color in terminal";

    TaskHandler handler;

    public TerminalColor(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }

    public void ModifyTerminalColors(ConsoleColor consoleColor, ConsoleColor backgroundColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.BackgroundColor = backgroundColor;
    }
    public void Reset() => Console.ResetColor();

    public void Run()
    {
        ModifyTerminalColors(ConsoleColor.Red, ConsoleColor.Black);
        ConsoleEventing.Msg("Write something");
        ModifyTerminalColors(ConsoleColor.Black, ConsoleColor.Red);
        Console.ReadLine();
        Reset();
    }
}




