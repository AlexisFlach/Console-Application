using System;

public class MultiplicationTablePrinter : Task
{
    TaskHandler handler;

    public MultiplicationTablePrinter(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 10;
        Title = "Multiplication Table";
        Description = "Prints the Multiplication Table";
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

    public override void Run()
    {
        PrintMultiplicationTable();
    }

}




