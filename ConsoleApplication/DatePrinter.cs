using System;

public class DatePrinter : ITask
{
    public int TaskId { get; private set; } = 4;
    public string Title { get; set; } = "Date Printer";
    public string Description { get; set; } = "Prints current date.";

    TaskHandler handler;

    private string TodaysDate = DateTime.Now.ToString("dd/MM/yyyy");

    public DatePrinter(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }

    public void Run()
    {
        ConsoleEventing.Msg(TodaysDate);
    }
}




