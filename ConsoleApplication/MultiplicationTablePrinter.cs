using System;

public class MultiplicationTablePrinter : ITask
{
    public int TaskId { set; get; } = 10;
    public string Title { get; set; } = "Multiplication Table";
    public string Description { get; set; } = "Prints the Multiplication Table";

    TaskHandler handler;

    public MultiplicationTablePrinter(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }

    public void PrintMultiplicationTable()
    {

        for (var row = 1; row < 11; row++)
        {
            var line = "";

            for (var col = 1; col < 11; col++)
            {
                var num = row * col;
                var tab = " ";
                line += num + tab;
            }
            Console.WriteLine(line);
        }
    }

    public void Run()
    {
        PrintMultiplicationTable();
    }

}




