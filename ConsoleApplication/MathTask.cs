﻿using System;

public class MathTask : ITask
{
    public int TaskId { set; get; } = 9;
    public string Title { get; set; } = "Math Task";
    public string Description { get; set; } = "Returns input squared, raised by 2 AND raised by 10.";

    TaskHandler handler;


    public MathTask(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }

    public double GetUserInput()
    {
        double dec = Validator.ValidateDecimal("Please enter a decimal");
        return dec;
    }

    public double SquareBy(double userInput, int num)
    {
        return Math.Round(Math.Pow(userInput, num), 2);
    }

    public double SquareRoot(double userInput)
    {
        return Math.Round(Math.Sqrt(userInput), 2);
    }

    public void Print()
    {
        Double userinput = GetUserInput();
        Double sqrt = SquareRoot(userinput);
        Double elevetedBy2 = SquareBy(userinput, 2);
        Double elevetedBy10 = SquareBy(userinput, 10);

        ConsoleEventing.Msg($"Square root: {sqrt}\nEleveted by two: {elevetedBy2}\nElevated by ten: {elevetedBy10}");
    }

    public void Run()
    {
        Print();
    }
}




