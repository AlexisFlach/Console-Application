using System;

public class TerminalColor : Task
{
    TaskHandler handler;

    public TerminalColor(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 3;
        Title = "Terminal Color";
        Description = "Changes Color in terminal";
    }

    public void ModifyTerminalColors(ConsoleColor consoleColor, ConsoleColor backgroundColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.BackgroundColor = backgroundColor;
    }
    public void Reset() => Console.ResetColor();

    public override void Run()
    {
        ModifyTerminalColors(ConsoleColor.Red, ConsoleColor.Black);
        ConsoleEventing.Msg("Write something");
        ModifyTerminalColors(ConsoleColor.Black, ConsoleColor.Red);
        Console.ReadLine();
        Reset();
    }
}




