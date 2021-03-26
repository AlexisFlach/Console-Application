using System;

public class DatePrinter : Task
{
    TaskHandler handler;

    private string TodaysDate = DateTime.Now.ToString("dd/MM/yyyy");

    public DatePrinter(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 4;
        Title = "Date Printer";
        Description = "Prints current date.";
    }

    public override void Run()
    {
        ConsoleEventing.Msg(TodaysDate);
    }
}




